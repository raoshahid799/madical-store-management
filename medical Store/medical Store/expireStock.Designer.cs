namespace medical_Store
{
    partial class expireStock
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
            this.refresh = new System.Windows.Forms.Button();
            this.searchDate = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.medicineName = new System.Windows.Forms.TextBox();
            this.medicineId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batchSearch = new System.Windows.Forms.Button();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.netQty = new System.Windows.Forms.TextBox();
            this.batchNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh.Location = new System.Drawing.Point(754, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 25);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // searchDate
            // 
            this.searchDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchDate.Location = new System.Drawing.Point(692, 17);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(59, 25);
            this.searchDate.TabIndex = 2;
            this.searchDate.Text = "Search";
            this.searchDate.UseVisualStyleBackColor = true;
            this.searchDate.Click += new System.EventHandler(this.searchDate_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(128, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 25);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // medicineName
            // 
            this.medicineName.Location = new System.Drawing.Point(227, 18);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(83, 20);
            this.medicineName.TabIndex = 1;
            this.medicineName.TextChanged += new System.EventHandler(this.medicineName_TextChanged);
            // 
            // medicineId
            // 
            this.medicineId.Location = new System.Drawing.Point(53, 17);
            this.medicineId.Name = "medicineId";
            this.medicineId.Size = new System.Drawing.Size(70, 20);
            this.medicineId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expirey Date";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 492);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.batchSearch);
            this.groupBox1.Controls.Add(this.expireDate);
            this.groupBox1.Controls.Add(this.netQty);
            this.groupBox1.Controls.Add(this.netAmount);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.searchDate);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.medicineName);
            this.groupBox1.Controls.Add(this.medicineId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(9, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 574);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine\'s Information";
            // 
            // batchSearch
            // 
            this.batchSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batchSearch.Location = new System.Drawing.Point(461, 16);
            this.batchSearch.Name = "batchSearch";
            this.batchSearch.Size = new System.Drawing.Size(59, 25);
            this.batchSearch.TabIndex = 20;
            this.batchSearch.Text = "Search";
            this.batchSearch.UseVisualStyleBackColor = true;
            this.batchSearch.Click += new System.EventHandler(this.batchSearch_Click);
            // 
            // expireDate
            // 
            this.expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireDate.Location = new System.Drawing.Point(591, 19);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(98, 20);
            this.expireDate.TabIndex = 12;
            // 
            // netQty
            // 
            this.netQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.netQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.netQty.Location = new System.Drawing.Point(553, 543);
            this.netQty.Name = "netQty";
            this.netQty.ReadOnly = true;
            this.netQty.Size = new System.Drawing.Size(120, 26);
            this.netQty.TabIndex = 17;
            this.netQty.Text = "0";
            // 
            // batchNo
            // 
            this.batchNo.Location = new System.Drawing.Point(371, 18);
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(85, 20);
            this.batchNo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(478, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Net Qty.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Batch No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(336, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medicine Near to Expire";
            // 
            // report
            // 
            this.report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.report.Location = new System.Drawing.Point(835, 16);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 25);
            this.report.TabIndex = 3;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // expireStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(933, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "expireStock";
            this.Text = "Expire Stock Form";
            this.Load += new System.EventHandler(this.expireStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button searchDate;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox medicineName;
        private System.Windows.Forms.TextBox medicineId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expireDate;
        private System.Windows.Forms.Button batchSearch;
        private System.Windows.Forms.TextBox batchNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox netQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button report;
    }
}