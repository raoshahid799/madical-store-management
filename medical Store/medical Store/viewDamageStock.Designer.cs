namespace medical_Store
{
    partial class viewDamageStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.print = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mediName = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.batchSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.batchNo = new System.Windows.Forms.TextBox();
            this.medId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tQty = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tAmount);
            this.groupBox1.Controls.Add(this.tQty);
            this.groupBox1.Controls.Add(this.tPrice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.print);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mediName);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.addNew);
            this.groupBox1.Controls.Add(this.batchSearch);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.medId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(22, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 574);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine\'s Information";
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
            this.dataGridView1.Size = new System.Drawing.Size(958, 491);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // print
            // 
            this.print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.print.Location = new System.Drawing.Point(884, 17);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 25);
            this.print.TabIndex = 3;
            this.print.Text = "Report";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(806, 17);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 25);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descrip.";
            // 
            // descrip
            // 
            this.descrip.Location = new System.Drawing.Point(542, 20);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(100, 20);
            this.descrip.TabIndex = 1;
            this.descrip.TextChanged += new System.EventHandler(this.descrip_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // mediName
            // 
            this.mediName.Location = new System.Drawing.Point(412, 20);
            this.mediName.Name = "mediName";
            this.mediName.Size = new System.Drawing.Size(76, 20);
            this.mediName.TabIndex = 1;
            this.mediName.TextChanged += new System.EventHandler(this.mediName_TextChanged);
            // 
            // refresh
            // 
            this.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh.Location = new System.Drawing.Point(648, 18);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 25);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // addNew
            // 
            this.addNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNew.Location = new System.Drawing.Point(727, 17);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 25);
            this.addNew.TabIndex = 3;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // batchSearch
            // 
            this.batchSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batchSearch.Location = new System.Drawing.Point(312, 17);
            this.batchSearch.Name = "batchSearch";
            this.batchSearch.Size = new System.Drawing.Size(59, 25);
            this.batchSearch.TabIndex = 2;
            this.batchSearch.Text = "Search";
            this.batchSearch.UseVisualStyleBackColor = true;
            this.batchSearch.Click += new System.EventHandler(this.batchSearch_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(138, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 25);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // batchNo
            // 
            this.batchNo.Location = new System.Drawing.Point(246, 19);
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(65, 20);
            this.batchNo.TabIndex = 1;
            // 
            // medId
            // 
            this.medId.Location = new System.Drawing.Point(53, 17);
            this.medId.Name = "medId";
            this.medId.Size = new System.Drawing.Size(82, 20);
            this.medId.TabIndex = 1;
            this.medId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Batch No.";
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "View Damage & Expire Medicine Form";
            // 
            // tAmount
            // 
            this.tAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAmount.Location = new System.Drawing.Point(837, 542);
            this.tAmount.Name = "tAmount";
            this.tAmount.ReadOnly = true;
            this.tAmount.Size = new System.Drawing.Size(120, 26);
            this.tAmount.TabIndex = 22;
            this.tAmount.Text = "0";
            // 
            // tPrice
            // 
            this.tPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tPrice.Location = new System.Drawing.Point(644, 543);
            this.tPrice.Name = "tPrice";
            this.tPrice.ReadOnly = true;
            this.tPrice.Size = new System.Drawing.Size(92, 26);
            this.tPrice.TabIndex = 23;
            this.tPrice.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(737, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(553, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Price";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(373, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Qty.";
            // 
            // tQty
            // 
            this.tQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tQty.Location = new System.Drawing.Point(458, 541);
            this.tQty.Name = "tQty";
            this.tQty.ReadOnly = true;
            this.tQty.Size = new System.Drawing.Size(92, 26);
            this.tQty.TabIndex = 23;
            this.tQty.Text = "0";
            // 
            // viewDamageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1013, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewDamageStock";
            this.Text = "View Damage Stock";
            this.Load += new System.EventHandler(this.viewDamageStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button batchSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox mediName;
        private System.Windows.Forms.TextBox batchNo;
        private System.Windows.Forms.TextBox medId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tQty;
        private System.Windows.Forms.Label label5;

    }
}