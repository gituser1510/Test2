namespace ChemInform.Export
{
    partial class frmShipmentDelivery
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
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcShipmentDelivery = new System.Windows.Forms.TabControl();
            this.tpShipmentRefs = new System.Windows.Forms.TabPage();
            this.dgvRDFRefs = new System.Windows.Forms.DataGridView();
            this.colShipmentRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpShipmentSolvents = new System.Windows.Forms.TabPage();
            this.splcontSolvents = new System.Windows.Forms.SplitContainer();
            this.dgvSolvents = new System.Windows.Forms.DataGridView();
            this.colShipmentRef_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventName_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventMolFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solventRenderer = new MDL.Draw.Renderer.Renderer();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtDeliveryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkExpClientDelivery = new System.Windows.Forms.CheckBox();
            this.lblStartMdl = new System.Windows.Forms.Label();
            this.txtMDLNo = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnGenerateRDF = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblRxnsCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRefsCount = new System.Windows.Forms.Label();
            this.txtClassType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShipmentYear = new System.Windows.Forms.TextBox();
            this.btnGetShipmentRefs = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.tcShipmentDelivery.SuspendLayout();
            this.tpShipmentRefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDFRefs)).BeginInit();
            this.tpShipmentSolvents.SuspendLayout();
            this.splcontSolvents.Panel1.SuspendLayout();
            this.splcontSolvents.Panel2.SuspendLayout();
            this.splcontSolvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvents)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tcShipmentDelivery);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1173, 471);
            this.pnlMain.TabIndex = 0;
            // 
            // tcShipmentDelivery
            // 
            this.tcShipmentDelivery.Controls.Add(this.tpShipmentRefs);
            this.tcShipmentDelivery.Controls.Add(this.tpShipmentSolvents);
            this.tcShipmentDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcShipmentDelivery.Location = new System.Drawing.Point(0, 30);
            this.tcShipmentDelivery.Name = "tcShipmentDelivery";
            this.tcShipmentDelivery.SelectedIndex = 0;
            this.tcShipmentDelivery.Size = new System.Drawing.Size(1173, 410);
            this.tcShipmentDelivery.TabIndex = 16;
            // 
            // tpShipmentRefs
            // 
            this.tpShipmentRefs.Controls.Add(this.dgvRDFRefs);
            this.tpShipmentRefs.Location = new System.Drawing.Point(4, 26);
            this.tpShipmentRefs.Name = "tpShipmentRefs";
            this.tpShipmentRefs.Padding = new System.Windows.Forms.Padding(3);
            this.tpShipmentRefs.Size = new System.Drawing.Size(1165, 380);
            this.tpShipmentRefs.TabIndex = 0;
            this.tpShipmentRefs.Text = "Delivery References";
            this.tpShipmentRefs.UseVisualStyleBackColor = true;
            // 
            // dgvRDFRefs
            // 
            this.dgvRDFRefs.AllowUserToAddRows = false;
            this.dgvRDFRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvRDFRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRDFRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRDFRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRDFRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRefID,
            this.colReferenceName,
            this.colSysText,
            this.colSysNo,
            this.colRxnCnt,
            this.colShipmentName,
            this.colRefStatus,
            this.colIsDelivered});
            this.dgvRDFRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRDFRefs.Location = new System.Drawing.Point(3, 3);
            this.dgvRDFRefs.Name = "dgvRDFRefs";
            this.dgvRDFRefs.ReadOnly = true;
            this.dgvRDFRefs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvRDFRefs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRDFRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRDFRefs.Size = new System.Drawing.Size(1159, 374);
            this.dgvRDFRefs.TabIndex = 15;
            this.dgvRDFRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRDFRefs_RowPostPaint);
            // 
            // colShipmentRefID
            // 
            this.colShipmentRefID.HeaderText = "Ref_ID";
            this.colShipmentRefID.Name = "colShipmentRefID";
            this.colShipmentRefID.ReadOnly = true;
            this.colShipmentRefID.Visible = false;
            // 
            // colReferenceName
            // 
            this.colReferenceName.HeaderText = "Reference";
            this.colReferenceName.Name = "colReferenceName";
            this.colReferenceName.ReadOnly = true;
            this.colReferenceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReferenceName.Width = 121;
            // 
            // colSysText
            // 
            this.colSysText.HeaderText = "SysText";
            this.colSysText.Name = "colSysText";
            this.colSysText.ReadOnly = true;
            // 
            // colSysNo
            // 
            this.colSysNo.HeaderText = "SysNo";
            this.colSysNo.Name = "colSysNo";
            this.colSysNo.ReadOnly = true;
            // 
            // colRxnCnt
            // 
            this.colRxnCnt.FillWeight = 50F;
            this.colRxnCnt.HeaderText = "Rxns";
            this.colRxnCnt.Name = "colRxnCnt";
            this.colRxnCnt.ReadOnly = true;
            this.colRxnCnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRxnCnt.Width = 70;
            // 
            // colShipmentName
            // 
            this.colShipmentName.FillWeight = 150F;
            this.colShipmentName.HeaderText = "Shipment";
            this.colShipmentName.Name = "colShipmentName";
            this.colShipmentName.ReadOnly = true;
            this.colShipmentName.Width = 150;
            // 
            // colRefStatus
            // 
            this.colRefStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRefStatus.HeaderText = "Status";
            this.colRefStatus.Name = "colRefStatus";
            this.colRefStatus.ReadOnly = true;
            // 
            // colIsDelivered
            // 
            this.colIsDelivered.HeaderText = "Delivered";
            this.colIsDelivered.Name = "colIsDelivered";
            this.colIsDelivered.ReadOnly = true;
            // 
            // tpShipmentSolvents
            // 
            this.tpShipmentSolvents.Controls.Add(this.splcontSolvents);
            this.tpShipmentSolvents.Location = new System.Drawing.Point(4, 26);
            this.tpShipmentSolvents.Name = "tpShipmentSolvents";
            this.tpShipmentSolvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpShipmentSolvents.Size = new System.Drawing.Size(1165, 380);
            this.tpShipmentSolvents.TabIndex = 1;
            this.tpShipmentSolvents.Text = "Delivery New Solvents";
            this.tpShipmentSolvents.UseVisualStyleBackColor = true;
            // 
            // splcontSolvents
            // 
            this.splcontSolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcontSolvents.Location = new System.Drawing.Point(3, 3);
            this.splcontSolvents.Name = "splcontSolvents";
            // 
            // splcontSolvents.Panel1
            // 
            this.splcontSolvents.Panel1.Controls.Add(this.dgvSolvents);
            // 
            // splcontSolvents.Panel2
            // 
            this.splcontSolvents.Panel2.Controls.Add(this.solventRenderer);
            this.splcontSolvents.Size = new System.Drawing.Size(1159, 374);
            this.splcontSolvents.SplitterDistance = 835;
            this.splcontSolvents.TabIndex = 0;
            // 
            // dgvSolvents
            // 
            this.dgvSolvents.AllowUserToAddRows = false;
            this.dgvSolvents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSolvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSolvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRef_Solv,
            this.colSolventName_Solv,
            this.colSolventMolFile});
            this.dgvSolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolvents.Location = new System.Drawing.Point(0, 0);
            this.dgvSolvents.Name = "dgvSolvents";
            this.dgvSolvents.ReadOnly = true;
            this.dgvSolvents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvSolvents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSolvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolvents.Size = new System.Drawing.Size(835, 374);
            this.dgvSolvents.TabIndex = 16;
            this.dgvSolvents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolvents_RowEnter);
            this.dgvSolvents.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSolvents_RowPostPaint);
            // 
            // colShipmentRef_Solv
            // 
            this.colShipmentRef_Solv.HeaderText = "Reference";
            this.colShipmentRef_Solv.Name = "colShipmentRef_Solv";
            this.colShipmentRef_Solv.ReadOnly = true;
            this.colShipmentRef_Solv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShipmentRef_Solv.Width = 121;
            // 
            // colSolventName_Solv
            // 
            this.colSolventName_Solv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSolventName_Solv.HeaderText = "Solvent Name";
            this.colSolventName_Solv.Name = "colSolventName_Solv";
            this.colSolventName_Solv.ReadOnly = true;
            // 
            // colSolventMolFile
            // 
            this.colSolventMolFile.FillWeight = 150F;
            this.colSolventMolFile.HeaderText = "SolventMolfile";
            this.colSolventMolFile.Name = "colSolventMolFile";
            this.colSolventMolFile.ReadOnly = true;
            this.colSolventMolFile.Visible = false;
            this.colSolventMolFile.Width = 150;
            // 
            // solventRenderer
            // 
            this.solventRenderer.AutoSizeStructure = true;
            this.solventRenderer.BinHexSketch = "01030004412400214372656174656420627920416363656C7279734472617720342E322E302E36303" +
    "502040000005805000000005905000000000B0B0005417269616C780000140200";
            this.solventRenderer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.solventRenderer.ChimeString = null;
            this.solventRenderer.CopyingEnabled = true;
            this.solventRenderer.DisplayOnEmpty = null;
            this.solventRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solventRenderer.FileName = null;
            this.solventRenderer.HighlightInfo = "";
            this.solventRenderer.IsBitmapFromOLE = false;
            this.solventRenderer.Location = new System.Drawing.Point(0, 0);
            molecule1.ArrowDir = MDL.Draw.ArrowDirType.No;
            molecule1.ArrowStyle = MDL.Draw.ArrowStyleType.Empty;
            molecule1.AtomValenceDisplay = true;
            molecule1.BaseFormBoxSetting = 0;
            molecule1.BondLineThickness = 0D;
            molecule1.CarbonLabelDisplay = false;
            molecule1.ChemLabelFont = null;
            molecule1.ChemLabelFontString = "(none)";
            molecule1.ColorAtomsByTypeInSketch = false;
            molecule1.ConfigLabelFont = null;
            molecule1.ConfigLabelFontString = "(none)";
            molecule1.ConvertRingBondIntoOneToMany = true;
            molecule1.Coords = null;
            molecule1.DashSpacing = 0.1D;
            molecule1.DisplaySinCys = false;
            molecule1.DisplaySulfurInCysSequence = false;
            molecule1.DoubleBondWidth = 0.18D;
            molecule1.FillColor = System.Drawing.Color.Empty;
            molecule1.FillStyle = MDL.Draw.ChemGraphicsObject.FillStyles.SOLID;
            molecule1.ForeColor = System.Drawing.Color.Empty;
            molecule1.ForeColorString = "";
            molecule1.ForSubsequenceQuery = false;
            molecule1.HighlightChildren = "";
            molecule1.HighlightColor = System.Drawing.Color.Blue;
            molecule1.HydrogenDisplayMode = MDL.Draw.Chemistry.Atom.HydrogenDisplayMode.Off;
            molecule1.Id = 157;
            molecule1.Initial = "";
            molecule1.IsAModel = false;
            molecule1.IsARotatedModel = false;
            molecule1.KeepRSLabelsInSketch = true;
            molecule1.LastModifyChemText = -1;
            molecule1.MaintainXMLChildOrderFlag = false;
            molecule1.MustPerceiveStereo = true;
            molecule1.PenColor = System.Drawing.Color.Empty;
            molecule1.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            molecule1.PenStyleToken = 0;
            molecule1.PenWidth = ((byte)(0));
            molecule1.PenWidthUnit = MDL.Draw.ChemGraphicsObject.PenWidthUnits.Default;
            molecule1.RefId = 157;
            molecule1.Replaced = false;
            molecule1.RgroupCleeanUpNeeded = false;
            molecule1.RgroupLabelsPresentFlag = false;
            molecule1.RLabelAtAbsCenter = "R";
            molecule1.RLabelAtAndCenter = "R*";
            molecule1.RLabelAtOrCenter = "(R)";
            molecule1.ScaleLabelsToBondLength = false;
            molecule1.Selected = false;
            molecule1.SequenceDictionary = null;
            molecule1.SequenceNeedsRealign = false;
            molecule1.SequenceView = MDL.Draw.Chemistry.Molecule.SequenceViewEnum.None;
            molecule1.Size = 0;
            molecule1.SkcWritten = false;
            molecule1.SkNumber = ((short)(0));
            molecule1.SLabelAtAbsCenter = "S";
            molecule1.SLabelAtAndCenter = "S*";
            molecule1.SLabelAtOrCenter = "(S)";
            molecule1.StandardBondLength = 0D;
            molecule1.StereoChemistryMode = MDL.Draw.Chemistry.Molecule.StereoChemistryModeEnum.And;
            molecule1.TextBorder = 0.1D;
            molecule1.Transparent = false;
            molecule1.UndoableEditListener = null;
            molecule1.WedgeWidth = 0.1D;
            molecule1.ZLayer = -99844;
            this.solventRenderer.Molecule = molecule1;
            this.solventRenderer.MolfileString = "";
            this.solventRenderer.Name = "solventRenderer";
            this.solventRenderer.PastingEnabled = true;
            this.solventRenderer.Preferences = displayPreferences1;
            this.solventRenderer.PreferencesFileName = "default.xml";
            this.solventRenderer.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.solventRenderer.Size = new System.Drawing.Size(320, 374);
            this.solventRenderer.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.solventRenderer.SmilesString = "";
            this.solventRenderer.TabIndex = 33;
            this.solventRenderer.URLEncodedMolfileString = "";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.txtDeliveryName);
            this.pnlBottom.Controls.Add(this.label5);
            this.pnlBottom.Controls.Add(this.chkExpClientDelivery);
            this.pnlBottom.Controls.Add(this.lblStartMdl);
            this.pnlBottom.Controls.Add(this.txtMDLNo);
            this.pnlBottom.Controls.Add(this.btnBrowse);
            this.pnlBottom.Controls.Add(this.label3);
            this.pnlBottom.Controls.Add(this.txtFolderPath);
            this.pnlBottom.Controls.Add(this.btnGenerateRDF);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 440);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1173, 31);
            this.pnlBottom.TabIndex = 14;
            // 
            // txtDeliveryName
            // 
            this.txtDeliveryName.BackColor = System.Drawing.Color.White;
            this.txtDeliveryName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryName.ForeColor = System.Drawing.Color.Blue;
            this.txtDeliveryName.Location = new System.Drawing.Point(97, 3);
            this.txtDeliveryName.Name = "txtDeliveryName";
            this.txtDeliveryName.Size = new System.Drawing.Size(182, 21);
            this.txtDeliveryName.TabIndex = 44;
            this.txtDeliveryName.Text = "GVK_CI_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Delivery Name";
            // 
            // chkExpClientDelivery
            // 
            this.chkExpClientDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExpClientDelivery.AutoSize = true;
            this.chkExpClientDelivery.Location = new System.Drawing.Point(882, 3);
            this.chkExpClientDelivery.Name = "chkExpClientDelivery";
            this.chkExpClientDelivery.Size = new System.Drawing.Size(179, 21);
            this.chkExpClientDelivery.TabIndex = 43;
            this.chkExpClientDelivery.Text = "Export for Client Delivery";
            this.chkExpClientDelivery.UseVisualStyleBackColor = true;
            this.chkExpClientDelivery.CheckedChanged += new System.EventHandler(this.chkExpClientDelivery_CheckedChanged);
            // 
            // lblStartMdl
            // 
            this.lblStartMdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartMdl.AutoSize = true;
            this.lblStartMdl.Location = new System.Drawing.Point(665, 6);
            this.lblStartMdl.Name = "lblStartMdl";
            this.lblStartMdl.Size = new System.Drawing.Size(98, 17);
            this.lblStartMdl.TabIndex = 42;
            this.lblStartMdl.Text = "Start MDL No.";
            // 
            // txtMDLNo
            // 
            this.txtMDLNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMDLNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDLNo.ForeColor = System.Drawing.Color.Blue;
            this.txtMDLNo.Location = new System.Drawing.Point(764, 2);
            this.txtMDLNo.Name = "txtMDLNo";
            this.txtMDLNo.Size = new System.Drawing.Size(98, 25);
            this.txtMDLNo.TabIndex = 41;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(623, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 24);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(288, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output Path";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.ForeColor = System.Drawing.Color.Blue;
            this.txtFolderPath.Location = new System.Drawing.Point(370, 3);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(250, 21);
            this.txtFolderPath.TabIndex = 10;
            // 
            // btnGenerateRDF
            // 
            this.btnGenerateRDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRDF.AutoSize = true;
            this.btnGenerateRDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRDF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRDF.Location = new System.Drawing.Point(1069, 1);
            this.btnGenerateRDF.Name = "btnGenerateRDF";
            this.btnGenerateRDF.Size = new System.Drawing.Size(96, 25);
            this.btnGenerateRDF.TabIndex = 9;
            this.btnGenerateRDF.Text = "Generate RDF";
            this.btnGenerateRDF.UseVisualStyleBackColor = true;
            this.btnGenerateRDF.Click += new System.EventHandler(this.btnGenerateRDF_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblRxnsCnt);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.lblRefsCount);
            this.pnlTop.Controls.Add(this.txtClassType);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtShipmentYear);
            this.pnlTop.Controls.Add(this.btnGetShipmentRefs);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1173, 30);
            this.pnlTop.TabIndex = 13;
            // 
            // lblRxnsCnt
            // 
            this.lblRxnsCnt.AutoSize = true;
            this.lblRxnsCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblRxnsCnt.Location = new System.Drawing.Point(739, 7);
            this.lblRxnsCnt.Name = "lblRxnsCnt";
            this.lblRxnsCnt.Size = new System.Drawing.Size(15, 17);
            this.lblRxnsCnt.TabIndex = 51;
            this.lblRxnsCnt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(219, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Rxns Count: ";
            // 
            // lblRefsCount
            // 
            this.lblRefsCount.AutoSize = true;
            this.lblRefsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblRefsCount.Location = new System.Drawing.Point(598, 7);
            this.lblRefsCount.Name = "lblRefsCount";
            this.lblRefsCount.Size = new System.Drawing.Size(15, 17);
            this.lblRefsCount.TabIndex = 49;
            this.lblRefsCount.Text = "0";
            // 
            // txtClassType
            // 
            this.txtClassType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClassType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassType.ForeColor = System.Drawing.Color.Blue;
            this.txtClassType.Location = new System.Drawing.Point(295, 5);
            this.txtClassType.Name = "txtClassType";
            this.txtClassType.Size = new System.Drawing.Size(40, 21);
            this.txtClassType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ref.Count: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment Year";
            // 
            // txtShipmentYear
            // 
            this.txtShipmentYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipmentYear.ForeColor = System.Drawing.Color.Blue;
            this.txtShipmentYear.Location = new System.Drawing.Point(98, 5);
            this.txtShipmentYear.Name = "txtShipmentYear";
            this.txtShipmentYear.Size = new System.Drawing.Size(107, 21);
            this.txtShipmentYear.TabIndex = 1;
            // 
            // btnGetShipmentRefs
            // 
            this.btnGetShipmentRefs.AutoSize = true;
            this.btnGetShipmentRefs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetShipmentRefs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetShipmentRefs.Location = new System.Drawing.Point(344, 3);
            this.btnGetShipmentRefs.Name = "btnGetShipmentRefs";
            this.btnGetShipmentRefs.Size = new System.Drawing.Size(80, 25);
            this.btnGetShipmentRefs.TabIndex = 8;
            this.btnGetShipmentRefs.Text = "Get";
            this.btnGetShipmentRefs.UseVisualStyleBackColor = true;
            this.btnGetShipmentRefs.Click += new System.EventHandler(this.btnGetShipmentRefs_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ref_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Rxns";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Shipment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 150F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Delivered";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Delivered";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 121;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Solvent Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 150F;
            this.dataGridViewTextBoxColumn11.HeaderText = "SolventMolfile";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // frmShipmentDelivery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1173, 471);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmShipmentDelivery";
            this.ShowIcon = false;
            this.Text = "Shipment Delivery";
            this.Load += new System.EventHandler(this.frmShipmentDelivery_Load);
            this.pnlMain.ResumeLayout(false);
            this.tcShipmentDelivery.ResumeLayout(false);
            this.tpShipmentRefs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDFRefs)).EndInit();
            this.tpShipmentSolvents.ResumeLayout(false);
            this.splcontSolvents.Panel1.ResumeLayout(false);
            this.splcontSolvents.Panel2.ResumeLayout(false);
            this.splcontSolvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvents)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShipmentYear;
        private System.Windows.Forms.Button btnGetShipmentRefs;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.CheckBox chkExpClientDelivery;
        private System.Windows.Forms.Label lblStartMdl;
        private System.Windows.Forms.TextBox txtMDLNo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnGenerateRDF;
        private System.Windows.Forms.DataGridView dgvRDFRefs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblRxnsCnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRefsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelivered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeliveryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabControl tcShipmentDelivery;
        private System.Windows.Forms.TabPage tpShipmentRefs;
        private System.Windows.Forms.TabPage tpShipmentSolvents;
        private System.Windows.Forms.SplitContainer splcontSolvents;
        private System.Windows.Forms.DataGridView dgvSolvents;
        private MDL.Draw.Renderer.Renderer solventRenderer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRef_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventName_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventMolFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}