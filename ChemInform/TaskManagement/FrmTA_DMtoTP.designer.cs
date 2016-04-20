namespace ChemInform.Task_Management
{
    partial class FrmTA_DMtoTP
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvAssignedTaskPreparation = new System.Windows.Forms.DataGridView();
            this.pnlCntrls = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblShipMentName = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.ColTpShipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPShipMentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTpEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTaskPreparation)).BeginInit();
            this.pnlCntrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvAssignedTaskPreparation);
            this.pnlMain.Controls.Add(this.pnlCntrls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(968, 426);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvAssignedTaskPreparation
            // 
            this.dgvAssignedTaskPreparation.AllowUserToAddRows = false;
            this.dgvAssignedTaskPreparation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignedTaskPreparation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignedTaskPreparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedTaskPreparation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssignedTaskPreparation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssignedTaskPreparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedTaskPreparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTpShipmentId,
            this.colTPShipMentName,
            this.colTPAssignedTo,
            this.colTPAssignedDate,
            this.colTpEndDate,
            this.colTPStatus});
            this.dgvAssignedTaskPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedTaskPreparation.Location = new System.Drawing.Point(0, 39);
            this.dgvAssignedTaskPreparation.Name = "dgvAssignedTaskPreparation";
            this.dgvAssignedTaskPreparation.ReadOnly = true;
            this.dgvAssignedTaskPreparation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedTaskPreparation.Size = new System.Drawing.Size(968, 387);
            this.dgvAssignedTaskPreparation.TabIndex = 41;
            this.dgvAssignedTaskPreparation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAssignedTaskPreparation_RowPostPaint);
            // 
            // pnlCntrls
            // 
            this.pnlCntrls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCntrls.Controls.Add(this.cmbShipmentName);
            this.pnlCntrls.Controls.Add(this.cmbUserName);
            this.pnlCntrls.Controls.Add(this.lblUserName);
            this.pnlCntrls.Controls.Add(this.lblShipMentName);
            this.pnlCntrls.Controls.Add(this.btnAssign);
            this.pnlCntrls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCntrls.Location = new System.Drawing.Point(0, 0);
            this.pnlCntrls.Name = "pnlCntrls";
            this.pnlCntrls.Size = new System.Drawing.Size(968, 39);
            this.pnlCntrls.TabIndex = 40;
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Location = new System.Drawing.Point(120, 6);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(281, 25);
            this.cmbShipmentName.TabIndex = 30;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(565, 6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(281, 25);
            this.cmbUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(416, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(143, 17);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "Task Preparation users";
            // 
            // lblShipMentName
            // 
            this.lblShipMentName.AutoSize = true;
            this.lblShipMentName.Location = new System.Drawing.Point(10, 9);
            this.lblShipMentName.Name = "lblShipMentName";
            this.lblShipMentName.Size = new System.Drawing.Size(104, 17);
            this.lblShipMentName.TabIndex = 16;
            this.lblShipMentName.Text = "ShipMent Name";
            // 
            // btnAssign
            // 
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Location = new System.Drawing.Point(880, 6);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 25);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // ColTpShipmentId
            // 
            this.ColTpShipmentId.HeaderText = "Id";
            this.ColTpShipmentId.Name = "ColTpShipmentId";
            this.ColTpShipmentId.ReadOnly = true;
            this.ColTpShipmentId.Visible = false;
            // 
            // colTPShipMentName
            // 
            this.colTPShipMentName.FillWeight = 247.1923F;
            this.colTPShipMentName.HeaderText = "ShipMent Name";
            this.colTPShipMentName.Name = "colTPShipMentName";
            this.colTPShipMentName.ReadOnly = true;
            // 
            // colTPAssignedTo
            // 
            this.colTPAssignedTo.FillWeight = 297.0175F;
            this.colTPAssignedTo.HeaderText = "Assigned To";
            this.colTPAssignedTo.Name = "colTPAssignedTo";
            this.colTPAssignedTo.ReadOnly = true;
            // 
            // colTPAssignedDate
            // 
            this.colTPAssignedDate.FillWeight = 312.7642F;
            this.colTPAssignedDate.HeaderText = "Assigned Date";
            this.colTPAssignedDate.Name = "colTPAssignedDate";
            this.colTPAssignedDate.ReadOnly = true;
            // 
            // colTpEndDate
            // 
            this.colTpEndDate.FillWeight = 236.9566F;
            this.colTpEndDate.HeaderText = "End Date";
            this.colTpEndDate.Name = "colTpEndDate";
            this.colTpEndDate.ReadOnly = true;
            // 
            // colTPStatus
            // 
            this.colTPStatus.FillWeight = 278.7084F;
            this.colTPStatus.HeaderText = "Status";
            this.colTPStatus.Name = "colTPStatus";
            this.colTPStatus.ReadOnly = true;
            // 
            // FrmTA_DMtoTP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 426);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTA_DMtoTP";
            this.Text = "Task Allocation-Delivery Manager to Task Preparation";
            this.Load += new System.EventHandler(this.FrmTA_DMtoTP_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTaskPreparation)).EndInit();
            this.pnlCntrls.ResumeLayout(false);
            this.pnlCntrls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvAssignedTaskPreparation;
        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblShipMentName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTpShipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPShipMentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPAssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPStatus;
    }
}