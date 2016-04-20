namespace ChemInform.Task_Management
{
    partial class FrmTA_DMtoMH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.lblModuleHeadName = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvUnAssignedToMH = new System.Windows.Forms.DataGridView();
            this.pnlCntrls = new System.Windows.Forms.Panel();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipMentName = new System.Windows.Forms.Label();
            this.gbAssignedShipmentDoc = new System.Windows.Forms.GroupBox();
            this.dgvAssignedToMH = new System.Windows.Forms.DataGridView();
            this.colAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocModuleHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsremoveassignedtask = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.colUnAssignedDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDMAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnAssignedDocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToMH)).BeginInit();
            this.pnlCntrls.SuspendLayout();
            this.gbAssignedShipmentDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedToMH)).BeginInit();
            this.ctmenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvUnAssignedToMH);
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
            this.pnlAssign.Controls.Add(this.lblModuleHeadName);
            this.pnlAssign.Controls.Add(this.btnAssign);
            this.pnlAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssign.Location = new System.Drawing.Point(0, 160);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(968, 37);
            this.pnlAssign.TabIndex = 45;
            // 
            // lblModuleHeadName
            // 
            this.lblModuleHeadName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModuleHeadName.AutoSize = true;
            this.lblModuleHeadName.Location = new System.Drawing.Point(713, 10);
            this.lblModuleHeadName.Name = "lblModuleHeadName";
            this.lblModuleHeadName.Size = new System.Drawing.Size(140, 17);
            this.lblModuleHeadName.TabIndex = 2;
            this.lblModuleHeadName.Text = "Module Head:---------;";
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
            // dgvUnAssignedToMH
            // 
            this.dgvUnAssignedToMH.AllowUserToAddRows = false;
            this.dgvUnAssignedToMH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUnAssignedToMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnAssignedToMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnAssignedToMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnAssignedToMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUnAssignedToMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnAssignedToMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnAssignedToMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnAssignedDocName,
            this.colDMAssignedTo,
            this.colUnAssignedDocStatus});
            this.dgvUnAssignedToMH.Location = new System.Drawing.Point(0, 42);
            this.dgvUnAssignedToMH.Name = "dgvUnAssignedToMH";
            this.dgvUnAssignedToMH.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvUnAssignedToMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnAssignedToMH.Size = new System.Drawing.Size(968, 112);
            this.dgvUnAssignedToMH.TabIndex = 44;
            this.dgvUnAssignedToMH.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvNotAssignedToMH_RowPostPaint);
            // 
            // pnlCntrls
            // 
            this.pnlCntrls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCntrls.Controls.Add(this.cmbModule);
            this.pnlCntrls.Controls.Add(this.lblModule);
            this.pnlCntrls.Controls.Add(this.cmbShipmentName);
            this.pnlCntrls.Controls.Add(this.lblShipMentName);
            this.pnlCntrls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCntrls.Location = new System.Drawing.Point(0, 0);
            this.pnlCntrls.Name = "pnlCntrls";
            this.pnlCntrls.Size = new System.Drawing.Size(968, 42);
            this.pnlCntrls.TabIndex = 43;
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(513, 9);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(322, 25);
            this.cmbModule.TabIndex = 30;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(455, 13);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(52, 17);
            this.lblModule.TabIndex = 16;
            this.lblModule.Text = "Module";
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Location = new System.Drawing.Point(120, 8);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(322, 25);
            this.cmbShipmentName.TabIndex = 30;
            this.cmbShipmentName.SelectionChangeCommitted += new System.EventHandler(this.cmbShipmentName_SelectionChangeCommitted);
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
            // gbAssignedShipmentDoc
            // 
            this.gbAssignedShipmentDoc.Controls.Add(this.dgvAssignedToMH);
            this.gbAssignedShipmentDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAssignedShipmentDoc.Location = new System.Drawing.Point(0, 0);
            this.gbAssignedShipmentDoc.Name = "gbAssignedShipmentDoc";
            this.gbAssignedShipmentDoc.Size = new System.Drawing.Size(968, 225);
            this.gbAssignedShipmentDoc.TabIndex = 0;
            this.gbAssignedShipmentDoc.TabStop = false;
            this.gbAssignedShipmentDoc.Text = "Assigned Shipment Documents";
            // 
            // dgvAssignedToMH
            // 
            this.dgvAssignedToMH.AllowUserToAddRows = false;
            this.dgvAssignedToMH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedToMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssignedToMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedToMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssignedToMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssignedToMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedToMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssignedDocName,
            this.colAssignedDocType,
            this.colAssignedDocModuleHead,
            this.colAssignedDocDate,
            this.colAssignedDocStatus});
            this.dgvAssignedToMH.ContextMenuStrip = this.ctmenu;
            this.dgvAssignedToMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedToMH.Location = new System.Drawing.Point(3, 21);
            this.dgvAssignedToMH.Name = "dgvAssignedToMH";
            this.dgvAssignedToMH.ReadOnly = true;
            this.dgvAssignedToMH.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAssignedToMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedToMH.Size = new System.Drawing.Size(962, 201);
            this.dgvAssignedToMH.TabIndex = 45;
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
            // colAssignedDocModuleHead
            // 
            this.colAssignedDocModuleHead.FillWeight = 157.9163F;
            this.colAssignedDocModuleHead.HeaderText = "Module Head";
            this.colAssignedDocModuleHead.Name = "colAssignedDocModuleHead";
            this.colAssignedDocModuleHead.ReadOnly = true;
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(968, 426);
            this.pnlMain.TabIndex = 1;
            // 
            // colUnAssignedDocName
            // 
            this.colUnAssignedDocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnAssignedDocName.DataPropertyName = "DocName";
            this.colUnAssignedDocName.FillWeight = 89.28016F;
            this.colUnAssignedDocName.HeaderText = "Document Name";
            this.colUnAssignedDocName.Name = "colUnAssignedDocName";
            // 
            // colDMAssignedTo
            // 
            this.colDMAssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDMAssignedTo.FillWeight = 230.3883F;
            this.colDMAssignedTo.HeaderText = "Assigned To";
            this.colDMAssignedTo.Name = "colDMAssignedTo";
            // 
            // colUnAssignedDocStatus
            // 
            this.colUnAssignedDocStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnAssignedDocStatus.DataPropertyName = "Status";
            this.colUnAssignedDocStatus.FillWeight = 218.5767F;
            this.colUnAssignedDocStatus.HeaderText = "Status";
            this.colUnAssignedDocStatus.Name = "colUnAssignedDocStatus";
            // 
            // FrmTA_DMtoMH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 426);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTA_DMtoMH";
            this.Text = "Task Allocation-Delivery Manager to Module Head";
            this.Load += new System.EventHandler(this.FrmTA_DMtoMH_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnAssignedToMH)).EndInit();
            this.pnlCntrls.ResumeLayout(false);
            this.pnlCntrls.PerformLayout();
            this.gbAssignedShipmentDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedToMH)).EndInit();
            this.ctmenu.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUnAssignedToMH;
        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipMentName;
        private System.Windows.Forms.GroupBox gbAssignedShipmentDoc;
        private System.Windows.Forms.Panel pnlMain;
          private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvAssignedToMH;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocModuleHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedDocStatus;
        private System.Windows.Forms.Label lblModuleHeadName;
        private System.Windows.Forms.ContextMenuStrip ctmenu;
        private System.Windows.Forms.ToolStripMenuItem tsremoveassignedtask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDMAssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnAssignedDocStatus;


    }
}