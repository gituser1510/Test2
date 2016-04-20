namespace ChemInform
{
    partial class FrmExportXml
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
            this.dgvExportXml = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.lblFoldLoc = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.lblShipMentName = new System.Windows.Forms.Label();
            this.btnExportToXml = new System.Windows.Forms.Button();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXmlStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportXml)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvExportXml);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 487);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvExportXml
            // 
            this.dgvExportXml.AllowUserToAddRows = false;
            this.dgvExportXml.AllowUserToDeleteRows = false;
            this.dgvExportXml.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportXml.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExportXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportXml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect,
            this.ColDocName,
            this.ColXmlStatus});
            this.dgvExportXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExportXml.Location = new System.Drawing.Point(0, 45);
            this.dgvExportXml.Name = "dgvExportXml";
            this.dgvExportXml.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportXml.Size = new System.Drawing.Size(980, 398);
            this.dgvExportXml.TabIndex = 1;
            this.dgvExportXml.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvExportXml_RowPostPaint);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.btnExportToXml);
            this.pnlBottom.Controls.Add(this.btnBrowseFolder);
            this.pnlBottom.Controls.Add(this.lblFoldLoc);
            this.pnlBottom.Controls.Add(this.txtFolderPath);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 443);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(980, 44);
            this.pnlBottom.TabIndex = 6;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(381, 8);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(42, 23);
            this.btnBrowseFolder.TabIndex = 6;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // lblFoldLoc
            // 
            this.lblFoldLoc.AutoSize = true;
            this.lblFoldLoc.Location = new System.Drawing.Point(12, 12);
            this.lblFoldLoc.Name = "lblFoldLoc";
            this.lblFoldLoc.Size = new System.Drawing.Size(106, 19);
            this.lblFoldLoc.TabIndex = 4;
            this.lblFoldLoc.Text = "Folder Location";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Location = new System.Drawing.Point(124, 8);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(251, 26);
            this.txtFolderPath.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.cmbShipmentName);
            this.pnlTop.Controls.Add(this.lblShipMentName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(980, 45);
            this.pnlTop.TabIndex = 2;
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Location = new System.Drawing.Point(122, 7);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(322, 27);
            this.cmbShipmentName.TabIndex = 32;
            this.cmbShipmentName.SelectedIndexChanged += new System.EventHandler(this.cmbShipmentName_SelectedIndexChanged);
            // 
            // lblShipMentName
            // 
            this.lblShipMentName.AutoSize = true;
            this.lblShipMentName.Location = new System.Drawing.Point(12, 11);
            this.lblShipMentName.Name = "lblShipMentName";
            this.lblShipMentName.Size = new System.Drawing.Size(106, 19);
            this.lblShipMentName.TabIndex = 31;
            this.lblShipMentName.Text = "Shipment Name";
            // 
            // btnExportToXml
            // 
            this.btnExportToXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToXml.Location = new System.Drawing.Point(860, 7);
            this.btnExportToXml.Name = "btnExportToXml";
            this.btnExportToXml.Size = new System.Drawing.Size(107, 27);
            this.btnExportToXml.TabIndex = 33;
            this.btnExportToXml.Text = "Export To Xml";
            this.btnExportToXml.UseVisualStyleBackColor = true;
            this.btnExportToXml.Click += new System.EventHandler(this.btnExportToXml_Click);
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.FillWeight = 22.91879F;
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            // 
            // ColDocName
            // 
            this.ColDocName.FillWeight = 214.2907F;
            this.ColDocName.HeaderText = "Document Name";
            this.ColDocName.Name = "ColDocName";
            this.ColDocName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDocName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColXmlStatus
            // 
            this.ColXmlStatus.FillWeight = 214.2907F;
            this.ColXmlStatus.HeaderText = "Xml Status";
            this.ColXmlStatus.Name = "ColXmlStatus";
            // 
            // FrmExportXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 487);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmExportXml";
            this.Text = "Export Xml";
            this.Load += new System.EventHandler(this.FrmExportXml_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportXml)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvExportXml;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Label lblFoldLoc;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Label lblShipMentName;
        private System.Windows.Forms.Button btnExportToXml;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColXmlStatus;


    }
}