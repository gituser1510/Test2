namespace ChemInform.TaskSheets
{
    partial class FrmTaskSheetDM
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcModules = new System.Windows.Forms.TabControl();
            this.tpReaction = new System.Windows.Forms.TabPage();
            this.dgvReaction = new System.Windows.Forms.DataGridView();
            this.colRaDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaAssignTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSpectral = new System.Windows.Forms.TabPage();
            this.dgvSpectral = new System.Windows.Forms.DataGridView();
            this.colSaDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpAssignTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTaskPrep = new System.Windows.Forms.TabPage();
            this.dgvTaskPrep = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipment = new System.Windows.Forms.Label();
            this.colTpShipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.tcModules.SuspendLayout();
            this.tpReaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaction)).BeginInit();
            this.tpSpectral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectral)).BeginInit();
            this.tpTaskPrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskPrep)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tcModules);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(878, 339);
            this.pnlMain.TabIndex = 1;
            // 
            // tcModules
            // 
            this.tcModules.Controls.Add(this.tpReaction);
            this.tcModules.Controls.Add(this.tpSpectral);
            this.tcModules.Controls.Add(this.tpTaskPrep);
            this.tcModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcModules.Location = new System.Drawing.Point(0, 39);
            this.tcModules.Name = "tcModules";
            this.tcModules.SelectedIndex = 0;
            this.tcModules.Size = new System.Drawing.Size(878, 300);
            this.tcModules.TabIndex = 1;
            this.tcModules.SelectedIndexChanged += new System.EventHandler(this.tcModules_SelectedIndexChanged);
            // 
            // tpReaction
            // 
            this.tpReaction.Controls.Add(this.dgvReaction);
            this.tpReaction.Location = new System.Drawing.Point(4, 28);
            this.tpReaction.Name = "tpReaction";
            this.tpReaction.Padding = new System.Windows.Forms.Padding(3);
            this.tpReaction.Size = new System.Drawing.Size(870, 268);
            this.tpReaction.TabIndex = 0;
            this.tpReaction.Text = "Reaction Analysis";
            this.tpReaction.UseVisualStyleBackColor = true;
            // 
            // dgvReaction
            // 
            this.dgvReaction.AllowUserToAddRows = false;
            this.dgvReaction.AllowUserToDeleteRows = false;
            this.dgvReaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRaDocId,
            this.colRaDocName,
            this.colRaAssignTo,
            this.colRaAssignedDate,
            this.colRaStatus});
            this.dgvReaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaction.Location = new System.Drawing.Point(3, 3);
            this.dgvReaction.Name = "dgvReaction";
            this.dgvReaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReaction.Size = new System.Drawing.Size(864, 262);
            this.dgvReaction.TabIndex = 2;
            // 
            // colRaDocId
            // 
            this.colRaDocId.FillWeight = 50.76142F;
            this.colRaDocId.HeaderText = "Doc Id";
            this.colRaDocId.Name = "colRaDocId";
            this.colRaDocId.Visible = false;
            // 
            // colRaDocName
            // 
            this.colRaDocName.HeaderText = "Doc Name";
            this.colRaDocName.Name = "colRaDocName";
            // 
            // colRaAssignTo
            // 
            this.colRaAssignTo.HeaderText = "Assign To";
            this.colRaAssignTo.Name = "colRaAssignTo";
            // 
            // colRaAssignedDate
            // 
            this.colRaAssignedDate.HeaderText = "Assigned Date";
            this.colRaAssignedDate.Name = "colRaAssignedDate";
            // 
            // colRaStatus
            // 
            this.colRaStatus.FillWeight = 112.3096F;
            this.colRaStatus.HeaderText = "Status";
            this.colRaStatus.Name = "colRaStatus";
            // 
            // tpSpectral
            // 
            this.tpSpectral.Controls.Add(this.dgvSpectral);
            this.tpSpectral.Location = new System.Drawing.Point(4, 28);
            this.tpSpectral.Name = "tpSpectral";
            this.tpSpectral.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpectral.Size = new System.Drawing.Size(870, 268);
            this.tpSpectral.TabIndex = 1;
            this.tpSpectral.Text = "Spectral Analysis";
            this.tpSpectral.UseVisualStyleBackColor = true;
            // 
            // dgvSpectral
            // 
            this.dgvSpectral.AllowUserToAddRows = false;
            this.dgvSpectral.AllowUserToDeleteRows = false;
            this.dgvSpectral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpectral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpectral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaDocId,
            this.colSpDocName,
            this.colSpAssignTo,
            this.colSpAssignDate,
            this.colSpStatus});
            this.dgvSpectral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpectral.Location = new System.Drawing.Point(3, 3);
            this.dgvSpectral.Name = "dgvSpectral";
            this.dgvSpectral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpectral.Size = new System.Drawing.Size(864, 262);
            this.dgvSpectral.TabIndex = 2;
            // 
            // colSaDocId
            // 
            this.colSaDocId.FillWeight = 50.76142F;
            this.colSaDocId.HeaderText = "Doc Id";
            this.colSaDocId.Name = "colSaDocId";
            this.colSaDocId.Visible = false;
            // 
            // colSpDocName
            // 
            this.colSpDocName.HeaderText = "Doc Name";
            this.colSpDocName.Name = "colSpDocName";
            // 
            // colSpAssignTo
            // 
            this.colSpAssignTo.HeaderText = "Assign To";
            this.colSpAssignTo.Name = "colSpAssignTo";
            // 
            // colSpAssignDate
            // 
            this.colSpAssignDate.HeaderText = "Assigned Date";
            this.colSpAssignDate.Name = "colSpAssignDate";
            // 
            // colSpStatus
            // 
            this.colSpStatus.FillWeight = 112.3096F;
            this.colSpStatus.HeaderText = "Status";
            this.colSpStatus.Name = "colSpStatus";
            // 
            // tpTaskPrep
            // 
            this.tpTaskPrep.Controls.Add(this.dgvTaskPrep);
            this.tpTaskPrep.Location = new System.Drawing.Point(4, 28);
            this.tpTaskPrep.Name = "tpTaskPrep";
            this.tpTaskPrep.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaskPrep.Size = new System.Drawing.Size(870, 268);
            this.tpTaskPrep.TabIndex = 2;
            this.tpTaskPrep.Text = "Task Preparation";
            this.tpTaskPrep.UseVisualStyleBackColor = true;
            // 
            // dgvTaskPrep
            // 
            this.dgvTaskPrep.AllowUserToAddRows = false;
            this.dgvTaskPrep.AllowUserToDeleteRows = false;
            this.dgvTaskPrep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskPrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskPrep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTpShipmentId,
            this.colTpShipmentName,
            this.colTpAssignedTo,
            this.colTpAssignedDate,
            this.colTpEndDate,
            this.colTpStatus});
            this.dgvTaskPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskPrep.Location = new System.Drawing.Point(3, 3);
            this.dgvTaskPrep.Name = "dgvTaskPrep";
            this.dgvTaskPrep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskPrep.Size = new System.Drawing.Size(864, 262);
            this.dgvTaskPrep.TabIndex = 2;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmbShipmentName);
            this.pnlControls.Controls.Add(this.lblShipment);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(878, 39);
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
            // colTpShipmentId
            // 
            this.colTpShipmentId.FillWeight = 50.76142F;
            this.colTpShipmentId.HeaderText = "Shipment Id";
            this.colTpShipmentId.Name = "colTpShipmentId";
            this.colTpShipmentId.Visible = false;
            // 
            // colTpShipmentName
            // 
            this.colTpShipmentName.HeaderText = "Shipment Name";
            this.colTpShipmentName.Name = "colTpShipmentName";
            // 
            // colTpAssignedTo
            // 
            this.colTpAssignedTo.HeaderText = "Assign To";
            this.colTpAssignedTo.Name = "colTpAssignedTo";
            // 
            // colTpAssignedDate
            // 
            this.colTpAssignedDate.HeaderText = "Assigned Date";
            this.colTpAssignedDate.Name = "colTpAssignedDate";
            // 
            // colTpEndDate
            // 
            this.colTpEndDate.HeaderText = "End Date";
            this.colTpEndDate.Name = "colTpEndDate";
            // 
            // colTpStatus
            // 
            this.colTpStatus.FillWeight = 112.3096F;
            this.colTpStatus.HeaderText = "Status";
            this.colTpStatus.Name = "colTpStatus";
            // 
            // FrmTaskSheetDM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 339);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTaskSheetDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Sheet";
            this.Load += new System.EventHandler(this.FrmTaskSheetPM_DM_TP_Load);
            this.pnlMain.ResumeLayout(false);
            this.tcModules.ResumeLayout(false);
            this.tpReaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaction)).EndInit();
            this.tpSpectral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectral)).EndInit();
            this.tpTaskPrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskPrep)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipment;
        private System.Windows.Forms.TabControl tcModules;
        private System.Windows.Forms.TabPage tpReaction;
        private System.Windows.Forms.DataGridView dgvReaction;
        private System.Windows.Forms.TabPage tpSpectral;
        private System.Windows.Forms.DataGridView dgvSpectral;
        private System.Windows.Forms.TabPage tpTaskPrep;
        private System.Windows.Forms.DataGridView dgvTaskPrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaAssignTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpAssignTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpShipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpAssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpStatus;
    }
}