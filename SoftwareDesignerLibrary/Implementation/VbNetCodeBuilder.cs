using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class VbNetCodeBuilder : Definitions.ICodeBuilder
    {
        

        public StringBuilder Code { get; set; }

        public VbNetCodeBuilder()
        {
            Code = new StringBuilder();
        }

        public void AppendPropertyDefinitions(PropertyInfo[] collection)
        {

            if (collection == null)
                return;

            // ex: Property NewProperty() As String()
            foreach (var pInfo in collection)
                Code.AppendFormat("Property {2}() As {0}{1}",
                    CleanType(pInfo.PropertyType),
                    pInfo.IsArray ? "()" : "",
                    pInfo.PropertyName).AppendLine();

        }

        public void AppendProperties(PropertyInfo[] collection)
        {

            if (collection == null)
                return;

            // ex: Public Property NewProperty() As String()
            foreach (var pInfo in collection)
                Code.AppendFormat("Public Property {2}() As {0}{1}",
                    CleanType(pInfo.PropertyType),
                    pInfo.IsArray ? "()" : "",
                    pInfo.PropertyName).AppendLine();

        }

       
        public void AppendConstructor(string className)
        {
            // ex: Public Sub New()
            //     End Sub
            Code.AppendLine("Public Sub New()").AppendLine("End Sub");
        }

        public void BeginNamespace(string xNamespace)
        {
            if (string.IsNullOrWhiteSpace(xNamespace))
                return;

            // ex: Namespace NewNamespace
            Code.AppendFormat("Namespace {0}", xNamespace).AppendLine();
        }

        public void EndNamespace(string xNamespace)
        {
            if (string.IsNullOrWhiteSpace(xNamespace))
                return;

            // ex: End Namespace
            Code.AppendLine("End Namespace");
        }
 

        public void BeginClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                return;

            // ex: Public Class Class1
            Code.AppendFormat("Public Class {0}", className).AppendLine();

        }
        public void EndClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                return;

            // ex: End Class
            Code.AppendLine("End Class");
        }

        public void BeginInterface(string InterfaceName)
        {
            if (string.IsNullOrWhiteSpace(InterfaceName))
                return;

            // ex: Public Interface IClass1
            Code.AppendFormat("Public Interface  {0} ", InterfaceName).AppendLine();
        }

        public void EndInterface(string InterfaceName)
        {
            if (string.IsNullOrWhiteSpace(InterfaceName))
                return;

            // ex: End Interface
            Code.AppendLine("End Interface");
        }

        public string GetFileExtension()
        {
            return ".vb";
        }

        public void AppendMethodDefinitions(MethodInfo[] collection)
        {
            
            if (collection == null)
                return;

            AppendSubDefinition(collection.Where(x=> string.IsNullOrWhiteSpace(x.ReturnType)).ToArray());
            AppendFunctionDefinition(collection.Where(x => !string.IsNullOrWhiteSpace(x.ReturnType)).ToArray());

        }
        public void AppendMethods(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            AppendSub(collection.Where(x => string.IsNullOrWhiteSpace(x.ReturnType)).ToArray());
            AppendFunction(collection.Where(x => !string.IsNullOrWhiteSpace(x.ReturnType)).ToArray());

        }

        private string CleanType(string originalType) {

            if (string.IsNullOrWhiteSpace(originalType))
                return string.Empty;

            string retType = originalType.Trim();
            string evalType = originalType.ToUpper();
            if (new string[] { "STRING" }.Contains(evalType)) return "String";
            if (new string[] { "BOOL", "BOOLEAN" }.Contains(evalType)) return "Boolean";
            if (new string[] { "INT", "INTEGER" }.Contains(evalType)) return "Integer";
            if (new string[] { "DECIMAL" }.Contains(evalType)) return "Decimal";
            if (new string[] { "DOUBLE" }.Contains(evalType)) return "Double";
            if (new string[] { "DATETIME" }.Contains(evalType)) return "DateTime";
            
            return retType;
        }


        private string BuildParameters(ParamInfo[] collection) {

            if (collection == null || collection.Length == 0)
                return string.Empty;

            List<string> sParams = new List<string>();
            foreach (ParamInfo paramInfo in collection)
            {
                string sType = CleanType(paramInfo.ParamType);
                string sArray = paramInfo.IsArray ? "()" : "";

                // ByVal oValue As String()
                sParams.Add($"ByVal {paramInfo.ParamName} {sType}{sArray}");
            }

            return string.Join(", ", sParams.ToArray());

        }

        public void AppendSubDefinition(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var subInfo in collection)
            {
                // ex:  Sub NewSub(ByVal sValue1 As String(), ByVal sValue2 As String())
                string parameters = BuildParameters(subInfo.Parameters);
                Code.AppendFormat("Sub {0}({1})", 
                    subInfo.MethodName, 
                    parameters).AppendLine();
            }


        }

        public void AppendSub(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var subInfo in collection)
            {
                // ex:  Public Sub NewSub(ByVal sValue1 As String(), ByVal sValue2 As String())
                //          Throw New NotImplementedException()
                //      End Sub
                string parameters = BuildParameters(subInfo.Parameters);
                Code.AppendFormat("Public Sub {0}({1})",subInfo.MethodName, parameters)
                    .AppendLine("Throw New NotImplementedException()")
                    .AppendLine("End Sub");
            }


        }

        public void AppendFunction(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var funcInfo in collection)
            {
                // ex: Public Function NewFunction(ByVal sValue1 As String(), ByVal sValue2 As String()) As String()
                //      Throw New NotImplementedException()
                //     End Function
                string parameters = BuildParameters(funcInfo.Parameters);
                Code.AppendFormat("Public Function {2}({3}) As {0}{1}",CleanType(funcInfo.ReturnType),funcInfo.ReturnTypeIsArray ? "[]" : "",funcInfo.MethodName,parameters)
                    .AppendLine("Throw New NotImplementedException()")
                    .AppendLine("End Function");
            }

        }

        public void AppendFunctionDefinition(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var funcInfo in collection)
            {
                // ex: Function NewFunction(ByVal sValue1 As String(), ByVal sValue2 As String()) As String()
                string parameters = BuildParameters(funcInfo.Parameters);
                Code.AppendFormat("Function {2}({3}) As {0}{1}",
                    CleanType(funcInfo.ReturnType),
                    funcInfo.ReturnTypeIsArray ? "[]" : "",
                    funcInfo.MethodName,
                    parameters).AppendLine();
            }


        }


    }
}
