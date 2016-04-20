namespace ChemInform
{
    partial class FrmPdfGererationOnAbstract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPdfGererationOnAbstract));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.Append = new System.Windows.Forms.Panel();
            this.tblCntrlGeneratedPdfs = new System.Windows.Forms.TabControl();
            this.tpPdf = new System.Windows.Forms.TabPage();
            this.acroPdfExport = new AxAcroPDFLib.AxAcroPDF();
            this.pnlOutputfileCntls = new System.Windows.Forms.Panel();
            this.chkNoReaction = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.rbAppend = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.txtDoi = new System.Windows.Forms.TextBox();
            this.lblDoi = new System.Windows.Forms.Label();
            this.tpPreview = new System.Windows.Forms.TabPage();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.tblpnlPreview = new System.Windows.Forms.TableLayoutPanel();
            this.acroPdfPreview = new AxAcroPDFLib.AxAcroPDF();
            this.tpGeneratedPdfs = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtPreviewFolderPath = new System.Windows.Forms.TextBox();
            this.btnPreviewFolder = new System.Windows.Forms.Button();
            this.lstvFolder = new System.Windows.Forms.ListView();
            this.lblPreviewOutPutfolder = new System.Windows.Forms.Label();
            this.acroPdfView = new AxAcroPDFLib.AxAcroPDF();
            this.pnlBrowseControls = new System.Windows.Forms.Panel();
            this.lnkSysNo = new System.Windows.Forms.LinkLabel();
            this.txtSysNoClassType = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lnkSysText = new System.Windows.Forms.LinkLabel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.txtAbstractRefNo = new System.Windows.Forms.TextBox();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.txtShipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSysNum = new System.Windows.Forms.TextBox();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.txtSysText = new System.Windows.Forms.TextBox();
            this.lblInPutFile = new System.Windows.Forms.Label();
            this.btnBrowsePdf = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.Append.SuspendLayout();
            this.tblCntrlGeneratedPdfs.SuspendLayout();
            this.tpPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfExport)).BeginInit();
            this.pnlOutputfileCntls.SuspendLayout();
            this.tpPreview.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.tblpnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfPreview)).BeginInit();
            this.tpGeneratedPdfs.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfView)).BeginInit();
            this.pnlBrowseControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.Append);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1097, 499);
            this.pnlMain.TabIndex = 1;
            // 
            // Append
            // 
            this.Append.Controls.Add(this.tblCntrlGeneratedPdfs);
            this.Append.Controls.Add(this.pnlBrowseControls);
            this.Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Append.Location = new System.Drawing.Point(0, 0);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(1097, 499);
            this.Append.TabIndex = 11;
            // 
            // tblCntrlGeneratedPdfs
            // 
            this.tblCntrlGeneratedPdfs.CausesValidation = false;
            this.tblCntrlGeneratedPdfs.Controls.Add(this.tpPdf);
            this.tblCntrlGeneratedPdfs.Controls.Add(this.tpPreview);
            this.tblCntrlGeneratedPdfs.Controls.Add(this.tpGeneratedPdfs);
            this.tblCntrlGeneratedPdfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCntrlGeneratedPdfs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCntrlGeneratedPdfs.Location = new System.Drawing.Point(0, 91);
            this.tblCntrlGeneratedPdfs.Name = "tblCntrlGeneratedPdfs";
            this.tblCntrlGeneratedPdfs.SelectedIndex = 0;
            this.tblCntrlGeneratedPdfs.Size = new System.Drawing.Size(1097, 408);
            this.tblCntrlGeneratedPdfs.TabIndex = 11;
            this.tblCntrlGeneratedPdfs.SelectedIndexChanged += new System.EventHandler(this.tbPdfs_SelectedIndexChanged);
            // 
            // tpPdf
            // 
            this.tpPdf.Controls.Add(this.acroPdfExport);
            this.tpPdf.Controls.Add(this.pnlOutputfileCntls);
            this.tpPdf.Location = new System.Drawing.Point(4, 26);
            this.tpPdf.Name = "tpPdf";
            this.tpPdf.Padding = new System.Windows.Forms.Padding(3);
            this.tpPdf.Size = new System.Drawing.Size(1089, 378);
            this.tpPdf.TabIndex = 0;
            this.tpPdf.Text = "Pdf";
            this.tpPdf.UseVisualStyleBackColor = true;
            // 
            // acroPdfExport
            // 
            this.acroPdfExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acroPdfExport.Enabled = true;
            this.acroPdfExport.Location = new System.Drawing.Point(3, 3);
            this.acroPdfExport.Name = "acroPdfExport";
            this.acroPdfExport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acroPdfExport.OcxState")));
            this.acroPdfExport.Size = new System.Drawing.Size(1083, 340);
            this.acroPdfExport.TabIndex = 0;
            // 
            // pnlOutputfileCntls
            // 
            this.pnlOutputfileCntls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOutputfileCntls.Controls.Add(this.chkNoReaction);
            this.pnlOutputfileCntls.Controls.Add(this.btnStop);
            this.pnlOutputfileCntls.Controls.Add(this.btnExportPdf);
            this.pnlOutputfileCntls.Controls.Add(this.rbAppend);
            this.pnlOutputfileCntls.Controls.Add(this.rbCreate);
            this.pnlOutputfileCntls.Controls.Add(this.txtDoi);
            this.pnlOutputfileCntls.Controls.Add(this.lblDoi);
            this.pnlOutputfileCntls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOutputfileCntls.Location = new System.Drawing.Point(3, 343);
            this.pnlOutputfileCntls.Name = "pnlOutputfileCntls";
            this.pnlOutputfileCntls.Size = new System.Drawing.Size(1083, 32);
            this.pnlOutputfileCntls.TabIndex = 14;
            // 
            // chkNoReaction
            // 
            this.chkNoReaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkNoReaction.AutoSize = true;
            this.chkNoReaction.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoReaction.Location = new System.Drawing.Point(468, 4);
            this.chkNoReaction.Name = "chkNoReaction";
            this.chkNoReaction.Size = new System.Drawing.Size(100, 21);
            this.chkNoReaction.TabIndex = 9;
            this.chkNoReaction.Text = "No Rections";
            this.chkNoReaction.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(996, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 28);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Complete";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPdf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPdf.Location = new System.Drawing.Point(918, 0);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(73, 28);
            this.btnExportPdf.TabIndex = 12;
            this.btnExportPdf.Text = "Create Pdf";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbAppend
            // 
            this.rbAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAppend.AutoSize = true;
            this.rbAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAppend.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAppend.Location = new System.Drawing.Point(689, 4);
            this.rbAppend.Name = "rbAppend";
            this.rbAppend.Size = new System.Drawing.Size(112, 21);
            this.rbAppend.TabIndex = 11;
            this.rbAppend.Text = "Append to Pdf";
            this.rbAppend.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCreate.AutoSize = true;
            this.rbCreate.Checked = true;
            this.rbCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCreate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreate.Location = new System.Drawing.Point(586, 4);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(91, 21);
            this.rbCreate.TabIndex = 10;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create Pdf";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // txtDoi
            // 
            this.txtDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDoi.Location = new System.Drawing.Point(61, 1);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(377, 25);
            this.txtDoi.TabIndex = 7;
            // 
            // lblDoi
            // 
            this.lblDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDoi.AutoSize = true;
            this.lblDoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoi.Location = new System.Drawing.Point(23, 5);
            this.lblDoi.Name = "lblDoi";
            this.lblDoi.Size = new System.Drawing.Size(35, 17);
            this.lblDoi.TabIndex = 0;
            this.lblDoi.Text = "DOI";
            // 
            // tpPreview
            // 
            this.tpPreview.Controls.Add(this.pnlPreview);
            this.tpPreview.Location = new System.Drawing.Point(4, 26);
            this.tpPreview.Name = "tpPreview";
            this.tpPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreview.Size = new System.Drawing.Size(1089, 378);
            this.tpPreview.TabIndex = 1;
            this.tpPreview.Text = "Preview";
            this.tpPreview.UseVisualStyleBackColor = true;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.tblpnlPreview);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(3, 3);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(1083, 372);
            this.pnlPreview.TabIndex = 13;
            // 
            // tblpnlPreview
            // 
            this.tblpnlPreview.ColumnCount = 1;
            this.tblpnlPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlPreview.Controls.Add(this.acroPdfPreview, 0, 0);
            this.tblpnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlPreview.Location = new System.Drawing.Point(0, 0);
            this.tblpnlPreview.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnlPreview.Name = "tblpnlPreview";
            this.tblpnlPreview.RowCount = 1;
            this.tblpnlPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlPreview.Size = new System.Drawing.Size(1083, 372);
            this.tblpnlPreview.TabIndex = 12;
            // 
            // acroPdfPreview
            // 
            this.acroPdfPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acroPdfPreview.Enabled = true;
            this.acroPdfPreview.Location = new System.Drawing.Point(0, 0);
            this.acroPdfPreview.Margin = new System.Windows.Forms.Padding(0);
            this.acroPdfPreview.Name = "acroPdfPreview";
            this.acroPdfPreview.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acroPdfPreview.OcxState")));
            this.acroPdfPreview.Size = new System.Drawing.Size(1083, 372);
            this.acroPdfPreview.TabIndex = 1;
            // 
            // tpGeneratedPdfs
            // 
            this.tpGeneratedPdfs.BackColor = System.Drawing.Color.White;
            this.tpGeneratedPdfs.Controls.Add(this.splitContainer1);
            this.tpGeneratedPdfs.Location = new System.Drawing.Point(4, 26);
            this.tpGeneratedPdfs.Name = "tpGeneratedPdfs";
            this.tpGeneratedPdfs.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneratedPdfs.Size = new System.Drawing.Size(1089, 378);
            this.tpGeneratedPdfs.TabIndex = 2;
            this.tpGeneratedPdfs.Text = "Total Generated Pdfs";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtPreviewFolderPath);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviewFolder);
            this.splitContainer1.Panel1.Controls.Add(this.lstvFolder);
            this.splitContainer1.Panel1.Controls.Add(this.lblPreviewOutPutfolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.acroPdfView);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 372);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtPreviewFolderPath
            // 
            this.txtPreviewFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPreviewFolderPath.BackColor = System.Drawing.Color.White;
            this.txtPreviewFolderPath.Location = new System.Drawing.Point(54, 5);
            this.txtPreviewFolderPath.Name = "txtPreviewFolderPath";
            this.txtPreviewFolderPath.ReadOnly = true;
            this.txtPreviewFolderPath.Size = new System.Drawing.Size(289, 25);
            this.txtPreviewFolderPath.TabIndex = 14;
            // 
            // btnPreviewFolder
            // 
            this.btnPreviewFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPreviewFolder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewFolder.Location = new System.Drawing.Point(352, 7);
            this.btnPreviewFolder.Name = "btnPreviewFolder";
            this.btnPreviewFolder.Size = new System.Drawing.Size(39, 23);
            this.btnPreviewFolder.TabIndex = 15;
            this.btnPreviewFolder.Text = "...";
            this.btnPreviewFolder.UseVisualStyleBackColor = true;
            this.btnPreviewFolder.Click += new System.EventHandler(this.btnPreviewFolder_Click);
            // 
            // lstvFolder
            // 
            this.lstvFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvFolder.Location = new System.Drawing.Point(0, 34);
            this.lstvFolder.Name = "lstvFolder";
            this.lstvFolder.Size = new System.Drawing.Size(393, 338);
            this.lstvFolder.TabIndex = 0;
            this.lstvFolder.UseCompatibleStateImageBehavior = false;
            this.lstvFolder.View = System.Windows.Forms.View.Details;
            this.lstvFolder.SelectedIndexChanged += new System.EventHandler(this.lstvFolder_SelectedIndexChanged);
            // 
            // lblPreviewOutPutfolder
            // 
            this.lblPreviewOutPutfolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPreviewOutPutfolder.AutoSize = true;
            this.lblPreviewOutPutfolder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewOutPutfolder.Location = new System.Drawing.Point(6, 10);
            this.lblPreviewOutPutfolder.Name = "lblPreviewOutPutfolder";
            this.lblPreviewOutPutfolder.Size = new System.Drawing.Size(45, 17);
            this.lblPreviewOutPutfolder.TabIndex = 13;
            this.lblPreviewOutPutfolder.Text = "Folder";
            // 
            // acroPdfView
            // 
            this.acroPdfView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acroPdfView.Enabled = true;
            this.acroPdfView.Location = new System.Drawing.Point(0, 0);
            this.acroPdfView.Margin = new System.Windows.Forms.Padding(0);
            this.acroPdfView.Name = "acroPdfView";
            this.acroPdfView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acroPdfView.OcxState")));
            this.acroPdfView.Size = new System.Drawing.Size(681, 372);
            this.acroPdfView.TabIndex = 2;
            // 
            // pnlBrowseControls
            // 
            this.pnlBrowseControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrowseControls.Controls.Add(this.lnkSysNo);
            this.pnlBrowseControls.Controls.Add(this.txtSysNoClassType);
            this.pnlBrowseControls.Controls.Add(this.lblYear);
            this.pnlBrowseControls.Controls.Add(this.label4);
            this.pnlBrowseControls.Controls.Add(this.lblIssue);
            this.pnlBrowseControls.Controls.Add(this.lnkSysText);
            this.pnlBrowseControls.Controls.Add(this.txtYear);
            this.pnlBrowseControls.Controls.Add(this.txtIssue);
            this.pnlBrowseControls.Controls.Add(this.txtAbstractRefNo);
            this.pnlBrowseControls.Controls.Add(this.lblAbstract);
            this.pnlBrowseControls.Controls.Add(this.txtShipment);
            this.pnlBrowseControls.Controls.Add(this.label3);
            this.pnlBrowseControls.Controls.Add(this.txtSysNum);
            this.pnlBrowseControls.Controls.Add(this.txtInputFilePath);
            this.pnlBrowseControls.Controls.Add(this.txtSysText);
            this.pnlBrowseControls.Controls.Add(this.lblInPutFile);
            this.pnlBrowseControls.Controls.Add(this.btnBrowsePdf);
            this.pnlBrowseControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrowseControls.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBrowseControls.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowseControls.Name = "pnlBrowseControls";
            this.pnlBrowseControls.Size = new System.Drawing.Size(1097, 91);
            this.pnlBrowseControls.TabIndex = 0;
            // 
            // lnkSysNo
            // 
            this.lnkSysNo.AutoSize = true;
            this.lnkSysNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSysNo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSysNo.Location = new System.Drawing.Point(577, 65);
            this.lnkSysNo.Name = "lnkSysNo";
            this.lnkSysNo.Size = new System.Drawing.Size(47, 17);
            this.lnkSysNo.TabIndex = 32;
            this.lnkSysNo.TabStop = true;
            this.lnkSysNo.Text = "SysNo";
            // 
            // txtSysNoClassType
            // 
            this.txtSysNoClassType.BackColor = System.Drawing.Color.SeaShell;
            this.txtSysNoClassType.ForeColor = System.Drawing.Color.Blue;
            this.txtSysNoClassType.Location = new System.Drawing.Point(991, 61);
            this.txtSysNoClassType.Name = "txtSysNoClassType";
            this.txtSysNoClassType.ReadOnly = true;
            this.txtSysNoClassType.Size = new System.Drawing.Size(51, 25);
            this.txtSysNoClassType.TabIndex = 31;
            this.txtSysNoClassType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(267, 37);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(915, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Class Type";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.Location = new System.Drawing.Point(263, 8);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(39, 17);
            this.lblIssue.TabIndex = 22;
            this.lblIssue.Text = "Issue";
            // 
            // lnkSysText
            // 
            this.lnkSysText.AutoSize = true;
            this.lnkSysText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSysText.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSysText.Location = new System.Drawing.Point(13, 65);
            this.lnkSysText.Name = "lnkSysText";
            this.lnkSysText.Size = new System.Drawing.Size(55, 17);
            this.lnkSysText.TabIndex = 27;
            this.lnkSysText.TabStop = true;
            this.lnkSysText.Text = "SysText";
            this.lnkSysText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSysText_LinkClicked);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.SeaShell;
            this.txtYear.Location = new System.Drawing.Point(307, 33);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(65, 25);
            this.txtYear.TabIndex = 21;
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.SeaShell;
            this.txtIssue.Location = new System.Drawing.Point(307, 3);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(65, 25);
            this.txtIssue.TabIndex = 20;
            // 
            // txtAbstractRefNo
            // 
            this.txtAbstractRefNo.BackColor = System.Drawing.Color.SeaShell;
            this.txtAbstractRefNo.Location = new System.Drawing.Point(72, 32);
            this.txtAbstractRefNo.Name = "txtAbstractRefNo";
            this.txtAbstractRefNo.ReadOnly = true;
            this.txtAbstractRefNo.Size = new System.Drawing.Size(186, 25);
            this.txtAbstractRefNo.TabIndex = 19;
            // 
            // lblAbstract
            // 
            this.lblAbstract.AutoSize = true;
            this.lblAbstract.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstract.Location = new System.Drawing.Point(14, 35);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Size = new System.Drawing.Size(52, 17);
            this.lblAbstract.TabIndex = 18;
            this.lblAbstract.Text = "Ref.No";
            // 
            // txtShipment
            // 
            this.txtShipment.BackColor = System.Drawing.Color.SeaShell;
            this.txtShipment.Location = new System.Drawing.Point(72, 3);
            this.txtShipment.Name = "txtShipment";
            this.txtShipment.ReadOnly = true;
            this.txtShipment.Size = new System.Drawing.Size(186, 25);
            this.txtShipment.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipment";
            // 
            // txtSysNum
            // 
            this.txtSysNum.BackColor = System.Drawing.Color.SeaShell;
            this.txtSysNum.Location = new System.Drawing.Point(627, 61);
            this.txtSysNum.Name = "txtSysNum";
            this.txtSysNum.ReadOnly = true;
            this.txtSysNum.Size = new System.Drawing.Size(284, 25);
            this.txtSysNum.TabIndex = 3;
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFilePath.BackColor = System.Drawing.Color.White;
            this.txtInputFilePath.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFilePath.Location = new System.Drawing.Point(464, 3);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.ReadOnly = true;
            this.txtInputFilePath.Size = new System.Drawing.Size(582, 25);
            this.txtInputFilePath.TabIndex = 1;
            this.txtInputFilePath.TabStop = false;
            // 
            // txtSysText
            // 
            this.txtSysText.BackColor = System.Drawing.Color.SeaShell;
            this.txtSysText.Location = new System.Drawing.Point(72, 61);
            this.txtSysText.Name = "txtSysText";
            this.txtSysText.ReadOnly = true;
            this.txtSysText.Size = new System.Drawing.Size(494, 25);
            this.txtSysText.TabIndex = 2;
            // 
            // lblInPutFile
            // 
            this.lblInPutFile.AutoSize = true;
            this.lblInPutFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInPutFile.Location = new System.Drawing.Point(398, 7);
            this.lblInPutFile.Name = "lblInPutFile";
            this.lblInPutFile.Size = new System.Drawing.Size(63, 17);
            this.lblInPutFile.TabIndex = 1;
            this.lblInPutFile.Text = "Input Pdf";
            // 
            // btnBrowsePdf
            // 
            this.btnBrowsePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowsePdf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePdf.Location = new System.Drawing.Point(1052, 4);
            this.btnBrowsePdf.Name = "btnBrowsePdf";
            this.btnBrowsePdf.Size = new System.Drawing.Size(40, 24);
            this.btnBrowsePdf.TabIndex = 1;
            this.btnBrowsePdf.Text = "...";
            this.btnBrowsePdf.UseVisualStyleBackColor = true;
            this.btnBrowsePdf.Click += new System.EventHandler(this.btnBrowsePdf_Click);
            // 
            // FrmPdfGererationOnAbstract
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1097, 499);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmPdfGererationOnAbstract";
            this.ShowIcon = false;
            this.Text = "Abstract based Pdf generation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPdfGererationBasedOnAbstract_FormClosing);
            this.Load += new System.EventHandler(this.FrmPdfGererationBasedOnAbstract_Load);
            this.pnlMain.ResumeLayout(false);
            this.Append.ResumeLayout(false);
            this.tblCntrlGeneratedPdfs.ResumeLayout(false);
            this.tpPdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfExport)).EndInit();
            this.pnlOutputfileCntls.ResumeLayout(false);
            this.pnlOutputfileCntls.PerformLayout();
            this.tpPreview.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.tblpnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfPreview)).EndInit();
            this.tpGeneratedPdfs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acroPdfView)).EndInit();
            this.pnlBrowseControls.ResumeLayout(false);
            this.pnlBrowseControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel Append;
        private System.Windows.Forms.Panel pnlOutputfileCntls;
        private System.Windows.Forms.Panel pnlBrowseControls;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Label lblInPutFile;
        private System.Windows.Forms.Button btnBrowsePdf;
        private System.Windows.Forms.TabPage tpPdf;
        private System.Windows.Forms.TabPage tpPreview;
        //private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.TabPage tpGeneratedPdfs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvFolder;
        //private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.TextBox txtPreviewFolderPath;
        private System.Windows.Forms.Button btnPreviewFolder;
        private System.Windows.Forms.Label lblPreviewOutPutfolder;
        private AxAcroPDFLib.AxAcroPDF acroPdfExport;
        private System.Windows.Forms.TextBox txtDoi;
        private System.Windows.Forms.Label lblDoi;
        private System.Windows.Forms.CheckBox chkNoReaction;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.RadioButton rbAppend;
        private System.Windows.Forms.RadioButton rbCreate;
        private AxAcroPDFLib.AxAcroPDF acroPdfView;
        private System.Windows.Forms.TabControl tblCntrlGeneratedPdfs;
        private System.Windows.Forms.TableLayoutPanel tblpnlPreview;
        private AxAcroPDFLib.AxAcroPDF acroPdfPreview;
        private System.Windows.Forms.TextBox txtSysNum;
        private System.Windows.Forms.TextBox txtSysText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkSysText;
        private System.Windows.Forms.TextBox txtSysNoClassType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbstractRefNo;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.TextBox txtShipment;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.LinkLabel lnkSysNo;

    }
}

