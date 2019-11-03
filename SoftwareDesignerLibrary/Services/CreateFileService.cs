using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesignerLibrary.Definitions;

namespace SoftwareDesignerLibrary.Services
{
    public class CreateFileService  
    {
        public string CreateFile(StringBuilder content, string fileName, string extension)
        {            
            if (content.Length == 0)
                return string.Empty;

            string tempFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{fileName}{extension}");
            if (System.IO.File.Exists(tempFile))
                System.IO.File.Delete(tempFile);

            System.IO.File.WriteAllText(tempFile, content.ToString());

            return tempFile;
        }
    }
}
