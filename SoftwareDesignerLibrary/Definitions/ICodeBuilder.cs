namespace SoftwareDesignerLibrary.Definitions
{
    public interface ICodeBuilder
    {

        System.Text.StringBuilder Code { get; set; }
        void AppendConstructor(string ClassName);
        void AppendPropertyDefinitions(PropertyInfo[] Collection);
        void AppendProperties(PropertyInfo[] Collection);
        void AppendMethods(MethodInfo[] Collection);
        void BeginClass(string className);
        void EndClass(string ClassName);
        void BeginInterface(string InterfaceName);
        void EndInterface(string InterfaceName);
        void BeginNamespace(string xNamespace);
        void EndNamespace(string xNamespace);
        string GetFileExtension();
        void AppendMethodDefinitions(MethodInfo[] methodInfo);
    }
}