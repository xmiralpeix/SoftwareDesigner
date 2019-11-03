using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class oMain
    {

        public static void Main()
        {
            SoftwareDesignerLibrary.Engine.RegisterAutofacModule("autofac.json");
            SoftwareDesignerLibrary.Engine.Run();
            //
            var frm = new Form1();
            frm.ShowDialog();
        }
    }
}
