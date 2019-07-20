namespace medical_Store
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSaleHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expireMedicineStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.lowStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showExpireMedicineInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expireNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.lowStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineManagementToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.accountManagementToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineManagementToolStripMenuItem
            // 
            this.medicineManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanyToolStripMenuItem,
            this.addMedicineTypeToolStripMenuItem,
            this.addMedicineToolStripMenuItem,
            this.viewStockToolStripMenuItem,
            this.damageStockToolStripMenuItem});
            this.medicineManagementToolStripMenuItem.Name = "medicineManagementToolStripMenuItem";
            this.medicineManagementToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.medicineManagementToolStripMenuItem.Text = "Medicine Management";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addCompanyToolStripMenuItem.Text = "Manufacture Company";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // addMedicineTypeToolStripMenuItem
            // 
            this.addMedicineTypeToolStripMenuItem.Name = "addMedicineTypeToolStripMenuItem";
            this.addMedicineTypeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addMedicineTypeToolStripMenuItem.Text = "Medicine Type";
            this.addMedicineTypeToolStripMenuItem.Click += new System.EventHandler(this.addMedicineTypeToolStripMenuItem_Click);
            // 
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addMedicineToolStripMenuItem.Text = " Medicine";
            this.addMedicineToolStripMenuItem.Click += new System.EventHandler(this.addMedicineToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewStockToolStripMenuItem.Text = "Medicine Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // damageStockToolStripMenuItem
            // 
            this.damageStockToolStripMenuItem.Name = "damageStockToolStripMenuItem";
            this.damageStockToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.damageStockToolStripMenuItem.Text = "Damage Stock";
            this.damageStockToolStripMenuItem.Click += new System.EventHandler(this.damageStockToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem1,
            this.viewSaleHistoryToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.saleToolStripMenuItem.Text = "Transection";
            // 
            // saleToolStripMenuItem1
            // 
            this.saleToolStripMenuItem1.Name = "saleToolStripMenuItem1";
            this.saleToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.saleToolStripMenuItem1.Text = "Sale                            ";
            this.saleToolStripMenuItem1.Click += new System.EventHandler(this.saleToolStripMenuItem1_Click);
            // 
            // viewSaleHistoryToolStripMenuItem
            // 
            this.viewSaleHistoryToolStripMenuItem.Name = "viewSaleHistoryToolStripMenuItem";
            this.viewSaleHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewSaleHistoryToolStripMenuItem.Text = "View Sale History";
            this.viewSaleHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewSaleHistoryToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineStatusToolStripMenuItem,
            this.expireMedicineStatusToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // medicineStatusToolStripMenuItem
            // 
            this.medicineStatusToolStripMenuItem.Name = "medicineStatusToolStripMenuItem";
            this.medicineStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.medicineStatusToolStripMenuItem.Text = "Low Stock Status";
            this.medicineStatusToolStripMenuItem.Click += new System.EventHandler(this.medicineStatusToolStripMenuItem_Click);
            // 
            // expireMedicineStatusToolStripMenuItem
            // 
            this.expireMedicineStatusToolStripMenuItem.Name = "expireMedicineStatusToolStripMenuItem";
            this.expireMedicineStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.expireMedicineStatusToolStripMenuItem.Text = "Expire Medicine Status";
            this.expireMedicineStatusToolStripMenuItem.Click += new System.EventHandler(this.expireMedicineStatusToolStripMenuItem_Click);
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInfoToolStripMenuItem});
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.accountManagementToolStripMenuItem.Text = "Account Management";
            // 
            // accountInfoToolStripMenuItem
            // 
            this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountInfoToolStripMenuItem.Text = "Account Info.";
            this.accountInfoToolStripMenuItem.Click += new System.EventHandler(this.accountInfoToolStripMenuItem_Click);
            // 
            // lowStockNotify
            // 
            this.lowStockNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.lowStockNotify.BalloonTipText = "Some medicine have low Quantity";
            this.lowStockNotify.BalloonTipTitle = "Click here to View";
            this.lowStockNotify.ContextMenuStrip = this.lowStock;
            this.lowStockNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("lowStockNotify.Icon")));
            this.lowStockNotify.Text = "Notification";
            this.lowStockNotify.Visible = true;
            this.lowStockNotify.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // lowStock
            // 
            this.lowStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.showExpireMedicineInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.lowStock.Name = "lowStock";
            this.lowStock.Size = new System.Drawing.Size(217, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showToolStripMenuItem.Text = "Show Low Stock Medicine";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showExpireMedicineInfoToolStripMenuItem
            // 
            this.showExpireMedicineInfoToolStripMenuItem.Name = "showExpireMedicineInfoToolStripMenuItem";
            this.showExpireMedicineInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showExpireMedicineInfoToolStripMenuItem.Text = "Show Expire Medicine Info.";
            this.showExpireMedicineInfoToolStripMenuItem.Click += new System.EventHandler(this.showExpireMedicineInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // expireNotify
            // 
            this.expireNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.expireNotify.BalloonTipText = "Some medicine will expire in few months";
            this.expireNotify.BalloonTipTitle = "Click here to View";
            this.expireNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("expireNotify.Icon")));
            this.expireNotify.Text = "notifyIcon2";
            this.expireNotify.Visible = true;
            this.expireNotify.BalloonTipClicked += new System.EventHandler(this.expireNotify_BalloonTipClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(61)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(657, 473);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lowStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewSaleHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineStatusToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon lowStockNotify;
        private System.Windows.Forms.ContextMenuStrip lowStock;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expireMedicineStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showExpireMedicineInfoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon expireNotify;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}