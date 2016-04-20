namespace ChemInform.Reports
{
    partial class frmShipmentStatusReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lnkClearFilter = new System.Windows.Forms.LinkLabel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblRxnsCnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNotAssignedRefs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQCCompleteCnt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblQCProgressCnt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReviewCompleteCnt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReviewProgressCnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurationCompleteCnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurationProgressCnt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelRefCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRefsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchRef = new System.Windows.Forms.TextBox();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn8 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn9 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferance = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSysText = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colSysNo = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnCount = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colSysClassType = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colTaskStatus = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colIsDelivered = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colCurator = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colReviewer = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.colQC = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lnkClearFilter);
            this.pnlMain.Controls.Add(this.dgvReport);
            this.pnlMain.Controls.Add(this.pnlStatus);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1055, 505);
            this.pnlMain.TabIndex = 1;
            // 
            // lnkClearFilter
            // 
            this.lnkClearFilter.AutoSize = true;
            this.lnkClearFilter.Location = new System.Drawing.Point(6, 41);
            this.lnkClearFilter.Name = "lnkClearFilter";
            this.lnkClearFilter.Size = new System.Drawing.Size(25, 17);
            this.lnkClearFilter.TabIndex = 12;
            this.lnkClearFilter.TabStop = true;
            this.lnkClearFilter.Text = "All";
            this.lnkClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearFilter_LinkClicked);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRefID,
            this.colReferance,
            this.colSysText,
            this.colSysNo,
            this.colDocType,
            this.colRxnCount,
            this.colSysClassType,
            this.colTaskStatus,
            this.colIsDelivered,
            this.colCurator,
            this.colReviewer,
            this.colQC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 37);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(1055, 412);
            this.dgvReport.TabIndex = 10;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            this.dgvReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReport_DataBindingComplete);
            this.dgvReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvReport_RowPostPaint);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblRxnsCnt);
            this.pnlStatus.Controls.Add(this.label8);
            this.pnlStatus.Controls.Add(this.lblNotAssignedRefs);
            this.pnlStatus.Controls.Add(this.label6);
            this.pnlStatus.Controls.Add(this.lblQCCompleteCnt);
            this.pnlStatus.Controls.Add(this.label15);
            this.pnlStatus.Controls.Add(this.lblQCProgressCnt);
            this.pnlStatus.Controls.Add(this.label13);
            this.pnlStatus.Controls.Add(this.lblReviewCompleteCnt);
            this.pnlStatus.Controls.Add(this.label11);
            this.pnlStatus.Controls.Add(this.lblReviewProgressCnt);
            this.pnlStatus.Controls.Add(this.label9);
            this.pnlStatus.Controls.Add(this.lblCurationCompleteCnt);
            this.pnlStatus.Controls.Add(this.label7);
            this.pnlStatus.Controls.Add(this.lblCurationProgressCnt);
            this.pnlStatus.Controls.Add(this.label5);
            this.pnlStatus.Controls.Add(this.lblDelRefCnt);
            this.pnlStatus.Controls.Add(this.label4);
            this.pnlStatus.Controls.Add(this.lblRefsCount);
            this.pnlStatus.Controls.Add(this.label2);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 449);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1055, 56);
            this.pnlStatus.TabIndex = 11;
            // 
            // lblRxnsCnt
            // 
            this.lblRxnsCnt.AutoSize = true;
            this.lblRxnsCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblRxnsCnt.Location = new System.Drawing.Point(117, 32);
            this.lblRxnsCnt.Name = "lblRxnsCnt";
            this.lblRxnsCnt.Size = new System.Drawing.Size(15, 17);
            this.lblRxnsCnt.TabIndex = 19;
            this.lblRxnsCnt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Rxns Count: ";
            // 
            // lblNotAssignedRefs
            // 
            this.lblNotAssignedRefs.AutoSize = true;
            this.lblNotAssignedRefs.ForeColor = System.Drawing.Color.Blue;
            this.lblNotAssignedRefs.Location = new System.Drawing.Point(307, 32);
            this.lblNotAssignedRefs.Name = "lblNotAssignedRefs";
            this.lblNotAssignedRefs.Size = new System.Drawing.Size(15, 17);
            this.lblNotAssignedRefs.TabIndex = 17;
            this.lblNotAssignedRefs.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Not Assigned Refs: ";
            // 
            // lblQCCompleteCnt
            // 
            this.lblQCCompleteCnt.AutoSize = true;
            this.lblQCCompleteCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblQCCompleteCnt.Location = new System.Drawing.Point(955, 32);
            this.lblQCCompleteCnt.Name = "lblQCCompleteCnt";
            this.lblQCCompleteCnt.Size = new System.Drawing.Size(15, 17);
            this.lblQCCompleteCnt.TabIndex = 15;
            this.lblQCCompleteCnt.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(815, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "QC Completed Refs: ";
            // 
            // lblQCProgressCnt
            // 
            this.lblQCProgressCnt.AutoSize = true;
            this.lblQCProgressCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblQCProgressCnt.Location = new System.Drawing.Point(955, 4);
            this.lblQCProgressCnt.Name = "lblQCProgressCnt";
            this.lblQCProgressCnt.Size = new System.Drawing.Size(15, 17);
            this.lblQCProgressCnt.TabIndex = 13;
            this.lblQCProgressCnt.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(815, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "QC Progress Refs: ";
            // 
            // lblReviewCompleteCnt
            // 
            this.lblReviewCompleteCnt.AutoSize = true;
            this.lblReviewCompleteCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblReviewCompleteCnt.Location = new System.Drawing.Point(767, 32);
            this.lblReviewCompleteCnt.Name = "lblReviewCompleteCnt";
            this.lblReviewCompleteCnt.Size = new System.Drawing.Size(15, 17);
            this.lblReviewCompleteCnt.TabIndex = 11;
            this.lblReviewCompleteCnt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Review Completed Refs: ";
            // 
            // lblReviewProgressCnt
            // 
            this.lblReviewProgressCnt.AutoSize = true;
            this.lblReviewProgressCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblReviewProgressCnt.Location = new System.Drawing.Point(767, 4);
            this.lblReviewProgressCnt.Name = "lblReviewProgressCnt";
            this.lblReviewProgressCnt.Size = new System.Drawing.Size(15, 17);
            this.lblReviewProgressCnt.TabIndex = 9;
            this.lblReviewProgressCnt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Review Progress Refs: ";
            // 
            // lblCurationCompleteCnt
            // 
            this.lblCurationCompleteCnt.AutoSize = true;
            this.lblCurationCompleteCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblCurationCompleteCnt.Location = new System.Drawing.Point(558, 32);
            this.lblCurationCompleteCnt.Name = "lblCurationCompleteCnt";
            this.lblCurationCompleteCnt.Size = new System.Drawing.Size(15, 17);
            this.lblCurationCompleteCnt.TabIndex = 7;
            this.lblCurationCompleteCnt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Curation Completed Refs:";
            // 
            // lblCurationProgressCnt
            // 
            this.lblCurationProgressCnt.AutoSize = true;
            this.lblCurationProgressCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblCurationProgressCnt.Location = new System.Drawing.Point(558, 4);
            this.lblCurationProgressCnt.Name = "lblCurationProgressCnt";
            this.lblCurationProgressCnt.Size = new System.Drawing.Size(15, 17);
            this.lblCurationProgressCnt.TabIndex = 5;
            this.lblCurationProgressCnt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Curation Progress Refs: ";
            // 
            // lblDelRefCnt
            // 
            this.lblDelRefCnt.AutoSize = true;
            this.lblDelRefCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblDelRefCnt.Location = new System.Drawing.Point(307, 4);
            this.lblDelRefCnt.Name = "lblDelRefCnt";
            this.lblDelRefCnt.Size = new System.Drawing.Size(15, 17);
            this.lblDelRefCnt.TabIndex = 3;
            this.lblDelRefCnt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delivered Ref.Count: ";
            // 
            // lblRefsCount
            // 
            this.lblRefsCount.AutoSize = true;
            this.lblRefsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblRefsCount.Location = new System.Drawing.Point(118, 4);
            this.lblRefsCount.Name = "lblRefsCount";
            this.lblRefsCount.Size = new System.Drawing.Size(15, 17);
            this.lblRefsCount.TabIndex = 1;
            this.lblRefsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Ref.Count: ";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtSearchRef);
            this.pnlTop.Controls.Add(this.cmbShipment);
            this.pnlTop.Controls.Add(this.lblPhase);
            this.pnlTop.Controls.Add(this.btnExport);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1055, 37);
            this.pnlTop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search Ref.";
            // 
            // txtSearchRef
            // 
            this.txtSearchRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRef.Location = new System.Drawing.Point(354, 5);
            this.txtSearchRef.Name = "txtSearchRef";
            this.txtSearchRef.Size = new System.Drawing.Size(617, 25);
            this.txtSearchRef.TabIndex = 29;
            this.txtSearchRef.TextChanged += new System.EventHandler(this.txtSearchRef_TextChanged);
            // 
            // cmbShipment
            // 
            this.cmbShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Items.AddRange(new object[] {
            "rxnfile.800002",
            "rxnfile.800003",
            "rxnfile.800004"});
            this.cmbShipment.Location = new System.Drawing.Point(68, 5);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(197, 25);
            this.cmbShipment.TabIndex = 28;
            this.cmbShipment.SelectionChangeCommitted += new System.EventHandler(this.cmbShipment_SelectionChangeCommitted);
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(3, 9);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(62, 17);
            this.lblPhase.TabIndex = 27;
            this.lblPhase.Text = "Shipment";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.AutoSize = true;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::ChemInform.Properties.Resources.export_excel_icon;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(977, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 25);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ref.No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn1.HeaderText = "Ref.No";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "SysText";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "SysNo";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "RxnCount";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn3.Width = 50;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn4.Width = 50;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewAutoFilterTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "TaskStatus";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "IsDelivered";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn6.Width = 60;
            // 
            // dataGridViewAutoFilterTextBoxColumn7
            // 
            this.dataGridViewAutoFilterTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn7.HeaderText = "Analyst";
            this.dataGridViewAutoFilterTextBoxColumn7.Name = "dataGridViewAutoFilterTextBoxColumn7";
            this.dataGridViewAutoFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn8
            // 
            this.dataGridViewAutoFilterTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn8.HeaderText = "Reviewer";
            this.dataGridViewAutoFilterTextBoxColumn8.Name = "dataGridViewAutoFilterTextBoxColumn8";
            this.dataGridViewAutoFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn9
            // 
            this.dataGridViewAutoFilterTextBoxColumn9.HeaderText = "QC";
            this.dataGridViewAutoFilterTextBoxColumn9.Name = "dataGridViewAutoFilterTextBoxColumn9";
            this.dataGridViewAutoFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "SysText";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "SysNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "ClassType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "TaskStatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "Analyst";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Reviewer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "QC";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "QC";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // colShipmentRefID
            // 
            this.colShipmentRefID.HeaderText = "ShipmentRefID";
            this.colShipmentRefID.Name = "colShipmentRefID";
            this.colShipmentRefID.ReadOnly = true;
            this.colShipmentRefID.Visible = false;
            // 
            // colReferance
            // 
            this.colReferance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReferance.HeaderText = "Ref.No";
            this.colReferance.Name = "colReferance";
            this.colReferance.ReadOnly = true;
            this.colReferance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReferance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSysText
            // 
            this.colSysText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSysText.HeaderText = "SysText";
            this.colSysText.Name = "colSysText";
            this.colSysText.ReadOnly = true;
            this.colSysText.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSysNo
            // 
            this.colSysNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSysNo.HeaderText = "SysNo";
            this.colSysNo.Name = "colSysNo";
            this.colSysNo.ReadOnly = true;
            this.colSysNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDocType
            // 
            this.colDocType.HeaderText = "Type";
            this.colDocType.Name = "colDocType";
            this.colDocType.ReadOnly = true;
            // 
            // colRxnCount
            // 
            this.colRxnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnCount.HeaderText = "RxnCount";
            this.colRxnCount.Name = "colRxnCount";
            this.colRxnCount.ReadOnly = true;
            this.colRxnCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRxnCount.Width = 50;
            // 
            // colSysClassType
            // 
            this.colSysClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSysClassType.HeaderText = "Type";
            this.colSysClassType.Name = "colSysClassType";
            this.colSysClassType.ReadOnly = true;
            this.colSysClassType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSysClassType.Width = 50;
            // 
            // colTaskStatus
            // 
            this.colTaskStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTaskStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTaskStatus.HeaderText = "TaskStatus";
            this.colTaskStatus.Name = "colTaskStatus";
            this.colTaskStatus.ReadOnly = true;
            this.colTaskStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colIsDelivered
            // 
            this.colIsDelivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsDelivered.HeaderText = "Delivered";
            this.colIsDelivered.Name = "colIsDelivered";
            this.colIsDelivered.ReadOnly = true;
            this.colIsDelivered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsDelivered.Width = 60;
            // 
            // colCurator
            // 
            this.colCurator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurator.HeaderText = "Analyst";
            this.colCurator.Name = "colCurator";
            this.colCurator.ReadOnly = true;
            this.colCurator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colReviewer
            // 
            this.colReviewer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReviewer.HeaderText = "Reviewer";
            this.colReviewer.Name = "colReviewer";
            this.colReviewer.ReadOnly = true;
            this.colReviewer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colQC
            // 
            this.colQC.HeaderText = "QC";
            this.colQC.Name = "colQC";
            this.colQC.ReadOnly = true;
            this.colQC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmShipmentStatusReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1055, 505);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmShipmentStatusReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipment Status Report";
            this.Load += new System.EventHandler(this.frmShipmentReport_New_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchRef;
        private System.Windows.Forms.Panel pnlStatus;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn7;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn8;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn9;
        private System.Windows.Forms.Label lblRefsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQCCompleteCnt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblQCProgressCnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReviewCompleteCnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReviewProgressCnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurationCompleteCnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurationProgressCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelRefCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNotAssignedRefs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRxnsCnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lnkClearFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID;
        private System.Windows.Forms.DataGridViewLinkColumn colReferance;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colSysText;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colSysNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colRxnCount;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colSysClassType;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colTaskStatus;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colIsDelivered;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colCurator;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colReviewer;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn colQC;
    }
}