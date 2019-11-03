using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class MethodInfo
    {
        
        public string MethodName { get; set; }       
        public string ReturnType { get; set; }
        public bool ReturnTypeIsArray { get; set; }

        public ParamInfo[] Parameters { get; set; }

        public void Validate() {
            
            if (string.IsNullOrWhiteSpace(MethodName))
                throw new ArgumentException("This field can not be empty", nameof(MethodName));
        }


        public MethodInfo() { }


        /// <summary>
        /// MethodName([Parameters]):[MethodType]
        /// </summary>       
        /// ex: function001(param001:string,param002:[int],param003:obj001):[string]
        /// </param>
        /// <returns></returns>
        public static MethodInfo Parse(string s)
        {

            if (string.IsNullOrWhiteSpace(s))
                return null;
                        
            string[] pContentParts = s.Split(new string [] { "(",")"}, StringSplitOptions.RemoveEmptyEntries);
                                          
            
            MethodInfo oMethodInfo = new MethodInfo();

            // method name            
            oMethodInfo.MethodName = pContentParts[0].Trim();

            if (pContentParts.Length > 1)
                oMethodInfo.Parameters = ParamInfo.Parse(pContentParts[1]);

            // method type
            if (pContentParts.Length > 2)
            {
                string sMethodType = pContentParts[2].Replace(":","");
                //
                oMethodInfo.ReturnTypeIsArray = (sMethodType.IndexOf("[") > -1);
                oMethodInfo.ReturnType = sMethodType.Replace("[", "").Replace("]", "");
            }


            oMethodInfo.Validate();

            return oMethodInfo;

        }

    }
}
