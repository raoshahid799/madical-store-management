namespace medical_Store
{
    partial class viewMedicineType
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet1 = new medical_Store.medicalStoreDataSet1();
            this.report = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.comName = new System.Windows.Forms.TextBox();
            this.companyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineTypeTableAdapter = new medical_Store.medicalStoreDataSet1TableAdapters.medicineTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(270, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "View Medicine\'s Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.showAll);
            this.groupBox1.Controls.Add(this.addNew);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.comName);
            this.groupBox1.Controls.Add(this.companyId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 547);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridView,
            this.nameDataGridView,
            this.dateDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicineTypeBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 496);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridView
            // 
            this.idDataGridView.DataPropertyName = "id";
            this.idDataGridView.FillWeight = 72.41962F;
            this.idDataGridView.HeaderText = "Medicine Type ID";
            this.idDataGridView.Name = "idDataGridView";
            this.idDataGridView.ReadOnly = true;
            // 
            // nameDataGridView
            // 
            this.nameDataGridView.DataPropertyName = "name";
            this.nameDataGridView.FillWeight = 72.41962F;
            this.nameDataGridView.HeaderText = "Name";
            this.nameDataGridView.Name = "nameDataGridView";
            this.nameDataGridView.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 72.41962F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.FillWeight = 182.7411F;
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // medicineTypeBindingSource
            // 
            this.medicineTypeBindingSource.DataMember = "medicineType";
            this.medicineTypeBindingSource.DataSource = this.medicalStoreDataSet1;
            // 
            // medicalStoreDataSet1
            // 
            this.medicalStoreDataSet1.DataSetName = "medicalStoreDataSet1";
            this.medicalStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report
            // 
            this.report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.report.Location = new System.Drawing.Point(651, 16);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 25);
            this.report.TabIndex = 3;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(570, 16);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 25);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // showAll
            // 
            this.showAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showAll.Location = new System.Drawing.Point(408, 16);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(75, 25);
            this.showAll.TabIndex = 3;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // addNew
            // 
            this.addNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNew.Location = new System.Drawing.Point(489, 16);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 25);
            this.addNew.TabIndex = 3;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(185, 14);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 25);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // comName
            // 
            this.comName.Location = new System.Drawing.Point(302, 18);
            this.comName.MaxLength = 20;
            this.comName.Name = "comName";
            this.comName.Size = new System.Drawing.Size(100, 20);
            this.comName.TabIndex = 1;
            this.comName.TextChanged += new System.EventHandler(this.comName_TextChanged);
            this.comName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comName_KeyPress);
            // 
            // companyId
            // 
            this.companyId.Location = new System.Drawing.Point(78, 17);
            this.companyId.MaxLength = 8;
            this.companyId.Name = "companyId";
            this.companyId.Size = new System.Drawing.Size(100, 20);
            this.companyId.TabIndex = 1;
            this.companyId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine ID";
            // 
            // medicineTypeTableAdapter
            // 
            this.medicineTypeTableAdapter.ClearBeforeFill = true;
            // 
            // viewMedicineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(801, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewMedicineType";
            this.Text = "Medicine Type Form";
            this.Load += new System.EventHandler(this.viewMedicineType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox comName;
        private System.Windows.Forms.TextBox companyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private medicalStoreDataSet1 medicalStoreDataSet1;
        private System.Windows.Forms.BindingSource medicineTypeBindingSource;
        private medicalStoreDataSet1TableAdapters.medicineTypeTableAdapter medicineTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button report;
    }
}