namespace ChemInform
{
    partial class frmCreateShipment
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
            this.dgvShipmentDetails = new System.Windows.Forms.DataGridView();
            this.ColSmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbstractCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmDownloadedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmDownloadedFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSmTaskPrepStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbstractRefsCount = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDownloadDate = new System.Windows.Forms.DateTimePicker();
            this.txtDownloadedFileName = new System.Windows.Forms.TextBox();
            this.txtShipmentName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblDownloadedFile = new System.Windows.Forms.Label();
            this.lblDownLoadDate = new System.Windows.Forms.Label();
            this.lblShipmentType = new System.Windows.Forms.Label();
            this.lblShipmentName = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDetails)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvShipmentDetails);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1079, 481);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvShipmentDetails
            // 
            this.dgvShipmentDetails.AllowUserToAddRows = false;
            this.dgvShipmentDetails.AllowUserToDeleteRows = false;
            this.dgvShipmentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShipmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShipmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSmId,
            this.ColSmName,
            this.ColSmType,
            this.colAbstractCount,
            this.ColSmDownloadedDate,
            this.ColSmDeliveryDate,
            this.ColSmDownloadedFile,
            this.ColSmTaskPrepStatus});
            this.dgvShipmentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShipmentDetails.Location = new System.Drawing.Point(0, 95);
            this.dgvShipmentDetails.Name = "dgvShipmentDetails";
            this.dgvShipmentDetails.ReadOnly = true;
            this.dgvShipmentDetails.Size = new System.Drawing.Size(1079, 386);
            this.dgvShipmentDetails.TabIndex = 1;
            this.dgvShipmentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipmentDetails_CellClick);
            this.dgvShipmentDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvShipmentDetails_RowPostPaint);
            // 
            // ColSmId
            // 
            this.ColSmId.HeaderText = "ShipmentId";
            this.ColSmId.Name = "ColSmId";
            this.ColSmId.ReadOnly = true;
            this.ColSmId.Visible = false;
            // 
            // ColSmName
            // 
            this.ColSmName.FillWeight = 126.5512F;
            this.ColSmName.HeaderText = "Shipment Name";
            this.ColSmName.Name = "ColSmName";
            this.ColSmName.ReadOnly = true;
            // 
            // ColSmType
            // 
            this.ColSmType.FillWeight = 73.42883F;
            this.ColSmType.HeaderText = "Type";
            this.ColSmType.Name = "ColSmType";
            this.ColSmType.ReadOnly = true;
            // 
            // colAbstractCount
            // 
            this.colAbstractCount.HeaderText = "RefCount";
            this.colAbstractCount.Name = "colAbstractCount";
            this.colAbstractCount.ReadOnly = true;
            // 
            // ColSmDownloadedDate
            // 
            this.ColSmDownloadedDate.FillWeight = 126.5512F;
            this.ColSmDownloadedDate.HeaderText = "Downloaded Date";
            this.ColSmDownloadedDate.Name = "ColSmDownloadedDate";
            this.ColSmDownloadedDate.ReadOnly = true;
            // 
            // ColSmDeliveryDate
            // 
            this.ColSmDeliveryDate.FillWeight = 126.5512F;
            this.ColSmDeliveryDate.HeaderText = "Delivery Date";
            this.ColSmDeliveryDate.Name = "ColSmDeliveryDate";
            this.ColSmDeliveryDate.ReadOnly = true;
            // 
            // ColSmDownloadedFile
            // 
            this.ColSmDownloadedFile.FillWeight = 126.5512F;
            this.ColSmDownloadedFile.HeaderText = "Downloaded File";
            this.ColSmDownloadedFile.Name = "ColSmDownloadedFile";
            this.ColSmDownloadedFile.ReadOnly = true;
            // 
            // ColSmTaskPrepStatus
            // 
            this.ColSmTaskPrepStatus.FillWeight = 49.30017F;
            this.ColSmTaskPrepStatus.HeaderText = "Status";
            this.ColSmTaskPrepStatus.Name = "ColSmTaskPrepStatus";
            this.ColSmTaskPrepStatus.ReadOnly = true;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControls.Controls.Add(this.btnBrowse);
            this.pnlControls.Controls.Add(this.lblIssue);
            this.pnlControls.Controls.Add(this.txtIssue);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.txtYear);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.txtAbstractRefsCount);
            this.pnlControls.Controls.Add(this.btnReset);
            this.pnlControls.Controls.Add(this.cmbType);
            this.pnlControls.Controls.Add(this.dtpDeliveryDate);
            this.pnlControls.Controls.Add(this.dtpDownloadDate);
            this.pnlControls.Controls.Add(this.txtDownloadedFileName);
            this.pnlControls.Controls.Add(this.txtShipmentName);
            this.pnlControls.Controls.Add(this.btnCreate);
            this.pnlControls.Controls.Add(this.lblDeliveryDate);
            this.pnlControls.Controls.Add(this.lblDownloadedFile);
            this.pnlControls.Controls.Add(this.lblDownLoadDate);
            this.pnlControls.Controls.Add(this.lblShipmentType);
            this.pnlControls.Controls.Add(this.lblShipmentName);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1079, 95);
            this.pnlControls.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(370, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(664, 9);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(39, 17);
            this.lblIssue.TabIndex = 13;
            this.lblIssue.Text = "Issue";
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.SeaShell;
            this.txtIssue.Location = new System.Drawing.Point(709, 5);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(79, 25);
            this.txtIssue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.SeaShell;
            this.txtYear.Location = new System.Drawing.Point(550, 5);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(79, 25);
            this.txtYear.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Abstracts Count";
            // 
            // txtAbstractRefsCount
            // 
            this.txtAbstractRefsCount.Location = new System.Drawing.Point(550, 35);
            this.txtAbstractRefsCount.Name = "txtAbstractRefsCount";
            this.txtAbstractRefsCount.Size = new System.Drawing.Size(79, 25);
            this.txtAbstractRefsCount.TabIndex = 8;
            this.txtAbstractRefsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbstractRefsCount_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(929, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 25);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "ABSTRACT",
            "FULLTEXT"});
            this.cmbType.Location = new System.Drawing.Point(918, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(128, 25);
            this.cmbType.TabIndex = 2;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(550, 65);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(226, 25);
            this.dtpDeliveryDate.TabIndex = 5;
            // 
            // dtpDownloadDate
            // 
            this.dtpDownloadDate.CustomFormat = "";
            this.dtpDownloadDate.Location = new System.Drawing.Point(137, 65);
            this.dtpDownloadDate.Name = "dtpDownloadDate";
            this.dtpDownloadDate.Size = new System.Drawing.Size(226, 25);
            this.dtpDownloadDate.TabIndex = 4;
            // 
            // txtDownloadedFileName
            // 
            this.txtDownloadedFileName.Location = new System.Drawing.Point(137, 35);
            this.txtDownloadedFileName.Name = "txtDownloadedFileName";
            this.txtDownloadedFileName.Size = new System.Drawing.Size(226, 25);
            this.txtDownloadedFileName.TabIndex = 3;
            // 
            // txtShipmentName
            // 
            this.txtShipmentName.Location = new System.Drawing.Point(137, 5);
            this.txtShipmentName.Name = "txtShipmentName";
            this.txtShipmentName.Size = new System.Drawing.Size(226, 25);
            this.txtShipmentName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(1005, 67);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(70, 25);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(453, 69);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(91, 17);
            this.lblDeliveryDate.TabIndex = 0;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblDownloadedFile
            // 
            this.lblDownloadedFile.AutoSize = true;
            this.lblDownloadedFile.Location = new System.Drawing.Point(24, 38);
            this.lblDownloadedFile.Name = "lblDownloadedFile";
            this.lblDownloadedFile.Size = new System.Drawing.Size(107, 17);
            this.lblDownloadedFile.TabIndex = 0;
            this.lblDownloadedFile.Text = "Downloaded File";
            // 
            // lblDownLoadDate
            // 
            this.lblDownLoadDate.AutoSize = true;
            this.lblDownLoadDate.Location = new System.Drawing.Point(30, 69);
            this.lblDownLoadDate.Name = "lblDownLoadDate";
            this.lblDownLoadDate.Size = new System.Drawing.Size(101, 17);
            this.lblDownLoadDate.TabIndex = 0;
            this.lblDownLoadDate.Text = "Download Date";
            // 
            // lblShipmentType
            // 
            this.lblShipmentType.AutoSize = true;
            this.lblShipmentType.Location = new System.Drawing.Point(817, 8);
            this.lblShipmentType.Name = "lblShipmentType";
            this.lblShipmentType.Size = new System.Drawing.Size(95, 17);
            this.lblShipmentType.TabIndex = 0;
            this.lblShipmentType.Text = "Shipment Type";
            // 
            // lblShipmentName
            // 
            this.lblShipmentName.AutoSize = true;
            this.lblShipmentName.Location = new System.Drawing.Point(29, 8);
            this.lblShipmentName.Name = "lblShipmentName";
            this.lblShipmentName.Size = new System.Drawing.Size(102, 17);
            this.lblShipmentName.TabIndex = 0;
            this.lblShipmentName.Text = "Shipment Name";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ShipmentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 126.5512F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Shipment Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 73.42883F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "RefCount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 142;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 126.5512F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Downloaded Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 126.5512F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Delivery Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 126.5512F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Downloaded File";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 180;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 49.30017F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 42.63958F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::ChemInform.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 63;
            // 
            // frmCreateShipment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1079, 481);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmCreateShipment";
            this.ShowIcon = false;
            this.Text = "Create Shipment";
            this.Load += new System.EventHandler(this.FrmCreateShipment_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentDetails)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvShipmentDetails;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDownloadDate;
        private System.Windows.Forms.TextBox txtDownloadedFileName;
        private System.Windows.Forms.TextBox txtShipmentName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblDownloadedFile;
        private System.Windows.Forms.Label lblDownLoadDate;
        private System.Windows.Forms.Label lblShipmentType;
        private System.Windows.Forms.Label lblShipmentName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbstractRefsCount;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbstractCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmDownloadedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmDownloadedFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSmTaskPrepStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

    }
}