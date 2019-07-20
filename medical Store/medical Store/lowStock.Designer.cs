namespace medical_Store
{
    partial class lowStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.netQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.netAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicineIdColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineNameColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineTypeColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.qtySearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.medicineName = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.medicineId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(339, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Low Stock Medicine";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.netQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.netAmount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.qtySearch);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.medicineName);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.medicineId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(9, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 574);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine\'s Information";
            // 
            // netQty
            // 
            this.netQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.netQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.netQty.Location = new System.Drawing.Point(571, 544);
            this.netQty.Name = "netQty";
            this.netQty.ReadOnly = true;
            this.netQty.Size = new System.Drawing.Size(120, 26);
            this.netQty.TabIndex = 19;
            this.netQty.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(496, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Net Qty.";
            // 
            // netAmount
            // 
            this.netAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.netAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.netAmount.Location = new System.Drawing.Point(784, 543);
            this.netAmount.Name = "netAmount";
            this.netAmount.ReadOnly = true;
            this.netAmount.Size = new System.Drawing.Size(120, 26);
            this.netAmount.TabIndex = 17;
            this.netAmount.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(688, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Net Amount:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdColoumn,
            this.MedicineNameColoumn,
            this.manufactureColoumn,
            this.medicineTypeColoumn,
            this.dateColoumn,
            this.shelfColoumn,
            this.descriptionColoumn,
            this.priceColoumn,
            this.qtyColoumn,
            this.amountColoumn});
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
            this.dataGridView1.Size = new System.Drawing.Size(906, 498);
            this.dataGridView1.TabIndex = 4;
            // 
            // medicineIdColoumn
            // 
            this.medicineIdColoumn.HeaderText = "Medicine ID";
            this.medicineIdColoumn.Name = "medicineIdColoumn";
            this.medicineIdColoumn.ReadOnly = true;
            // 
            // MedicineNameColoumn
            // 
            this.MedicineNameColoumn.HeaderText = "Medicine Name";
            this.MedicineNameColoumn.Name = "MedicineNameColoumn";
            this.MedicineNameColoumn.ReadOnly = true;
            // 
            // manufactureColoumn
            // 
            this.manufactureColoumn.HeaderText = "Manufacturer";
            this.manufactureColoumn.Name = "manufactureColoumn";
            this.manufactureColoumn.ReadOnly = true;
            // 
            // medicineTypeColoumn
            // 
            this.medicineTypeColoumn.HeaderText = "Medicine Type";
            this.medicineTypeColoumn.Name = "medicineTypeColoumn";
            this.medicineTypeColoumn.ReadOnly = true;
            // 
            // dateColoumn
            // 
            this.dateColoumn.HeaderText = "Date";
            this.dateColoumn.Name = "dateColoumn";
            this.dateColoumn.ReadOnly = true;
            // 
            // shelfColoumn
            // 
            this.shelfColoumn.HeaderText = "Shelf";
            this.shelfColoumn.Name = "shelfColoumn";
            this.shelfColoumn.ReadOnly = true;
            // 
            // descriptionColoumn
            // 
            this.descriptionColoumn.HeaderText = "Description";
            this.descriptionColoumn.Name = "descriptionColoumn";
            this.descriptionColoumn.ReadOnly = true;
            // 
            // priceColoumn
            // 
            this.priceColoumn.HeaderText = "Price";
            this.priceColoumn.Name = "priceColoumn";
            this.priceColoumn.ReadOnly = true;
            // 
            // qtyColoumn
            // 
            this.qtyColoumn.HeaderText = "Available Qty.";
            this.qtyColoumn.Name = "qtyColoumn";
            this.qtyColoumn.ReadOnly = true;
            // 
            // amountColoumn
            // 
            this.amountColoumn.HeaderText = "Amount";
            this.amountColoumn.Name = "amountColoumn";
            this.amountColoumn.ReadOnly = true;
            // 
            // report
            // 
            this.report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.report.Location = new System.Drawing.Point(652, 17);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 25);
            this.report.TabIndex = 3;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // refresh
            // 
            this.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh.Location = new System.Drawing.Point(571, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 25);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // qtySearch
            // 
            this.qtySearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qtySearch.Location = new System.Drawing.Point(500, 17);
            this.qtySearch.Name = "qtySearch";
            this.qtySearch.Size = new System.Drawing.Size(59, 25);
            this.qtySearch.TabIndex = 2;
            this.qtySearch.Text = "Search";
            this.qtySearch.UseVisualStyleBackColor = true;
            this.qtySearch.Click += new System.EventHandler(this.qtySearch_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(144, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 25);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // medicineName
            // 
            this.medicineName.Location = new System.Drawing.Point(243, 18);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(100, 20);
            this.medicineName.TabIndex = 1;
            this.medicineName.TextChanged += new System.EventHandler(this.medicineName_TextChanged);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(410, 19);
            this.qty.MaxLength = 6;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(85, 20);
            this.qty.TabIndex = 1;
            this.qty.Text = "10";
            // 
            // medicineId
            // 
            this.medicineId.Location = new System.Drawing.Point(53, 17);
            this.medicineId.Name = "medicineId";
            this.medicineId.Size = new System.Drawing.Size(82, 20);
            this.medicineId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Qty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 20);
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
            // lowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(933, 618);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "lowStock";
            this.Text = "Low Stock Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.lowStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button qtySearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox medicineName;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox medicineId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNameColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineTypeColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColoumn;
        private System.Windows.Forms.TextBox netAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox netQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button report;
    }
}