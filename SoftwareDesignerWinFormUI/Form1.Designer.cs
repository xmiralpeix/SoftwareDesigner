namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputField = new System.Windows.Forms.TextBox();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.gridDataInfo = new System.Windows.Forms.DataGridView();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.btnAddDataInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblDataFilter = new System.Windows.Forms.Label();
            this.btnIncludeFilter = new System.Windows.Forms.Button();
            this.gridDataFilter = new System.Windows.Forms.DataGridView();
            this.btnFromFilter = new System.Windows.Forms.Button();
            this.btnToFilter = new System.Windows.Forms.Button();
            this.btnExcludeFilter = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gridNew = new System.Windows.Forms.DataGridView();
            this.lblNewData = new System.Windows.Forms.Label();
            this.btnAddDataAccess = new System.Windows.Forms.Button();
            this.gridDac = new System.Windows.Forms.DataGridView();
            this.lblDataAccess = new System.Windows.Forms.Label();
            this.btnAddArrayDataInfo = new System.Windows.Forms.Button();
            this.btnAddArrayNew = new System.Windows.Forms.Button();
            this.btnAddArrayDataAccess = new System.Windows.Forms.Button();
            this.chkUniqueItem = new System.Windows.Forms.CheckBox();
            this.chkFillData = new System.Windows.Forms.CheckBox();
            this.chkCreateTests = new System.Windows.Forms.CheckBox();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.gridRepository = new System.Windows.Forms.DataGridView();
            this.btnAddRepositoryDefaults = new System.Windows.Forms.Button();
            this.txtRepositoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRepository = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputField
            // 
            this.txtInputField.Location = new System.Drawing.Point(231, 32);
            this.txtInputField.Name = "txtInputField";
            this.txtInputField.Size = new System.Drawing.Size(123, 20);
            this.txtInputField.TabIndex = 0;
            this.txtInputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputField_KeyPress);
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.AutoSize = true;
            this.lblDataInfo.Location = new System.Drawing.Point(720, 257);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(54, 13);
            this.lblDataInfo.TabIndex = 4;
            this.lblDataInfo.Text = "oDataInfo";
            // 
            // gridDataInfo
            // 
            this.gridDataInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridDataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataInfo.Location = new System.Drawing.Point(719, 273);
            this.gridDataInfo.Name = "gridDataInfo";
            this.gridDataInfo.Size = new System.Drawing.Size(240, 216);
            this.gridDataInfo.TabIndex = 5;
            // 
            // gridFields
            // 
            this.gridFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Location = new System.Drawing.Point(440, 32);
            this.gridFields.Name = "gridFields";
            this.gridFields.Size = new System.Drawing.Size(203, 457);
            this.gridFields.TabIndex = 6;
            // 
            // btnAddDataInfo
            // 
            this.btnAddDataInfo.Location = new System.Drawing.Point(650, 273);
            this.btnAddDataInfo.Name = "btnAddDataInfo";
            this.btnAddDataInfo.Size = new System.Drawing.Size(64, 23);
            this.btnAddDataInfo.TabIndex = 10;
            this.btnAddDataInfo.TabStop = false;
            this.btnAddDataInfo.Text = "Add >";
            this.btnAddDataInfo.UseVisualStyleBackColor = true;
            this.btnAddDataInfo.Click += new System.EventHandler(this.btnAddDataInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fields";
            // 
            // gridHistory
            // 
            this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Location = new System.Drawing.Point(237, 61);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.Size = new System.Drawing.Size(197, 428);
            this.gridHistory.TabIndex = 12;
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(360, 32);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(74, 23);
            this.btnAddField.TabIndex = 19;
            this.btnAddField.TabStop = false;
            this.btnAddField.Text = "Add >";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddInt_Click);
            // 
            // lblDataFilter
            // 
            this.lblDataFilter.AutoSize = true;
            this.lblDataFilter.Location = new System.Drawing.Point(716, 16);
            this.lblDataFilter.Name = "lblDataFilter";
            this.lblDataFilter.Size = new System.Drawing.Size(58, 13);
            this.lblDataFilter.TabIndex = 3;
            this.lblDataFilter.Text = "oDataFilter";
            // 
            // btnIncludeFilter
            // 
            this.btnIncludeFilter.Location = new System.Drawing.Point(649, 61);
            this.btnIncludeFilter.Name = "btnIncludeFilter";
            this.btnIncludeFilter.Size = new System.Drawing.Size(64, 23);
            this.btnIncludeFilter.TabIndex = 9;
            this.btnIncludeFilter.TabStop = false;
            this.btnIncludeFilter.Text = "Include >";
            this.btnIncludeFilter.UseVisualStyleBackColor = true;
            this.btnIncludeFilter.Click += new System.EventHandler(this.btnIncludeFilter_Click);
            // 
            // gridDataFilter
            // 
            this.gridDataFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataFilter.Location = new System.Drawing.Point(719, 32);
            this.gridDataFilter.Name = "gridDataFilter";
            this.gridDataFilter.Size = new System.Drawing.Size(240, 216);
            this.gridDataFilter.TabIndex = 2;
            // 
            // btnFromFilter
            // 
            this.btnFromFilter.Location = new System.Drawing.Point(649, 118);
            this.btnFromFilter.Name = "btnFromFilter";
            this.btnFromFilter.Size = new System.Drawing.Size(64, 23);
            this.btnFromFilter.TabIndex = 28;
            this.btnFromFilter.TabStop = false;
            this.btnFromFilter.Text = "From >";
            this.btnFromFilter.UseVisualStyleBackColor = true;
            this.btnFromFilter.Click += new System.EventHandler(this.btnFromFilter_Click);
            // 
            // btnToFilter
            // 
            this.btnToFilter.Location = new System.Drawing.Point(649, 147);
            this.btnToFilter.Name = "btnToFilter";
            this.btnToFilter.Size = new System.Drawing.Size(64, 23);
            this.btnToFilter.TabIndex = 29;
            this.btnToFilter.TabStop = false;
            this.btnToFilter.Text = "To >";
            this.btnToFilter.UseVisualStyleBackColor = true;
            this.btnToFilter.Click += new System.EventHandler(this.btnToFilter_Click);
            // 
            // btnExcludeFilter
            // 
            this.btnExcludeFilter.Location = new System.Drawing.Point(649, 90);
            this.btnExcludeFilter.Name = "btnExcludeFilter";
            this.btnExcludeFilter.Size = new System.Drawing.Size(64, 23);
            this.btnExcludeFilter.TabIndex = 30;
            this.btnExcludeFilter.TabStop = false;
            this.btnExcludeFilter.Text = "Exclude >";
            this.btnExcludeFilter.UseVisualStyleBackColor = true;
            this.btnExcludeFilter.Click += new System.EventHandler(this.btnExcludeFilter_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(650, 25);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(64, 23);
            this.btnAddFilter.TabIndex = 31;
            this.btnAddFilter.TabStop = false;
            this.btnAddFilter.Text = "Add >";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(971, 25);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(64, 23);
            this.btnAddNew.TabIndex = 36;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "Add >";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gridNew
            // 
            this.gridNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNew.Location = new System.Drawing.Point(1040, 32);
            this.gridNew.Name = "gridNew";
            this.gridNew.Size = new System.Drawing.Size(240, 216);
            this.gridNew.TabIndex = 35;
            // 
            // lblNewData
            // 
            this.lblNewData.AutoSize = true;
            this.lblNewData.Location = new System.Drawing.Point(1040, 16);
            this.lblNewData.Name = "lblNewData";
            this.lblNewData.Size = new System.Drawing.Size(58, 13);
            this.lblNewData.TabIndex = 34;
            this.lblNewData.Text = "oNewData";
            // 
            // btnAddDataAccess
            // 
            this.btnAddDataAccess.Location = new System.Drawing.Point(973, 273);
            this.btnAddDataAccess.Name = "btnAddDataAccess";
            this.btnAddDataAccess.Size = new System.Drawing.Size(64, 23);
            this.btnAddDataAccess.TabIndex = 40;
            this.btnAddDataAccess.TabStop = false;
            this.btnAddDataAccess.Text = "Add >";
            this.btnAddDataAccess.UseVisualStyleBackColor = true;
            this.btnAddDataAccess.Click += new System.EventHandler(this.btnAddDataAccess_Click);
            // 
            // gridDac
            // 
            this.gridDac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridDac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDac.Location = new System.Drawing.Point(1043, 273);
            this.gridDac.Name = "gridDac";
            this.gridDac.Size = new System.Drawing.Size(240, 216);
            this.gridDac.TabIndex = 39;
            // 
            // lblDataAccess
            // 
            this.lblDataAccess.AutoSize = true;
            this.lblDataAccess.Location = new System.Drawing.Point(1043, 257);
            this.lblDataAccess.Name = "lblDataAccess";
            this.lblDataAccess.Size = new System.Drawing.Size(71, 13);
            this.lblDataAccess.TabIndex = 38;
            this.lblDataAccess.Text = "oDataAccess";
            // 
            // btnAddArrayDataInfo
            // 
            this.btnAddArrayDataInfo.Location = new System.Drawing.Point(650, 299);
            this.btnAddArrayDataInfo.Name = "btnAddArrayDataInfo";
            this.btnAddArrayDataInfo.Size = new System.Drawing.Size(64, 23);
            this.btnAddArrayDataInfo.TabIndex = 42;
            this.btnAddArrayDataInfo.TabStop = false;
            this.btnAddArrayDataInfo.Text = "Array >";
            this.btnAddArrayDataInfo.UseVisualStyleBackColor = true;
            this.btnAddArrayDataInfo.Click += new System.EventHandler(this.btnAddArrayDataInfo_Click);
            // 
            // btnAddArrayNew
            // 
            this.btnAddArrayNew.Location = new System.Drawing.Point(970, 61);
            this.btnAddArrayNew.Name = "btnAddArrayNew";
            this.btnAddArrayNew.Size = new System.Drawing.Size(64, 23);
            this.btnAddArrayNew.TabIndex = 43;
            this.btnAddArrayNew.TabStop = false;
            this.btnAddArrayNew.Text = "Array >";
            this.btnAddArrayNew.UseVisualStyleBackColor = true;
            this.btnAddArrayNew.Click += new System.EventHandler(this.btnAddArrayNew_Click);
            // 
            // btnAddArrayDataAccess
            // 
            this.btnAddArrayDataAccess.Location = new System.Drawing.Point(973, 302);
            this.btnAddArrayDataAccess.Name = "btnAddArrayDataAccess";
            this.btnAddArrayDataAccess.Size = new System.Drawing.Size(64, 23);
            this.btnAddArrayDataAccess.TabIndex = 44;
            this.btnAddArrayDataAccess.TabStop = false;
            this.btnAddArrayDataAccess.Text = "Array >";
            this.btnAddArrayDataAccess.UseVisualStyleBackColor = true;
            this.btnAddArrayDataAccess.Click += new System.EventHandler(this.btnAddArrayDataAccess_Click);
            // 
            // chkUniqueItem
            // 
            this.chkUniqueItem.AutoSize = true;
            this.chkUniqueItem.Location = new System.Drawing.Point(10, 60);
            this.chkUniqueItem.Name = "chkUniqueItem";
            this.chkUniqueItem.Size = new System.Drawing.Size(83, 17);
            this.chkUniqueItem.TabIndex = 45;
            this.chkUniqueItem.Text = "Unique Item";
            this.chkUniqueItem.UseVisualStyleBackColor = true;
            // 
            // chkFillData
            // 
            this.chkFillData.AutoSize = true;
            this.chkFillData.Location = new System.Drawing.Point(11, 81);
            this.chkFillData.Name = "chkFillData";
            this.chkFillData.Size = new System.Drawing.Size(62, 17);
            this.chkFillData.TabIndex = 46;
            this.chkFillData.Text = "Fill data";
            this.chkFillData.UseVisualStyleBackColor = true;
            // 
            // chkCreateTests
            // 
            this.chkCreateTests.AutoSize = true;
            this.chkCreateTests.Location = new System.Drawing.Point(11, 104);
            this.chkCreateTests.Name = "chkCreateTests";
            this.chkCreateTests.Size = new System.Drawing.Size(82, 17);
            this.chkCreateTests.TabIndex = 47;
            this.chkCreateTests.Text = "Create tests";
            this.chkCreateTests.UseVisualStyleBackColor = true;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(1312, 450);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(80, 39);
            this.btnGenerateCode.TabIndex = 48;
            this.btnGenerateCode.TabStop = false;
            this.btnGenerateCode.Text = "Generate code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // gridRepository
            // 
            this.gridRepository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRepository.Location = new System.Drawing.Point(1312, 34);
            this.gridRepository.Name = "gridRepository";
            this.gridRepository.Size = new System.Drawing.Size(277, 216);
            this.gridRepository.TabIndex = 50;
            // 
            // btnAddRepositoryDefaults
            // 
            this.btnAddRepositoryDefaults.Location = new System.Drawing.Point(1500, 11);
            this.btnAddRepositoryDefaults.Name = "btnAddRepositoryDefaults";
            this.btnAddRepositoryDefaults.Size = new System.Drawing.Size(89, 23);
            this.btnAddRepositoryDefaults.TabIndex = 52;
            this.btnAddRepositoryDefaults.TabStop = false;
            this.btnAddRepositoryDefaults.Text = "Add defaults";
            this.btnAddRepositoryDefaults.UseVisualStyleBackColor = true;
            this.btnAddRepositoryDefaults.Click += new System.EventHandler(this.btnAddRepositoryDefaults_Click);
            // 
            // txtRepositoryName
            // 
            this.txtRepositoryName.Location = new System.Drawing.Point(71, 34);
            this.txtRepositoryName.Name = "txtRepositoryName";
            this.txtRepositoryName.Size = new System.Drawing.Size(134, 20);
            this.txtRepositoryName.TabIndex = 54;
            this.txtRepositoryName.TextChanged += new System.EventHandler(this.txtRepositoryName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Repository";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Search";
            // 
            // lblMethods
            // 
            this.lblRepository.AutoSize = true;
            this.lblRepository.Location = new System.Drawing.Point(1309, 16);
            this.lblRepository.Name = "lblMethods";
            this.lblRepository.Size = new System.Drawing.Size(98, 13);
            this.lblRepository.TabIndex = 56;
            this.lblRepository.Text = "RepositoryMethods";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1309, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 91);
            this.label1.TabIndex = 57;
            this.label1.Text = "Syntax:\r\n1. MethodName([ParamTypes])//Comments\r\n2. ReturnType:MethodName([ParamTy" +
    "pes])//Comments\r\n\r\n\r\nVariables:\r\n{RepositoryName}: Repository Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRepository);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRepositoryName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddRepositoryDefaults);
            this.Controls.Add(this.gridRepository);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.chkCreateTests);
            this.Controls.Add(this.chkFillData);
            this.Controls.Add(this.chkUniqueItem);
            this.Controls.Add(this.btnAddArrayDataAccess);
            this.Controls.Add(this.btnAddArrayNew);
            this.Controls.Add(this.btnAddArrayDataInfo);
            this.Controls.Add(this.btnAddDataAccess);
            this.Controls.Add(this.gridDac);
            this.Controls.Add(this.lblDataAccess);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gridNew);
            this.Controls.Add(this.lblNewData);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.btnExcludeFilter);
            this.Controls.Add(this.btnToFilter);
            this.Controls.Add(this.btnFromFilter);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddDataInfo);
            this.Controls.Add(this.btnIncludeFilter);
            this.Controls.Add(this.gridFields);
            this.Controls.Add(this.gridDataInfo);
            this.Controls.Add(this.lblDataInfo);
            this.Controls.Add(this.lblDataFilter);
            this.Controls.Add(this.gridDataFilter);
            this.Controls.Add(this.txtInputField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputField;
        private System.Windows.Forms.Label lblDataInfo;
        private System.Windows.Forms.DataGridView gridDataInfo;
        private System.Windows.Forms.DataGridView gridFields;
        private System.Windows.Forms.Button btnAddDataInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Label lblDataFilter;
        private System.Windows.Forms.Button btnIncludeFilter;
        private System.Windows.Forms.DataGridView gridDataFilter;
        private System.Windows.Forms.Button btnFromFilter;
        private System.Windows.Forms.Button btnToFilter;
        private System.Windows.Forms.Button btnExcludeFilter;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gridNew;
        private System.Windows.Forms.Label lblNewData;
        private System.Windows.Forms.Button btnAddDataAccess;
        private System.Windows.Forms.DataGridView gridDac;
        private System.Windows.Forms.Label lblDataAccess;
        private System.Windows.Forms.Button btnAddArrayDataInfo;
        private System.Windows.Forms.Button btnAddArrayNew;
        private System.Windows.Forms.Button btnAddArrayDataAccess;
        private System.Windows.Forms.CheckBox chkUniqueItem;
        private System.Windows.Forms.CheckBox chkFillData;
        private System.Windows.Forms.CheckBox chkCreateTests;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.DataGridView gridRepository;
        private System.Windows.Forms.Button btnAddRepositoryDefaults;
        private System.Windows.Forms.TextBox txtRepositoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRepository;
        private System.Windows.Forms.Label label1;
    }
}