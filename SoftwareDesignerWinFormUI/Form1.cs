using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareDesignerLibrary;
using SoftwareDesignerLibrary.Services;


namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var dtFields = new DataTable();
            dtFields.Columns.Add("Value", typeof(string));
           
            this.gridDataInfo.DataSource = dtFields.Clone();  
            this.gridHistory.DataSource = dtFields.Clone();
            this.gridDataFilter.DataSource = dtFields.Clone();
            this.gridFields.DataSource = dtFields.Clone();
            this.gridDac.DataSource = dtFields.Clone();
            this.gridNew.DataSource = dtFields.Clone();             
            this.gridRepository.DataSource = dtFields.Clone();

            DataGridView[] grids = { gridDataInfo, gridHistory, gridDataFilter, gridFields, gridDac, gridNew, gridRepository };
            foreach (DataGridView grid in grids)
            {
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            }

            // Loading Data
            try {
                IFormatter formater = new BinaryFormatter();
                Stream stream = new FileStream(StoreFile(), FileMode.Open, FileAccess.Read);
                RepositoryData o = (RepositoryData)formater.Deserialize(stream);
                stream.Close();
                //
                this.chkUniqueItem.Checked = o.UniqueItem;
                this.chkCreateTests.Checked = o.CreateTests;
                this.chkFillData.Checked = o.FillData;
                this.txtRepositoryName.Text = o.RepositoryName;
                //
                foreach (string field in o.HistoricFields) {
                    this.HistoryFields.Rows.Add(field);
                }
                foreach (string field in o.InfoFields)
                {
                    this.InfoFields.Rows.Add(field);
                }
                foreach (string field in o.FilterFields)
                {
                    this.FilterFields.Rows.Add(field);
                }
                foreach (string field in o.Fields)
                {
                    this.Fields.Rows.Add(field);
                }
                foreach (string field in o.DataAccessFields)
                {
                    this.DataAccessFields.Rows.Add(field);
                }
                foreach (string field in o.NewDataFields)
                {
                    this.NewDataFields.Rows.Add(field);
                }
                foreach (string field in o.RepositoryMethods)
                {
                    this.RepositoryMethods.Rows.Add(field);
                }
            }
            catch  { }

            
        }

        DataTable HistoryFields { get { return (DataTable)this.gridHistory.DataSource; } }
        DataTable InfoFields { get { return (DataTable)this.gridDataInfo.DataSource; } }
        DataTable FilterFields { get { return (DataTable)this.gridDataFilter.DataSource; } }
        DataTable Fields { get { return (DataTable)this.gridFields.DataSource; } }
        DataTable DataAccessFields { get { return (DataTable)this.gridDac.DataSource; } }
        DataTable NewDataFields { get { return (DataTable)this.gridNew.DataSource; } }
        DataTable RepositoryMethods { get { return (DataTable)this.gridRepository.DataSource; } }
            
         

        private void btnAddInt_Click(object sender, EventArgs e)
        {
            CopyFields(gridHistory, gridFields, "");
        }

        private static void CopyFields(DataGridView gridFrom, DataGridView gridTo, string prefix) {
            
            var selectedRows = gridFrom.SelectedRows;
            DataTable dt = (DataTable)gridTo.DataSource;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                dt.Rows.Add(string.Concat(prefix , selectedRow.Cells["Value"].Value));
            }

        }

        private static void CopyArrayFields(DataGridView gridFrom, DataGridView gridTo, string prefix)
        {

            var selectedRows = gridFrom.SelectedRows;
            DataTable dt = (DataTable)gridTo.DataSource;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                string[] valueParts = selectedRow.Cells["Value"].Value.ToString().Split(':');
                valueParts[0] =   valueParts[0].EndsWith("y")?string.Concat(valueParts[0].Substring(0, valueParts[0].Length -1),"ies"): string.Concat(valueParts[0] ,"s");
                valueParts[1] = string.Concat("[", valueParts[1], "]");
                dt.Rows.Add(string.Concat(prefix, string.Join(":",valueParts)));
            }

        }

        private void txtInputField_KeyPress(object sender, KeyPressEventArgs e)
        {
                       

            if ((Convert.ToInt32(e.KeyChar) == 13) && (this.txtInputField.Text.Trim().Length > 0))
            {
                this.HistoryFields.Rows.Add(this.txtInputField.Text);
                this.Fields.Rows.Add(this.txtInputField.Text);
                return;
            }

            if ((Convert.ToInt32(e.KeyChar) == 13) && (this.txtInputField.Text.Trim().Length == 0))
            {
                this.HistoryFields.DefaultView.RowFilter = "";
                return;
            }

            this.HistoryFields.DefaultView.RowFilter = $" Value LIKE '%{this.txtInputField.Text}%'";
                                          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            // saving data
            this.HistoryFields.DefaultView.RowFilter = "";
            RepositoryData o = new RepositoryData();
            o.HistoricFields = (from DataRow oRow in this.HistoryFields.Rows
                                select Convert.ToString(oRow["Value"])).ToArray();
            o.DataAccessFields = (from DataRow oRow in this.DataAccessFields.Rows
                                select Convert.ToString(oRow["Value"])).ToArray();
            o.Fields = (from DataRow oRow in this.Fields.Rows
                                select Convert.ToString(oRow["Value"])).ToArray();
            o.FilterFields = (from DataRow oRow in this.FilterFields.Rows
                                select Convert.ToString(oRow["Value"])).ToArray();
            o.InfoFields = (from DataRow oRow in this.InfoFields.Rows
                                select Convert.ToString(oRow["Value"])).ToArray();
            o.NewDataFields = (from DataRow oRow in this.NewDataFields.Rows
                            select Convert.ToString(oRow["Value"])).ToArray();
            o.RepositoryMethods = (from DataRow oRow in this.RepositoryMethods.Rows
                               select Convert.ToString(oRow["Value"])).ToArray();

            o.UniqueItem = this.chkUniqueItem.Checked;
            o.CreateTests = this.chkCreateTests.Checked;
            o.FillData = this.chkFillData.Checked;
            o.RepositoryName = this.txtRepositoryName.Text;            

            IFormatter formater = new BinaryFormatter(); 
            Stream stream = new FileStream(StoreFile(), FileMode.Create, FileAccess.Write);

            formater.Serialize(stream, o);
            stream.Close();

        }

        public static string StoreFile() {
            return System.IO.Path.Combine(AssemblyDirectory(), "SoftwareDesigner.xml");
        }

        public static string AssemblyDirectory() {
            string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            //
            return System.IO.Path.GetDirectoryName(path);
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, gridDataFilter, "");
        }

        private void btnIncludeFilter_Click(object sender, EventArgs e)
        {
            CopyArrayFields(gridFields, gridDataFilter, "Include");
        }

        private void btnExcludeFilter_Click(object sender, EventArgs e)
        {
            CopyArrayFields(gridFields, gridDataFilter, "Exclude");             
        }

        private void btnFromFilter_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, gridDataFilter, "From");
        }

        private void btnToFilter_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, gridDataFilter, "To");
        }

        private void btnAddDataInfo_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, gridDataInfo, "");
        }

        private void btnAddArrayDataInfo_Click(object sender, EventArgs e)
        {
            CopyArrayFields(gridFields, gridDataInfo, "");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, this.gridNew, "");
        }

        private void btnAddArrayNew_Click(object sender, EventArgs e)
        {
            CopyArrayFields(gridFields, this.gridNew, "");
        }

        private void btnAddDataAccess_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, this.gridDac, "");
        }

        private void btnAddArrayDataAccess_Click(object sender, EventArgs e)
        {
            CopyFields(gridFields, this.gridDac, "");
        }

       
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {

            List<ClassInfo> classCollection = new List<ClassInfo>();
            List<InterfaceInfo> interfaceCollection = new List<InterfaceInfo>();

            AddFilterClass(classCollection);
            AddFieldInfoClass(classCollection);
            AddNewDataClass(classCollection);
            AddDataAccessClass(classCollection);
            
            AddRepositoryInterface(interfaceCollection);

            string[] codeFiles = CodeBuilderService.GenerateFiles("CSharp", classCollection.ToArray(), interfaceCollection.ToArray());

        }

        private void AddRepositoryInterface(List<InterfaceInfo> interfaceCollection)
        {

            if (RepositoryMethods == null || RepositoryMethods.Rows.Count == 0)
                return;

            InterfaceInfo oInterfaceInfo = new InterfaceInfo();
            string[] interfaceParts = this.lblRepository.Text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            if (interfaceParts.Length == 2)
            {
                oInterfaceInfo.Namespace = interfaceParts[0];
                oInterfaceInfo.InterfaceName = interfaceParts[1];
            }
            else
            {
                oInterfaceInfo.InterfaceName = interfaceParts[0];
            }
            if (!oInterfaceInfo.InterfaceName.StartsWith("I"))
                oInterfaceInfo.InterfaceName = "I" + oInterfaceInfo.InterfaceName;

            if (RepositoryMethods != null)
                oInterfaceInfo.AddMethods((from DataRow oRow in RepositoryMethods.Rows 
                                           select ((string)oRow["Value"]).Replace("{RepositoryName}",this.txtRepositoryName.Text)).ToArray());

            interfaceCollection.Add(oInterfaceInfo);

        }

        private void AddDataAccessClass(List<ClassInfo> classCollection)
        {

            if (DataAccessFields == null || DataAccessFields.Rows.Count == 0)
                return;

            ClassInfo oClsInfo = new ClassInfo();
            string[] classParts = this.lblDataAccess.Text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            if (classParts.Length == 2)
            {
                oClsInfo.Namespace = classParts[0];
                oClsInfo.ClassName = classParts[1];
            }
            else
            {
                oClsInfo.ClassName = classParts[0];
            }
            
            //
            List<PropertyInfo> propCollection = new List<PropertyInfo>();
            foreach (DataRow oRow in DataAccessFields.Rows)
            {
                string sValue = (string)oRow["Value"];
                propCollection.Add(PropertyInfo.Parse(sValue));
            }
            oClsInfo.AddProperties(propCollection.ToArray());
            classCollection.Add(oClsInfo);
        }

        private void AddNewDataClass(List<ClassInfo> classCollection)
        {

            if (NewDataFields == null || NewDataFields.Rows.Count == 0)
                return;

            ClassInfo oClsInfo = new ClassInfo();
            oClsInfo.ClassName = this.lblNewData.Text;
            //
            List<PropertyInfo> propCollection = new List<PropertyInfo>();
            foreach (DataRow oRow in NewDataFields.Rows)
            {
                string sValue = (string)oRow["Value"];
                propCollection.Add(PropertyInfo.Parse(sValue));
            }
            oClsInfo.AddProperties(propCollection.ToArray());
            classCollection.Add(oClsInfo);
        }


        private void AddFilterClass(List<ClassInfo> classCollection)
        {

            if (FilterFields == null || FilterFields.Rows.Count == 0)
                return;

            ClassInfo oClsInfo = new ClassInfo();
            oClsInfo.ClassName = this.lblDataFilter.Text;
            //
            List<PropertyInfo> propCollection = new List<PropertyInfo>();
            foreach (DataRow oRow in FilterFields.Rows)
            {
                string sValue = (string)oRow["Value"];
                propCollection.Add(PropertyInfo.Parse(sValue));
            }
            oClsInfo.AddProperties(propCollection.ToArray());
            classCollection.Add(oClsInfo);

        }



        private void AddFieldInfoClass(List<ClassInfo>  classCollection)
        {

            if (InfoFields == null || InfoFields.Rows.Count == 0)
                return;

            ClassInfo oClsInfo = new ClassInfo();
            oClsInfo.ClassName = this.lblDataInfo.Text;
            //
            List<PropertyInfo> propCollection = new List<PropertyInfo>();
            foreach (DataRow oRow in InfoFields.Rows)
            {
                string sValue = (string)oRow["Value"];
                propCollection.Add(PropertyInfo.Parse(sValue));
            }
            oClsInfo.AddProperties(propCollection.ToArray());
            classCollection.Add(oClsInfo);

        }

        private void btnAddRepositoryDefaults_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gridRepository.DataSource;
            dt.Rows.Add("Clear()");
            dt.Rows.Add("Load(oFilter:{RepositoryName}Filter)");
            dt.Rows.Add("Boolean:Add(ResultMsg:IResultMsg,Rep:New{RepositoryName})");
        }

        private void txtRepositoryName_TextChanged(object sender, EventArgs e)
        {
            string repName = this.txtRepositoryName.Text;

            if (repName.Length > 0)
            {
                this.lblDataAccess.Text = $"DAC.{repName}";
                this.lblDataFilter.Text = $"{repName}Filter";
                this.lblDataInfo.Text = $"{repName}Info";
                this.lblNewData.Text = $"New{repName}";
                this.lblRepository.Text = $"I{repName}Repository";
            }
            else
            {
                this.lblDataAccess.Text = "oDataAccess";
                this.lblDataFilter.Text = "oDataFilter";
                this.lblDataInfo.Text = "oDataInfo";
                this.lblNewData.Text = "oNewData";
                this.lblNewData.Text = "IRepository";

            }


        }
    }
}
