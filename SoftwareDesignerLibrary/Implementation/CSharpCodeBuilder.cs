using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class CSharpCodeBuilder : Definitions.ICodeBuilder
    {
        

        public StringBuilder Code { get; set; }

        public CSharpCodeBuilder()
        {
            Code = new StringBuilder();
        }

        public void AppendProperties(PropertyInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var pInfo in collection)
                Code.AppendFormat("{0}{1} {2} {{ get; set; }}",
                    CleanType(pInfo.PropertyType),
                    pInfo.IsArray ? "[]" : "",
                    pInfo.PropertyName).AppendLine();

        }

       
        public void AppendConstructor(string className)
        {
            Code.AppendFormat("public {0}() {{ }}", className).AppendLine();
        }

        public void BeginNamespace(string xNamespace)
        {
            if (string.IsNullOrWhiteSpace(xNamespace))
                return;

            Code.AppendFormat("Namespace {0} {{", xNamespace).AppendLine();
        }

        public void EndNamespace(string xNamespace)
        {
            if (string.IsNullOrWhiteSpace(xNamespace))
                return;

            Code.AppendLine("}");
        }
 

        public void BeginClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                return;

            Code.AppendFormat("public class {0} {{", className).AppendLine();

        }
        public void EndClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                return;

            Code.AppendLine("}");
        }

        public void BeginInterface(string InterfaceName)
        {
            if (string.IsNullOrWhiteSpace(InterfaceName))
                return;

            Code.AppendFormat("public interface {0} {{", InterfaceName).AppendLine();
        }

        public void EndInterface(string InterfaceName)
        {
            if (string.IsNullOrWhiteSpace(InterfaceName))
                return;

            Code.AppendLine("}");
        }

        public string GetFileExtension()
        {
            return ".cs";
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
            if (new string[] { "STRING" }.Contains(evalType)) return "string";
            if (new string[] { "BOOL", "BOOLEAN" }.Contains(evalType)) return "bool";
            if (new string[] { "INT", "INTEGER" }.Contains(evalType)) return "int";
            if (new string[] { "DECIMAL" }.Contains(evalType)) return "decimal";
            if (new string[] { "DOUBLE" }.Contains(evalType)) return "double";
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
                string sArray = paramInfo.IsArray ? "[]" : "";

                sParams.Add($"{sType}{sArray} {paramInfo.ParamName}");
            }

            return string.Join(", ", sParams.ToArray());

        }

        public void AppendSubDefinition(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var subInfo in collection)
            {
                string parameters = BuildParameters(subInfo.Parameters);
                Code.AppendFormat("public void {0}({1});", 
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
                string parameters = BuildParameters(subInfo.Parameters);

                Code.AppendFormat("public void {0}({1}) {{ Throw new NotImplementedException(); }}",
                    subInfo.MethodName, 
                    parameters).AppendLine();
            }


        }

        public void AppendFunction(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var funcInfo in collection)
            {
                string parameters = BuildParameters(funcInfo.Parameters);

                Code.AppendFormat("public {0}{1} {2}({3}) {{ Throw new NotImplementedException(); }}",
                    CleanType(funcInfo.ReturnType),
                    funcInfo.ReturnTypeIsArray ? "[]" : "",
                    funcInfo.MethodName,
                    parameters).AppendLine();
            }


        }

        public void AppendFunctionDefinition(MethodInfo[] collection)
        {

            if (collection == null)
                return;

            foreach (var funcInfo in collection)
            {
                string parameters = BuildParameters(funcInfo.Parameters);

                Code.AppendFormat("public {0}{1} {2}({3});",
                    CleanType(funcInfo.ReturnType),
                    funcInfo.ReturnTypeIsArray ? "[]" : "",
                    funcInfo.MethodName,
                    parameters).AppendLine();
            }


        }


    }
}
