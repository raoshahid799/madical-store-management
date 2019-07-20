namespace medical_Store
{
    partial class damageStock
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
            this.search = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ComboBox();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet2 = new medical_Store.medicalStoreDataSet2();
            this.batchNo = new System.Windows.Forms.ComboBox();
            this.medicineType = new System.Windows.Forms.ComboBox();
            this.mCompany = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label6.Location = new System.Drawing.Point(104, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Add Damage & Expire Medicine Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.medicineType);
            this.groupBox1.Controls.Add(this.mCompany);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(64, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 491);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Information";
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(445, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name.DataSource = this.medicineBindingSource;
            this.name.DisplayMember = "name";
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(191, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 28);
            this.name.TabIndex = 3;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
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
            // batchNo
            // 
            this.batchNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchNo.DisplayMember = "name";
            this.batchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.batchNo.FormattingEnabled = true;
            this.batchNo.Location = new System.Drawing.Point(191, 94);
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(248, 28);
            this.batchNo.TabIndex = 4;
            this.batchNo.Text = "Select Batch No.";
            // 
            // medicineType
            // 
            this.medicineType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicineType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.medicineType.DisplayMember = "name";
            this.medicineType.Enabled = false;
            this.medicineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineType.FormattingEnabled = true;
            this.medicineType.Location = new System.Drawing.Point(191, 130);
            this.medicineType.Name = "medicineType";
            this.medicineType.Size = new System.Drawing.Size(248, 28);
            this.medicineType.TabIndex = 5;
            // 
            // mCompany
            // 
            this.mCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mCompany.DisplayMember = "name";
            this.mCompany.Enabled = false;
            this.mCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mCompany.FormattingEnabled = true;
            this.mCompany.Location = new System.Drawing.Point(191, 165);
            this.mCompany.Name = "mCompany";
            this.mCompany.Size = new System.Drawing.Size(248, 28);
            this.mCompany.TabIndex = 6;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(191, 208);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(248, 26);
            this.date.TabIndex = 7;
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(219, 406);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(139, 44);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(191, 314);
            this.description.MaxLength = 100;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 71);
            this.description.TabIndex = 10;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(191, 242);
            this.price.MaxLength = 10;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(248, 26);
            this.price.TabIndex = 8;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.Location = new System.Drawing.Point(191, 277);
            this.qty.MaxLength = 4;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(248, 26);
            this.qty.TabIndex = 9;
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.Location = new System.Drawing.Point(191, 24);
            this.id.MaxLength = 8;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(248, 26);
            this.id.TabIndex = 1;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(13, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(13, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medicine Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Batch No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(13, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manufacture Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine ID";
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // damageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(627, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "damageStock";
            this.Text = "Damage Stock";
            this.Load += new System.EventHandler(this.damageStock_Load);
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
        private System.Windows.Forms.ComboBox medicineType;
        private System.Windows.Forms.ComboBox mCompany;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label9;
        private medicalStoreDataSet2 medicalStoreDataSet2;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private medicalStoreDataSet2TableAdapters.medicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.ComboBox batchNo;
        private System.Windows.Forms.Label label10;
    }
}