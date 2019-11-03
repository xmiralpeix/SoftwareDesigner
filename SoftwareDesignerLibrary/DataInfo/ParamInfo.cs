using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class ParamInfo
    {
        
        public string ParamName { get; set; }
        public string ParamType { get; set; }       
        public bool IsArray { get; set; }

        public void Validate() {
            
            if (string.IsNullOrWhiteSpace(ParamName))
                throw new ArgumentException("This field can not be empty", nameof(ParamName));

            if (string.IsNullOrWhiteSpace(ParamType))
                throw new ArgumentException("This field can not be empty", nameof(ParamName));                      

        }


        public ParamInfo() { }


        /// <summary>
        /// [ParamName:[ParamType]]
        /// ex: param1:string,param2:[int]
        /// </summary>
        /// <returns></returns>
        public static ParamInfo[] Parse(string s)
        {

            if (string.IsNullOrWhiteSpace(s))
                return null;

            string[] parColl = s.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            List<ParamInfo> pResult = new List<ParamInfo>();

            foreach (string sParam in parColl)
            {
                string[] pInfoParts = sParam.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                if (pInfoParts.Length == 1)
                {
                    pInfoParts = new string[] { "o" + pInfoParts[0].Replace("[","").Replace("]","").Trim(), pInfoParts[0]};
                }
                ParamInfo oParamInfo = new ParamInfo();

                oParamInfo.ParamName = pInfoParts[0].Trim();
               
                string sParamType = pInfoParts[1].Trim();
                //
                oParamInfo.IsArray = (sParamType.IndexOf("[") > -1);
                oParamInfo.ParamType = sParamType.Replace("[", "").Replace("]", "");
                

                oParamInfo.Validate();
                pResult.Add(oParamInfo);
            }

            return pResult.ToArray();           

        }

    }
}
