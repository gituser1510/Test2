namespace ChemInform
{
    partial class frmTaskAssignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGrids = new System.Windows.Forms.Panel();
            this.splCont_Main = new System.Windows.Forms.SplitContainer();
            this.splCont = new System.Windows.Forms.SplitContainer();
            this.dgvUnAssignedRefs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTaskCounts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.cmbCurator = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtQC = new System.Windows.Forms.TextBox();
            this.lblCurator = new System.Windows.Forms.Label();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.lblQC = new System.Windows.Forms.Label();
            this.txtReviewer = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.dgvAssignedRefs = new System.Windows.Forms.DataGridView();
            this.lblAssTANS = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblClassType = new System.Windows.Forms.Label();
            this.txtClassType = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.txtTANSrch = new System.Windows.Forms.TextBox();
            this.lblTAN = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvl_Doc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvl_Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleName_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedCnt_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInPrgressCnt_TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlGrids.SuspendLayout();
            this.splCont_Main.Panel1.SuspendLayout();
            this.splCont_Main.Panel2.SuspendLayout();
            this.splCont_Main.SuspendLayout();
            this.splCont.Panel1.SuspendLayout();
            this.splCont.Panel2.SuspendLayout();
            this.splCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedRefs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCounts)).BeginInit();
            this.pnlUsers.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedRefs)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGrids);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1102, 666);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlGrids
            // 
            this.pnlGrids.Controls.Add(this.splCont_Main);
            this.pnlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrids.Location = new System.Drawing.Point(0, 76);
            this.pnlGrids.Name = "pnlGrids";
            this.pnlGrids.Size = new System.Drawing.Size(1102, 590);
            this.pnlGrids.TabIndex = 30;
            // 
            // splCont_Main
            // 
            this.splCont_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCont_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont_Main.Location = new System.Drawing.Point(0, 0);
            this.splCont_Main.Name = "splCont_Main";
            this.splCont_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCont_Main.Panel1
            // 
            this.splCont_Main.Panel1.Controls.Add(this.splCont);
            this.splCont_Main.Panel1.Controls.Add(this.pnlUsers);
            // 
            // splCont_Main.Panel2
            // 
            this.splCont_Main.Panel2.Controls.Add(this.pnlButtons);
            this.splCont_Main.Size = new System.Drawing.Size(1102, 590);
            this.splCont_Main.SplitterDistance = 436;
            this.splCont_Main.TabIndex = 30;
            // 
            // splCont
            // 
            this.splCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont.Location = new System.Drawing.Point(0, 0);
            this.splCont.Name = "splCont";
            // 
            // splCont.Panel1
            // 
            this.splCont.Panel1.Controls.Add(this.dgvUnAssignedRefs);
            this.splCont.Panel1.Controls.Add(this.label3);
            // 
            // splCont.Panel2
            // 
            this.splCont.Panel2.Controls.Add(this.dgvTaskCounts);
            this.splCont.Panel2.Controls.Add(this.label2);
            this.splCont.Size = new System.Drawing.Size(1102, 403);
            this.splCont.SplitterDistance = 435;
            this.splCont.TabIndex = 29;
            // 
            // dgvUnAssignedRefs
            // 
            this.dgvUnAssignedRefs.AllowUserToAddRows = false;
            this.dgvUnAssignedRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaShell;
            this.dgvUnAssignedRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUnAssignedRefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnAssignedRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnAssignedRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnAssignedRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAvl_Doc_ID,
            this.colAvl_Ref,
            this.colSysClassType});
            this.dgvUnAssignedRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnAssignedRefs.Location = new System.Drawing.Point(0, 25);
            this.dgvUnAssignedRefs.Name = "dgvUnAssignedRefs";
            this.dgvUnAssignedRefs.ReadOnly = true;
            this.dgvUnAssignedRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnAssignedRefs.Size = new System.Drawing.Size(433, 376);
            this.dgvUnAssignedRefs.TabIndex = 19;
            this.dgvUnAssignedRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGrid_TANs_RowPostPaint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Available References";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTaskCounts
            // 
            this.dgvTaskCounts.AllowUserToAddRows = false;
            this.dgvTaskCounts.AllowUserToDeleteRows = false;
            this.dgvTaskCounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaShell;
            this.dgvTaskCounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTaskCounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTaskCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskCounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName_TC,
            this.colRoleName_TC,
            this.colAssignedCnt_TC,
            this.colInPrgressCnt_TC});
            this.dgvTaskCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskCounts.Location = new System.Drawing.Point(0, 25);
            this.dgvTaskCounts.MultiSelect = false;
            this.dgvTaskCounts.Name = "dgvTaskCounts";
            this.dgvTaskCounts.ReadOnly = true;
            this.dgvTaskCounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskCounts.Size = new System.Drawing.Size(661, 376);
            this.dgvTaskCounts.TabIndex = 2;
            this.dgvTaskCounts.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTaskCounts_RowPostPaint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(661, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Module Users";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.White;
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsers.Controls.Add(this.cmbCurator);
            this.pnlUsers.Controls.Add(this.btnAssign);
            this.pnlUsers.Controls.Add(this.txtQC);
            this.pnlUsers.Controls.Add(this.lblCurator);
            this.pnlUsers.Controls.Add(this.lblReviewer);
            this.pnlUsers.Controls.Add(this.lblQC);
            this.pnlUsers.Controls.Add(this.txtReviewer);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsers.Location = new System.Drawing.Point(0, 403);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1102, 33);
            this.pnlUsers.TabIndex = 36;
            // 
            // cmbCurator
            // 
            this.cmbCurator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurator.FormattingEnabled = true;
            this.cmbCurator.Location = new System.Drawing.Point(90, 3);
            this.cmbCurator.Name = "cmbCurator";
            this.cmbCurator.Size = new System.Drawing.Size(222, 25);
            this.cmbCurator.TabIndex = 3;
            this.cmbCurator.SelectedIndexChanged += new System.EventHandler(this.cmbCurator_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Location = new System.Drawing.Point(1025, 1);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(72, 29);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtQC
            // 
            this.txtQC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQC.Location = new System.Drawing.Point(750, 3);
            this.txtQC.Name = "txtQC";
            this.txtQC.ReadOnly = true;
            this.txtQC.Size = new System.Drawing.Size(238, 25);
            this.txtQC.TabIndex = 35;
            // 
            // lblCurator
            // 
            this.lblCurator.AutoSize = true;
            this.lblCurator.Location = new System.Drawing.Point(31, 7);
            this.lblCurator.Name = "lblCurator";
            this.lblCurator.Size = new System.Drawing.Size(53, 17);
            this.lblCurator.TabIndex = 30;
            this.lblCurator.Text = "Analyst";
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(328, 7);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(65, 17);
            this.lblReviewer.TabIndex = 32;
            this.lblReviewer.Text = "Reviewer";
            // 
            // lblQC
            // 
            this.lblQC.AutoSize = true;
            this.lblQC.Location = new System.Drawing.Point(715, 7);
            this.lblQC.Name = "lblQC";
            this.lblQC.Size = new System.Drawing.Size(29, 17);
            this.lblQC.TabIndex = 33;
            this.lblQC.Text = "QC";
            // 
            // txtReviewer
            // 
            this.txtReviewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReviewer.Location = new System.Drawing.Point(399, 3);
            this.txtReviewer.Name = "txtReviewer";
            this.txtReviewer.ReadOnly = true;
            this.txtReviewer.Size = new System.Drawing.Size(278, 25);
            this.txtReviewer.TabIndex = 34;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.dgvAssignedRefs);
            this.pnlButtons.Controls.Add(this.lblAssTANS);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1100, 148);
            this.pnlButtons.TabIndex = 5;
            // 
            // dgvAssignedRefs
            // 
            this.dgvAssignedRefs.AllowUserToAddRows = false;
            this.dgvAssignedRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaShell;
            this.dgvAssignedRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAssignedRefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedRefs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignedRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedRefs.Location = new System.Drawing.Point(0, 20);
            this.dgvAssignedRefs.Name = "dgvAssignedRefs";
            this.dgvAssignedRefs.ReadOnly = true;
            this.dgvAssignedRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedRefs.Size = new System.Drawing.Size(1100, 128);
            this.dgvAssignedRefs.TabIndex = 22;
            this.dgvAssignedRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGridAssigedTANs_RowPostPaint);
            // 
            // lblAssTANS
            // 
            this.lblAssTANS.BackColor = System.Drawing.SystemColors.Info;
            this.lblAssTANS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAssTANS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssTANS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssTANS.Location = new System.Drawing.Point(0, 0);
            this.lblAssTANS.Name = "lblAssTANS";
            this.lblAssTANS.Size = new System.Drawing.Size(1100, 20);
            this.lblAssTANS.TabIndex = 21;
            this.lblAssTANS.Text = "Assigned References";
            this.lblAssTANS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.btnGet);
            this.pnlTop.Controls.Add(this.cmbShipment);
            this.pnlTop.Controls.Add(this.lblPhase);
            this.pnlTop.Controls.Add(this.lblClassType);
            this.pnlTop.Controls.Add(this.txtClassType);
            this.pnlTop.Controls.Add(this.lblYear);
            this.pnlTop.Controls.Add(this.txtYear);
            this.pnlTop.Controls.Add(this.cmbModule);
            this.pnlTop.Controls.Add(this.lblModule);
            this.pnlTop.Controls.Add(this.txtTANSrch);
            this.pnlTop.Controls.Add(this.lblTAN);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1102, 76);
            this.pnlTop.TabIndex = 29;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(584, 3);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 25);
            this.btnGet.TabIndex = 31;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Location = new System.Drawing.Point(476, 7);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(73, 17);
            this.lblClassType.TabIndex = 30;
            this.lblClassType.Text = "Class Type";
            this.lblClassType.Visible = false;
            // 
            // txtClassType
            // 
            this.txtClassType.Location = new System.Drawing.Point(553, 3);
            this.txtClassType.Name = "txtClassType";
            this.txtClassType.Size = new System.Drawing.Size(100, 25);
            this.txtClassType.TabIndex = 29;
            this.txtClassType.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(327, 7);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.TabIndex = 28;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(367, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 25);
            this.txtYear.TabIndex = 27;
            this.txtYear.Visible = false;
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "Task Preparation",
            "Reaction Analysis"});
            this.cmbModule.Location = new System.Drawing.Point(91, 3);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(220, 25);
            this.cmbModule.TabIndex = 26;
            this.cmbModule.SelectedIndexChanged += new System.EventHandler(this.cmbModule_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(33, 7);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(52, 17);
            this.lblModule.TabIndex = 25;
            this.lblModule.Text = "Module";
            // 
            // cmbShipment
            // 
            this.cmbShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Items.AddRange(new object[] {
            "rxnfile.800002",
            "rxnfile.800003",
            "rxnfile.800004"});
            this.cmbShipment.Location = new System.Drawing.Point(378, 3);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(197, 25);
            this.cmbShipment.TabIndex = 16;
            this.cmbShipment.SelectionChangeCommitted += new System.EventHandler(this.cmbShipment_SelectionChangeCommitted);
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(313, 7);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(62, 17);
            this.lblPhase.TabIndex = 15;
            this.lblPhase.Text = "Shipment";
            // 
            // txtTANSrch
            // 
            this.txtTANSrch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTANSrch.BackColor = System.Drawing.Color.White;
            this.txtTANSrch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTANSrch.ForeColor = System.Drawing.Color.Blue;
            this.txtTANSrch.Location = new System.Drawing.Point(91, 32);
            this.txtTANSrch.Multiline = true;
            this.txtTANSrch.Name = "txtTANSrch";
            this.txtTANSrch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTANSrch.Size = new System.Drawing.Size(1007, 39);
            this.txtTANSrch.TabIndex = 23;
            this.txtTANSrch.TextChanged += new System.EventHandler(this.txtTANSrch_TextChanged);
            // 
            // lblTAN
            // 
            this.lblTAN.AutoSize = true;
            this.lblTAN.ForeColor = System.Drawing.Color.Black;
            this.lblTAN.Location = new System.Drawing.Point(2, 35);
            this.lblTAN.Name = "lblTAN";
            this.lblTAN.Size = new System.Drawing.Size(79, 17);
            this.lblTAN.TabIndex = 24;
            this.lblTAN.Text = "Ref. Search";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "BT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 47.95918F;
            this.dataGridViewTextBoxColumn2.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 47.95918F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 87.85046F;
            this.dataGridViewTextBoxColumn4.HeaderText = "TANStatus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ASSIGNED_CNT";
            dataGridViewCellStyle9.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn5.HeaderText = "Rxns";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 45;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USER_NAME";
            dataGridViewCellStyle10.NullValue = "0";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn6.HeaderText = "Stages";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 48;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ROLE_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "DocClass";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // colAvl_Doc_ID
            // 
            this.colAvl_Doc_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAvl_Doc_ID.HeaderText = "Doc_ID";
            this.colAvl_Doc_ID.Name = "colAvl_Doc_ID";
            this.colAvl_Doc_ID.ReadOnly = true;
            this.colAvl_Doc_ID.Visible = false;
            this.colAvl_Doc_ID.Width = 20;
            // 
            // colAvl_Ref
            // 
            this.colAvl_Ref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAvl_Ref.FillWeight = 72.85299F;
            this.colAvl_Ref.HeaderText = "Ref.No";
            this.colAvl_Ref.Name = "colAvl_Ref";
            this.colAvl_Ref.ReadOnly = true;
            // 
            // colSysClassType
            // 
            this.colSysClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSysClassType.FillWeight = 75.10619F;
            this.colSysClassType.HeaderText = "ClassType";
            this.colSysClassType.Name = "colSysClassType";
            this.colSysClassType.ReadOnly = true;
            // 
            // colUserName_TC
            // 
            this.colUserName_TC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName_TC.HeaderText = "UserName";
            this.colUserName_TC.Name = "colUserName_TC";
            this.colUserName_TC.ReadOnly = true;
            // 
            // colRoleName_TC
            // 
            this.colRoleName_TC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRoleName_TC.HeaderText = "Role";
            this.colRoleName_TC.Name = "colRoleName_TC";
            this.colRoleName_TC.ReadOnly = true;
            // 
            // colAssignedCnt_TC
            // 
            this.colAssignedCnt_TC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAssignedCnt_TC.DataPropertyName = "ASSIGNED_CNT";
            this.colAssignedCnt_TC.HeaderText = "Assigned";
            this.colAssignedCnt_TC.Name = "colAssignedCnt_TC";
            this.colAssignedCnt_TC.ReadOnly = true;
            this.colAssignedCnt_TC.Width = 80;
            // 
            // colInPrgressCnt_TC
            // 
            this.colInPrgressCnt_TC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInPrgressCnt_TC.DataPropertyName = "PROGRESS_CNT";
            this.colInPrgressCnt_TC.HeaderText = "InProgress";
            this.colInPrgressCnt_TC.Name = "colInPrgressCnt_TC";
            this.colInPrgressCnt_TC.ReadOnly = true;
            this.colInPrgressCnt_TC.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ALLOCATED_CNT";
            this.dataGridViewTextBoxColumn8.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "USER_NAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ROLE_NAME";
            this.dataGridViewTextBoxColumn10.HeaderText = "Role";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ALLOCATED_CNT";
            this.dataGridViewTextBoxColumn11.HeaderText = "Allocated";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ASSIGNED_CNT";
            this.dataGridViewTextBoxColumn12.HeaderText = "Assigned";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PROGRESS_CNT";
            this.dataGridViewTextBoxColumn13.HeaderText = "InProgress";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "COMPLETED_CNT";
            this.dataGridViewTextBoxColumn14.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // frmTaskAssignment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 666);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmTaskAssignment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Assignment";
            this.Load += new System.EventHandler(this.frmTaskAssignment_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlGrids.ResumeLayout(false);
            this.splCont_Main.Panel1.ResumeLayout(false);
            this.splCont_Main.Panel2.ResumeLayout(false);
            this.splCont_Main.ResumeLayout(false);
            this.splCont.Panel1.ResumeLayout(false);
            this.splCont.Panel2.ResumeLayout(false);
            this.splCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedRefs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCounts)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedRefs)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cmbCurator;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.DataGridView dgvUnAssignedRefs;
        private System.Windows.Forms.DataGridView dgvAssignedRefs;
        private System.Windows.Forms.Label lblAssTANS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtTANSrch;
        private System.Windows.Forms.Label lblTAN;
        private System.Windows.Forms.Panel pnlGrids;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtQC;
        private System.Windows.Forms.TextBox txtReviewer;
        private System.Windows.Forms.Label lblQC;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.Label lblCurator;
        private System.Windows.Forms.SplitContainer splCont;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.DataGridView dgvTaskCounts;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.SplitContainer splCont_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedCnt_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInPrgressCnt_TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvl_Doc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvl_Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysClassType;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.TextBox txtClassType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGet;
    }
}