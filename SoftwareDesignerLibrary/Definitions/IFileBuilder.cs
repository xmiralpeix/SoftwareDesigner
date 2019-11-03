using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary.Definitions
{
    public interface IFileBuilder
    {
        bool CanBuildFile(string valitaionMsg);

        string BuildFile();
    }
}
