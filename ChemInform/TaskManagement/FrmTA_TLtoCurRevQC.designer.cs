namespace ChemInform.Task_Management
{
    partial class FrmTA_TLtoCurRevQC
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
            this.pnlCntrls = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipMentName = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.lblTeamMapping = new System.Windows.Forms.Label();
            this.cmbRolesUnderTL = new System.Windows.Forms.ComboBox();
            this.lblAssignedfor = new System.Windows.Forms.Label();
            this.lblModuleHeadName = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvUnAssignedToTeamMembers = new System.Windows.Forms.DataGridView();
            this.colUnAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAssignedShipmentDoc = new System.Windows.Forms.GroupBox();
            this.dgvAssignedDocToTeamMembers = new System.Windows.Forms.DataGridView();
            this.colAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocCurator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedReview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedQc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntMnuModifyTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyCuratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyReviewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyQualityCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAssignedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colTPAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCntrls.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToTeamMembers)).BeginInit();
            this.gbAssignedShipmentDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedDocToTeamMembers)).BeginInit();
            this.cntMnuModifyTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCntrls
            // 
            this.pnlCntrls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCntrls.Controls.Add(this.cmbShipmentName);
            this.pnlCntrls.Controls.Add(this.lblShipMentName);
            this.pnlCntrls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCntrls.Location = new System.Drawing.Point(0, 0);
            this.pnlCntrls.Name = "pnlCntrls";
            this.pnlCntrls.Size = new System.Drawing.Size(1105, 42);
            this.pnlCntrls.TabIndex = 43;
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Location = new System.Drawing.Point(120, 8);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(322, 25);
            this.cmbShipmentName.TabIndex = 30;
            this.cmbShipmentName.SelectedIndexChanged += new System.EventHandler(this.cmbShipmentName_SelectedIndexChanged);
            // 
            // lblShipMentName
            // 
            this.lblShipMentName.AutoSize = true;
            this.lblShipMentName.Location = new System.Drawing.Point(10, 12);
            this.lblShipMentName.Name = "lblShipMentName";
            this.lblShipMentName.Size = new System.Drawing.Size(102, 17);
            this.lblShipMentName.TabIndex = 16;
            this.lblShipMentName.Text = "Shipment Name";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Curator 1",
            "Curator 2"});
            this.cmbUserName.Location = new System.Drawing.Point(540, 8);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(322, 25);
            this.cmbUserName.TabIndex = 30;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(457, 12);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(77, 17);
            this.lblModule.TabIndex = 16;
            this.lblModule.Text = "User Name";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1105, 415);
            this.pnlMain.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAssign);
            this.splitContainer1.Panel1.Controls.Add(this.dgvUnAssignedToTeamMembers);
            this.splitContainer1.Panel1.Controls.Add(this.pnlCntrls);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbAssignedShipmentDoc);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 415);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAssign
            // 
            this.pnlAssign.Controls.Add(this.lblTeamMapping);
            this.pnlAssign.Controls.Add(this.cmbRolesUnderTL);
            this.pnlAssign.Controls.Add(this.lblAssignedfor);
            this.pnlAssign.Controls.Add(this.cmbUserName);
            this.pnlAssign.Controls.Add(this.lblModule);
            this.pnlAssign.Controls.Add(this.lblModuleHeadName);
            this.pnlAssign.Controls.Add(this.btnReset);
            this.pnlAssign.Controls.Add(this.btnAssign);
            this.pnlAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssign.Location = new System.Drawing.Point(0, 156);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(1105, 70);
            this.pnlAssign.TabIndex = 45;
            // 
            // lblTeamMapping
            // 
            this.lblTeamMapping.AutoSize = true;
            this.lblTeamMapping.Location = new System.Drawing.Point(119, 44);
            this.lblTeamMapping.Name = "lblTeamMapping";
            this.lblTeamMapping.Size = new System.Drawing.Size(0, 17);
            this.lblTeamMapping.TabIndex = 33;
            // 
            // cmbRolesUnderTL
            // 
            this.cmbRolesUnderTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolesUnderTL.FormattingEnabled = true;
            this.cmbRolesUnderTL.Location = new System.Drawing.Point(121, 8);
            this.cmbRolesUnderTL.Name = "cmbRolesUnderTL";
            this.cmbRolesUnderTL.Size = new System.Drawing.Size(322, 25);
            this.cmbRolesUnderTL.TabIndex = 32;
           // this.cmbRolesUnderTL.SelectionChangeCommitted += new System.EventHandler(this.cmbAssignedTo_SelectionChangeCommitted);
            // 
            // lblAssignedfor
            // 
            this.lblAssignedfor.AutoSize = true;
            this.lblAssignedfor.Location = new System.Drawing.Point(35, 11);
            this.lblAssignedfor.Name = "lblAssignedfor";
            this.lblAssignedfor.Size = new System.Drawing.Size(83, 17);
            this.lblAssignedfor.TabIndex = 31;
            this.lblAssignedfor.Text = "Assigned for";
            // 
            // lblModuleHeadName
            // 
            this.lblModuleHeadName.AutoSize = true;
            this.lblModuleHeadName.Location = new System.Drawing.Point(14, 44);
            this.lblModuleHeadName.Name = "lblModuleHeadName";
            this.lblModuleHeadName.Size = new System.Drawing.Size(99, 17);
            this.lblModuleHeadName.TabIndex = 2;
            this.lblModuleHeadName.Text = "Team Structure";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(1021, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Location = new System.Drawing.Point(937, 8);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 26);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dgvUnAssignedToTeamMembers
            // 
            this.dgvUnAssignedToTeamMembers.AllowUserToAddRows = false;
            this.dgvUnAssignedToTeamMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUnAssignedToTeamMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnAssignedToTeamMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnAssignedToTeamMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnAssignedToTeamMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnAssignedToTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnAssignedToTeamMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnAssignedToTeamMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnAssignedDocName,
            this.colUnAssignedDocStatus});
            this.dgvUnAssignedToTeamMembers.Location = new System.Drawing.Point(0, 42);
            this.dgvUnAssignedToTeamMembers.Name = "dgvUnAssignedToTeamMembers";
            this.dgvUnAssignedToTeamMembers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvUnAssignedToTeamMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnAssignedToTeamMembers.Size = new System.Drawing.Size(1105, 113);
            this.dgvUnAssignedToTeamMembers.TabIndex = 44;
            this.dgvUnAssignedToTeamMembers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUnAssignedToCuration_RowPostPaint);
            // 
            // colUnAssignedDocName
            // 
            this.colUnAssignedDocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnAssignedDocName.DataPropertyName = "DocName";
            this.colUnAssignedDocName.FillWeight = 338.2452F;
            this.colUnAssignedDocName.HeaderText = "Document Name";
            this.colUnAssignedDocName.Name = "colUnAssignedDocName";
            // 
            // colUnAssignedDocStatus
            // 
            this.colUnAssignedDocStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUnAssignedDocStatus.DataPropertyName = "Status";
            this.colUnAssignedDocStatus.HeaderText = "Status";
            this.colUnAssignedDocStatus.Name = "colUnAssignedDocStatus";
            this.colUnAssignedDocStatus.Width = 200;
            // 
            // gbAssignedShipmentDoc
            // 
            this.gbAssignedShipmentDoc.Controls.Add(this.dgvAssignedDocToTeamMembers);
            this.gbAssignedShipmentDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAssignedShipmentDoc.Location = new System.Drawing.Point(0, 0);
            this.gbAssignedShipmentDoc.Name = "gbAssignedShipmentDoc";
            this.gbAssignedShipmentDoc.Size = new System.Drawing.Size(1105, 185);
            this.gbAssignedShipmentDoc.TabIndex = 0;
            this.gbAssignedShipmentDoc.TabStop = false;
            this.gbAssignedShipmentDoc.Text = "Assigned Shipment Documents";
            // 
            // dgvAssignedDocToTeamMembers
            // 
            this.dgvAssignedDocToTeamMembers.AllowUserToAddRows = false;
            this.dgvAssignedDocToTeamMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedDocToTeamMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignedDocToTeamMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedDocToTeamMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssignedDocToTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssignedDocToTeamMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedDocToTeamMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssignedDocName,
            this.colAssignedDocType,
            this.colAssignedDocCurator,
            this.colAssignedReview,
            this.colAssignedQc,
            this.colAssignedDocDate,
            this.colAssignedDocStatus});
            this.dgvAssignedDocToTeamMembers.ContextMenuStrip = this.cntMnuModifyTask;
            this.dgvAssignedDocToTeamMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedDocToTeamMembers.Location = new System.Drawing.Point(3, 21);
            this.dgvAssignedDocToTeamMembers.Name = "dgvAssignedDocToTeamMembers";
            this.dgvAssignedDocToTeamMembers.ReadOnly = true;
            this.dgvAssignedDocToTeamMembers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAssignedDocToTeamMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedDocToTeamMembers.Size = new System.Drawing.Size(1099, 161);
            this.dgvAssignedDocToTeamMembers.TabIndex = 45;
            this.dgvAssignedDocToTeamMembers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAssignedDocToCuration_RowPostPaint);
            // 
            // colAssignedDocName
            // 
            this.colAssignedDocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAssignedDocName.FillWeight = 148.2673F;
            this.colAssignedDocName.HeaderText = "Document Name";
            this.colAssignedDocName.MinimumWidth = 10;
            this.colAssignedDocName.Name = "colAssignedDocName";
            this.colAssignedDocName.ReadOnly = true;
            // 
            // colAssignedDocType
            // 
            this.colAssignedDocType.FillWeight = 142.3365F;
            this.colAssignedDocType.HeaderText = "Doc Type";
            this.colAssignedDocType.Name = "colAssignedDocType";
            this.colAssignedDocType.ReadOnly = true;
            // 
            // colAssignedDocCurator
            // 
            this.colAssignedDocCurator.FillWeight = 142.3365F;
            this.colAssignedDocCurator.HeaderText = "Curator";
            this.colAssignedDocCurator.Name = "colAssignedDocCurator";
            this.colAssignedDocCurator.ReadOnly = true;
            // 
            // colAssignedReview
            // 
            this.colAssignedReview.FillWeight = 90.13416F;
            this.colAssignedReview.HeaderText = "Reviewer";
            this.colAssignedReview.Name = "colAssignedReview";
            this.colAssignedReview.ReadOnly = true;
            // 
            // colAssignedQc
            // 
            this.colAssignedQc.FillWeight = 172.834F;
            this.colAssignedQc.HeaderText = "Quality Check";
            this.colAssignedQc.Name = "colAssignedQc";
            this.colAssignedQc.ReadOnly = true;
            // 
            // colAssignedDocDate
            // 
            this.colAssignedDocDate.FillWeight = 142.3365F;
            this.colAssignedDocDate.HeaderText = "Assigned Date";
            this.colAssignedDocDate.Name = "colAssignedDocDate";
            this.colAssignedDocDate.ReadOnly = true;
            // 
            // colAssignedDocStatus
            // 
            this.colAssignedDocStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAssignedDocStatus.HeaderText = "Status";
            this.colAssignedDocStatus.Name = "colAssignedDocStatus";
            this.colAssignedDocStatus.ReadOnly = true;
            // 
            // cntMnuModifyTask
            // 
            this.cntMnuModifyTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyCuratorToolStripMenuItem,
            this.modifyReviewerToolStripMenuItem,
            this.modifyQualityCheckToolStripMenuItem,
            this.removeAssignedTaskToolStripMenuItem});
            this.cntMnuModifyTask.Name = "cntMnuModifyTask";
            this.cntMnuModifyTask.Size = new System.Drawing.Size(200, 92);
            // 
            // modifyCuratorToolStripMenuItem
            // 
            this.modifyCuratorToolStripMenuItem.Name = "modifyCuratorToolStripMenuItem";
            this.modifyCuratorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modifyCuratorToolStripMenuItem.Text = "Modify Curator";
            this.modifyCuratorToolStripMenuItem.Click += new System.EventHandler(this.modifyCuratorToolStripMenuItem_Click);
            // 
            // modifyReviewerToolStripMenuItem
            // 
            this.modifyReviewerToolStripMenuItem.Name = "modifyReviewerToolStripMenuItem";
            this.modifyReviewerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modifyReviewerToolStripMenuItem.Text = "Modify Reviewer";
            this.modifyReviewerToolStripMenuItem.Click += new System.EventHandler(this.modifyReviewerToolStripMenuItem_Click);
            // 
            // modifyQualityCheckToolStripMenuItem
            // 
            this.modifyQualityCheckToolStripMenuItem.Name = "modifyQualityCheckToolStripMenuItem";
            this.modifyQualityCheckToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modifyQualityCheckToolStripMenuItem.Text = "Modify Quality Checker";
            this.modifyQualityCheckToolStripMenuItem.Click += new System.EventHandler(this.modifyQualityCheckToolStripMenuItem_Click);
            // 
            // removeAssignedTaskToolStripMenuItem
            // 
            this.removeAssignedTaskToolStripMenuItem.Name = "removeAssignedTaskToolStripMenuItem";
            this.removeAssignedTaskToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.removeAssignedTaskToolStripMenuItem.Text = "Remove Assigned Task";
            this.removeAssignedTaskToolStripMenuItem.Click += new System.EventHandler(this.removeAssignedTaskToolStripMenuItem_Click);
            // 
            // colTPAssignedTo
            // 
            this.colTPAssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTPAssignedTo.FillWeight = 406.4234F;
            this.colTPAssignedTo.HeaderText = "Assigned To";
            this.colTPAssignedTo.Name = "colTPAssignedTo";
            this.colTPAssignedTo.ReadOnly = true;
            // 
            // FrmTA_TLtoCurRevQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 415);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTA_TLtoCurRevQC";
            this.Text = "Task Allocation-Team Lead to Curation/Review/QC";
            this.Load += new System.EventHandler(this.lblAssignedTo_Load);
            this.pnlCntrls.ResumeLayout(false);
            this.pnlCntrls.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToTeamMembers)).EndInit();
            this.gbAssignedShipmentDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedDocToTeamMembers)).EndInit();
            this.cntMnuModifyTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipMentName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Label lblModuleHeadName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvUnAssignedToTeamMembers;
        private System.Windows.Forms.GroupBox gbAssignedShipmentDoc;
        private System.Windows.Forms.DataGridView dgvAssignedDocToTeamMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPAssignedTo;
        private System.Windows.Forms.ComboBox cmbRolesUnderTL;
        private System.Windows.Forms.Label lblAssignedfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocCurator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedQc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocStatus;
        private System.Windows.Forms.ContextMenuStrip cntMnuModifyTask;
        private System.Windows.Forms.Label lblTeamMapping;
        private System.Windows.Forms.ToolStripMenuItem modifyCuratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyReviewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyQualityCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAssignedTaskToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;

    }
}