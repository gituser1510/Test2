namespace ChemInform
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblUserNameValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblSep = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblRoleName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRoleNameValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblSep1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.taskSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblUserName,
            this.tssLblUserNameValue,
            this.tsslblSep,
            this.tssLblRoleName,
            this.tsslRoleNameValue,
            this.tssLblSep1,
            this.tssLblDataBase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1047, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLblUserName
            // 
            this.tssLblUserName.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblUserName.ForeColor = System.Drawing.Color.Black;
            this.tssLblUserName.Name = "tssLblUserName";
            this.tssLblUserName.Size = new System.Drawing.Size(72, 17);
            this.tssLblUserName.Text = "User Name:";
            // 
            // tssLblUserNameValue
            // 
            this.tssLblUserNameValue.ForeColor = System.Drawing.Color.Blue;
            this.tssLblUserNameValue.Name = "tssLblUserNameValue";
            this.tssLblUserNameValue.Size = new System.Drawing.Size(10, 17);
            this.tssLblUserNameValue.Text = " ";
            // 
            // tsslblSep
            // 
            this.tsslblSep.Name = "tsslblSep";
            this.tsslblSep.Size = new System.Drawing.Size(16, 17);
            this.tsslblSep.Text = " | ";
            // 
            // tssLblRoleName
            // 
            this.tssLblRoleName.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblRoleName.Name = "tssLblRoleName";
            this.tssLblRoleName.Size = new System.Drawing.Size(71, 17);
            this.tssLblRoleName.Text = "Role Name:";
            // 
            // tsslRoleNameValue
            // 
            this.tsslRoleNameValue.ForeColor = System.Drawing.Color.Blue;
            this.tsslRoleNameValue.Name = "tsslRoleNameValue";
            this.tsslRoleNameValue.Size = new System.Drawing.Size(10, 17);
            this.tsslRoleNameValue.Text = " ";
            // 
            // tssLblSep1
            // 
            this.tssLblSep1.Name = "tssLblSep1";
            this.tssLblSep1.Size = new System.Drawing.Size(10, 17);
            this.tssLblSep1.Text = "|";
            // 
            // tssLblDataBase
            // 
            this.tssLblDataBase.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblDataBase.ForeColor = System.Drawing.Color.Green;
            this.tssLblDataBase.Name = "tssLblDataBase";
            this.tssLblDataBase.Size = new System.Drawing.Size(60, 17);
            this.tssLblDataBase.Text = "Database:";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.logInToolStripMenuItem.Text = "&Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.logOffToolStripMenuItem.Text = "Log &Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.userManagementToolStripMenuItem.Text = "&User Management";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create &User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // shipmentToolStripMenuItem
            // 
            this.shipmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createShipmentToolStripMenuItem});
            this.shipmentToolStripMenuItem.Name = "shipmentToolStripMenuItem";
            this.shipmentToolStripMenuItem.Size = new System.Drawing.Size(144, 19);
            this.shipmentToolStripMenuItem.Text = "Shipment &Management";
            // 
            // createShipmentToolStripMenuItem
            // 
            this.createShipmentToolStripMenuItem.Name = "createShipmentToolStripMenuItem";
            this.createShipmentToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.createShipmentToolStripMenuItem.Text = "Create &Shipment";
            this.createShipmentToolStripMenuItem.Click += new System.EventHandler(this.createShipmentToolStripMenuItem_Click);
            // 
            // taskManagementToolStripMenuItem
            // 
            this.taskManagementToolStripMenuItem.Name = "taskManagementToolStripMenuItem";
            this.taskManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.taskManagementToolStripMenuItem.Text = "&Task Management";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.versionToolStripMenuItem.Text = "&Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.taskSheetToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.shipmentToolStripMenuItem,
            this.taskManagementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1047, 25);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "MenuStrip";
            // 
            // taskSheetToolStripMenuItem
            // 
            this.taskSheetToolStripMenuItem.Name = "taskSheetToolStripMenuItem";
            this.taskSheetToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.taskSheetToolStripMenuItem.Text = "Task &Sheet";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1047, 406);
            this.pnlMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1047, 453);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bio Indexing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssLblUserNameValue;
        private System.Windows.Forms.ToolStripStatusLabel tsslblSep;
        private System.Windows.Forms.ToolStripStatusLabel tssLblRoleName;
        private System.Windows.Forms.ToolStripStatusLabel tsslRoleNameValue;
        private System.Windows.Forms.ToolStripStatusLabel tssLblSep1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblDataBase;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createShipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem taskSheetToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;

    }
}



