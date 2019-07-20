namespace medical_Store
{
    partial class sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet2 = new medical_Store.medicalStoreDataSet2();
            this.medicineTableAdapter = new medical_Store.medicalStoreDataSet2TableAdapters.medicineTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cashMemoNo = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.medicineName = new System.Windows.Forms.ComboBox();
            this.medicineId = new System.Windows.Forms.ComboBox();
            this.batchNo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newBill = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicineIdColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalItem = new System.Windows.Forms.TextBox();
            this.grossAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.netAmount = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cash Memo No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(260, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qty.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(260, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medicine ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(461, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medicine Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(725, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Batch No.";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(127, 77);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(121, 24);
            this.date.TabIndex = 0;
            this.date.TabStop = false;
            // 
            // cashMemoNo
            // 
            this.cashMemoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cashMemoNo.Location = new System.Drawing.Point(127, 19);
            this.cashMemoNo.Name = "cashMemoNo";
            this.cashMemoNo.ReadOnly = true;
            this.cashMemoNo.Size = new System.Drawing.Size(121, 24);
            this.cashMemoNo.TabIndex = 0;
            this.cashMemoNo.TabStop = false;
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.customerName.Location = new System.Drawing.Point(128, 46);
            this.customerName.MaxLength = 20;
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(120, 24);
            this.customerName.TabIndex = 0;
            this.customerName.TabStop = false;
            this.customerName.Text = "Customer Name";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.qty.Location = new System.Drawing.Point(344, 61);
            this.qty.MaxLength = 6;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(106, 24);
            this.qty.TabIndex = 4;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            // 
            // medicineName
            // 
            this.medicineName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.medicineName.DataSource = this.medicineBindingSource;
            this.medicineName.DisplayMember = "name";
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.medicineName.FormattingEnabled = true;
            this.medicineName.Location = new System.Drawing.Point(569, 26);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(149, 26);
            this.medicineName.TabIndex = 1;
            // 
            // medicineId
            // 
            this.medicineId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicineId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.medicineId.DataSource = this.medicineBindingSource;
            this.medicineId.DisplayMember = "medicineId";
            this.medicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.medicineId.FormattingEnabled = true;
            this.medicineId.Location = new System.Drawing.Point(344, 23);
            this.medicineId.Name = "medicineId";
            this.medicineId.Size = new System.Drawing.Size(106, 26);
            this.medicineId.TabIndex = 1;
            this.medicineId.TextChanged += new System.EventHandler(this.medicineId_TextChanged);
            // 
            // batchNo
            // 
            this.batchNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.batchNo.FormattingEnabled = true;
            this.batchNo.Location = new System.Drawing.Point(799, 29);
            this.batchNo.Name = "batchNo";
            this.batchNo.Size = new System.Drawing.Size(140, 26);
            this.batchNo.TabIndex = 2;
            this.batchNo.Text = "Select Batch No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.newBill);
            this.groupBox1.Controls.Add(this.removeItem);
            this.groupBox1.Controls.Add(this.addItem);
            this.groupBox1.Controls.Add(this.batchNo);
            this.groupBox1.Controls.Add(this.medicineId);
            this.groupBox1.Controls.Add(this.medicineName);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Controls.Add(this.cashMemoNo);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Information";
            // 
            // newBill
            // 
            this.newBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newBill.Location = new System.Drawing.Point(659, 61);
            this.newBill.Name = "newBill";
            this.newBill.Size = new System.Drawing.Size(87, 23);
            this.newBill.TabIndex = 0;
            this.newBill.TabStop = false;
            this.newBill.Text = "New  Bill";
            this.newBill.UseVisualStyleBackColor = true;
            this.newBill.Click += new System.EventHandler(this.newBill_Click);
            // 
            // removeItem
            // 
            this.removeItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeItem.Location = new System.Drawing.Point(558, 61);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(87, 23);
            this.removeItem.TabIndex = 0;
            this.removeItem.TabStop = false;
            this.removeItem.Text = "Remove Item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // addItem
            // 
            this.addItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addItem.Location = new System.Drawing.Point(464, 61);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(88, 23);
            this.addItem.TabIndex = 5;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(398, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Medicine Sale Form";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(20, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 363);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdColoumn,
            this.medicineNameColoumn,
            this.batchNoColoumn,
            this.manufactureColoumn,
            this.expiryDateColoumn,
            this.priceColoumn,
            this.qtyColoumn,
            this.netAmountColoumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(935, 344);
            this.dataGridView1.TabIndex = 4;
            // 
            // medicineIdColoumn
            // 
            this.medicineIdColoumn.HeaderText = "Medicine ID";
            this.medicineIdColoumn.Name = "medicineIdColoumn";
            this.medicineIdColoumn.ReadOnly = true;
            // 
            // medicineNameColoumn
            // 
            this.medicineNameColoumn.HeaderText = "Medicine Name";
            this.medicineNameColoumn.Name = "medicineNameColoumn";
            this.medicineNameColoumn.ReadOnly = true;
            // 
            // batchNoColoumn
            // 
            this.batchNoColoumn.HeaderText = "Batch No.";
            this.batchNoColoumn.Name = "batchNoColoumn";
            this.batchNoColoumn.ReadOnly = true;
            // 
            // manufactureColoumn
            // 
            this.manufactureColoumn.HeaderText = "Manufacture";
            this.manufactureColoumn.Name = "manufactureColoumn";
            this.manufactureColoumn.ReadOnly = true;
            // 
            // expiryDateColoumn
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiryDateColoumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.expiryDateColoumn.HeaderText = "Expiry Date";
            this.expiryDateColoumn.Name = "expiryDateColoumn";
            this.expiryDateColoumn.ReadOnly = true;
            // 
            // priceColoumn
            // 
            this.priceColoumn.HeaderText = "Price";
            this.priceColoumn.Name = "priceColoumn";
            this.priceColoumn.ReadOnly = true;
            // 
            // qtyColoumn
            // 
            this.qtyColoumn.HeaderText = "Qty.";
            this.qtyColoumn.Name = "qtyColoumn";
            this.qtyColoumn.ReadOnly = true;
            // 
            // netAmountColoumn
            // 
            this.netAmountColoumn.HeaderText = "Net Amount";
            this.netAmountColoumn.Name = "netAmountColoumn";
            this.netAmountColoumn.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(229, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Items";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(389, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gross Amount:";
            // 
            // totalItem
            // 
            this.totalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalItem.Location = new System.Drawing.Point(319, 526);
            this.totalItem.Name = "totalItem";
            this.totalItem.ReadOnly = true;
            this.totalItem.Size = new System.Drawing.Size(66, 26);
            this.totalItem.TabIndex = 2;
            this.totalItem.TabStop = false;
            this.totalItem.Validating += new System.ComponentModel.CancelEventHandler(this.qty_Validating);
            // 
            // grossAmount
            // 
            this.grossAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grossAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grossAmount.Location = new System.Drawing.Point(506, 527);
            this.grossAmount.Name = "grossAmount";
            this.grossAmount.ReadOnly = true;
            this.grossAmount.Size = new System.Drawing.Size(89, 26);
            this.grossAmount.TabIndex = 2;
            this.grossAmount.TabStop = false;
            this.grossAmount.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(607, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Discount:";
            // 
            // disc
            // 
            this.disc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disc.Location = new System.Drawing.Point(679, 527);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(48, 26);
            this.disc.TabIndex = 2;
            this.disc.TabStop = false;
            this.disc.Text = "0";
            this.disc.TextChanged += new System.EventHandler(this.disc_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(732, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Net Amount:";
            // 
            // netAmount
            // 
            this.netAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.netAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.netAmount.Location = new System.Drawing.Point(828, 527);
            this.netAmount.Name = "netAmount";
            this.netAmount.ReadOnly = true;
            this.netAmount.Size = new System.Drawing.Size(120, 26);
            this.netAmount.TabIndex = 2;
            this.netAmount.TabStop = false;
            this.netAmount.Text = "0";
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.save.Location = new System.Drawing.Point(33, 522);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(82, 36);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.print.Enabled = false;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.print.Location = new System.Drawing.Point(121, 522);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(89, 36);
            this.print.TabIndex = 6;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(998, 570);
            this.Controls.Add(this.print);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.netAmount);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.grossAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalItem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Name = "sale";
            this.Text = "Sale Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private medicalStoreDataSet2 medicalStoreDataSet2;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private medicalStoreDataSet2TableAdapters.medicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox cashMemoNo;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.ComboBox medicineName;
        private System.Windows.Forms.ComboBox medicineId;
        private System.Windows.Forms.ComboBox batchNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalItem;
        private System.Windows.Forms.TextBox grossAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox disc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox netAmount;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountColoumn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button newBill;
    }
}