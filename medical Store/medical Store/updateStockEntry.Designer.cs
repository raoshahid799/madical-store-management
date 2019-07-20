namespace medical_Store
{
    partial class updateStockEntry
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receiveDate = new System.Windows.Forms.DateTimePicker();
            this.mfDate = new System.Windows.Forms.DateTimePicker();
            this.expDate = new System.Windows.Forms.DateTimePicker();
            this.update = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.batchNo = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.medicineId = new System.Windows.Forms.TextBox();
            this.medicineName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(208, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Update Stock Entry Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receiveDate);
            this.groupBox1.Controls.Add(this.mfDate);
            this.groupBox1.Controls.Add(this.expDate);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.medicineId);
            this.groupBox1.Controls.Add(this.medicineName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(48, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 408);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Information";
            // 
            // receiveDate
            // 
            this.receiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.receiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.receiveDate.Location = new System.Drawing.Point(220, 95);
            this.receiveDate.Name = "receiveDate";
            this.receiveDate.Size = new System.Drawing.Size(248, 26);
            this.receiveDate.TabIndex = 3;
            // 
            // mfDate
            // 
            this.mfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mfDate.Location = new System.Drawing.Point(220, 161);
            this.mfDate.Name = "mfDate";
            this.mfDate.Size = new System.Drawing.Size(248, 26);
            this.mfDate.TabIndex = 5;
            // 
            // expDate
            // 
            this.expDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expDate.Location = new System.Drawing.Point(220, 195);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(248, 26);
            this.expDate.TabIndex = 6;
            // 
            // update
            // 
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(268, 349);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(139, 44);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(220, 265);
            this.description.MaxLength = 100;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 71);
            this.description.TabIndex = 8;
            // 
            // batchNo
            // 
            this.batchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.batchNo.Location = new System.Drawing.Point(220, 128);
            this.batchNo.MaxLength = 50;
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(248, 26);
            this.batchNo.TabIndex = 4;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.Location = new System.Drawing.Point(220, 229);
            this.qty.MaxLength = 5;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(248, 26);
            this.qty.TabIndex = 7;
            // 
            // medicineId
            // 
            this.medicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineId.Location = new System.Drawing.Point(220, 22);
            this.medicineId.Name = "medicineId";
            this.medicineId.ReadOnly = true;
            this.medicineId.Size = new System.Drawing.Size(248, 26);
            this.medicineId.TabIndex = 1;
            // 
            // medicineName
            // 
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medicineName.Location = new System.Drawing.Point(220, 56);
            this.medicineName.MaxLength = 50;
            this.medicineName.Name = "medicineName";
            this.medicineName.ReadOnly = true;
            this.medicineName.Size = new System.Drawing.Size(248, 26);
            this.medicineName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(42, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(42, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expiry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(42, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Batch No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(42, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Receive Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MF. Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(42, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medicine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // updateStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(610, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateStockEntry";
            this.Text = "Update Stock Entry Form";
            this.Load += new System.EventHandler(this.updateStockEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker receiveDate;
        private System.Windows.Forms.DateTimePicker mfDate;
        private System.Windows.Forms.DateTimePicker expDate;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox batchNo;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox medicineName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicineId;
        private System.Windows.Forms.Label label9;
    }
}