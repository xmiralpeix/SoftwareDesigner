using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class ClassBuilder : Definitions.IClassBuilder
    {

        private Definitions.ICodeBuilder _codeBuilder;
        public Definitions.ICodeBuilder CodeBuilder { set { _codeBuilder = value; } }


        private Services.CreateFileService _createFileService;       
        

        public ClassInfo oClassInfo { get; set; }

        public ClassBuilder() {
            _createFileService = new Services.CreateFileService();
        }

        
        public string BuildFile()
        {

            string validationResult = null;
            if (!this.CanBuildFile(validationResult)) 
                throw new ArgumentException(validationResult);
                    
            _codeBuilder.BeginNamespace(oClassInfo.Namespace);

            _codeBuilder.BeginClass(oClassInfo.ClassName);

            if (oClassInfo.PropertyCollection != null)
                _codeBuilder.AppendProperties(oClassInfo.PropertyCollection.ToArray());

            _codeBuilder.AppendConstructor(oClassInfo.ClassName);

            _codeBuilder.EndClass(oClassInfo.ClassName);

            _codeBuilder.EndNamespace(oClassInfo.Namespace);


            return _createFileService.CreateFile(_codeBuilder.Code, oClassInfo.ClassName, _codeBuilder.GetFileExtension());
 
        }

        public bool CanBuildFile(string ValidationMsg)
        {
            if (oClassInfo == null)  {
                ValidationMsg = nameof(oClassInfo) + " can not be empty.";
                return false;
            }

            if (!oClassInfo.HasValidData(ValidationMsg)) return false;
            
            return true;
        }
    }
}
