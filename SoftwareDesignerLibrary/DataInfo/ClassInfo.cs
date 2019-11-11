using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignerLibrary
{
    public class ClassInfo
    {
        public string Namespace { get; set; }

        public string ClassName { get; set; }
        

        internal List<PropertyInfo> PropertyCollection = new List<PropertyInfo>();
        internal List<MethodInfo> MethodCollection = new List<MethodInfo>();       
        internal List<string> CtorCollection = new List<string>();
        internal List<string> DependencyCollection = new List<string>();              
        
        public void AddProperties(PropertyInfo[] input) {
            if (input == null) return;
            input.ToList().ForEach(x => x.Validate());
            PropertyCollection.AddRange(input);
        }

        public void AddProperties(string[] input)
        {
            if (input == null) return;
            PropertyCollection.AddRange((from sInput in input select PropertyInfo.Parse(sInput)).ToArray());
        }

        public void AddMethods(string[] input)
        {
            if (input == null) return;
                MethodCollection.AddRange((from sInput in input select MethodInfo.Parse(sInput)).ToArray());
        }

        public void AddDependency(string[] input) {
            if (input == null) return;
            DependencyCollection.AddRange(input);
        }

        public bool HasValidData(string validationMsg) {

            if (string.IsNullOrWhiteSpace(this.ClassName)) {
                validationMsg = nameof(ClassName) + " is a manatory field";
                return false;
            }
            return true;
        }
    }
}
