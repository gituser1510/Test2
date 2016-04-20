namespace ChemInform.TaskSheets
{
    partial class FrmTaskSheetPM_DM
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipment = new System.Windows.Forms.Label();
            this.tcModules = new System.Windows.Forms.TabControl();
            this.tpReaction = new System.Windows.Forms.TabPage();
            this.tpSpectral = new System.Windows.Forms.TabPage();
            this.tpTaskPrep = new System.Windows.Forms.TabPage();
            this.dgvReaction = new System.Windows.Forms.DataGridView();
            this.ColShipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpectral = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTaskPrep = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.tcModules.SuspendLayout();
            this.tpReaction.SuspendLayout();
            this.tpSpectral.SuspendLayout();
            this.tpTaskPrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskPrep)).BeginInit();
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
            // dgvReaction
            // 
            this.dgvReaction.AllowUserToAddRows = false;
            this.dgvReaction.AllowUserToDeleteRows = false;
            this.dgvReaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColShipmentId,
            this.ColShipmentName,
            this.colAssignTo,
            this.ColAssignedDate,
            this.ColStatus});
            this.dgvReaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaction.Location = new System.Drawing.Point(3, 3);
            this.dgvReaction.Name = "dgvReaction";
            this.dgvReaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReaction.Size = new System.Drawing.Size(864, 262);
            this.dgvReaction.TabIndex = 2;
            // 
            // ColShipmentId
            // 
            this.ColShipmentId.FillWeight = 50.76142F;
            this.ColShipmentId.HeaderText = "Shipment Id";
            this.ColShipmentId.Name = "ColShipmentId";
            this.ColShipmentId.Visible = false;
            // 
            // ColShipmentName
            // 
            this.ColShipmentName.HeaderText = "Shipment Name";
            this.ColShipmentName.Name = "ColShipmentName";
            // 
            // colAssignTo
            // 
            this.colAssignTo.HeaderText = "Assign To";
            this.colAssignTo.Name = "colAssignTo";
            // 
            // ColAssignedDate
            // 
            this.ColAssignedDate.HeaderText = "Assigned Date";
            this.ColAssignedDate.Name = "ColAssignedDate";
            // 
            // ColStatus
            // 
            this.ColStatus.FillWeight = 112.3096F;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // dgvSpectral
            // 
            this.dgvSpectral.AllowUserToAddRows = false;
            this.dgvSpectral.AllowUserToDeleteRows = false;
            this.dgvSpectral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpectral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpectral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvSpectral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpectral.Location = new System.Drawing.Point(3, 3);
            this.dgvSpectral.Name = "dgvSpectral";
            this.dgvSpectral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpectral.Size = new System.Drawing.Size(864, 262);
            this.dgvSpectral.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Shipment Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Shipment Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Assign To";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Assigned Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 112.3096F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dgvTaskPrep
            // 
            this.dgvTaskPrep.AllowUserToAddRows = false;
            this.dgvTaskPrep.AllowUserToDeleteRows = false;
            this.dgvTaskPrep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskPrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskPrep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvTaskPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskPrep.Location = new System.Drawing.Point(3, 3);
            this.dgvTaskPrep.Name = "dgvTaskPrep";
            this.dgvTaskPrep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskPrep.Size = new System.Drawing.Size(864, 262);
            this.dgvTaskPrep.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Shipment Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Shipment Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Assign To";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Assigned Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 112.3096F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmTaskSheetPM_DM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 339);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTaskSheetPM_DM";
            this.Text = "Task Sheet";
            this.Load += new System.EventHandler(this.FrmTaskSheetPM_DM_TP_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.tcModules.ResumeLayout(false);
            this.tpReaction.ResumeLayout(false);
            this.tpSpectral.ResumeLayout(false);
            this.tpTaskPrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpectral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskPrep)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.TabPage tpSpectral;
        private System.Windows.Forms.DataGridView dgvSpectral;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tpTaskPrep;
        private System.Windows.Forms.DataGridView dgvTaskPrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}