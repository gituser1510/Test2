namespace ChemInform
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTaskTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentExportTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.taskAssingnmentTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskModificationTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.validateTaskPreparationTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentDeliveryTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentStatusReportTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersStatusReportTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userHourlyStatusReportTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearWiseStatusReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deliveryStatusReportTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveredSolventsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solventAgentsMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblRoleName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblShipment = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblRefName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.exportToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.deliveryMenuItem,
            this.reportsToolStripMenuItem,
            this.usersTSMenuItem,
            this.otherTSMenuItem,
            this.helpToolStripMenuItem,
            this.aboutTSMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1362, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTaskTSMenuItem,
            this.toolStripSeparator1,
            this.loginToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 19);
            this.fileMenu.Text = "&File";
            // 
            // loadTaskTSMenuItem
            // 
            this.loadTaskTSMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.loadTaskTSMenuItem.Name = "loadTaskTSMenuItem";
            this.loadTaskTSMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.loadTaskTSMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadTaskTSMenuItem.Text = "Load &Task";
            this.loadTaskTSMenuItem.Click += new System.EventHandler(this.loadTaskTSMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loginToolStripMenuItem.Text = "&Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.LogoutToolStripMenuItem.Text = "Log&out";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shipmentExportTSMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // shipmentExportTSMenuItem
            // 
            this.shipmentExportTSMenuItem.Name = "shipmentExportTSMenuItem";
            this.shipmentExportTSMenuItem.Size = new System.Drawing.Size(161, 22);
            this.shipmentExportTSMenuItem.Text = "Shipment Export";
            this.shipmentExportTSMenuItem.Click += new System.EventHandler(this.shipmentExportTSMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createShipmentToolStripMenuItem,
            this.toolStripSeparator2,
            this.taskAssingnmentTSMenuItem,
            this.taskModificationTSMenuItem,
            this.toolStripSeparator4,
            this.validateTaskPreparationTSMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // createShipmentToolStripMenuItem
            // 
            this.createShipmentToolStripMenuItem.Name = "createShipmentToolStripMenuItem";
            this.createShipmentToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.createShipmentToolStripMenuItem.Text = "Shipment Creation";
            this.createShipmentToolStripMenuItem.Click += new System.EventHandler(this.createShipmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // taskAssingnmentTSMenuItem
            // 
            this.taskAssingnmentTSMenuItem.Name = "taskAssingnmentTSMenuItem";
            this.taskAssingnmentTSMenuItem.Size = new System.Drawing.Size(218, 22);
            this.taskAssingnmentTSMenuItem.Text = "Task Assignment";
            this.taskAssingnmentTSMenuItem.Click += new System.EventHandler(this.taskAssingnmentTSMenuItem_Click);
            // 
            // taskModificationTSMenuItem
            // 
            this.taskModificationTSMenuItem.Name = "taskModificationTSMenuItem";
            this.taskModificationTSMenuItem.Size = new System.Drawing.Size(218, 22);
            this.taskModificationTSMenuItem.Text = "Task Modification";
            this.taskModificationTSMenuItem.Click += new System.EventHandler(this.taskModificationTSMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // validateTaskPreparationTSMenuItem
            // 
            this.validateTaskPreparationTSMenuItem.Name = "validateTaskPreparationTSMenuItem";
            this.validateTaskPreparationTSMenuItem.Size = new System.Drawing.Size(218, 22);
            this.validateTaskPreparationTSMenuItem.Text = "Task Preparation Validation";
            this.validateTaskPreparationTSMenuItem.Click += new System.EventHandler(this.validateTaskPreparationTSMenuItem_Click);
            // 
            // deliveryMenuItem
            // 
            this.deliveryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shipmentDeliveryTSMenuItem});
            this.deliveryMenuItem.Name = "deliveryMenuItem";
            this.deliveryMenuItem.Size = new System.Drawing.Size(61, 19);
            this.deliveryMenuItem.Text = "Delivery";
            // 
            // shipmentDeliveryTSMenuItem
            // 
            this.shipmentDeliveryTSMenuItem.Name = "shipmentDeliveryTSMenuItem";
            this.shipmentDeliveryTSMenuItem.Size = new System.Drawing.Size(170, 22);
            this.shipmentDeliveryTSMenuItem.Text = "Shipment Delivery";
            this.shipmentDeliveryTSMenuItem.Click += new System.EventHandler(this.shipmentDeliveryTSMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shipmentStatusReportTSMenuItem,
            this.toolStripSeparator6,
            this.usersStatusReportTSMenuItem,
            this.userHourlyStatusReportTSMenuItem,
            this.yearWiseStatusReportToolStripMenuItem,
            this.toolStripSeparator5,
            this.deliveryStatusReportTSMenuItem,
            this.deliveredSolventsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // shipmentStatusReportTSMenuItem
            // 
            this.shipmentStatusReportTSMenuItem.Name = "shipmentStatusReportTSMenuItem";
            this.shipmentStatusReportTSMenuItem.Size = new System.Drawing.Size(209, 22);
            this.shipmentStatusReportTSMenuItem.Text = "Shipment Status Report";
            this.shipmentStatusReportTSMenuItem.Click += new System.EventHandler(this.shipmentStatusReportTSMenuItem_Click);
            // 
            // usersStatusReportTSMenuItem
            // 
            this.usersStatusReportTSMenuItem.Name = "usersStatusReportTSMenuItem";
            this.usersStatusReportTSMenuItem.Size = new System.Drawing.Size(209, 22);
            this.usersStatusReportTSMenuItem.Text = "Users Status Report";
            this.usersStatusReportTSMenuItem.Click += new System.EventHandler(this.usersStatusReportTSMenuItem_Click);
            // 
            // userHourlyStatusReportTSMenuItem
            // 
            this.userHourlyStatusReportTSMenuItem.Name = "userHourlyStatusReportTSMenuItem";
            this.userHourlyStatusReportTSMenuItem.Size = new System.Drawing.Size(209, 22);
            this.userHourlyStatusReportTSMenuItem.Text = "User Hourly Status Report";
            this.userHourlyStatusReportTSMenuItem.Click += new System.EventHandler(this.userHourlyStatusReportTSMenuItem_Click);
            // 
            // yearWiseStatusReportToolStripMenuItem
            // 
            this.yearWiseStatusReportToolStripMenuItem.Name = "yearWiseStatusReportToolStripMenuItem";
            this.yearWiseStatusReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.yearWiseStatusReportToolStripMenuItem.Text = "Year Wise Status Report";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(206, 6);
            // 
            // deliveryStatusReportTSMenuItem
            // 
            this.deliveryStatusReportTSMenuItem.Name = "deliveryStatusReportTSMenuItem";
            this.deliveryStatusReportTSMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deliveryStatusReportTSMenuItem.Text = "Delivery Status Report";
            this.deliveryStatusReportTSMenuItem.Click += new System.EventHandler(this.deliveryStatusReportTSMenuItem_Click);
            // 
            // deliveredSolventsReportToolStripMenuItem
            // 
            this.deliveredSolventsReportToolStripMenuItem.Name = "deliveredSolventsReportToolStripMenuItem";
            this.deliveredSolventsReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deliveredSolventsReportToolStripMenuItem.Text = "Delivered Solvents Report";
            this.deliveredSolventsReportToolStripMenuItem.Click += new System.EventHandler(this.deliveredSolventsReportToolStripMenuItem_Click);
            // 
            // usersTSMenuItem
            // 
            this.usersTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfileTSMenuItem});
            this.usersTSMenuItem.Name = "usersTSMenuItem";
            this.usersTSMenuItem.Size = new System.Drawing.Size(47, 19);
            this.usersTSMenuItem.Text = "Users";
            // 
            // userProfileTSMenuItem
            // 
            this.userProfileTSMenuItem.Name = "userProfileTSMenuItem";
            this.userProfileTSMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userProfileTSMenuItem.Text = "User Profile";
            this.userProfileTSMenuItem.Click += new System.EventHandler(this.userProfileTSMenuItem_Click);
            // 
            // otherTSMenuItem
            // 
            this.otherTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solventAgentsMasterToolStripMenuItem});
            this.otherTSMenuItem.Name = "otherTSMenuItem";
            this.otherTSMenuItem.Size = new System.Drawing.Size(49, 19);
            this.otherTSMenuItem.Text = "Other";
            // 
            // solventAgentsMasterToolStripMenuItem
            // 
            this.solventAgentsMasterToolStripMenuItem.Name = "solventAgentsMasterToolStripMenuItem";
            this.solventAgentsMasterToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.solventAgentsMasterToolStripMenuItem.Text = "Solvent-Agents Master";
            this.solventAgentsMasterToolStripMenuItem.Click += new System.EventHandler(this.solventAgentsMasterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTSMenuItem
            // 
            this.aboutTSMenuItem.Name = "aboutTSMenuItem";
            this.aboutTSMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutTSMenuItem.Text = "About";
            this.aboutTSMenuItem.Click += new System.EventHandler(this.aboutTSMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblUserName,
            this.sslblRoleName,
            this.toolStripStatusLabel1,
            this.sslblShipment,
            this.toolStripStatusLabel2,
            this.sslblRefName,
            this.toolStripStatusLabel3,
            this.ssLblAppVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslblUserName
            // 
            this.sslblUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslblUserName.Image = global::ChemInform.Properties.Resources.UserName;
            this.sslblUserName.Name = "sslblUserName";
            this.sslblUserName.Size = new System.Drawing.Size(20, 20);
            // 
            // sslblRoleName
            // 
            this.sslblRoleName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslblRoleName.Image = global::ChemInform.Properties.Resources.Role;
            this.sslblRoleName.Name = "sslblRoleName";
            this.sslblRoleName.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Shipment";
            // 
            // sslblShipment
            // 
            this.sslblShipment.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslblShipment.ForeColor = System.Drawing.Color.Blue;
            this.sslblShipment.Name = "sslblShipment";
            this.sslblShipment.Size = new System.Drawing.Size(16, 20);
            this.sslblShipment.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 20);
            this.toolStripStatusLabel2.Text = "Ref.No";
            // 
            // sslblRefName
            // 
            this.sslblRefName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslblRefName.ForeColor = System.Drawing.Color.Blue;
            this.sslblRefName.Name = "sslblRefName";
            this.sslblRefName.Size = new System.Drawing.Size(16, 20);
            this.sslblRefName.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusLabel3.Text = "App. Version";
            // 
            // ssLblAppVersion
            // 
            this.ssLblAppVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssLblAppVersion.ForeColor = System.Drawing.Color.Blue;
            this.ssLblAppVersion.Name = "ssLblAppVersion";
            this.ssLblAppVersion.Size = new System.Drawing.Size(16, 20);
            this.ssLblAppVersion.Text = "-";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(206, 6);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChemInform.Properties.Resources.wci_cas_react_screen_bg1_new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1362, 592);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WCI";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTaskTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createShipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskAssingnmentTSMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslblUserName;
        private System.Windows.Forms.ToolStripStatusLabel sslblRoleName;
        private System.Windows.Forms.ToolStripStatusLabel sslblShipment;
        private System.Windows.Forms.ToolStripStatusLabel sslblRefName;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentExportTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateTaskPreparationTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem shipmentStatusReportTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersStatusReportTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solventAgentsMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssLblAppVersion;
        private System.Windows.Forms.ToolStripMenuItem taskModificationTSMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deliveryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentDeliveryTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryStatusReportTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearWiseStatusReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveredSolventsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem userHourlyStatusReportTSMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}



