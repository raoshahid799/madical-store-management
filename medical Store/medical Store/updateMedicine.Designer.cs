namespace medical_Store
{
    partial class updateMedicine
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
            this.medicalStoreDataSet3 = new medical_Store.medicalStoreDataSet3();
            this.medicalStoreDataSet6 = new medical_Store.medicalStoreDataSet6();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medicineType = new System.Windows.Forms.ComboBox();
            this.medicineTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacture = new System.Windows.Forms.ComboBox();
            this.companyNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.shelf = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameTableAdapter = new medical_Store.medicalStoreDataSet6TableAdapters.companyNameTableAdapter();
            this.medicineTypeTableAdapter = new medical_Store.medicalStoreDataSet3TableAdapters.medicineTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalStoreDataSet3
            // 
            this.medicalStoreDataSet3.DataSetName = "medicalStoreDataSet3";
            this.medicalStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalStoreDataSet6
            // 
            this.medicalStoreDataSet6.DataSetName = "medicalStoreDataSet6";
            this.medicalStoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(168, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Update Medicine Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicineType);
            this.groupBox1.Controls.Add(this.manufacture);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.shelf);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 420);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Information";
            // 
            // medicineType
            // 
            this.medicineType.DataSource = this.medicineTypeBindingSource;
            this.medicineType.DisplayMember = "name";
            this.medicineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineType.FormattingEnabled = true;
            this.medicineType.Location = new System.Drawing.Point(235, 100);
            this.medicineType.Name = "medicineType";
            this.medicineType.Size = new System.Drawing.Size(248, 28);
            this.medicineType.TabIndex = 4;
            // 
            // medicineTypeBindingSource
            // 
            this.medicineTypeBindingSource.DataMember = "medicineType";
            this.medicineTypeBindingSource.DataSource = this.medicalStoreDataSet3BindingSource;
            // 
            // medicalStoreDataSet3BindingSource
            // 
            this.medicalStoreDataSet3BindingSource.DataSource = this.medicalStoreDataSet3;
            this.medicalStoreDataSet3BindingSource.Position = 0;
            // 
            // manufacture
            // 
            this.manufacture.DataSource = this.companyNameBindingSource;
            this.manufacture.DisplayMember = "name";
            this.manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manufacture.FormattingEnabled = true;
            this.manufacture.Location = new System.Drawing.Point(235, 135);
            this.manufacture.Name = "manufacture";
            this.manufacture.Size = new System.Drawing.Size(248, 28);
            this.manufacture.TabIndex = 4;
            // 
            // companyNameBindingSource
            // 
            this.companyNameBindingSource.DataMember = "companyName";
            this.companyNameBindingSource.DataSource = this.medicalStoreDataSet6BindingSource;
            // 
            // medicalStoreDataSet6BindingSource
            // 
            this.medicalStoreDataSet6BindingSource.DataSource = this.medicalStoreDataSet6;
            this.medicalStoreDataSet6BindingSource.Position = 0;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(235, 172);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(248, 26);
            this.date.TabIndex = 3;
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(263, 362);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(139, 44);
            this.save.TabIndex = 2;
            this.save.Text = "Update";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(235, 278);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 71);
            this.description.TabIndex = 1;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(235, 206);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(248, 26);
            this.price.TabIndex = 1;
            // 
            // shelf
            // 
            this.shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelf.Location = new System.Drawing.Point(235, 241);
            this.shelf.Name = "shelf";
            this.shelf.Size = new System.Drawing.Size(248, 26);
            this.shelf.TabIndex = 1;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.Location = new System.Drawing.Point(235, 27);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(248, 26);
            this.id.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(235, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 26);
            this.name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(57, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(57, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(57, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(57, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Shelf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(57, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manufacture Company";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(57, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medicine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // companyNameTableAdapter
            // 
            this.companyNameTableAdapter.ClearBeforeFill = true;
            // 
            // medicineTypeTableAdapter
            // 
            this.medicineTypeTableAdapter.ClearBeforeFill = true;
            // 
            // updateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(567, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateMedicine";
            this.Text = "Update Medicine Form";
            this.Load += new System.EventHandler(this.updateMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private medicalStoreDataSet6 medicalStoreDataSet6;
        private medicalStoreDataSet3 medicalStoreDataSet3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox medicineType;
        private System.Windows.Forms.ComboBox manufacture;
        private System.Windows.Forms.BindingSource medicalStoreDataSet6BindingSource;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox shelf;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource medicalStoreDataSet3BindingSource;
        private System.Windows.Forms.BindingSource companyNameBindingSource;
        private medicalStoreDataSet6TableAdapters.companyNameTableAdapter companyNameTableAdapter;
        private System.Windows.Forms.BindingSource medicineTypeBindingSource;
        private medicalStoreDataSet3TableAdapters.medicineTypeTableAdapter medicineTypeTableAdapter;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label9;
    }
}