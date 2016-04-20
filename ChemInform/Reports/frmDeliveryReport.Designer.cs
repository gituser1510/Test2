namespace ChemInform.Reports
{
    partial class frmDeliveryReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGrids = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splContDelivMaster = new System.Windows.Forms.SplitContainer();
            this.lnkLbClearFilter = new System.Windows.Forms.LinkLabel();
            this.dgvDeliveryMaster = new System.Windows.Forms.DataGridView();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colDeliveredRefCount = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colDeliveredReactionCount = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colMdlStartNum = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colMdlEndNum = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colDeliveredBy = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colDeliveryDate = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDeliveredRefsCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeliveredRxnsCnt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDeliveriesCnt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcDeliveryDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lnklblAll = new System.Windows.Forms.LinkLabel();
            this.dgvDeliveryDetails = new System.Windows.Forms.DataGridView();
            this.colShipmentRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colClassType = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colRefRxnCount = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splcontSolvents = new System.Windows.Forms.SplitContainer();
            this.dgvDeliverySolvents = new System.Windows.Forms.DataGridView();
            this.colShipmentRef_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventName_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventMolFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solventRenderer = new MDL.Draw.Renderer.Renderer();
            this.pnlAssignContrls = new System.Windows.Forms.Panel();
            this.lblRxnsCnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRefsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.chkDeliveryDetails = new System.Windows.Forms.CheckBox();
            this.chkDeliveries = new System.Windows.Forms.CheckBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn8 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn9 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn10 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlGrids.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splContDelivMaster.Panel1.SuspendLayout();
            this.splContDelivMaster.Panel2.SuspendLayout();
            this.splContDelivMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tcDeliveryDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.splcontSolvents.Panel1.SuspendLayout();
            this.splcontSolvents.Panel2.SuspendLayout();
            this.splcontSolvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySolvents)).BeginInit();
            this.pnlAssignContrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGrids);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1086, 431);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlGrids
            // 
            this.pnlGrids.BackColor = System.Drawing.Color.White;
            this.pnlGrids.Controls.Add(this.pnlControls);
            this.pnlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrids.Location = new System.Drawing.Point(0, 0);
            this.pnlGrids.Name = "pnlGrids";
            this.pnlGrids.Size = new System.Drawing.Size(1086, 431);
            this.pnlGrids.TabIndex = 30;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.splitContainer1);
            this.pnlControls.Controls.Add(this.pnlAssignContrls);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1086, 431);
            this.pnlControls.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splContDelivMaster);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcDeliveryDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 396);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 83;
            // 
            // splContDelivMaster
            // 
            this.splContDelivMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContDelivMaster.Location = new System.Drawing.Point(0, 0);
            this.splContDelivMaster.Name = "splContDelivMaster";
            // 
            // splContDelivMaster.Panel1
            // 
            this.splContDelivMaster.Panel1.Controls.Add(this.lnkLbClearFilter);
            this.splContDelivMaster.Panel1.Controls.Add(this.dgvDeliveryMaster);
            // 
            // splContDelivMaster.Panel2
            // 
            this.splContDelivMaster.Panel2.Controls.Add(this.chart1);
            this.splContDelivMaster.Size = new System.Drawing.Size(1084, 170);
            this.splContDelivMaster.SplitterDistance = 621;
            this.splContDelivMaster.TabIndex = 84;
            // 
            // lnkLbClearFilter
            // 
            this.lnkLbClearFilter.AutoSize = true;
            this.lnkLbClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.lnkLbClearFilter.Location = new System.Drawing.Point(8, 5);
            this.lnkLbClearFilter.Name = "lnkLbClearFilter";
            this.lnkLbClearFilter.Size = new System.Drawing.Size(25, 17);
            this.lnkLbClearFilter.TabIndex = 10;
            this.lnkLbClearFilter.TabStop = true;
            this.lnkLbClearFilter.Text = "All";
            this.lnkLbClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbClearFilter_LinkClicked);
            // 
            // dgvDeliveryMaster
            // 
            this.dgvDeliveryMaster.AllowUserToAddRows = false;
            this.dgvDeliveryMaster.AllowUserToDeleteRows = false;
            this.dgvDeliveryMaster.AllowUserToResizeRows = false;
            this.dgvDeliveryMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeliveryMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeliveryId,
            this.colDeliveryName,
            this.colDeliveredRefCount,
            this.colDeliveredReactionCount,
            this.colMdlStartNum,
            this.colMdlEndNum,
            this.colDeliveredBy,
            this.colDeliveryDate});
            this.dgvDeliveryMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveryMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvDeliveryMaster.MultiSelect = false;
            this.dgvDeliveryMaster.Name = "dgvDeliveryMaster";
            this.dgvDeliveryMaster.ReadOnly = true;
            this.dgvDeliveryMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryMaster.Size = new System.Drawing.Size(621, 170);
            this.dgvDeliveryMaster.TabIndex = 1;
            this.dgvDeliveryMaster.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryMaster_CellEnter);
            this.dgvDeliveryMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDeliveries_DataBindingComplete);
            this.dgvDeliveryMaster.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDeliveries_DataError);
            this.dgvDeliveryMaster.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeliveries_RowPostPaint);
            this.dgvDeliveryMaster.BindingContextChanged += new System.EventHandler(this.dgvDeliveries_BindingContextChanged);
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.HeaderText = "DeliveryId";
            this.colDeliveryId.Name = "colDeliveryId";
            this.colDeliveryId.ReadOnly = true;
            this.colDeliveryId.Visible = false;
            // 
            // colDeliveryName
            // 
            this.colDeliveryName.HeaderText = "DeliveryName";
            this.colDeliveryName.Name = "colDeliveryName";
            this.colDeliveryName.ReadOnly = true;
            this.colDeliveryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDeliveredRefCount
            // 
            this.colDeliveredRefCount.HeaderText = "Refs";
            this.colDeliveredRefCount.Name = "colDeliveredRefCount";
            this.colDeliveredRefCount.ReadOnly = true;
            this.colDeliveredRefCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDeliveredReactionCount
            // 
            this.colDeliveredReactionCount.HeaderText = " Rxns";
            this.colDeliveredReactionCount.Name = "colDeliveredReactionCount";
            this.colDeliveredReactionCount.ReadOnly = true;
            this.colDeliveredReactionCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMdlStartNum
            // 
            this.colMdlStartNum.HeaderText = "MDLStart";
            this.colMdlStartNum.Name = "colMdlStartNum";
            this.colMdlStartNum.ReadOnly = true;
            this.colMdlStartNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMdlEndNum
            // 
            this.colMdlEndNum.HeaderText = "MDLEnd";
            this.colMdlEndNum.Name = "colMdlEndNum";
            this.colMdlEndNum.ReadOnly = true;
            this.colMdlEndNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDeliveredBy
            // 
            this.colDeliveredBy.HeaderText = "DeliveredBy";
            this.colDeliveredBy.Name = "colDeliveredBy";
            this.colDeliveredBy.ReadOnly = true;
            this.colDeliveredBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeliveredBy.Visible = false;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.HeaderText = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.ReadOnly = true;
            this.colDeliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(459, 170);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDeliveredRefsCnt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDeliveredRxnsCnt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalDeliveriesCnt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 28);
            this.panel1.TabIndex = 83;
            // 
            // lblDeliveredRefsCnt
            // 
            this.lblDeliveredRefsCnt.AutoSize = true;
            this.lblDeliveredRefsCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblDeliveredRefsCnt.Location = new System.Drawing.Point(317, 4);
            this.lblDeliveredRefsCnt.Name = "lblDeliveredRefsCnt";
            this.lblDeliveredRefsCnt.Size = new System.Drawing.Size(15, 17);
            this.lblDeliveredRefsCnt.TabIndex = 49;
            this.lblDeliveredRefsCnt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Delivered Refs. : ";
            // 
            // lblDeliveredRxnsCnt
            // 
            this.lblDeliveredRxnsCnt.AutoSize = true;
            this.lblDeliveredRxnsCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblDeliveredRxnsCnt.Location = new System.Drawing.Point(504, 4);
            this.lblDeliveredRxnsCnt.Name = "lblDeliveredRxnsCnt";
            this.lblDeliveredRxnsCnt.Size = new System.Drawing.Size(15, 17);
            this.lblDeliveredRxnsCnt.TabIndex = 47;
            this.lblDeliveredRxnsCnt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Delivered Rxns: ";
            // 
            // lblTotalDeliveriesCnt
            // 
            this.lblTotalDeliveriesCnt.AutoSize = true;
            this.lblTotalDeliveriesCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalDeliveriesCnt.Location = new System.Drawing.Point(109, 4);
            this.lblTotalDeliveriesCnt.Name = "lblTotalDeliveriesCnt";
            this.lblTotalDeliveriesCnt.Size = new System.Drawing.Size(15, 17);
            this.lblTotalDeliveriesCnt.TabIndex = 45;
            this.lblTotalDeliveriesCnt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Total Deliveries: ";
            // 
            // tcDeliveryDetails
            // 
            this.tcDeliveryDetails.Controls.Add(this.tabPage1);
            this.tcDeliveryDetails.Controls.Add(this.tabPage2);
            this.tcDeliveryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDeliveryDetails.Location = new System.Drawing.Point(0, 0);
            this.tcDeliveryDetails.Name = "tcDeliveryDetails";
            this.tcDeliveryDetails.SelectedIndex = 0;
            this.tcDeliveryDetails.Size = new System.Drawing.Size(1084, 190);
            this.tcDeliveryDetails.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lnklblAll);
            this.tabPage1.Controls.Add(this.dgvDeliveryDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Delivery References";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lnklblAll
            // 
            this.lnklblAll.AutoSize = true;
            this.lnklblAll.BackColor = System.Drawing.Color.Transparent;
            this.lnklblAll.Location = new System.Drawing.Point(11, 8);
            this.lnklblAll.Name = "lnklblAll";
            this.lnklblAll.Size = new System.Drawing.Size(25, 17);
            this.lnklblAll.TabIndex = 10;
            this.lnklblAll.TabStop = true;
            this.lnklblAll.Text = "All";
            this.lnklblAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAll_LinkClicked);
            // 
            // dgvDeliveryDetails
            // 
            this.dgvDeliveryDetails.AllowUserToAddRows = false;
            this.dgvDeliveryDetails.AllowUserToDeleteRows = false;
            this.dgvDeliveryDetails.AllowUserToResizeRows = false;
            this.dgvDeliveryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeliveryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRefID,
            this.colDR_ID,
            this.colRefName,
            this.colClassType,
            this.colRefRxnCount});
            this.dgvDeliveryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveryDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvDeliveryDetails.Name = "dgvDeliveryDetails";
            this.dgvDeliveryDetails.ReadOnly = true;
            this.dgvDeliveryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryDetails.Size = new System.Drawing.Size(1070, 154);
            this.dgvDeliveryDetails.TabIndex = 50;
            this.dgvDeliveryDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDeliveryDetails_DataBindingComplete);
            this.dgvDeliveryDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDeliveryDetails_DataError);
            this.dgvDeliveryDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeliveryDetails_RowPostPaint);
            this.dgvDeliveryDetails.BindingContextChanged += new System.EventHandler(this.dgvDeliveryDetails_BindingContextChanged);
            // 
            // colShipmentRefID
            // 
            this.colShipmentRefID.HeaderText = "ShipmentRefID";
            this.colShipmentRefID.Name = "colShipmentRefID";
            this.colShipmentRefID.ReadOnly = true;
            this.colShipmentRefID.Visible = false;
            // 
            // colDR_ID
            // 
            this.colDR_ID.HeaderText = "DR_ID";
            this.colDR_ID.Name = "colDR_ID";
            this.colDR_ID.ReadOnly = true;
            this.colDR_ID.Visible = false;
            // 
            // colRefName
            // 
            this.colRefName.HeaderText = "Reference Name";
            this.colRefName.Name = "colRefName";
            this.colRefName.ReadOnly = true;
            this.colRefName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colClassType
            // 
            this.colClassType.HeaderText = "Class";
            this.colClassType.Name = "colClassType";
            this.colClassType.ReadOnly = true;
            this.colClassType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colRefRxnCount
            // 
            this.colRefRxnCount.HeaderText = "RxnCount";
            this.colRefRxnCount.Name = "colRefRxnCount";
            this.colRefRxnCount.ReadOnly = true;
            this.colRefRxnCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splcontSolvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delivery Solvents";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splcontSolvents
            // 
            this.splcontSolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcontSolvents.Location = new System.Drawing.Point(3, 3);
            this.splcontSolvents.Name = "splcontSolvents";
            // 
            // splcontSolvents.Panel1
            // 
            this.splcontSolvents.Panel1.Controls.Add(this.dgvDeliverySolvents);
            // 
            // splcontSolvents.Panel2
            // 
            this.splcontSolvents.Panel2.Controls.Add(this.solventRenderer);
            this.splcontSolvents.Size = new System.Drawing.Size(1070, 154);
            this.splcontSolvents.SplitterDistance = 770;
            this.splcontSolvents.TabIndex = 1;
            // 
            // dgvDeliverySolvents
            // 
            this.dgvDeliverySolvents.AllowUserToAddRows = false;
            this.dgvDeliverySolvents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvDeliverySolvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliverySolvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeliverySolvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverySolvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRef_Solv,
            this.colSolventName_Solv,
            this.colSolventMolFile});
            this.dgvDeliverySolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliverySolvents.Location = new System.Drawing.Point(0, 0);
            this.dgvDeliverySolvents.Name = "dgvDeliverySolvents";
            this.dgvDeliverySolvents.ReadOnly = true;
            this.dgvDeliverySolvents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDeliverySolvents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDeliverySolvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliverySolvents.Size = new System.Drawing.Size(770, 154);
            this.dgvDeliverySolvents.TabIndex = 16;
            this.dgvDeliverySolvents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliverySolvents_RowEnter);
            this.dgvDeliverySolvents.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeliverySolvents_RowPostPaint);
            // 
            // colShipmentRef_Solv
            // 
            this.colShipmentRef_Solv.HeaderText = "Reference";
            this.colShipmentRef_Solv.Name = "colShipmentRef_Solv";
            this.colShipmentRef_Solv.ReadOnly = true;
            this.colShipmentRef_Solv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShipmentRef_Solv.Width = 121;
            // 
            // colSolventName_Solv
            // 
            this.colSolventName_Solv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSolventName_Solv.HeaderText = "Solvent Name";
            this.colSolventName_Solv.Name = "colSolventName_Solv";
            this.colSolventName_Solv.ReadOnly = true;
            // 
            // colSolventMolFile
            // 
            this.colSolventMolFile.FillWeight = 150F;
            this.colSolventMolFile.HeaderText = "SolventMolfile";
            this.colSolventMolFile.Name = "colSolventMolFile";
            this.colSolventMolFile.ReadOnly = true;
            this.colSolventMolFile.Visible = false;
            this.colSolventMolFile.Width = 150;
            // 
            // solventRenderer
            // 
            this.solventRenderer.AutoSizeStructure = true;
            this.solventRenderer.BinHexSketch = "010300044122001F4372656174656420627920416363656C7279734472617720342E312E312E34020" +
    "40000005805000000005905000000000B0B0005417269616C780000140200";
            this.solventRenderer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.solventRenderer.ChimeString = null;
            this.solventRenderer.CopyingEnabled = true;
            this.solventRenderer.DisplayOnEmpty = null;
            this.solventRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solventRenderer.FileName = null;
            this.solventRenderer.HighlightInfo = "";
            this.solventRenderer.IsBitmapFromOLE = false;
            this.solventRenderer.Location = new System.Drawing.Point(0, 0);
            molecule1.ArrowDir = MDL.Draw.ArrowDirType.No;
            molecule1.ArrowStyle = MDL.Draw.ArrowStyleType.Empty;
            molecule1.AtomValenceDisplay = true;
            molecule1.BaseFormBoxSetting = 0;
            molecule1.BondLineThickness = 0D;
            molecule1.CarbonLabelDisplay = false;
            molecule1.ChemLabelFont = null;
            molecule1.ChemLabelFontString = "(none)";
            molecule1.ColorAtomsByTypeInSketch = false;
            molecule1.ConfigLabelFont = null;
            molecule1.ConfigLabelFontString = "(none)";
            molecule1.ConvertRingBondIntoOneToMany = true;
            molecule1.Coords = null;
            molecule1.DashSpacing = 0.1D;
            molecule1.DisplaySinCys = false;
            molecule1.DisplaySulfurInCysSequence = false;
            molecule1.DoubleBondWidth = 0.18D;
            molecule1.FillColor = System.Drawing.Color.Empty;
            molecule1.FillStyle = MDL.Draw.ChemGraphicsObject.FillStyles.SOLID;
            molecule1.ForeColor = System.Drawing.Color.Empty;
            molecule1.ForeColorString = "";
            molecule1.ForSubsequenceQuery = false;
            molecule1.HighlightChildren = "";
            molecule1.HighlightColor = System.Drawing.Color.Blue;
            molecule1.HydrogenDisplayMode = MDL.Draw.Chemistry.Atom.HydrogenDisplayMode.Off;
            molecule1.Id = 3582;
            molecule1.Initial = "";
            molecule1.IsAModel = false;
            molecule1.IsARotatedModel = false;
            molecule1.KeepRSLabelsInSketch = true;
            molecule1.LastModifyChemText = -1;
            molecule1.MaintainXMLChildOrderFlag = false;
            molecule1.MustPerceiveStereo = true;
            molecule1.PenColor = System.Drawing.Color.Empty;
            molecule1.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            molecule1.PenStyleToken = 0;
            molecule1.PenWidth = ((byte)(0));
            molecule1.PenWidthUnit = MDL.Draw.ChemGraphicsObject.PenWidthUnits.Default;
            molecule1.RefId = 3582;
            molecule1.Replaced = false;
            molecule1.RgroupCleeanUpNeeded = false;
            molecule1.RgroupLabelsPresentFlag = false;
            molecule1.RLabelAtAbsCenter = "R";
            molecule1.RLabelAtAndCenter = "R*";
            molecule1.RLabelAtOrCenter = "(R)";
            molecule1.ScaleLabelsToBondLength = false;
            molecule1.Selected = false;
            molecule1.SequenceDictionary = null;
            molecule1.SequenceNeedsRealign = false;
            molecule1.SequenceView = MDL.Draw.Chemistry.Molecule.SequenceViewEnum.None;
            molecule1.Size = 0;
            molecule1.SkcWritten = false;
            molecule1.SkNumber = ((short)(0));
            molecule1.SLabelAtAbsCenter = "S";
            molecule1.SLabelAtAndCenter = "S*";
            molecule1.SLabelAtOrCenter = "(S)";
            molecule1.StandardBondLength = 0D;
            molecule1.StereoChemistryMode = MDL.Draw.Chemistry.Molecule.StereoChemistryModeEnum.And;
            molecule1.TextBorder = 0.1D;
            molecule1.Transparent = false;
            molecule1.UndoableEditListener = null;
            molecule1.WedgeWidth = 0.1D;
            molecule1.ZLayer = -96518;
            this.solventRenderer.Molecule = molecule1;
            this.solventRenderer.MolfileString = "";
            this.solventRenderer.Name = "solventRenderer";
            this.solventRenderer.PastingEnabled = true;
            this.solventRenderer.Preferences = displayPreferences1;
            this.solventRenderer.PreferencesFileName = "default.xml";
            this.solventRenderer.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.solventRenderer.Size = new System.Drawing.Size(296, 154);
            this.solventRenderer.SketchString = "AQMABEEiAB9DcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMS40AgQAAABYBQAAAABZBQAAAAALCwAFQ" +
    "XJpYWx4AAAUAgA=";
            this.solventRenderer.SmilesString = "";
            this.solventRenderer.TabIndex = 33;
            this.solventRenderer.URLEncodedMolfileString = "";
            // 
            // pnlAssignContrls
            // 
            this.pnlAssignContrls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAssignContrls.Controls.Add(this.lblRxnsCnt);
            this.pnlAssignContrls.Controls.Add(this.label8);
            this.pnlAssignContrls.Controls.Add(this.lblRefsCount);
            this.pnlAssignContrls.Controls.Add(this.label2);
            this.pnlAssignContrls.Controls.Add(this.lblOutputFolder);
            this.pnlAssignContrls.Controls.Add(this.btnBrowse);
            this.pnlAssignContrls.Controls.Add(this.txtOutputFolder);
            this.pnlAssignContrls.Controls.Add(this.chkDeliveryDetails);
            this.pnlAssignContrls.Controls.Add(this.chkDeliveries);
            this.pnlAssignContrls.Controls.Add(this.btnExportExcel);
            this.pnlAssignContrls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssignContrls.Location = new System.Drawing.Point(0, 396);
            this.pnlAssignContrls.Name = "pnlAssignContrls";
            this.pnlAssignContrls.Size = new System.Drawing.Size(1086, 35);
            this.pnlAssignContrls.TabIndex = 82;
            // 
            // lblRxnsCnt
            // 
            this.lblRxnsCnt.AutoSize = true;
            this.lblRxnsCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblRxnsCnt.Location = new System.Drawing.Point(196, 7);
            this.lblRxnsCnt.Name = "lblRxnsCnt";
            this.lblRxnsCnt.Size = new System.Drawing.Size(15, 17);
            this.lblRxnsCnt.TabIndex = 47;
            this.lblRxnsCnt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Rxns Count: ";
            // 
            // lblRefsCount
            // 
            this.lblRefsCount.AutoSize = true;
            this.lblRefsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblRefsCount.Location = new System.Drawing.Point(74, 7);
            this.lblRefsCount.Name = "lblRefsCount";
            this.lblRefsCount.Size = new System.Drawing.Size(15, 17);
            this.lblRefsCount.TabIndex = 45;
            this.lblRefsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ref.Count: ";
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Location = new System.Drawing.Point(246, 7);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(89, 17);
            this.lblOutputFolder.TabIndex = 43;
            this.lblOutputFolder.Text = "Output Folder";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(687, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 26);
            this.btnBrowse.TabIndex = 41;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Location = new System.Drawing.Point(340, 3);
            this.txtOutputFolder.MaxLength = 30;
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(341, 25);
            this.txtOutputFolder.TabIndex = 42;
            // 
            // chkDeliveryDetails
            // 
            this.chkDeliveryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeliveryDetails.AutoSize = true;
            this.chkDeliveryDetails.Location = new System.Drawing.Point(835, 6);
            this.chkDeliveryDetails.Name = "chkDeliveryDetails";
            this.chkDeliveryDetails.Size = new System.Drawing.Size(122, 21);
            this.chkDeliveryDetails.TabIndex = 6;
            this.chkDeliveryDetails.Text = "Delivery Details";
            this.chkDeliveryDetails.UseVisualStyleBackColor = true;
            // 
            // chkDeliveries
            // 
            this.chkDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeliveries.AutoSize = true;
            this.chkDeliveries.Location = new System.Drawing.Point(745, 6);
            this.chkDeliveries.Name = "chkDeliveries";
            this.chkDeliveries.Size = new System.Drawing.Size(86, 21);
            this.chkDeliveries.TabIndex = 6;
            this.chkDeliveries.Text = "Deliveries";
            this.chkDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(962, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(118, 26);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SHIPMENT_REF_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ShipmentRefId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "Delivery Name";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn1.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "Delivery Date";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn2.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "Delivered ref Count";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn3.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "Delivered reaction Count";
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn4.Width = 118;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "Mdl Start Number";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn5.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "Mdl End Number";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn6.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn7
            // 
            this.dataGridViewAutoFilterTextBoxColumn7.HeaderText = "Created by";
            this.dataGridViewAutoFilterTextBoxColumn7.Name = "dataGridViewAutoFilterTextBoxColumn7";
            this.dataGridViewAutoFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn7.Width = 117;
            // 
            // dataGridViewAutoFilterTextBoxColumn8
            // 
            this.dataGridViewAutoFilterTextBoxColumn8.HeaderText = "Created On";
            this.dataGridViewAutoFilterTextBoxColumn8.Name = "dataGridViewAutoFilterTextBoxColumn8";
            this.dataGridViewAutoFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn8.Width = 117;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "REFERENCE_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ref.Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewAutoFilterTextBoxColumn9
            // 
            this.dataGridViewAutoFilterTextBoxColumn9.HeaderText = "Delivery Id";
            this.dataGridViewAutoFilterTextBoxColumn9.Name = "dataGridViewAutoFilterTextBoxColumn9";
            this.dataGridViewAutoFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn9.Width = 469;
            // 
            // dataGridViewAutoFilterTextBoxColumn10
            // 
            this.dataGridViewAutoFilterTextBoxColumn10.HeaderText = "Shipment ref Id";
            this.dataGridViewAutoFilterTextBoxColumn10.Name = "dataGridViewAutoFilterTextBoxColumn10";
            this.dataGridViewAutoFilterTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn10.Width = 468;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TASK_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Task Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TASK_ALLOC_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Task Alloc Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ALLOCATION_STATUS";
            this.dataGridViewTextBoxColumn5.HeaderText = "Task Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USER_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ROLE_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "Role";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 140;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UR_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "UR_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ASSIGNED_CNT";
            this.dataGridViewTextBoxColumn9.HeaderText = "Assigned";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PROGRESS_CNT";
            this.dataGridViewTextBoxColumn10.HeaderText = "In Progress";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // frmDeliveryReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1086, 431);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmDeliveryReport";
            this.ShowIcon = false;
            this.Text = "Shipment Delivery Report";
            this.Load += new System.EventHandler(this.frmDeliveryReport_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlGrids.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splContDelivMaster.Panel1.ResumeLayout(false);
            this.splContDelivMaster.Panel1.PerformLayout();
            this.splContDelivMaster.Panel2.ResumeLayout(false);
            this.splContDelivMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcDeliveryDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splcontSolvents.Panel1.ResumeLayout(false);
            this.splcontSolvents.Panel2.ResumeLayout(false);
            this.splcontSolvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySolvents)).EndInit();
            this.pnlAssignContrls.ResumeLayout(false);
            this.pnlAssignContrls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlGrids;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlAssignContrls;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView dgvDeliveryMaster;
        private System.Windows.Forms.DataGridView dgvDeliveryDetails;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.CheckBox chkDeliveryDetails;
        private System.Windows.Forms.CheckBox chkDeliveries;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.LinkLabel lnkLbClearFilter;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn7;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn8;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn10;
        private System.Windows.Forms.LinkLabel lnklblAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDR_ID;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colRefName;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colClassType;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colRefRxnCount;
        private System.Windows.Forms.Label lblRxnsCnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRefsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeliveredRxnsCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDeliveriesCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeliveredRefsCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splContDelivMaster;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colDeliveryName;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colDeliveredRefCount;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colDeliveredReactionCount;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colMdlStartNum;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colMdlEndNum;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colDeliveredBy;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colDeliveryDate;
        private System.Windows.Forms.TabControl tcDeliveryDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splcontSolvents;
        private System.Windows.Forms.DataGridView dgvDeliverySolvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRef_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventName_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventMolFile;
        private MDL.Draw.Renderer.Renderer solventRenderer;

    }
}