namespace ChemInform
{
    partial class frmTaskSheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskSheet));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvAssignTANs = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBName = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.lblTanStatus = new System.Windows.Forms.Label();
            this.txtTanStatus = new System.Windows.Forms.TextBox();
            this.lblTAN = new System.Windows.Forms.Label();
            this.txtTAN = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskAllocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentRefNo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewDownLoad = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRxnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsReAssigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsRejected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colManagerURId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnalystStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnalystName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQCStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTANs)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvAssignTANs);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1180, 558);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvAssignTANs
            // 
            this.dgvAssignTANs.AllowUserToAddRows = false;
            this.dgvAssignTANs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAssignTANs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignTANs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssignTANs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignTANs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskID,
            this.colTaskAllocationID,
            this.colShipmentRefID,
            this.colShipmentRefNo,
            this.colDocType,
            this.colViewDownLoad,
            this.colRxnCount,
            this.colClassType,
            this.colShipmentName,
            this.colIssue,
            this.colYear,
            this.colSysClassType,
            this.colTaskStatus,
            this.colIsReAssigned,
            this.colIsRejected,
            this.colManagerURId,
            this.colAnalystStatus,
            this.colAnalystName,
            this.colReviewerName,
            this.colReviewStatus,
            this.colQCStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignTANs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssignTANs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignTANs.Location = new System.Drawing.Point(0, 35);
            this.dgvAssignTANs.Name = "dgvAssignTANs";
            this.dgvAssignTANs.ReadOnly = true;
            this.dgvAssignTANs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssignTANs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvAssignTANs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAssignTANs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignTANs.Size = new System.Drawing.Size(1180, 523);
            this.dgvAssignTANs.TabIndex = 3;
            this.dgvAssignTANs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignTANs_CellContentClick);
            this.dgvAssignTANs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAssignTANs_RowPostPaint);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblBName);
            this.pnlTop.Controls.Add(this.txtBName);
            this.pnlTop.Controls.Add(this.lblTanStatus);
            this.pnlTop.Controls.Add(this.txtTanStatus);
            this.pnlTop.Controls.Add(this.lblTAN);
            this.pnlTop.Controls.Add(this.txtTAN);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1180, 35);
            this.pnlTop.TabIndex = 11;
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Location = new System.Drawing.Point(3, 8);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(102, 17);
            this.lblBName.TabIndex = 13;
            this.lblBName.Text = "Shipment Name";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(108, 4);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(201, 25);
            this.txtBName.TabIndex = 12;
            this.txtBName.TextChanged += new System.EventHandler(this.txtTAN_TextChanged);
            this.txtBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBName_KeyPress);
            // 
            // lblTanStatus
            // 
            this.lblTanStatus.AutoSize = true;
            this.lblTanStatus.Location = new System.Drawing.Point(619, 8);
            this.lblTanStatus.Name = "lblTanStatus";
            this.lblTanStatus.Size = new System.Drawing.Size(74, 17);
            this.lblTanStatus.TabIndex = 17;
            this.lblTanStatus.Text = "Ref. Status";
            // 
            // txtTanStatus
            // 
            this.txtTanStatus.Location = new System.Drawing.Point(703, 4);
            this.txtTanStatus.Name = "txtTanStatus";
            this.txtTanStatus.Size = new System.Drawing.Size(472, 25);
            this.txtTanStatus.TabIndex = 16;
            this.txtTanStatus.TextChanged += new System.EventHandler(this.txtTAN_TextChanged);
            // 
            // lblTAN
            // 
            this.lblTAN.AutoSize = true;
            this.lblTAN.Location = new System.Drawing.Point(404, 8);
            this.lblTAN.Name = "lblTAN";
            this.lblTAN.Size = new System.Drawing.Size(52, 17);
            this.lblTAN.TabIndex = 11;
            this.lblTAN.Text = "Ref.No";
            // 
            // txtTAN
            // 
            this.txtTAN.Location = new System.Drawing.Point(458, 4);
            this.txtTAN.MaxLength = 9;
            this.txtTAN.Name = "txtTAN";
            this.txtTAN.Size = new System.Drawing.Size(121, 25);
            this.txtTAN.TabIndex = 8;
            this.txtTAN.TextChanged += new System.EventHandler(this.txtTAN_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "BTID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Application";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 94.08713F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Module";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewLinkColumn1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLinkColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLinkColumn1.FillWeight = 75.26971F;
            this.dataGridViewLinkColumn1.HeaderText = "TAN";
            this.dataGridViewLinkColumn1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.Text = "";
            this.dataGridViewLinkColumn1.TrackVisitedState = false;
            this.dataGridViewLinkColumn1.Width = 97;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 47.04356F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ChemInform.Properties.Resources.file_extension_pdf;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Download Pdf";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.FillWeight = 94.08713F;
            this.dataGridViewTextBoxColumn4.HeaderText = "DocClass";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.FillWeight = 94.08713F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 385;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.FillWeight = 28.22614F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Batch Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 122;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 28.22614F;
            this.dataGridViewTextBoxColumn7.HeaderText = "B.No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.FillWeight = 300F;
            this.dataGridViewTextBoxColumn8.HeaderText = "TAN Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.FillWeight = 300F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Manager";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Manager User Role Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "N";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsReAssigned";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "Y";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn2.FalseValue = "N";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsRejected";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "Y";
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Analyst ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Analyst ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.HeaderText = "AllocationStatus";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.HeaderText = "Manager User Role Id";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.HeaderText = "Status";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.HeaderText = "ReviewStatus";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.HeaderText = "QCStatus";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn2.FillWeight = 47.04356F;
            this.dataGridViewLinkColumn2.HeaderText = "Indexing";
            this.dataGridViewLinkColumn2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Text = "Indexing";
            this.dataGridViewLinkColumn2.TrackVisitedState = false;
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn2.Width = 50;
            // 
            // dataGridViewLinkColumn3
            // 
            this.dataGridViewLinkColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn3.FillWeight = 47.04356F;
            this.dataGridViewLinkColumn3.HeaderText = "View";
            this.dataGridViewLinkColumn3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn3.Name = "dataGridViewLinkColumn3";
            this.dataGridViewLinkColumn3.ReadOnly = true;
            this.dataGridViewLinkColumn3.Text = "PDF";
            this.dataGridViewLinkColumn3.TrackVisitedState = false;
            this.dataGridViewLinkColumn3.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn3.Width = 40;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn4.FillWeight = 47.04356F;
            this.dataGridViewLinkColumn4.HeaderText = "NUMs";
            this.dataGridViewLinkColumn4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.ReadOnly = true;
            this.dataGridViewLinkColumn4.Text = "NUMs";
            this.dataGridViewLinkColumn4.TrackVisitedState = false;
            this.dataGridViewLinkColumn4.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn4.Width = 50;
            // 
            // colTaskID
            // 
            this.colTaskID.HeaderText = "TaskID";
            this.colTaskID.Name = "colTaskID";
            this.colTaskID.ReadOnly = true;
            this.colTaskID.Visible = false;
            // 
            // colTaskAllocationID
            // 
            this.colTaskAllocationID.HeaderText = "TaskAllocationID";
            this.colTaskAllocationID.Name = "colTaskAllocationID";
            this.colTaskAllocationID.ReadOnly = true;
            this.colTaskAllocationID.Visible = false;
            // 
            // colShipmentRefID
            // 
            this.colShipmentRefID.HeaderText = "DocID";
            this.colShipmentRefID.Name = "colShipmentRefID";
            this.colShipmentRefID.ReadOnly = true;
            this.colShipmentRefID.Visible = false;
            // 
            // colShipmentRefNo
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShipmentRefNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colShipmentRefNo.FillWeight = 75.26971F;
            this.colShipmentRefNo.HeaderText = "ReferenceNo";
            this.colShipmentRefNo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colShipmentRefNo.Name = "colShipmentRefNo";
            this.colShipmentRefNo.ReadOnly = true;
            this.colShipmentRefNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShipmentRefNo.Text = "";
            this.colShipmentRefNo.TrackVisitedState = false;
            this.colShipmentRefNo.Width = 120;
            // 
            // colDocType
            // 
            this.colDocType.HeaderText = "Type";
            this.colDocType.Name = "colDocType";
            this.colDocType.ReadOnly = true;
            // 
            // colViewDownLoad
            // 
            this.colViewDownLoad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.colViewDownLoad.DefaultCellStyle = dataGridViewCellStyle3;
            this.colViewDownLoad.FillWeight = 47.04356F;
            this.colViewDownLoad.HeaderText = "View";
            this.colViewDownLoad.Image = global::ChemInform.Properties.Resources.file_extension_pdf;
            this.colViewDownLoad.Name = "colViewDownLoad";
            this.colViewDownLoad.ReadOnly = true;
            this.colViewDownLoad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colViewDownLoad.ToolTipText = "Download Pdf";
            this.colViewDownLoad.Width = 40;
            // 
            // colRxnCount
            // 
            this.colRxnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnCount.HeaderText = "RxnCount";
            this.colRxnCount.Name = "colRxnCount";
            this.colRxnCount.ReadOnly = true;
            this.colRxnCount.Width = 60;
            // 
            // colClassType
            // 
            this.colClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClassType.HeaderText = "Type";
            this.colClassType.Name = "colClassType";
            this.colClassType.ReadOnly = true;
            this.colClassType.Width = 50;
            // 
            // colShipmentName
            // 
            this.colShipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colShipmentName.HeaderText = "Shipment";
            this.colShipmentName.Name = "colShipmentName";
            this.colShipmentName.ReadOnly = true;
            this.colShipmentName.Width = 120;
            // 
            // colIssue
            // 
            this.colIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIssue.HeaderText = "Issue";
            this.colIssue.Name = "colIssue";
            this.colIssue.ReadOnly = true;
            this.colIssue.Width = 40;
            // 
            // colYear
            // 
            this.colYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Width = 40;
            // 
            // colSysClassType
            // 
            this.colSysClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSysClassType.HeaderText = "Class";
            this.colSysClassType.Name = "colSysClassType";
            this.colSysClassType.ReadOnly = true;
            this.colSysClassType.Width = 40;
            // 
            // colTaskStatus
            // 
            this.colTaskStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTaskStatus.HeaderText = "Task Status";
            this.colTaskStatus.Name = "colTaskStatus";
            this.colTaskStatus.ReadOnly = true;
            // 
            // colIsReAssigned
            // 
            this.colIsReAssigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsReAssigned.FalseValue = "N";
            this.colIsReAssigned.HeaderText = "ReAssigned";
            this.colIsReAssigned.Name = "colIsReAssigned";
            this.colIsReAssigned.ReadOnly = true;
            this.colIsReAssigned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsReAssigned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsReAssigned.TrueValue = "Y";
            this.colIsReAssigned.Width = 50;
            // 
            // colIsRejected
            // 
            this.colIsRejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsRejected.FalseValue = "N";
            this.colIsRejected.HeaderText = "Rejected";
            this.colIsRejected.Name = "colIsRejected";
            this.colIsRejected.ReadOnly = true;
            this.colIsRejected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsRejected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsRejected.TrueValue = "Y";
            this.colIsRejected.Width = 50;
            // 
            // colManagerURId
            // 
            this.colManagerURId.HeaderText = "Manager User Role Id";
            this.colManagerURId.Name = "colManagerURId";
            this.colManagerURId.ReadOnly = true;
            this.colManagerURId.Visible = false;
            // 
            // colAnalystStatus
            // 
            this.colAnalystStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAnalystStatus.HeaderText = "AnalystStatus";
            this.colAnalystStatus.Name = "colAnalystStatus";
            this.colAnalystStatus.ReadOnly = true;
            this.colAnalystStatus.Visible = false;
            // 
            // colAnalystName
            // 
            this.colAnalystName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAnalystName.HeaderText = "Analyst";
            this.colAnalystName.Name = "colAnalystName";
            this.colAnalystName.ReadOnly = true;
            // 
            // colReviewerName
            // 
            this.colReviewerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReviewerName.HeaderText = "Reviewer";
            this.colReviewerName.Name = "colReviewerName";
            this.colReviewerName.ReadOnly = true;
            // 
            // colReviewStatus
            // 
            this.colReviewStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReviewStatus.HeaderText = "ReviewStatus";
            this.colReviewStatus.Name = "colReviewStatus";
            this.colReviewStatus.ReadOnly = true;
            this.colReviewStatus.Visible = false;
            // 
            // colQCStatus
            // 
            this.colQCStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQCStatus.HeaderText = "QCStatus";
            this.colQCStatus.Name = "colQCStatus";
            this.colQCStatus.ReadOnly = true;
            this.colQCStatus.Visible = false;
            // 
            // frmTaskSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 558);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskSheet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Sheet - Assigned References";
            this.Load += new System.EventHandler(this.frmTaskSheet_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTANs)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvAssignTANs;
        private System.Windows.Forms.TextBox txtTAN;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label lblTAN;
        private System.Windows.Forms.Label lblTanStatus;
        private System.Windows.Forms.TextBox txtTanStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskAllocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID;
        private System.Windows.Forms.DataGridViewLinkColumn colShipmentRefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewImageColumn colViewDownLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsReAssigned;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsRejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerURId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnalystStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnalystName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQCStatus;
    }
}