namespace ChemInform.Task_Management
{
    partial class FrmTA_MHtoTL
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
            this.cmbTeamLead = new System.Windows.Forms.ComboBox();
            this.lblTeamLead = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvUnAssignedToTL = new System.Windows.Forms.DataGridView();
            this.colUnAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAssignedShipmentDoc = new System.Windows.Forms.GroupBox();
            this.dgvAssignedToTL = new System.Windows.Forms.DataGridView();
            this.colAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocTeamLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsremoveassignedtask = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCntrls.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToTL)).BeginInit();
            this.gbAssignedShipmentDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedToTL)).BeginInit();
            this.ctmenu.SuspendLayout();
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
            this.pnlCntrls.Size = new System.Drawing.Size(968, 42);
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
            // cmbTeamLead
            // 
            this.cmbTeamLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTeamLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamLead.FormattingEnabled = true;
            this.cmbTeamLead.Items.AddRange(new object[] {
            "Team Lead 1",
            "Team Lead 2"});
            this.cmbTeamLead.Location = new System.Drawing.Point(600, 6);
            this.cmbTeamLead.Name = "cmbTeamLead";
            this.cmbTeamLead.Size = new System.Drawing.Size(279, 25);
            this.cmbTeamLead.TabIndex = 30;
            // 
            // lblTeamLead
            // 
            this.lblTeamLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamLead.AutoSize = true;
            this.lblTeamLead.Location = new System.Drawing.Point(519, 9);
            this.lblTeamLead.Name = "lblTeamLead";
            this.lblTeamLead.Size = new System.Drawing.Size(75, 17);
            this.lblTeamLead.TabIndex = 16;
            this.lblTeamLead.Text = "Team Lead";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(968, 426);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvUnAssignedToTL);
            this.splitContainer1.Panel1.Controls.Add(this.pnlCntrls);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbAssignedShipmentDoc);
            this.splitContainer1.Size = new System.Drawing.Size(968, 426);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAssign
            // 
            this.pnlAssign.Controls.Add(this.cmbTeamLead);
            this.pnlAssign.Controls.Add(this.lblTeamLead);
            this.pnlAssign.Controls.Add(this.btnAssign);
            this.pnlAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssign.Location = new System.Drawing.Point(0, 160);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(968, 37);
            this.pnlAssign.TabIndex = 45;
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Location = new System.Drawing.Point(885, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 26);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dgvUnAssignedToTL
            // 
            this.dgvUnAssignedToTL.AllowUserToAddRows = false;
            this.dgvUnAssignedToTL.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUnAssignedToTL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnAssignedToTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnAssignedToTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnAssignedToTL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnAssignedToTL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnAssignedToTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnAssignedToTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnAssignedDocName,
            this.colUnAssignedDocStatus});
            this.dgvUnAssignedToTL.Location = new System.Drawing.Point(3, 42);
            this.dgvUnAssignedToTL.Name = "dgvUnAssignedToTL";
            this.dgvUnAssignedToTL.ReadOnly = true;
            this.dgvUnAssignedToTL.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvUnAssignedToTL.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUnAssignedToTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnAssignedToTL.Size = new System.Drawing.Size(962, 112);
            this.dgvUnAssignedToTL.TabIndex = 44;
            this.dgvUnAssignedToTL.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUnAssignedToMH_RowPostPaint);
            // 
            // colUnAssignedDocName
            // 
            this.colUnAssignedDocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnAssignedDocName.DataPropertyName = "DocName";
            this.colUnAssignedDocName.FillWeight = 338.2452F;
            this.colUnAssignedDocName.HeaderText = "Document Name";
            this.colUnAssignedDocName.Name = "colUnAssignedDocName";
            this.colUnAssignedDocName.ReadOnly = true;
            // 
            // colUnAssignedDocStatus
            // 
            this.colUnAssignedDocStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUnAssignedDocStatus.DataPropertyName = "Status";
            this.colUnAssignedDocStatus.HeaderText = "Status";
            this.colUnAssignedDocStatus.Name = "colUnAssignedDocStatus";
            this.colUnAssignedDocStatus.ReadOnly = true;
            this.colUnAssignedDocStatus.Width = 200;
            // 
            // gbAssignedShipmentDoc
            // 
            this.gbAssignedShipmentDoc.Controls.Add(this.dgvAssignedToTL);
            this.gbAssignedShipmentDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAssignedShipmentDoc.Location = new System.Drawing.Point(0, 0);
            this.gbAssignedShipmentDoc.Name = "gbAssignedShipmentDoc";
            this.gbAssignedShipmentDoc.Size = new System.Drawing.Size(968, 225);
            this.gbAssignedShipmentDoc.TabIndex = 0;
            this.gbAssignedShipmentDoc.TabStop = false;
            this.gbAssignedShipmentDoc.Text = "Assigned Shipment Documents";
            // 
            // dgvAssignedToTL
            // 
            this.dgvAssignedToTL.AllowUserToAddRows = false;
            this.dgvAssignedToTL.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedToTL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignedToTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedToTL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssignedToTL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssignedToTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedToTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssignedDocName,
            this.colAssignedDocType,
            this.colAssignedDocTeamLead,
            this.colAssignedDocDate,
            this.colAssignedDocStatus});
            this.dgvAssignedToTL.ContextMenuStrip = this.ctmenu;
            this.dgvAssignedToTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedToTL.Location = new System.Drawing.Point(3, 21);
            this.dgvAssignedToTL.Name = "dgvAssignedToTL";
            this.dgvAssignedToTL.ReadOnly = true;
            this.dgvAssignedToTL.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAssignedToTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedToTL.Size = new System.Drawing.Size(962, 201);
            this.dgvAssignedToTL.TabIndex = 45;
            this.dgvAssignedToTL.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAssignedDocToMH_RowPostPaint);
            // 
            // colAssignedDocName
            // 
            this.colAssignedDocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAssignedDocName.FillWeight = 164.4962F;
            this.colAssignedDocName.HeaderText = "Document Name";
            this.colAssignedDocName.MinimumWidth = 10;
            this.colAssignedDocName.Name = "colAssignedDocName";
            this.colAssignedDocName.ReadOnly = true;
            // 
            // colAssignedDocType
            // 
            this.colAssignedDocType.FillWeight = 157.9163F;
            this.colAssignedDocType.HeaderText = "Doc Type";
            this.colAssignedDocType.Name = "colAssignedDocType";
            this.colAssignedDocType.ReadOnly = true;
            // 
            // colAssignedDocTeamLead
            // 
            this.colAssignedDocTeamLead.FillWeight = 157.9163F;
            this.colAssignedDocTeamLead.HeaderText = "Team Lead";
            this.colAssignedDocTeamLead.Name = "colAssignedDocTeamLead";
            this.colAssignedDocTeamLead.ReadOnly = true;
            // 
            // colAssignedDocDate
            // 
            this.colAssignedDocDate.FillWeight = 157.9163F;
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
            // colTPAssignedTo
            // 
            this.colTPAssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTPAssignedTo.FillWeight = 406.4234F;
            this.colTPAssignedTo.HeaderText = "Assigned To";
            this.colTPAssignedTo.Name = "colTPAssignedTo";
            this.colTPAssignedTo.ReadOnly = true;
            // 
            // ctmenu
            // 
            this.ctmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsremoveassignedtask});
            this.ctmenu.Name = "ctmenu";
            this.ctmenu.Size = new System.Drawing.Size(196, 26);
            // 
            // tsremoveassignedtask
            // 
            this.tsremoveassignedtask.Name = "tsremoveassignedtask";
            this.tsremoveassignedtask.Size = new System.Drawing.Size(195, 22);
            this.tsremoveassignedtask.Text = "Remove Assigned Task";
            this.tsremoveassignedtask.Click += new System.EventHandler(this.tsremoveassignedtask_Click);
            // 
            // FrmTA_MHtoTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 426);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTA_MHtoTL";
            this.Text = "Task Allocation-Module Head to Team Lead";
            this.Load += new System.EventHandler(this.FrmTA_MHtoTL_Load);
            this.pnlCntrls.ResumeLayout(false);
            this.pnlCntrls.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToTL)).EndInit();
            this.gbAssignedShipmentDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedToTL)).EndInit();
            this.ctmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.ComboBox cmbTeamLead;
        private System.Windows.Forms.Label lblTeamLead;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipMentName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvUnAssignedToTL;
        private System.Windows.Forms.GroupBox gbAssignedShipmentDoc;
        private System.Windows.Forms.DataGridView dgvAssignedToTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPAssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocTeamLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocStatus;
        private System.Windows.Forms.ContextMenuStrip ctmenu;
        private System.Windows.Forms.ToolStripMenuItem tsremoveassignedtask;


    }
}