namespace ChemInform.TaskSheets
{
    partial class FrmTaskSheetTL
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.ColDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssingedToCurator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssignedReviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssingedQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntMnuManageTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyAnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipment = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.cntMnuManageTask.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvProjects);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(862, 371);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDocId,
            this.ColAssingedToCurator,
            this.ColAssignedReviewer,
            this.ColAssingedQC,
            this.ColStatus});
            this.dgvProjects.ContextMenuStrip = this.cntMnuManageTask;
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 39);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(862, 332);
            this.dgvProjects.TabIndex = 1;
            this.dgvProjects.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProjects_RowPostPaint);
            // 
            // ColDocId
            // 
            this.ColDocId.FillWeight = 50.76142F;
            this.ColDocId.HeaderText = "Doc Id";
            this.ColDocId.Name = "ColDocId";
            // 
            // ColAssingedToCurator
            // 
            this.ColAssingedToCurator.FillWeight = 112.3096F;
            this.ColAssingedToCurator.HeaderText = "Assinged To Curator";
            this.ColAssingedToCurator.Name = "ColAssingedToCurator";
            // 
            // ColAssignedReviewer
            // 
            this.ColAssignedReviewer.FillWeight = 112.3096F;
            this.ColAssignedReviewer.HeaderText = "Assinged To Reviewer";
            this.ColAssignedReviewer.Name = "ColAssignedReviewer";
            // 
            // ColAssingedQC
            // 
            this.ColAssingedQC.FillWeight = 112.3096F;
            this.ColAssingedQC.HeaderText = "Assigned To Qc";
            this.ColAssingedQC.Name = "ColAssingedQC";
            // 
            // ColStatus
            // 
            this.ColStatus.FillWeight = 112.3096F;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // cntMnuManageTask
            // 
            this.cntMnuManageTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyAnaToolStripMenuItem});
            this.cntMnuManageTask.Name = "cntMnuManageTask";
            this.cntMnuManageTask.Size = new System.Drawing.Size(140, 26);
            // 
            // modifyAnaToolStripMenuItem
            // 
            this.modifyAnaToolStripMenuItem.Name = "modifyAnaToolStripMenuItem";
            this.modifyAnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyAnaToolStripMenuItem.Text = "Modify Task";
            this.modifyAnaToolStripMenuItem.Click += new System.EventHandler(this.modifyAnaToolStripMenuItem_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmbShipmentName);
            this.pnlControls.Controls.Add(this.lblShipment);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(862, 39);
            this.pnlControls.TabIndex = 0;
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Items.AddRange(new object[] {
            "shipment1",
            "shipment2"});
            this.cmbShipmentName.Location = new System.Drawing.Point(97, 6);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(281, 27);
            this.cmbShipmentName.TabIndex = 1;
            this.cmbShipmentName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblShipment
            // 
            this.lblShipment.AutoSize = true;
            this.lblShipment.Location = new System.Drawing.Point(26, 9);
            this.lblShipment.Name = "lblShipment";
            this.lblShipment.Size = new System.Drawing.Size(65, 19);
            this.lblShipment.TabIndex = 0;
            this.lblShipment.Text = "Shipment";
            // 
            // FrmTaskSheetPM_DM_MH_TL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 371);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaskSheetPM_DM_MH_TL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Sheet";
            this.Load += new System.EventHandler(this.FrmTaskSheetPM_DM_MH_TL_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.cntMnuManageTask.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssingedToCurator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssignedReviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssingedQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.ContextMenuStrip cntMnuManageTask;
        private System.Windows.Forms.ToolStripMenuItem modifyAnaToolStripMenuItem;
    }
}