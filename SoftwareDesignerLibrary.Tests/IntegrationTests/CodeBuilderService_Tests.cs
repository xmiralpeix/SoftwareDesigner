using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Autofac;

namespace SoftwareDesignerLibrary.Tests.IntegrationTests
{
    public class CodeBuilderService_Tests
    {
        
        public CodeBuilderService_Tests() {
            if (SoftwareDesignerLibrary.Engine.IsRunning) return;

            SoftwareDesignerLibrary.Engine.RegisterAutofacModule("autofac.json");
            SoftwareDesignerLibrary.Engine.Run();
        }

        [Theory]
        [InlineData(
          new string[] { "public " + nameof(BuildFile_CSharpClass_ContainsSubstring) + "() { }", "bool Property001 { get; set; }", "string Property002 { get; set; }", "string[] Property003 { get; set; }", "oData Property004 { get; set; }" },
          new string[] { "Property001:Boolean", "Property002:String:10", "Property003:[STring]", "Property004:oData" },
          null)]
        public void BuildFile_CSharpClass_ContainsSubstring(string[] expectedSubstrings,
          string[] inputProperties,
          string[] inputMethods)
        {
                       

            ClassInfo oClassInfo = new SoftwareDesignerLibrary.ClassInfo();
            oClassInfo.ClassName = nameof(BuildFile_CSharpClass_ContainsSubstring);
            oClassInfo.AddProperties(inputProperties);
            oClassInfo.AddMethods(inputMethods);

            string[] files = Services.CodeBuilderService.GenerateFiles("CSharp", new ClassInfo[] { oClassInfo }, null);

            string actualFile = files.First();
            string actualString = System.IO.File.ReadAllText(actualFile);

            foreach (string expectedSubstring in expectedSubstrings)
                Assert.Contains(expectedSubstring, actualString);

        }


        [Theory]
        [InlineData(
            new string[] {
                "public interface " + nameof(BuildFile_CSharpInterface_ContainsSubstring) + " {",
                "bool Property001 { get; set; }",
                "string Property002 { get; set; }",
                "string[] Property003 { get; set; }",
                "oData Property004 { get; set; }",
                "void Method001();",
                "void Method002(string ostring);",
                "void Method003(string value);",
                "void Method004(string[] value);",
                "void Method005(string[] ostring, int oint, Value oValue);",
                "string[] Method006(int oint, string ostring);"},
            new string[] { "Property001:Boolean", "Property002:string:10", "Property003:[string]", "Property004:oData" },
            new string[] { "Method001()", "Method002(string)", "Method003(value:string)", "Method004(value:[string])", "Method005([string],int,oValue:Value)", "Method006(int, string):[string]" })]
        public void BuildFile_CSharpInterface_ContainsSubstring(string[] expectedSubstrings,
            string[] inputProperties,
            string[] inputMethods)
        {
                       
            InterfaceInfo oInterfaceInfo = new InterfaceInfo();
            oInterfaceInfo.InterfaceName = nameof(BuildFile_CSharpInterface_ContainsSubstring);
            oInterfaceInfo.AddProperties(inputProperties);
            oInterfaceInfo.AddMethods(inputMethods);

            string[] files = Services.CodeBuilderService.GenerateFiles("CSharp", null, new InterfaceInfo[] { oInterfaceInfo });

            string actualFile = files.First();
            string actualString = System.IO.File.ReadAllText(actualFile);

            foreach (string expectedSubstring in expectedSubstrings)
                Assert.Contains(expectedSubstring, actualString);

        }

    }
}
