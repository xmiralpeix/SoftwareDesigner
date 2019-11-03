using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [Serializable]
    public class RepositoryData
    {
        public string[] HistoricFields;
        public string[] Fields;
        public string[] FilterFields;
        public string[] InfoFields;
        public string[] DataAccessFields;
        public string[] NewDataFields;
        public string[] RepositoryMethods;
        public Boolean UniqueItem;
        public Boolean CreateTests;
        public Boolean FillData;
        public string RepositoryName;

        public RepositoryData() { }
    }
}
