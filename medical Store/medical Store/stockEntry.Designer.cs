namespace medical_Store
{
    partial class stockEntry
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.ComboBox();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet2 = new medical_Store.medicalStoreDataSet2();
            this.medicineName = new System.Windows.Forms.ComboBox();
            this.receiveDate = new System.Windows.Forms.DateTimePicker();
            this.mfDate = new System.Windows.Forms.DateTimePicker();
            this.expDate = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.batchNo = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineTableAdapter = new medical_Store.medicalStoreDataSet2TableAdapters.medicineTableAdapter();
            this.groupBox1.SuspendLayout();
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
            this.label6.Location = new System.Drawing.Point(173, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stock Entry Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.medicineName);
            this.groupBox1.Controls.Add(this.receiveDate);
            this.groupBox1.Controls.Add(this.mfDate);
            this.groupBox1.Controls.Add(this.expDate);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(39, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 408);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Information";
            // 
            // id
            // 
            this.id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id.DataSource = this.medicineBindingSource;
            this.id.DisplayMember = "medicineId";
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(235, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(248, 28);
            this.id.TabIndex = 1;
            this.id.SelectedIndexChanged += new System.EventHandler(this.medicineName_SelectedIndexChanged);
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
            // medicineName
            // 
            this.medicineName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.medicineName.DataSource = this.medicineBindingSource;
            this.medicineName.DisplayMember = "name";
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineName.FormattingEnabled = true;
            this.medicineName.Location = new System.Drawing.Point(235, 58);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(248, 28);
            this.medicineName.TabIndex = 2;
            // 
            // receiveDate
            // 
            this.receiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.receiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.receiveDate.Location = new System.Drawing.Point(235, 94);
            this.receiveDate.Name = "receiveDate";
            this.receiveDate.Size = new System.Drawing.Size(248, 26);
            this.receiveDate.TabIndex = 3;
            // 
            // mfDate
            // 
            this.mfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mfDate.Location = new System.Drawing.Point(235, 160);
            this.mfDate.Name = "mfDate";
            this.mfDate.Size = new System.Drawing.Size(248, 26);
            this.mfDate.TabIndex = 5;
            // 
            // expDate
            // 
            this.expDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expDate.Location = new System.Drawing.Point(235, 194);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(248, 26);
            this.expDate.TabIndex = 6;
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(254, 342);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(139, 44);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(235, 260);
            this.description.MaxLength = 100;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 71);
            this.description.TabIndex = 8;
            // 
            // batchNo
            // 
            this.batchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.batchNo.Location = new System.Drawing.Point(235, 127);
            this.batchNo.MaxLength = 50;
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(248, 26);
            this.batchNo.TabIndex = 4;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.Location = new System.Drawing.Point(235, 228);
            this.qty.MaxLength = 5;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(248, 26);
            this.qty.TabIndex = 7;
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(57, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(57, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expiry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(57, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(57, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Batch No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(57, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Receive Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(57, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MF. Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(57, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medicine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // stockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(577, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stockEntry";
            this.Text = "Stock Entry Form";
            this.Load += new System.EventHandler(this.stockEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker expDate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medicineName;
        private medicalStoreDataSet2 medicalStoreDataSet2;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private medicalStoreDataSet2TableAdapters.medicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.DateTimePicker mfDate;
        private System.Windows.Forms.TextBox batchNo;
        private System.Windows.Forms.DateTimePicker receiveDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox id;
    }
}