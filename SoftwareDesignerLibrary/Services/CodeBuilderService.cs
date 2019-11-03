using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SoftwareDesignerLibrary.Definitions;

namespace SoftwareDesignerLibrary.Services
{
    public static class CodeBuilderService
    {
        public static string[] GenerateFiles(string codeName, 
            ClassInfo[] classCollection,
            InterfaceInfo[] interfaceCollection) {

            List<string> resultFiles = new List<string>();

            if (string.IsNullOrWhiteSpace(codeName))
                codeName = "cSharp";
                         
            using (var scope = Engine.DIContainer.BeginLifetimeScope(codeName)) {

                if (classCollection != null) { 
                    foreach (ClassInfo oClassInfo  in classCollection)
                    {
                        var builder = scope.Resolve<IClassBuilder>();
                        builder.oClassInfo = oClassInfo;
                        //
                        resultFiles.Add(builder.BuildFile());
                    }
                }

                if (interfaceCollection != null)
                {
                    foreach (InterfaceInfo oInterfaceInfo in interfaceCollection)
                    {
                        var builder = scope.Resolve<IInterfaceBuilder>();
                        builder.oInterfaceInfo = oInterfaceInfo;
                        //
                        resultFiles.Add(builder.BuildFile());
                    }
                }

            }

            return resultFiles.ToArray();

        }

    }
}
