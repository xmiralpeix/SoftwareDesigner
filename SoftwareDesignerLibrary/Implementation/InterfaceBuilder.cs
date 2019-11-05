using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class InterfaceBuilder : Definitions.IInterfaceBuilder

    {

        private Definitions.ICodeBuilder _codeBuilder;
        public Definitions.ICodeBuilder CodeBuilder { set { _codeBuilder = value; } }

        private Services.CreateFileService _createFileService;        


        public InterfaceInfo oInterfaceInfo { get; set; }

        public InterfaceBuilder() {
            _createFileService = new Services.CreateFileService();
        }


        public string BuildFile()
        {

            string validationResult = null;
            if (!this.CanBuildFile(validationResult))
                throw new ArgumentException(validationResult);
            
            _codeBuilder.BeginNamespace(oInterfaceInfo.Namespace);

            _codeBuilder.BeginInterface(oInterfaceInfo.InterfaceName);

            if (oInterfaceInfo.PropertyCollection != null)
                _codeBuilder.AppendPropertyDefinitions( oInterfaceInfo.PropertyCollection.ToArray());

            if (oInterfaceInfo.MethodCollection != null)
                _codeBuilder.AppendMethodDefinitions(oInterfaceInfo.MethodCollection.ToArray());

            _codeBuilder.EndInterface(oInterfaceInfo.InterfaceName);

            _codeBuilder.EndNamespace(oInterfaceInfo.Namespace);


            return _createFileService.CreateFile(_codeBuilder.Code, oInterfaceInfo.InterfaceName, _codeBuilder.GetFileExtension());

        }

        public bool CanBuildFile(string ValidationMsg)
        {
            if (oInterfaceInfo == null)
            {
                ValidationMsg = nameof(oInterfaceInfo) + " can not be empty.";
                return false;
            }

            if (!oInterfaceInfo.HasValidData(ValidationMsg)) return false;

            return true;
        }
    }
}
