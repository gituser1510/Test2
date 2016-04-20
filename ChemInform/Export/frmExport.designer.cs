namespace ChemInform
{
    partial class frmExport
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
            this.dgvShipmentDocs = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStartMdl = new System.Windows.Forms.Label();
            this.txtMDLNo = new System.Windows.Forms.TextBox();
            this.chkExpClientDelivery = new System.Windows.Forms.CheckBox();
            this.btnFolderSel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.lblShipment = new System.Windows.Forms.Label();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colShipmentRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDocs)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvShipmentDocs);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1226, 481);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvShipmentDocs
            // 
            this.dgvShipmentDocs.AllowUserToAddRows = false;
            this.dgvShipmentDocs.AllowUserToDeleteRows = false;
            this.dgvShipmentDocs.AllowUserToResizeColumns = false;
            this.dgvShipmentDocs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShipmentDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colShipmentRefID,
            this.colReferenceName,
            this.colReferenceStatus});
            this.dgvShipmentDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShipmentDocs.Location = new System.Drawing.Point(0, 39);
            this.dgvShipmentDocs.Name = "dgvShipmentDocs";
            this.dgvShipmentDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipmentDocs.Size = new System.Drawing.Size(1226, 406);
            this.dgvShipmentDocs.TabIndex = 41;
            this.dgvShipmentDocs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvShipmentDocs_RowPostPaint);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblStartMdl);
            this.pnlBottom.Controls.Add(this.txtMDLNo);
            this.pnlBottom.Controls.Add(this.chkExpClientDelivery);
            this.pnlBottom.Controls.Add(this.btnFolderSel);
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Controls.Add(this.txtFolderPath);
            this.pnlBottom.Controls.Add(this.lblSaveFolder);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 445);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1226, 36);
            this.pnlBottom.TabIndex = 40;
            // 
            // lblStartMdl
            // 
            this.lblStartMdl.AutoSize = true;
            this.lblStartMdl.Location = new System.Drawing.Point(643, 8);
            this.lblStartMdl.Name = "lblStartMdl";
            this.lblStartMdl.Size = new System.Drawing.Size(98, 17);
            this.lblStartMdl.TabIndex = 40;
            this.lblStartMdl.Text = "Start MDL No.";
            // 
            // txtMDLNo
            // 
            this.txtMDLNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDLNo.ForeColor = System.Drawing.Color.Blue;
            this.txtMDLNo.Location = new System.Drawing.Point(742, 4);
            this.txtMDLNo.Name = "txtMDLNo";
            this.txtMDLNo.Size = new System.Drawing.Size(98, 25);
            this.txtMDLNo.TabIndex = 39;
            // 
            // chkExpClientDelivery
            // 
            this.chkExpClientDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExpClientDelivery.AutoSize = true;
            this.chkExpClientDelivery.Location = new System.Drawing.Point(963, 6);
            this.chkExpClientDelivery.Name = "chkExpClientDelivery";
            this.chkExpClientDelivery.Size = new System.Drawing.Size(179, 21);
            this.chkExpClientDelivery.TabIndex = 37;
            this.chkExpClientDelivery.Text = "Export for Client Delivery";
            this.chkExpClientDelivery.UseVisualStyleBackColor = true;
            // 
            // btnFolderSel
            // 
            this.btnFolderSel.Location = new System.Drawing.Point(574, 4);
            this.btnFolderSel.Name = "btnFolderSel";
            this.btnFolderSel.Size = new System.Drawing.Size(30, 26);
            this.btnFolderSel.TabIndex = 38;
            this.btnFolderSel.Text = "...";
            this.btnFolderSel.UseVisualStyleBackColor = true;
            this.btnFolderSel.Click += new System.EventHandler(this.btnFolderSel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1148, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 30);
            this.btnExport.TabIndex = 36;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Location = new System.Drawing.Point(104, 4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(464, 25);
            this.txtFolderPath.TabIndex = 8;
            // 
            // lblSaveFolder
            // 
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Location = new System.Drawing.Point(3, 8);
            this.lblSaveFolder.Name = "lblSaveFolder";
            this.lblSaveFolder.Size = new System.Drawing.Size(89, 17);
            this.lblSaveFolder.TabIndex = 3;
            this.lblSaveFolder.Text = "Output Folder";
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControls.Controls.Add(this.cmbModule);
            this.pnlControls.Controls.Add(this.lblModule);
            this.pnlControls.Controls.Add(this.cmbShipment);
            this.pnlControls.Controls.Add(this.lblShipment);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1226, 39);
            this.pnlControls.TabIndex = 39;
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "Reaction Analysis",
            "Spectral Analysis"});
            this.cmbModule.Location = new System.Drawing.Point(63, 4);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(220, 25);
            this.cmbModule.TabIndex = 28;
            this.cmbModule.SelectedIndexChanged += new System.EventHandler(this.cmbModule_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(5, 8);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(52, 17);
            this.lblModule.TabIndex = 27;
            this.lblModule.Text = "Module";
            // 
            // cmbShipment
            // 
            this.cmbShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(375, 4);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(241, 25);
            this.cmbShipment.TabIndex = 4;
            this.cmbShipment.SelectedIndexChanged += new System.EventHandler(this.cmbShipment_SelectedIndexChanged);            
            // 
            // lblShipment
            // 
            this.lblShipment.AutoSize = true;
            this.lblShipment.Location = new System.Drawing.Point(304, 8);
            this.lblShipment.Name = "lblShipment";
            this.lblShipment.Size = new System.Drawing.Size(62, 17);
            this.lblShipment.TabIndex = 1;
            this.lblShipment.Text = "Shipment";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TANID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "TAN Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSelect
            // 
            this.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 50;
            // 
            // colShipmentRefID
            // 
            this.colShipmentRefID.HeaderText = "ShipmentRefID";
            this.colShipmentRefID.Name = "colShipmentRefID";
            this.colShipmentRefID.ReadOnly = true;
            this.colShipmentRefID.Visible = false;
            // 
            // colReferenceName
            // 
            this.colReferenceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReferenceName.HeaderText = "ReferenceName";
            this.colReferenceName.Name = "colReferenceName";
            this.colReferenceName.ReadOnly = true;
            this.colReferenceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReferenceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colReferenceStatus
            // 
            this.colReferenceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReferenceStatus.HeaderText = "ReferenceStatus";
            this.colReferenceStatus.Name = "colReferenceStatus";
            this.colReferenceStatus.ReadOnly = true;
            this.colReferenceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReferenceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "TAN";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "TAN Status";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "Section Name";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Section Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Team Lead";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmExport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1226, 481);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipment Export";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDocs)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.Button btnFolderSel;
        private System.Windows.Forms.Label lblShipment;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.DataGridView dgvShipmentDocs;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private System.Windows.Forms.CheckBox chkExpClientDelivery;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceStatus;
        private System.Windows.Forms.Label lblStartMdl;
        private System.Windows.Forms.TextBox txtMDLNo;
    }
}