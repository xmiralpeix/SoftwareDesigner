using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class PropertyInfo
    {
        
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public int Len { get; set; }
        public bool IsArray { get; set; }

        public void Validate() {
            
            if (string.IsNullOrWhiteSpace(PropertyName))
                throw new ArgumentException("This field can not be empty", nameof(PropertyName));

            if (string.IsNullOrWhiteSpace(PropertyType))
                throw new ArgumentException("This field can not be empty", nameof(PropertyName));

            if ((PropertyType.ToLower() == "string") && (!IsArray) && (Len <= 0))
                throw new ArgumentException($"This field can not be {Len} when fieldtype is a string", nameof(Len));

        }


        public PropertyInfo() { }


        /// <summary>
        /// PropertyName:PropertyType:Len
        /// </summary>    
        /// <returns></returns>
        public static PropertyInfo Parse(string s)
        {

            if (string.IsNullOrWhiteSpace(s))
                return null;        
                        
            string[] pContentParts = s.Split(new string[] { ":" }, StringSplitOptions.None);
            //                      
            
            PropertyInfo oPropertyInfo = new PropertyInfo();
            // property name            
            oPropertyInfo.PropertyName = pContentParts[0].Trim();
             

            // property type
            if (pContentParts.Length > 1)
            {
                string sPropertyType = pContentParts[1].Trim();
                //
                oPropertyInfo.IsArray = (sPropertyType.IndexOf("[") > -1);                  
                oPropertyInfo.PropertyType = sPropertyType.Replace("[", "").Replace("]", "");
            }

            // len
            if (pContentParts.Length > 2)
                oPropertyInfo.Len = int.Parse(pContentParts[2].Trim());
             
            oPropertyInfo.Validate();

            return oPropertyInfo;

        }

    }
}
