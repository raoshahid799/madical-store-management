namespace medical_Store
{
    partial class viewMedicine
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.medicineTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet3 = new medical_Store.medicalStoreDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet2 = new medical_Store.medicalStoreDataSet2();
            this.update = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.comName = new System.Windows.Forms.TextBox();
            this.medicineId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineTableAdapter = new medical_Store.medicalStoreDataSet2TableAdapters.medicineTableAdapter();
            this.medicineTypeTableAdapter = new medical_Store.medicalStoreDataSet3TableAdapters.medicineTypeTableAdapter();
            this.tQty = new System.Windows.Forms.TextBox();
            this.aQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(324, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "View Medicine\'s Information Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tQty);
            this.groupBox1.Controls.Add(this.aQty);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.print);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.addNew);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.comName);
            this.groupBox1.Controls.Add(this.medicineId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 574);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine\'s Information";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.medicineTypeBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // medicineTypeBindingSource
            // 
            this.medicineTypeBindingSource.DataMember = "medicineType";
            this.medicineTypeBindingSource.DataSource = this.medicalStoreDataSet3;
            // 
            // medicalStoreDataSet3
            // 
            this.medicalStoreDataSet3.DataSetName = "medicalStoreDataSet3";
            this.medicalStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.medicineIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.medicineTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.manufactureDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn,
            this.totalQtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicineBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(951, 498);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "medicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "Medicine ID";
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            this.medicineIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineTypeDataGridViewTextBoxColumn
            // 
            this.medicineTypeDataGridViewTextBoxColumn.DataPropertyName = "medicineType";
            this.medicineTypeDataGridViewTextBoxColumn.HeaderText = "Medicine Type";
            this.medicineTypeDataGridViewTextBoxColumn.Name = "medicineTypeDataGridViewTextBoxColumn";
            this.medicineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            this.shelfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufactureDataGridViewTextBoxColumn
            // 
            this.manufactureDataGridViewTextBoxColumn.DataPropertyName = "manufacture";
            this.manufactureDataGridViewTextBoxColumn.HeaderText = "MF. Company";
            this.manufactureDataGridViewTextBoxColumn.Name = "manufactureDataGridViewTextBoxColumn";
            this.manufactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufactureDataGridViewTextBoxColumn.ToolTipText = "Manufacture Company";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "availableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "Available Qty.";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            this.availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQtyDataGridViewTextBoxColumn
            // 
            this.totalQtyDataGridViewTextBoxColumn.DataPropertyName = "totalQty";
            this.totalQtyDataGridViewTextBoxColumn.HeaderText = "Total Qty.";
            this.totalQtyDataGridViewTextBoxColumn.Name = "totalQtyDataGridViewTextBoxColumn";
            this.totalQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "medicine";
            this.medicineBindingSource.DataSource = this.medicalStoreDataSet2;
            // 
            // medicalStoreDataSet2
            // 
            this.medicalStoreDataSet2.DataSetName = "medicalStoreDataSet2";
            this.medicalStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update.Location = new System.Drawing.Point(704, 15);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 25);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // print
            // 
            this.print.ForeColor = System.Drawing.SystemColors.ControlText;
            this.print.Location = new System.Drawing.Point(865, 14);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 25);
            this.print.TabIndex = 3;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(784, 15);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 25);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // refresh
            // 
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refresh.Location = new System.Drawing.Point(546, 15);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 25);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // addNew
            // 
            this.addNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addNew.Location = new System.Drawing.Point(627, 15);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 25);
            this.addNew.TabIndex = 3;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search.Location = new System.Drawing.Point(135, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 25);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // comName
            // 
            this.comName.Location = new System.Drawing.Point(240, 18);
            this.comName.MaxLength = 20;
            this.comName.Name = "comName";
            this.comName.Size = new System.Drawing.Size(100, 20);
            this.comName.TabIndex = 1;
            this.comName.TextChanged += new System.EventHandler(this.comName_TextChanged);
            // 
            // medicineId
            // 
            this.medicineId.Location = new System.Drawing.Point(53, 17);
            this.medicineId.MaxLength = 8;
            this.medicineId.Name = "medicineId";
            this.medicineId.Size = new System.Drawing.Size(79, 20);
            this.medicineId.TabIndex = 1;
            this.medicineId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Med. ID";
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // medicineTypeTableAdapter
            // 
            this.medicineTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tQty
            // 
            this.tQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tQty.Location = new System.Drawing.Point(830, 544);
            this.tQty.Name = "tQty";
            this.tQty.ReadOnly = true;
            this.tQty.Size = new System.Drawing.Size(120, 26);
            this.tQty.TabIndex = 13;
            this.tQty.Text = "0";
            // 
            // aQty
            // 
            this.aQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aQty.Location = new System.Drawing.Point(649, 545);
            this.aQty.Name = "aQty";
            this.aQty.ReadOnly = true;
            this.aQty.Size = new System.Drawing.Size(92, 26);
            this.aQty.TabIndex = 14;
            this.aQty.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(746, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total Qty.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(549, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Available Qty.";
            // 
            // viewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(981, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewMedicine";
            this.Text = "View Medicine Form";
            this.Load += new System.EventHandler(this.addMedicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox comName;
        private System.Windows.Forms.TextBox medicineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private medicalStoreDataSet2 medicalStoreDataSet2;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private medicalStoreDataSet2TableAdapters.medicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private medicalStoreDataSet3 medicalStoreDataSet3;
        private System.Windows.Forms.BindingSource medicineTypeBindingSource;
        private medicalStoreDataSet3TableAdapters.medicineTypeTableAdapter medicineTypeTableAdapter;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox tQty;
        private System.Windows.Forms.TextBox aQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}