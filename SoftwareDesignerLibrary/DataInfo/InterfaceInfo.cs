using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class InterfaceInfo
    {
        public string Namespace { get; set; }
        public string InterfaceName { get; set; }
        public string[] ImplementedTypes { get; set; }

        internal List<PropertyInfo> PropertyCollection = new List<PropertyInfo>();
        internal List<MethodInfo> MethodCollection = new List<MethodInfo>();
        

        public void AddProperties(PropertyInfo[] input)
        {
            if (input == null) return;
            input.ToList().ForEach(x => x.Validate());
            PropertyCollection.AddRange(input);
        }

        public void AddProperties(string[] input)
        {
            if (input == null) return;
            AddProperties((from sInput in input select PropertyInfo.Parse(sInput)).ToArray());
        }

        public void AddMethods(string[] input)
        {
            if (input == null) return;
            AddMethods((from sInput in input select MethodInfo.Parse(sInput)).ToArray());
        }

        public void AddMethods(MethodInfo[] input)
        {
            if (input == null) return;
            input.ToList().ForEach(x => x.Validate());
            MethodCollection.AddRange(input);
        }



        public bool HasValidData(string validationMsg)
        {

            if (string.IsNullOrWhiteSpace(this.InterfaceName))
            {
                validationMsg = nameof(InterfaceName) + " is a manatory field";
                return false;
            }
            return true;
        }


    }
}
