namespace medical_Store
{
    partial class addMedicine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medicineType = new System.Windows.Forms.ComboBox();
            this.medicineTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet4 = new medical_Store.medicalStoreDataSet4();
            this.company = new System.Windows.Forms.ComboBox();
            this.companyNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet6 = new medical_Store.medicalStoreDataSet6();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.shelf = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.medicineTypeTableAdapter = new medical_Store.medicalStoreDataSet4TableAdapters.medicineTypeTableAdapter();
            this.medicalStoreDataSet5 = new medical_Store.medicalStoreDataSet5();
            this.medicineTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTypeTableAdapter1 = new medical_Store.medicalStoreDataSet5TableAdapters.medicineTypeTableAdapter();
            this.companyNameTableAdapter = new medical_Store.medicalStoreDataSet6TableAdapters.companyNameTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicineType);
            this.groupBox1.Controls.Add(this.company);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.shelf);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(28, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Information";
            // 
            // medicineType
            // 
            this.medicineType.DataSource = this.medicineTypeBindingSource;
            this.medicineType.DisplayMember = "name";
            this.medicineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineType.FormattingEnabled = true;
            this.medicineType.Location = new System.Drawing.Point(235, 73);
            this.medicineType.Name = "medicineType";
            this.medicineType.Size = new System.Drawing.Size(248, 28);
            this.medicineType.TabIndex = 2;
            this.medicineType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineType_KeyPress);
            // 
            // medicineTypeBindingSource
            // 
            this.medicineTypeBindingSource.DataMember = "medicineType";
            this.medicineTypeBindingSource.DataSource = this.medicalStoreDataSet4;
            // 
            // medicalStoreDataSet4
            // 
            this.medicalStoreDataSet4.DataSetName = "medicalStoreDataSet4";
            this.medicalStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // company
            // 
            this.company.DataSource = this.companyNameBindingSource;
            this.company.DisplayMember = "name";
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(235, 108);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(248, 28);
            this.company.TabIndex = 3;
            this.company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineType_KeyPress);
            // 
            // companyNameBindingSource
            // 
            this.companyNameBindingSource.DataMember = "companyName";
            this.companyNameBindingSource.DataSource = this.medicalStoreDataSet6;
            // 
            // medicalStoreDataSet6
            // 
            this.medicalStoreDataSet6.DataSetName = "medicalStoreDataSet6";
            this.medicalStoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(235, 145);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(248, 26);
            this.date.TabIndex = 4;
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(263, 344);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(139, 44);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(235, 251);
            this.description.MaxLength = 200;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 71);
            this.description.TabIndex = 7;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(235, 179);
            this.price.MaxLength = 10;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(248, 26);
            this.price.TabIndex = 5;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // shelf
            // 
            this.shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelf.Location = new System.Drawing.Point(235, 214);
            this.shelf.MaxLength = 30;
            this.shelf.Name = "shelf";
            this.shelf.Size = new System.Drawing.Size(248, 26);
            this.shelf.TabIndex = 6;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(235, 36);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 26);
            this.name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(57, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(57, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(57, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(57, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Shelf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(57, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manufacture Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(162, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Add Medicine Form";
            // 
            // medicineTypeTableAdapter
            // 
            this.medicineTypeTableAdapter.ClearBeforeFill = true;
            // 
            // medicalStoreDataSet5
            // 
            this.medicalStoreDataSet5.DataSetName = "medicalStoreDataSet5";
            this.medicalStoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTypeBindingSource1
            // 
            this.medicineTypeBindingSource1.DataMember = "medicineType";
            this.medicineTypeBindingSource1.DataSource = this.medicalStoreDataSet5;
            // 
            // medicineTypeTableAdapter1
            // 
            this.medicineTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // companyNameTableAdapter
            // 
            this.companyNameTableAdapter.ClearBeforeFill = true;
            // 
            // addMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(562, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addMedicine";
            this.Text = "Add Medicine";
            this.Load += new System.EventHandler(this.addMedicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shelf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.ComboBox medicineType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
        private medicalStoreDataSet4 medicalStoreDataSet4;
        private System.Windows.Forms.BindingSource medicineTypeBindingSource;
        private medicalStoreDataSet4TableAdapters.medicineTypeTableAdapter medicineTypeTableAdapter;
        private medicalStoreDataSet5 medicalStoreDataSet5;
        private System.Windows.Forms.BindingSource medicineTypeBindingSource1;
        private medicalStoreDataSet5TableAdapters.medicineTypeTableAdapter medicineTypeTableAdapter1;
        private medicalStoreDataSet6 medicalStoreDataSet6;
        private System.Windows.Forms.BindingSource companyNameBindingSource;
        private medicalStoreDataSet6TableAdapters.companyNameTableAdapter companyNameTableAdapter;
    }
}