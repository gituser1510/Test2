namespace ChemInform
{
    partial class frmReactionCuration_Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReactionCuration_Journal));
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            MDL.Draw.Chemistry.Molecule molecule2 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences2 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlReaction = new System.Windows.Forms.Panel();
            this.splContRxnTree_RxnView = new System.Windows.Forms.SplitContainer();
            this.tvReactions = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splcontRxnSteps = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RenditorRxnScheme = new MDL.Draw.Renditor.Renditor();
            this.productRenderer = new MDL.Draw.Renderer.Renderer();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlRxnRef = new System.Windows.Forms.Panel();
            this.btnResetRxnRef = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStepInfo = new System.Windows.Forms.TextBox();
            this.txtMultiStep2 = new System.Windows.Forms.TextBox();
            this.rbnMultiStep = new System.Windows.Forms.RadioButton();
            this.rbnSingleStep = new System.Windows.Forms.RadioButton();
            this.btnAddRxnRef = new System.Windows.Forms.Button();
            this.dgvRxnRef = new System.Windows.Forms.DataGridView();
            this.txtMultiStep1 = new System.Windows.Forms.TextBox();
            this.txtExtRegNo = new System.Windows.Forms.TextBox();
            this.lblExtReg = new System.Windows.Forms.Label();
            this.txtRxnPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.pnlRxnSchemeCtrls = new System.Windows.Forms.Panel();
            this.lblCrossRefId = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnPrevRxn = new System.Windows.Forms.Button();
            this.numGoToRxn = new System.Windows.Forms.NumericUpDown();
            this.btnFirstRxn = new System.Windows.Forms.Button();
            this.btnNextRxn = new System.Windows.Forms.Button();
            this.btnLastRxn = new System.Windows.Forms.Button();
            this.txtRxnSNo = new System.Windows.Forms.TextBox();
            this.rbnAutoMapping = new System.Windows.Forms.RadioButton();
            this.btnAddReaction = new System.Windows.Forms.Button();
            this.btnDelReaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRxnCnt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnManualMapping = new System.Windows.Forms.RadioButton();
            this.chkImpReaction = new System.Windows.Forms.CheckBox();
            this.pnlCrossRef = new System.Windows.Forms.Panel();
            this.btnResetCrossRef = new System.Windows.Forms.Button();
            this.btnAddCrossRef = new System.Windows.Forms.Button();
            this.dgvCrossRef = new System.Windows.Forms.DataGridView();
            this.txtSuccRxn = new System.Windows.Forms.TextBox();
            this.lblSuccRxn = new System.Windows.Forms.Label();
            this.txtPreRxn = new System.Windows.Forms.TextBox();
            this.lblPreRxn = new System.Windows.Forms.Label();
            this.tcRxnSteps = new System.Windows.Forms.TabControl();
            this.cntMnuAddNewStep = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStepTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStepTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.chkRxnComplete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRxn_CrossRef = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtRxnComments = new System.Windows.Forms.TextBox();
            this.btnRefComplete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefreshRxnScheme = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlAbstract = new System.Windows.Forms.Panel();
            this.txtEndPage = new System.Windows.Forms.TextBox();
            this.lblEndPage = new System.Windows.Forms.Label();
            this.txtStartPage = new System.Windows.Forms.TextBox();
            this.lblStartPage = new System.Windows.Forms.Label();
            this.txtDOI = new System.Windows.Forms.TextBox();
            this.lblDOI = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtJournalName = new System.Windows.Forms.TextBox();
            this.lblJournalName = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cntMnuAddNewRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductStructImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProductStructNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductYield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colproductEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProductDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colInchiKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditRxnRef = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDeleteRxnRef = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCrossRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrossRefPreRxn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrossRefSuccRxn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditCrossRef = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDeleteCrossRef = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlMain.SuspendLayout();
            this.pnlReaction.SuspendLayout();
            this.splContRxnTree_RxnView.Panel1.SuspendLayout();
            this.splContRxnTree_RxnView.Panel2.SuspendLayout();
            this.splContRxnTree_RxnView.SuspendLayout();
            this.splcontRxnSteps.Panel1.SuspendLayout();
            this.splcontRxnSteps.Panel2.SuspendLayout();
            this.splcontRxnSteps.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlRxnRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRxnRef)).BeginInit();
            this.pnlRxnSchemeCtrls.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoToRxn)).BeginInit();
            this.pnlCrossRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRef)).BeginInit();
            this.cntMnuAddNewStep.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlAbstract.SuspendLayout();
            this.cntMnuAddNewRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlReaction);
            this.pnlMain.Controls.Add(this.pnlAbstract);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1129, 650);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlReaction
            // 
            this.pnlReaction.Controls.Add(this.splContRxnTree_RxnView);
            this.pnlReaction.Controls.Add(this.pnlSave);
            this.pnlReaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaction.Location = new System.Drawing.Point(0, 32);
            this.pnlReaction.Name = "pnlReaction";
            this.pnlReaction.Size = new System.Drawing.Size(1129, 618);
            this.pnlReaction.TabIndex = 4;
            // 
            // splContRxnTree_RxnView
            // 
            this.splContRxnTree_RxnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContRxnTree_RxnView.Location = new System.Drawing.Point(0, 0);
            this.splContRxnTree_RxnView.Name = "splContRxnTree_RxnView";
            // 
            // splContRxnTree_RxnView.Panel1
            // 
            this.splContRxnTree_RxnView.Panel1.Controls.Add(this.tvReactions);
            // 
            // splContRxnTree_RxnView.Panel2
            // 
            this.splContRxnTree_RxnView.Panel2.Controls.Add(this.splcontRxnSteps);
            this.splContRxnTree_RxnView.Size = new System.Drawing.Size(1129, 561);
            this.splContRxnTree_RxnView.SplitterDistance = 82;
            this.splContRxnTree_RxnView.TabIndex = 6;
            // 
            // tvReactions
            // 
            this.tvReactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReactions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvReactions.ForeColor = System.Drawing.Color.Blue;
            this.tvReactions.ImageIndex = 2;
            this.tvReactions.ImageList = this.imageList1;
            this.tvReactions.Location = new System.Drawing.Point(0, 0);
            this.tvReactions.Name = "tvReactions";
            this.tvReactions.SelectedImageIndex = 2;
            this.tvReactions.Size = new System.Drawing.Size(82, 561);
            this.tvReactions.TabIndex = 2;
            this.tvReactions.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvReactions_NodeMouseDoubleClick);
            this.tvReactions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvReactions_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RxnComplete.png");
            this.imageList1.Images.SetKeyName(1, "RxnNotComplete.jpg");
            this.imageList1.Images.SetKeyName(2, "SelectedRxn.png");
            // 
            // splcontRxnSteps
            // 
            this.splcontRxnSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splcontRxnSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcontRxnSteps.Location = new System.Drawing.Point(0, 0);
            this.splcontRxnSteps.Name = "splcontRxnSteps";
            this.splcontRxnSteps.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcontRxnSteps.Panel1
            // 
            this.splcontRxnSteps.Panel1.Controls.Add(this.splitContainer1);
            this.splcontRxnSteps.Panel1.Controls.Add(this.pnlRxnRef);
            this.splcontRxnSteps.Panel1.Controls.Add(this.pnlRxnSchemeCtrls);
            this.splcontRxnSteps.Panel1.Controls.Add(this.pnlCrossRef);
            // 
            // splcontRxnSteps.Panel2
            // 
            this.splcontRxnSteps.Panel2.Controls.Add(this.tcRxnSteps);
            this.splcontRxnSteps.Size = new System.Drawing.Size(1043, 561);
            this.splcontRxnSteps.SplitterDistance = 323;
            this.splcontRxnSteps.SplitterWidth = 3;
            this.splcontRxnSteps.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RenditorRxnScheme);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productRenderer);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddProduct);
            this.splitContainer1.Panel2.Controls.Add(this.dgvProduct);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 296);
            this.splitContainer1.SplitterDistance = 664;
            this.splitContainer1.TabIndex = 23;
            // 
            // RenditorRxnScheme
            // 
            this.RenditorRxnScheme.AutoSizeStructure = true;
            this.RenditorRxnScheme.BinHexSketch = "01030004412400214372656174656420627920416363656C7279734472617720342E322E302E36303" +
    "502040000005805000000005905000000000B0B0005417269616C780000140200";
            this.RenditorRxnScheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RenditorRxnScheme.ChimeString = null;
            this.RenditorRxnScheme.ClearingEnabled = true;
            this.RenditorRxnScheme.CopyingEnabled = true;
            this.RenditorRxnScheme.DisplayOnEmpty = null;
            this.RenditorRxnScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenditorRxnScheme.EditingEnabled = true;
            this.RenditorRxnScheme.FileName = null;
            this.RenditorRxnScheme.HighlightInfo = "";
            this.RenditorRxnScheme.IsBitmapFromOLE = false;
            this.RenditorRxnScheme.Location = new System.Drawing.Point(0, 0);
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
            molecule1.Id = 7847;
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
            molecule1.RefId = 7847;
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
            molecule1.ZLayer = -92382;
            this.RenditorRxnScheme.Molecule = molecule1;
            this.RenditorRxnScheme.MolfileString = "";
            this.RenditorRxnScheme.Name = "RenditorRxnScheme";
            this.RenditorRxnScheme.OldScalingMode = MDL.Draw.Renderer.Preferences.StructureScalingMode.ScaleToFitBox;
            this.RenditorRxnScheme.PastingEnabled = true;
            this.RenditorRxnScheme.Preferences = displayPreferences1;
            this.RenditorRxnScheme.PreferencesFileName = "default.xml";
            this.RenditorRxnScheme.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.RenditorRxnScheme.RenditorMolecule = molecule1;
            this.RenditorRxnScheme.RenditorName = "Renditor";
            this.RenditorRxnScheme.Size = new System.Drawing.Size(664, 296);
            this.RenditorRxnScheme.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.RenditorRxnScheme.SmilesString = "";
            this.RenditorRxnScheme.TabIndex = 16;
            this.RenditorRxnScheme.URLEncodedMolfileString = "";
            this.RenditorRxnScheme.UseLocalXMLConfig = false;
            // 
            // productRenderer
            // 
            this.productRenderer.AutoSizeStructure = true;
            this.productRenderer.BinHexSketch = "01030004412400214372656174656420627920416363656C7279734472617720342E322E302E36303" +
    "502040000005805000000005905000000000B0B0005417269616C780000140200";
            this.productRenderer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productRenderer.ChimeString = null;
            this.productRenderer.CopyingEnabled = true;
            this.productRenderer.DisplayOnEmpty = null;
            this.productRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productRenderer.FileName = null;
            this.productRenderer.HighlightInfo = "";
            this.productRenderer.IsBitmapFromOLE = false;
            this.productRenderer.Location = new System.Drawing.Point(0, 87);
            molecule2.ArrowDir = MDL.Draw.ArrowDirType.No;
            molecule2.ArrowStyle = MDL.Draw.ArrowStyleType.Empty;
            molecule2.AtomValenceDisplay = true;
            molecule2.BaseFormBoxSetting = 0;
            molecule2.BondLineThickness = 0D;
            molecule2.CarbonLabelDisplay = false;
            molecule2.ChemLabelFont = null;
            molecule2.ChemLabelFontString = "(none)";
            molecule2.ColorAtomsByTypeInSketch = false;
            molecule2.ConfigLabelFont = null;
            molecule2.ConfigLabelFontString = "(none)";
            molecule2.ConvertRingBondIntoOneToMany = true;
            molecule2.Coords = null;
            molecule2.DashSpacing = 0.1D;
            molecule2.DisplaySinCys = false;
            molecule2.DisplaySulfurInCysSequence = false;
            molecule2.DoubleBondWidth = 0.18D;
            molecule2.FillColor = System.Drawing.Color.Empty;
            molecule2.FillStyle = MDL.Draw.ChemGraphicsObject.FillStyles.SOLID;
            molecule2.ForeColor = System.Drawing.Color.Empty;
            molecule2.ForeColorString = "";
            molecule2.ForSubsequenceQuery = false;
            molecule2.HighlightChildren = "";
            molecule2.HighlightColor = System.Drawing.Color.Blue;
            molecule2.HydrogenDisplayMode = MDL.Draw.Chemistry.Atom.HydrogenDisplayMode.Off;
            molecule2.Id = 7871;
            molecule2.Initial = "";
            molecule2.IsAModel = false;
            molecule2.IsARotatedModel = false;
            molecule2.KeepRSLabelsInSketch = true;
            molecule2.LastModifyChemText = -1;
            molecule2.MaintainXMLChildOrderFlag = false;
            molecule2.MustPerceiveStereo = true;
            molecule2.PenColor = System.Drawing.Color.Empty;
            molecule2.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            molecule2.PenStyleToken = 0;
            molecule2.PenWidth = ((byte)(0));
            molecule2.PenWidthUnit = MDL.Draw.ChemGraphicsObject.PenWidthUnits.Default;
            molecule2.RefId = 7871;
            molecule2.Replaced = false;
            molecule2.RgroupCleeanUpNeeded = false;
            molecule2.RgroupLabelsPresentFlag = false;
            molecule2.RLabelAtAbsCenter = "R";
            molecule2.RLabelAtAndCenter = "R*";
            molecule2.RLabelAtOrCenter = "(R)";
            molecule2.ScaleLabelsToBondLength = false;
            molecule2.Selected = false;
            molecule2.SequenceDictionary = null;
            molecule2.SequenceNeedsRealign = false;
            molecule2.SequenceView = MDL.Draw.Chemistry.Molecule.SequenceViewEnum.None;
            molecule2.Size = 0;
            molecule2.SkcWritten = false;
            molecule2.SkNumber = ((short)(0));
            molecule2.SLabelAtAbsCenter = "S";
            molecule2.SLabelAtAndCenter = "S*";
            molecule2.SLabelAtOrCenter = "(S)";
            molecule2.StandardBondLength = 0D;
            molecule2.StereoChemistryMode = MDL.Draw.Chemistry.Molecule.StereoChemistryModeEnum.And;
            molecule2.TextBorder = 0.1D;
            molecule2.Transparent = false;
            molecule2.UndoableEditListener = null;
            molecule2.WedgeWidth = 0.1D;
            molecule2.ZLayer = -92358;
            this.productRenderer.Molecule = molecule2;
            this.productRenderer.MolfileString = "";
            this.productRenderer.Name = "productRenderer";
            this.productRenderer.PastingEnabled = true;
            this.productRenderer.Preferences = displayPreferences2;
            this.productRenderer.PreferencesFileName = "default.xml";
            this.productRenderer.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.productRenderer.Size = new System.Drawing.Size(373, 209);
            this.productRenderer.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.productRenderer.SmilesString = "";
            this.productRenderer.TabIndex = 32;
            this.productRenderer.URLEncodedMolfileString = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 1);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(37, 24);
            this.btnAddProduct.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAddProduct, "Add Product");
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colProductStructure,
            this.colProductStructImage,
            this.colProductStructNo,
            this.colProductYield,
            this.colProductCs,
            this.colProductDs,
            this.colProductDE,
            this.colProductEE,
            this.colGrade,
            this.colproductEdit,
            this.colProductDelete,
            this.colInchiKey});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaShell;
            this.dgvProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(373, 87);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_RowEnter);
            this.dgvProduct.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProduct_RowPostPaint);
            // 
            // pnlRxnRef
            // 
            this.pnlRxnRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRxnRef.Controls.Add(this.btnResetRxnRef);
            this.pnlRxnRef.Controls.Add(this.label5);
            this.pnlRxnRef.Controls.Add(this.txtStepInfo);
            this.pnlRxnRef.Controls.Add(this.txtMultiStep2);
            this.pnlRxnRef.Controls.Add(this.rbnMultiStep);
            this.pnlRxnRef.Controls.Add(this.rbnSingleStep);
            this.pnlRxnRef.Controls.Add(this.btnAddRxnRef);
            this.pnlRxnRef.Controls.Add(this.dgvRxnRef);
            this.pnlRxnRef.Controls.Add(this.txtMultiStep1);
            this.pnlRxnRef.Controls.Add(this.txtExtRegNo);
            this.pnlRxnRef.Controls.Add(this.lblExtReg);
            this.pnlRxnRef.Controls.Add(this.txtRxnPath);
            this.pnlRxnRef.Controls.Add(this.lblPath);
            this.pnlRxnRef.Location = new System.Drawing.Point(21, 241);
            this.pnlRxnRef.Name = "pnlRxnRef";
            this.pnlRxnRef.Size = new System.Drawing.Size(83, 47);
            this.pnlRxnRef.TabIndex = 12;
            this.pnlRxnRef.Visible = false;
            // 
            // btnResetRxnRef
            // 
            this.btnResetRxnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetRxnRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetRxnRef.Image = global::ChemInform.Properties.Resources.refresh;
            this.btnResetRxnRef.Location = new System.Drawing.Point(45, 2);
            this.btnResetRxnRef.Name = "btnResetRxnRef";
            this.btnResetRxnRef.Size = new System.Drawing.Size(31, 27);
            this.btnResetRxnRef.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnResetRxnRef, "Reset Reaction Reference");
            this.btnResetRxnRef.UseVisualStyleBackColor = true;
            this.btnResetRxnRef.Click += new System.EventHandler(this.btnResetRxnRef_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "of";
            // 
            // txtStepInfo
            // 
            this.txtStepInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepInfo.BackColor = System.Drawing.Color.SeaShell;
            this.txtStepInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStepInfo.Location = new System.Drawing.Point(534, 3);
            this.txtStepInfo.MaxLength = 20;
            this.txtStepInfo.Name = "txtStepInfo";
            this.txtStepInfo.ReadOnly = true;
            this.txtStepInfo.Size = new System.Drawing.Size(0, 25);
            this.txtStepInfo.TabIndex = 13;
            this.txtStepInfo.Text = "1 STEP";
            // 
            // txtMultiStep2
            // 
            this.txtMultiStep2.Location = new System.Drawing.Point(471, 3);
            this.txtMultiStep2.MaxLength = 20;
            this.txtMultiStep2.Name = "txtMultiStep2";
            this.txtMultiStep2.Size = new System.Drawing.Size(42, 25);
            this.txtMultiStep2.TabIndex = 12;
            this.txtMultiStep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMultiStep2.TextChanged += new System.EventHandler(this.txtMultiStep1_TextChanged);
            this.txtMultiStep2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRxnExtRegNo_KeyPress);
            // 
            // rbnMultiStep
            // 
            this.rbnMultiStep.AutoSize = true;
            this.rbnMultiStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnMultiStep.Location = new System.Drawing.Point(315, 5);
            this.rbnMultiStep.Name = "rbnMultiStep";
            this.rbnMultiStep.Size = new System.Drawing.Size(86, 21);
            this.rbnMultiStep.TabIndex = 10;
            this.rbnMultiStep.Text = "Multi Step";
            this.rbnMultiStep.UseVisualStyleBackColor = true;
            this.rbnMultiStep.CheckedChanged += new System.EventHandler(this.rbnMultiStep_CheckedChanged);
            // 
            // rbnSingleStep
            // 
            this.rbnSingleStep.AutoSize = true;
            this.rbnSingleStep.Checked = true;
            this.rbnSingleStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnSingleStep.Location = new System.Drawing.Point(239, 5);
            this.rbnSingleStep.Name = "rbnSingleStep";
            this.rbnSingleStep.Size = new System.Drawing.Size(63, 21);
            this.rbnSingleStep.TabIndex = 9;
            this.rbnSingleStep.TabStop = true;
            this.rbnSingleStep.Text = "1 Step";
            this.rbnSingleStep.UseVisualStyleBackColor = true;
            this.rbnSingleStep.CheckedChanged += new System.EventHandler(this.rbnMultiStep_CheckedChanged);
            // 
            // btnAddRxnRef
            // 
            this.btnAddRxnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRxnRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRxnRef.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddRxnRef.Location = new System.Drawing.Point(8, 1);
            this.btnAddRxnRef.Name = "btnAddRxnRef";
            this.btnAddRxnRef.Size = new System.Drawing.Size(31, 27);
            this.btnAddRxnRef.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAddRxnRef, "Save Reaction Reference");
            this.btnAddRxnRef.UseVisualStyleBackColor = true;
            this.btnAddRxnRef.Click += new System.EventHandler(this.btnAddRxnRef_Click);
            // 
            // dgvRxnRef
            // 
            this.dgvRxnRef.AllowUserToAddRows = false;
            this.dgvRxnRef.AllowUserToDeleteRows = false;
            this.dgvRxnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRxnRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRxnRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRxnRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRxnRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRxnRefID,
            this.colExtReg,
            this.colRxnPath,
            this.colRxnStep,
            this.ColEditRxnRef,
            this.colDeleteRxnRef});
            this.dgvRxnRef.Location = new System.Drawing.Point(-1, 31);
            this.dgvRxnRef.Name = "dgvRxnRef";
            this.dgvRxnRef.ReadOnly = true;
            this.dgvRxnRef.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaShell;
            this.dgvRxnRef.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRxnRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRxnRef.Size = new System.Drawing.Size(83, 15);
            this.dgvRxnRef.TabIndex = 0;
            this.dgvRxnRef.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRxnRef_CellClick);
            this.dgvRxnRef.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRxnRef_RowPostPaint);
            // 
            // txtMultiStep1
            // 
            this.txtMultiStep1.Location = new System.Drawing.Point(401, 3);
            this.txtMultiStep1.MaxLength = 20;
            this.txtMultiStep1.Name = "txtMultiStep1";
            this.txtMultiStep1.Size = new System.Drawing.Size(40, 25);
            this.txtMultiStep1.TabIndex = 7;
            this.txtMultiStep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMultiStep1.TextChanged += new System.EventHandler(this.txtMultiStep1_TextChanged);
            this.txtMultiStep1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRxnExtRegNo_KeyPress);
            // 
            // txtExtRegNo
            // 
            this.txtExtRegNo.Location = new System.Drawing.Point(63, 3);
            this.txtExtRegNo.MaxLength = 2;
            this.txtExtRegNo.Name = "txtExtRegNo";
            this.txtExtRegNo.Size = new System.Drawing.Size(39, 25);
            this.txtExtRegNo.TabIndex = 3;
            this.txtExtRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtRegNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRxnExtRegNo_KeyPress);
            // 
            // lblExtReg
            // 
            this.lblExtReg.AutoSize = true;
            this.lblExtReg.Location = new System.Drawing.Point(3, 6);
            this.lblExtReg.Name = "lblExtReg";
            this.lblExtReg.Size = new System.Drawing.Size(61, 17);
            this.lblExtReg.TabIndex = 2;
            this.lblExtReg.Text = "Path No.";
            // 
            // txtRxnPath
            // 
            this.txtRxnPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRxnPath.Location = new System.Drawing.Point(149, 3);
            this.txtRxnPath.MaxLength = 1;
            this.txtRxnPath.Name = "txtRxnPath";
            this.txtRxnPath.Size = new System.Drawing.Size(41, 25);
            this.txtRxnPath.TabIndex = 5;
            this.txtRxnPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(111, 7);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 17);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path";
            // 
            // pnlRxnSchemeCtrls
            // 
            this.pnlRxnSchemeCtrls.Controls.Add(this.lblCrossRefId);
            this.pnlRxnSchemeCtrls.Controls.Add(this.pnlNavigation);
            this.pnlRxnSchemeCtrls.Controls.Add(this.txtRxnSNo);
            this.pnlRxnSchemeCtrls.Controls.Add(this.rbnAutoMapping);
            this.pnlRxnSchemeCtrls.Controls.Add(this.btnAddReaction);
            this.pnlRxnSchemeCtrls.Controls.Add(this.btnDelReaction);
            this.pnlRxnSchemeCtrls.Controls.Add(this.label1);
            this.pnlRxnSchemeCtrls.Controls.Add(this.lblRxnCnt);
            this.pnlRxnSchemeCtrls.Controls.Add(this.label3);
            this.pnlRxnSchemeCtrls.Controls.Add(this.rbnManualMapping);
            this.pnlRxnSchemeCtrls.Controls.Add(this.chkImpReaction);
            this.pnlRxnSchemeCtrls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRxnSchemeCtrls.Location = new System.Drawing.Point(0, 0);
            this.pnlRxnSchemeCtrls.Name = "pnlRxnSchemeCtrls";
            this.pnlRxnSchemeCtrls.Size = new System.Drawing.Size(1041, 25);
            this.pnlRxnSchemeCtrls.TabIndex = 22;
            // 
            // lblCrossRefId
            // 
            this.lblCrossRefId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrossRefId.AutoSize = true;
            this.lblCrossRefId.Location = new System.Drawing.Point(582, 4);
            this.lblCrossRefId.Name = "lblCrossRefId";
            this.lblCrossRefId.Size = new System.Drawing.Size(66, 17);
            this.lblCrossRefId.TabIndex = 10;
            this.lblCrossRefId.Text = "Rxn S.No";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnPrevRxn);
            this.pnlNavigation.Controls.Add(this.numGoToRxn);
            this.pnlNavigation.Controls.Add(this.btnFirstRxn);
            this.pnlNavigation.Controls.Add(this.btnNextRxn);
            this.pnlNavigation.Controls.Add(this.btnLastRxn);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNavigation.Location = new System.Drawing.Point(820, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(221, 25);
            this.pnlNavigation.TabIndex = 13;
            // 
            // btnPrevRxn
            // 
            this.btnPrevRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevRxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevRxn.Image = global::ChemInform.Properties.Resources.resultset_previous;
            this.btnPrevRxn.Location = new System.Drawing.Point(47, 0);
            this.btnPrevRxn.Name = "btnPrevRxn";
            this.btnPrevRxn.Size = new System.Drawing.Size(36, 25);
            this.btnPrevRxn.TabIndex = 8;
            this.btnPrevRxn.UseVisualStyleBackColor = true;
            this.btnPrevRxn.Click += new System.EventHandler(this.btnPrevRxn_Click);
            // 
            // numGoToRxn
            // 
            this.numGoToRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numGoToRxn.Location = new System.Drawing.Point(89, 0);
            this.numGoToRxn.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGoToRxn.Name = "numGoToRxn";
            this.numGoToRxn.Size = new System.Drawing.Size(47, 25);
            this.numGoToRxn.TabIndex = 12;
            this.numGoToRxn.ValueChanged += new System.EventHandler(this.numGoToRxn_ValueChanged);
            this.numGoToRxn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numGoToRxn_KeyPress);
            // 
            // btnFirstRxn
            // 
            this.btnFirstRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstRxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstRxn.Image = global::ChemInform.Properties.Resources.resultset_first;
            this.btnFirstRxn.Location = new System.Drawing.Point(5, 0);
            this.btnFirstRxn.Name = "btnFirstRxn";
            this.btnFirstRxn.Size = new System.Drawing.Size(36, 25);
            this.btnFirstRxn.TabIndex = 7;
            this.btnFirstRxn.UseVisualStyleBackColor = true;
            this.btnFirstRxn.Click += new System.EventHandler(this.btnFirstRxn_Click);
            // 
            // btnNextRxn
            // 
            this.btnNextRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextRxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextRxn.Image = global::ChemInform.Properties.Resources.resultset_next;
            this.btnNextRxn.Location = new System.Drawing.Point(140, 0);
            this.btnNextRxn.Name = "btnNextRxn";
            this.btnNextRxn.Size = new System.Drawing.Size(36, 25);
            this.btnNextRxn.TabIndex = 10;
            this.btnNextRxn.UseVisualStyleBackColor = true;
            this.btnNextRxn.Click += new System.EventHandler(this.btnNextRxn_Click);
            // 
            // btnLastRxn
            // 
            this.btnLastRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastRxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastRxn.Image = global::ChemInform.Properties.Resources.resultset_last;
            this.btnLastRxn.Location = new System.Drawing.Point(181, 0);
            this.btnLastRxn.Name = "btnLastRxn";
            this.btnLastRxn.Size = new System.Drawing.Size(36, 25);
            this.btnLastRxn.TabIndex = 11;
            this.btnLastRxn.UseVisualStyleBackColor = true;
            this.btnLastRxn.Click += new System.EventHandler(this.btnLastRxn_Click);
            // 
            // txtRxnSNo
            // 
            this.txtRxnSNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRxnSNo.BackColor = System.Drawing.Color.SeaShell;
            this.txtRxnSNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRxnSNo.ForeColor = System.Drawing.Color.Blue;
            this.txtRxnSNo.Location = new System.Drawing.Point(651, 0);
            this.txtRxnSNo.Name = "txtRxnSNo";
            this.txtRxnSNo.ReadOnly = true;
            this.txtRxnSNo.Size = new System.Drawing.Size(38, 25);
            this.txtRxnSNo.TabIndex = 11;
            this.txtRxnSNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbnAutoMapping
            // 
            this.rbnAutoMapping.AutoSize = true;
            this.rbnAutoMapping.BackColor = System.Drawing.Color.White;
            this.rbnAutoMapping.Location = new System.Drawing.Point(287, 2);
            this.rbnAutoMapping.Name = "rbnAutoMapping";
            this.rbnAutoMapping.Size = new System.Drawing.Size(110, 21);
            this.rbnAutoMapping.TabIndex = 7;
            this.rbnAutoMapping.Text = "Auto Mapping";
            this.rbnAutoMapping.UseVisualStyleBackColor = false;
            // 
            // btnAddReaction
            // 
            this.btnAddReaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReaction.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddReaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReaction.Location = new System.Drawing.Point(519, 0);
            this.btnAddReaction.Name = "btnAddReaction";
            this.btnAddReaction.Size = new System.Drawing.Size(62, 25);
            this.btnAddReaction.TabIndex = 10;
            this.btnAddReaction.Text = "Rxn";
            this.btnAddReaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReaction.UseVisualStyleBackColor = true;
            this.btnAddReaction.Click += new System.EventHandler(this.btnAddRxn_Click);
            // 
            // btnDelReaction
            // 
            this.btnDelReaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelReaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelReaction.Image = global::ChemInform.Properties.Resources.close_box_red;
            this.btnDelReaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelReaction.Location = new System.Drawing.Point(443, 0);
            this.btnDelReaction.Name = "btnDelReaction";
            this.btnDelReaction.Size = new System.Drawing.Size(62, 25);
            this.btnDelReaction.TabIndex = 9;
            this.btnDelReaction.Text = "Rxn";
            this.btnDelReaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelReaction.UseVisualStyleBackColor = true;
            this.btnDelReaction.Click += new System.EventHandler(this.btnDeleteRxn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(696, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reactions ";
            // 
            // lblRxnCnt
            // 
            this.lblRxnCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRxnCnt.AutoSize = true;
            this.lblRxnCnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRxnCnt.Location = new System.Drawing.Point(774, 4);
            this.lblRxnCnt.Name = "lblRxnCnt";
            this.lblRxnCnt.Size = new System.Drawing.Size(13, 17);
            this.lblRxnCnt.TabIndex = 17;
            this.lblRxnCnt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Atom Mapping Type: ";
            // 
            // rbnManualMapping
            // 
            this.rbnManualMapping.AutoSize = true;
            this.rbnManualMapping.BackColor = System.Drawing.Color.White;
            this.rbnManualMapping.Checked = true;
            this.rbnManualMapping.Location = new System.Drawing.Point(153, 2);
            this.rbnManualMapping.Name = "rbnManualMapping";
            this.rbnManualMapping.Size = new System.Drawing.Size(125, 21);
            this.rbnManualMapping.TabIndex = 6;
            this.rbnManualMapping.TabStop = true;
            this.rbnManualMapping.Text = "Manual Mapping";
            this.rbnManualMapping.UseVisualStyleBackColor = false;
            // 
            // chkImpReaction
            // 
            this.chkImpReaction.AutoSize = true;
            this.chkImpReaction.Location = new System.Drawing.Point(421, 3);
            this.chkImpReaction.Name = "chkImpReaction";
            this.chkImpReaction.Size = new System.Drawing.Size(140, 21);
            this.chkImpReaction.TabIndex = 8;
            this.chkImpReaction.Text = "Important Reaction";
            this.chkImpReaction.UseVisualStyleBackColor = true;
            // 
            // pnlCrossRef
            // 
            this.pnlCrossRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrossRef.Controls.Add(this.btnResetCrossRef);
            this.pnlCrossRef.Controls.Add(this.btnAddCrossRef);
            this.pnlCrossRef.Controls.Add(this.dgvCrossRef);
            this.pnlCrossRef.Controls.Add(this.txtSuccRxn);
            this.pnlCrossRef.Controls.Add(this.lblSuccRxn);
            this.pnlCrossRef.Controls.Add(this.txtPreRxn);
            this.pnlCrossRef.Controls.Add(this.lblPreRxn);
            this.pnlCrossRef.Location = new System.Drawing.Point(28, 156);
            this.pnlCrossRef.Name = "pnlCrossRef";
            this.pnlCrossRef.Size = new System.Drawing.Size(39, 40);
            this.pnlCrossRef.TabIndex = 13;
            this.pnlCrossRef.Visible = false;
            // 
            // btnResetCrossRef
            // 
            this.btnResetCrossRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetCrossRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCrossRef.Image = global::ChemInform.Properties.Resources.refresh;
            this.btnResetCrossRef.Location = new System.Drawing.Point(-1, 2);
            this.btnResetCrossRef.Name = "btnResetCrossRef";
            this.btnResetCrossRef.Size = new System.Drawing.Size(31, 27);
            this.btnResetCrossRef.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnResetCrossRef, "Reset Cross Reference");
            this.btnResetCrossRef.UseVisualStyleBackColor = true;
            this.btnResetCrossRef.Click += new System.EventHandler(this.btnResetCrossRef_Click);
            // 
            // btnAddCrossRef
            // 
            this.btnAddCrossRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCrossRef.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddCrossRef.Location = new System.Drawing.Point(283, 2);
            this.btnAddCrossRef.Name = "btnAddCrossRef";
            this.btnAddCrossRef.Size = new System.Drawing.Size(31, 27);
            this.btnAddCrossRef.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnAddCrossRef, "Save Cross Reference");
            this.btnAddCrossRef.UseVisualStyleBackColor = true;
            this.btnAddCrossRef.Click += new System.EventHandler(this.btnAddCrossRef_Click);
            // 
            // dgvCrossRef
            // 
            this.dgvCrossRef.AllowUserToAddRows = false;
            this.dgvCrossRef.AllowUserToDeleteRows = false;
            this.dgvCrossRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrossRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrossRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCrossRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrossRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCrossRefID,
            this.colCrossRefPreRxn,
            this.colCrossRefSuccRxn,
            this.colEditCrossRef,
            this.colDeleteCrossRef});
            this.dgvCrossRef.Location = new System.Drawing.Point(-1, 31);
            this.dgvCrossRef.Name = "dgvCrossRef";
            this.dgvCrossRef.ReadOnly = true;
            this.dgvCrossRef.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaShell;
            this.dgvCrossRef.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCrossRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrossRef.Size = new System.Drawing.Size(39, 8);
            this.dgvCrossRef.TabIndex = 1;
            this.dgvCrossRef.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrossRef_CellClick);
            this.dgvCrossRef.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCrossRef_RowPostPaint);
            // 
            // txtSuccRxn
            // 
            this.txtSuccRxn.Location = new System.Drawing.Point(228, 3);
            this.txtSuccRxn.MaxLength = 3;
            this.txtSuccRxn.Name = "txtSuccRxn";
            this.txtSuccRxn.Size = new System.Drawing.Size(49, 25);
            this.txtSuccRxn.TabIndex = 15;
            this.txtSuccRxn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuccRxn_KeyPress);
            // 
            // lblSuccRxn
            // 
            this.lblSuccRxn.AutoSize = true;
            this.lblSuccRxn.Location = new System.Drawing.Point(139, 7);
            this.lblSuccRxn.Name = "lblSuccRxn";
            this.lblSuccRxn.Size = new System.Drawing.Size(88, 17);
            this.lblSuccRxn.TabIndex = 14;
            this.lblSuccRxn.Text = "Succ. To Rxn";
            // 
            // txtPreRxn
            // 
            this.txtPreRxn.Location = new System.Drawing.Point(85, 3);
            this.txtPreRxn.MaxLength = 3;
            this.txtPreRxn.Name = "txtPreRxn";
            this.txtPreRxn.Size = new System.Drawing.Size(48, 25);
            this.txtPreRxn.TabIndex = 13;
            this.txtPreRxn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreRxn_KeyPress);
            // 
            // lblPreRxn
            // 
            this.lblPreRxn.AutoSize = true;
            this.lblPreRxn.Location = new System.Drawing.Point(2, 7);
            this.lblPreRxn.Name = "lblPreRxn";
            this.lblPreRxn.Size = new System.Drawing.Size(80, 17);
            this.lblPreRxn.TabIndex = 12;
            this.lblPreRxn.Text = "Pre. To Rxn";
            // 
            // tcRxnSteps
            // 
            this.tcRxnSteps.ContextMenuStrip = this.cntMnuAddNewStep;
            this.tcRxnSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRxnSteps.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcRxnSteps.HotTrack = true;
            this.tcRxnSteps.Location = new System.Drawing.Point(0, 0);
            this.tcRxnSteps.Margin = new System.Windows.Forms.Padding(0);
            this.tcRxnSteps.Name = "tcRxnSteps";
            this.tcRxnSteps.Padding = new System.Drawing.Point(0, 0);
            this.tcRxnSteps.SelectedIndex = 0;
            this.tcRxnSteps.Size = new System.Drawing.Size(1041, 233);
            this.tcRxnSteps.TabIndex = 14;
            this.tcRxnSteps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSteps_MouseClick);
            // 
            // cntMnuAddNewStep
            // 
            this.cntMnuAddNewStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStepTSMenuItem,
            this.deleteStepTSMenuItem});
            this.cntMnuAddNewStep.Name = "cntMnuAddNewTab";
            this.cntMnuAddNewStep.Size = new System.Drawing.Size(134, 48);
            // 
            // addStepTSMenuItem
            // 
            this.addStepTSMenuItem.Name = "addStepTSMenuItem";
            this.addStepTSMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addStepTSMenuItem.Text = "Add Step";
            this.addStepTSMenuItem.Click += new System.EventHandler(this.addStepTSMenuItem_Click);
            // 
            // deleteStepTSMenuItem
            // 
            this.deleteStepTSMenuItem.Name = "deleteStepTSMenuItem";
            this.deleteStepTSMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteStepTSMenuItem.Text = "Delete Step";
            this.deleteStepTSMenuItem.Click += new System.EventHandler(this.deleteStepTSMenuItem_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSave.Controls.Add(this.chkRxnComplete);
            this.pnlSave.Controls.Add(this.button1);
            this.pnlSave.Controls.Add(this.btnRxn_CrossRef);
            this.pnlSave.Controls.Add(this.btnExportPdf);
            this.pnlSave.Controls.Add(this.lblComments);
            this.pnlSave.Controls.Add(this.txtRxnComments);
            this.pnlSave.Controls.Add(this.btnRefComplete);
            this.pnlSave.Controls.Add(this.btnExport);
            this.pnlSave.Controls.Add(this.lblStatus);
            this.pnlSave.Controls.Add(this.btnRefreshRxnScheme);
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 561);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(1129, 57);
            this.pnlSave.TabIndex = 5;
            // 
            // chkRxnComplete
            // 
            this.chkRxnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRxnComplete.AutoSize = true;
            this.chkRxnComplete.Location = new System.Drawing.Point(906, 33);
            this.chkRxnComplete.Name = "chkRxnComplete";
            this.chkRxnComplete.Size = new System.Drawing.Size(139, 21);
            this.chkRxnComplete.TabIndex = 14;
            this.chkRxnComplete.Text = "Reaction Complete";
            this.chkRxnComplete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRxn_CrossRef
            // 
            this.btnRxn_CrossRef.Location = new System.Drawing.Point(292, 30);
            this.btnRxn_CrossRef.Name = "btnRxn_CrossRef";
            this.btnRxn_CrossRef.Size = new System.Drawing.Size(113, 25);
            this.btnRxn_CrossRef.TabIndex = 12;
            this.btnRxn_CrossRef.Text = "Rxn /Cross Ref";
            this.btnRxn_CrossRef.UseVisualStyleBackColor = true;
            this.btnRxn_CrossRef.Click += new System.EventHandler(this.btnRxn_CrossRef_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPdf.Image = global::ChemInform.Properties.Resources.file_extension_pdf;
            this.btnExportPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPdf.Location = new System.Drawing.Point(212, 30);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(74, 25);
            this.btnExportPdf.TabIndex = 11;
            this.btnExportPdf.Text = "Export";
            this.btnExportPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(2, 7);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(99, 17);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Rxn Comments";
            // 
            // txtRxnComments
            // 
            this.txtRxnComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRxnComments.Location = new System.Drawing.Point(107, 3);
            this.txtRxnComments.Name = "txtRxnComments";
            this.txtRxnComments.Size = new System.Drawing.Size(1017, 25);
            this.txtRxnComments.TabIndex = 8;
            // 
            // btnRefComplete
            // 
            this.btnRefComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefComplete.Location = new System.Drawing.Point(4, 30);
            this.btnRefComplete.Name = "btnRefComplete";
            this.btnRefComplete.Size = new System.Drawing.Size(99, 25);
            this.btnRefComplete.TabIndex = 7;
            this.btnRefComplete.Text = "Ref Complete";
            this.btnRefComplete.UseVisualStyleBackColor = true;
            this.btnRefComplete.Click += new System.EventHandler(this.btnRefComplete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(108, 30);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 25);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "RDF Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(691, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "--";
            // 
            // btnRefreshRxnScheme
            // 
            this.btnRefreshRxnScheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshRxnScheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshRxnScheme.Location = new System.Drawing.Point(455, 30);
            this.btnRefreshRxnScheme.Name = "btnRefreshRxnScheme";
            this.btnRefreshRxnScheme.Size = new System.Drawing.Size(118, 25);
            this.btnRefreshRxnScheme.TabIndex = 4;
            this.btnRefreshRxnScheme.Text = "Refresh Scheme";
            this.btnRefreshRxnScheme.UseVisualStyleBackColor = true;
            this.btnRefreshRxnScheme.Click += new System.EventHandler(this.btnRefreshRxnScheme_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::ChemInform.Properties.Resources.save_1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1051, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAbstract
            // 
            this.pnlAbstract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAbstract.Controls.Add(this.txtRefNo);
            this.pnlAbstract.Controls.Add(this.lblRefNo);
            this.pnlAbstract.Controls.Add(this.txtEndPage);
            this.pnlAbstract.Controls.Add(this.lblEndPage);
            this.pnlAbstract.Controls.Add(this.txtStartPage);
            this.pnlAbstract.Controls.Add(this.lblStartPage);
            this.pnlAbstract.Controls.Add(this.txtDOI);
            this.pnlAbstract.Controls.Add(this.lblDOI);
            this.pnlAbstract.Controls.Add(this.txtVolume);
            this.pnlAbstract.Controls.Add(this.lblVolume);
            this.pnlAbstract.Controls.Add(this.txtJournalName);
            this.pnlAbstract.Controls.Add(this.lblJournalName);
            this.pnlAbstract.Controls.Add(this.txtYear);
            this.pnlAbstract.Controls.Add(this.lblYear);
            this.pnlAbstract.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbstract.Location = new System.Drawing.Point(0, 0);
            this.pnlAbstract.Name = "pnlAbstract";
            this.pnlAbstract.Size = new System.Drawing.Size(1129, 32);
            this.pnlAbstract.TabIndex = 3;
            // 
            // txtEndPage
            // 
            this.txtEndPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPage.BackColor = System.Drawing.Color.SeaShell;
            this.txtEndPage.ForeColor = System.Drawing.Color.Blue;
            this.txtEndPage.Location = new System.Drawing.Point(835, 3);
            this.txtEndPage.MaxLength = 4;
            this.txtEndPage.Name = "txtEndPage";
            this.txtEndPage.Size = new System.Drawing.Size(60, 25);
            this.txtEndPage.TabIndex = 5;
            this.txtEndPage.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // lblEndPage
            // 
            this.lblEndPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndPage.AutoSize = true;
            this.lblEndPage.Location = new System.Drawing.Point(767, 7);
            this.lblEndPage.Name = "lblEndPage";
            this.lblEndPage.Size = new System.Drawing.Size(65, 17);
            this.lblEndPage.TabIndex = 10;
            this.lblEndPage.Text = "End Page";
            // 
            // txtStartPage
            // 
            this.txtStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartPage.BackColor = System.Drawing.Color.SeaShell;
            this.txtStartPage.ForeColor = System.Drawing.Color.Blue;
            this.txtStartPage.Location = new System.Drawing.Point(704, 3);
            this.txtStartPage.MaxLength = 4;
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(60, 25);
            this.txtStartPage.TabIndex = 4;
            this.txtStartPage.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // lblStartPage
            // 
            this.lblStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartPage.AutoSize = true;
            this.lblStartPage.Location = new System.Drawing.Point(631, 7);
            this.lblStartPage.Name = "lblStartPage";
            this.lblStartPage.Size = new System.Drawing.Size(70, 17);
            this.lblStartPage.TabIndex = 8;
            this.lblStartPage.Text = "Start Page";
            // 
            // txtDOI
            // 
            this.txtDOI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDOI.BackColor = System.Drawing.Color.SeaShell;
            this.txtDOI.ForeColor = System.Drawing.Color.Blue;
            this.txtDOI.Location = new System.Drawing.Point(936, 3);
            this.txtDOI.Name = "txtDOI";
            this.txtDOI.ReadOnly = true;
            this.txtDOI.Size = new System.Drawing.Size(189, 25);
            this.txtDOI.TabIndex = 3;
            // 
            // lblDOI
            // 
            this.lblDOI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOI.AutoSize = true;
            this.lblDOI.Location = new System.Drawing.Point(899, 7);
            this.lblDOI.Name = "lblDOI";
            this.lblDOI.Size = new System.Drawing.Size(35, 17);
            this.lblDOI.TabIndex = 6;
            this.lblDOI.Text = "DOI";
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolume.BackColor = System.Drawing.Color.SeaShell;
            this.txtVolume.ForeColor = System.Drawing.Color.Blue;
            this.txtVolume.Location = new System.Drawing.Point(449, 3);
            this.txtVolume.MaxLength = 2;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(60, 25);
            this.txtVolume.TabIndex = 1;
            this.txtVolume.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(396, 7);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(52, 17);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume";
            // 
            // txtJournalName
            // 
            this.txtJournalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJournalName.BackColor = System.Drawing.Color.SeaShell;
            this.txtJournalName.ForeColor = System.Drawing.Color.Blue;
            this.txtJournalName.Location = new System.Drawing.Point(212, 3);
            this.txtJournalName.Name = "txtJournalName";
            this.txtJournalName.ReadOnly = true;
            this.txtJournalName.Size = new System.Drawing.Size(180, 25);
            this.txtJournalName.TabIndex = 0;
            // 
            // lblJournalName
            // 
            this.lblJournalName.AutoSize = true;
            this.lblJournalName.Location = new System.Drawing.Point(160, 7);
            this.lblJournalName.Name = "lblJournalName";
            this.lblJournalName.Size = new System.Drawing.Size(50, 17);
            this.lblJournalName.TabIndex = 2;
            this.lblJournalName.Text = "Journal";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.BackColor = System.Drawing.Color.SeaShell;
            this.txtYear.Location = new System.Drawing.Point(552, 3);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(75, 25);
            this.txtYear.TabIndex = 2;
            this.txtYear.TextChanged += new System.EventHandler(this.txtVolume_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(513, 7);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // cntMnuAddNewRow
            // 
            this.cntMnuAddNewRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRowToolStripMenuItem});
            this.cntMnuAddNewRow.Name = "cntMnu";
            this.cntMnuAddNewRow.Size = new System.Drawing.Size(125, 26);
            // 
            // newRowToolStripMenuItem
            // 
            this.newRowToolStripMenuItem.Name = "newRowToolStripMenuItem";
            this.newRowToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newRowToolStripMenuItem.Text = "New Row";
            this.newRowToolStripMenuItem.Click += new System.EventHandler(this.newRowToolStripMenuItem_Click);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BackColor = System.Drawing.Color.SeaShell;
            this.txtRefNo.ForeColor = System.Drawing.Color.Blue;
            this.txtRefNo.Location = new System.Drawing.Point(55, 3);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.ReadOnly = true;
            this.txtRefNo.Size = new System.Drawing.Size(100, 25);
            this.txtRefNo.TabIndex = 12;
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(3, 7);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(56, 17);
            this.lblRefNo.TabIndex = 11;
            this.lblRefNo.Text = "Ref No.";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "RxnRefID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ExtReg";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 126;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Path";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Structure";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            this.dataGridViewImageColumn1.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 103.4264F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Step";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 299;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CrossRefID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 126;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 128.6018F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Pre. Rxn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 128.6018F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Succ. Rxn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 141;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 126;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Product";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Strucure";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 35;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ChemInform.Properties.Resources.Edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Edit Product";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = global::ChemInform.Properties.Resources.delete_row;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.ToolTipText = "Delete Product";
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.HeaderText = "Struct_No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.FillWeight = 50F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Yield";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.FillWeight = 50F;
            this.dataGridViewTextBoxColumn13.HeaderText = "CS";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.FillWeight = 103.4264F;
            this.dataGridViewTextBoxColumn14.HeaderText = "DS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 121;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.FillWeight = 103.4264F;
            this.dataGridViewTextBoxColumn15.HeaderText = "DE";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 120;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn1.FillWeight = 103.4264F;
            this.dataGridViewLinkColumn1.HeaderText = "Edit";
            this.dataGridViewLinkColumn1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Text = "Edit";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.Width = 60;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn2.FillWeight = 86.29442F;
            this.dataGridViewLinkColumn2.HeaderText = "Delete";
            this.dataGridViewLinkColumn2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn2.Text = "Delete";
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.FillWeight = 128.6018F;
            this.dataGridViewTextBoxColumn16.HeaderText = "EE";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.FillWeight = 128.6018F;
            this.dataGridViewTextBoxColumn17.HeaderText = "InchiKey";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 5;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.FillWeight = 128.6018F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Succ.Rxn";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 5;
            // 
            // dataGridViewLinkColumn3
            // 
            this.dataGridViewLinkColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn3.FillWeight = 51.17845F;
            this.dataGridViewLinkColumn3.HeaderText = "Edit";
            this.dataGridViewLinkColumn3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn3.Name = "dataGridViewLinkColumn3";
            this.dataGridViewLinkColumn3.ReadOnly = true;
            this.dataGridViewLinkColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn3.Text = "Edit";
            this.dataGridViewLinkColumn3.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn3.Width = 56;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn4.FillWeight = 76.14212F;
            this.dataGridViewLinkColumn4.HeaderText = "Delete";
            this.dataGridViewLinkColumn4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.ReadOnly = true;
            this.dataGridViewLinkColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn4.Text = "Delete";
            this.dataGridViewLinkColumn4.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn4.Width = 83;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colProductStructure
            // 
            this.colProductStructure.HeaderText = "Strucure";
            this.colProductStructure.Name = "colProductStructure";
            this.colProductStructure.ReadOnly = true;
            this.colProductStructure.Visible = false;
            // 
            // colProductStructImage
            // 
            this.colProductStructImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductStructImage.HeaderText = "Structure";
            this.colProductStructImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colProductStructImage.Name = "colProductStructImage";
            this.colProductStructImage.ReadOnly = true;
            this.colProductStructImage.Visible = false;
            this.colProductStructImage.Width = 80;
            // 
            // colProductStructNo
            // 
            this.colProductStructNo.HeaderText = "Struct_No";
            this.colProductStructNo.Name = "colProductStructNo";
            this.colProductStructNo.ReadOnly = true;
            // 
            // colProductYield
            // 
            this.colProductYield.HeaderText = "Yield";
            this.colProductYield.Name = "colProductYield";
            this.colProductYield.ReadOnly = true;
            // 
            // colProductCs
            // 
            this.colProductCs.HeaderText = "CS";
            this.colProductCs.Name = "colProductCs";
            this.colProductCs.ReadOnly = true;
            // 
            // colProductDs
            // 
            this.colProductDs.HeaderText = "DS";
            this.colProductDs.Name = "colProductDs";
            this.colProductDs.ReadOnly = true;
            // 
            // colProductDE
            // 
            this.colProductDE.HeaderText = "DE";
            this.colProductDE.Name = "colProductDE";
            this.colProductDE.ReadOnly = true;
            // 
            // colProductEE
            // 
            this.colProductEE.HeaderText = "EE";
            this.colProductEE.Name = "colProductEE";
            this.colProductEE.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.HeaderText = "Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // colproductEdit
            // 
            this.colproductEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colproductEdit.HeaderText = "Edit";
            this.colproductEdit.Image = global::ChemInform.Properties.Resources.Edit;
            this.colproductEdit.Name = "colproductEdit";
            this.colproductEdit.ReadOnly = true;
            this.colproductEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colproductEdit.ToolTipText = "Edit Product";
            this.colproductEdit.Width = 40;
            // 
            // colProductDelete
            // 
            this.colProductDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductDelete.HeaderText = "Delete";
            this.colProductDelete.Image = global::ChemInform.Properties.Resources.delete_row;
            this.colProductDelete.Name = "colProductDelete";
            this.colProductDelete.ReadOnly = true;
            this.colProductDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductDelete.ToolTipText = "Delete Product";
            this.colProductDelete.Width = 40;
            // 
            // colInchiKey
            // 
            this.colInchiKey.HeaderText = "InchiKey";
            this.colInchiKey.Name = "colInchiKey";
            this.colInchiKey.ReadOnly = true;
            this.colInchiKey.Visible = false;
            // 
            // colRxnRefID
            // 
            this.colRxnRefID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnRefID.HeaderText = "RxnRefID";
            this.colRxnRefID.Name = "colRxnRefID";
            this.colRxnRefID.ReadOnly = true;
            this.colRxnRefID.Visible = false;
            // 
            // colExtReg
            // 
            this.colExtReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExtReg.FillWeight = 50F;
            this.colExtReg.HeaderText = "PathNo";
            this.colExtReg.Name = "colExtReg";
            this.colExtReg.ReadOnly = true;
            // 
            // colRxnPath
            // 
            this.colRxnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnPath.FillWeight = 50F;
            this.colRxnPath.HeaderText = "Path";
            this.colRxnPath.Name = "colRxnPath";
            this.colRxnPath.ReadOnly = true;
            // 
            // colRxnStep
            // 
            this.colRxnStep.FillWeight = 103.4264F;
            this.colRxnStep.HeaderText = "Step";
            this.colRxnStep.Name = "colRxnStep";
            this.colRxnStep.ReadOnly = true;
            // 
            // ColEditRxnRef
            // 
            this.ColEditRxnRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEditRxnRef.FillWeight = 103.4264F;
            this.ColEditRxnRef.HeaderText = "Edit";
            this.ColEditRxnRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ColEditRxnRef.Name = "ColEditRxnRef";
            this.ColEditRxnRef.ReadOnly = true;
            this.ColEditRxnRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEditRxnRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEditRxnRef.Text = "Edit";
            this.ColEditRxnRef.UseColumnTextForLinkValue = true;
            this.ColEditRxnRef.Width = 60;
            // 
            // colDeleteRxnRef
            // 
            this.colDeleteRxnRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDeleteRxnRef.FillWeight = 86.29442F;
            this.colDeleteRxnRef.HeaderText = "Delete";
            this.colDeleteRxnRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colDeleteRxnRef.Name = "colDeleteRxnRef";
            this.colDeleteRxnRef.ReadOnly = true;
            this.colDeleteRxnRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteRxnRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteRxnRef.Text = "Delete";
            this.colDeleteRxnRef.UseColumnTextForLinkValue = true;
            this.colDeleteRxnRef.Width = 60;
            // 
            // colCrossRefID
            // 
            this.colCrossRefID.HeaderText = "CrossRefID";
            this.colCrossRefID.Name = "colCrossRefID";
            this.colCrossRefID.ReadOnly = true;
            this.colCrossRefID.Visible = false;
            // 
            // colCrossRefPreRxn
            // 
            this.colCrossRefPreRxn.FillWeight = 128.6018F;
            this.colCrossRefPreRxn.HeaderText = "Pre.Rxn";
            this.colCrossRefPreRxn.Name = "colCrossRefPreRxn";
            this.colCrossRefPreRxn.ReadOnly = true;
            // 
            // colCrossRefSuccRxn
            // 
            this.colCrossRefSuccRxn.FillWeight = 128.6018F;
            this.colCrossRefSuccRxn.HeaderText = "Succ.Rxn";
            this.colCrossRefSuccRxn.Name = "colCrossRefSuccRxn";
            this.colCrossRefSuccRxn.ReadOnly = true;
            // 
            // colEditCrossRef
            // 
            this.colEditCrossRef.FillWeight = 51.17845F;
            this.colEditCrossRef.HeaderText = "Edit";
            this.colEditCrossRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colEditCrossRef.Name = "colEditCrossRef";
            this.colEditCrossRef.ReadOnly = true;
            this.colEditCrossRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditCrossRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditCrossRef.Text = "Edit";
            this.colEditCrossRef.UseColumnTextForLinkValue = true;
            // 
            // colDeleteCrossRef
            // 
            this.colDeleteCrossRef.FillWeight = 76.14212F;
            this.colDeleteCrossRef.HeaderText = "Delete";
            this.colDeleteCrossRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colDeleteCrossRef.Name = "colDeleteCrossRef";
            this.colDeleteCrossRef.ReadOnly = true;
            this.colDeleteCrossRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteCrossRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteCrossRef.Text = "Delete";
            this.colDeleteCrossRef.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewLinkColumn5
            // 
            this.dataGridViewLinkColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn5.FillWeight = 51.17845F;
            this.dataGridViewLinkColumn5.HeaderText = "Edit";
            this.dataGridViewLinkColumn5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn5.Name = "dataGridViewLinkColumn5";
            this.dataGridViewLinkColumn5.ReadOnly = true;
            this.dataGridViewLinkColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn5.Text = "Edit";
            this.dataGridViewLinkColumn5.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn5.Width = 60;
            // 
            // dataGridViewLinkColumn6
            // 
            this.dataGridViewLinkColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn6.FillWeight = 76.14212F;
            this.dataGridViewLinkColumn6.HeaderText = "Delete";
            this.dataGridViewLinkColumn6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn6.Name = "dataGridViewLinkColumn6";
            this.dataGridViewLinkColumn6.ReadOnly = true;
            this.dataGridViewLinkColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn6.Text = "Delete";
            this.dataGridViewLinkColumn6.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn6.Width = 60;
            // 
            // frmReactionCuration_Journal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1129, 650);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmReactionCuration_Journal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reaction Curation - Journals";
            this.Load += new System.EventHandler(this.FrmReactionCuration_Load);
            this.Click += new System.EventHandler(this.FrmReactionCuration_Click);
            this.pnlMain.ResumeLayout(false);
            this.pnlReaction.ResumeLayout(false);
            this.splContRxnTree_RxnView.Panel1.ResumeLayout(false);
            this.splContRxnTree_RxnView.Panel2.ResumeLayout(false);
            this.splContRxnTree_RxnView.ResumeLayout(false);
            this.splcontRxnSteps.Panel1.ResumeLayout(false);
            this.splcontRxnSteps.Panel2.ResumeLayout(false);
            this.splcontRxnSteps.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlRxnRef.ResumeLayout(false);
            this.pnlRxnRef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRxnRef)).EndInit();
            this.pnlRxnSchemeCtrls.ResumeLayout(false);
            this.pnlRxnSchemeCtrls.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGoToRxn)).EndInit();
            this.pnlCrossRef.ResumeLayout(false);
            this.pnlCrossRef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRef)).EndInit();
            this.cntMnuAddNewStep.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.pnlAbstract.ResumeLayout(false);
            this.pnlAbstract.PerformLayout();
            this.cntMnuAddNewRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlAbstract;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtJournalName;
        private System.Windows.Forms.Label lblJournalName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnDelReaction;
        private System.Windows.Forms.Button btnAddReaction;
        private System.Windows.Forms.Button btnPrevRxn;
        private System.Windows.Forms.Button btnLastRxn;
        private System.Windows.Forms.Button btnNextRxn;
        private System.Windows.Forms.Button btnFirstRxn;
        private System.Windows.Forms.Panel pnlReaction;
        private System.Windows.Forms.ContextMenuStrip cntMnuAddNewRow;
        private System.Windows.Forms.ToolStripMenuItem newRowToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcontRxnSteps;
        private System.Windows.Forms.Label lblCrossRefId;
        private System.Windows.Forms.TextBox txtRxnSNo;
        private System.Windows.Forms.TabControl tcRxnSteps;
        private System.Windows.Forms.ContextMenuStrip cntMnuAddNewStep;
        private System.Windows.Forms.ToolStripMenuItem addStepTSMenuItem;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private MDL.Draw.Renditor.Renditor RenditorRxnScheme;
        private System.Windows.Forms.ToolStripMenuItem deleteStepTSMenuItem;
        private System.Windows.Forms.NumericUpDown numGoToRxn;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefreshRxnScheme;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRxnCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn5;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button btnRefComplete;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtRxnComments;
        private System.Windows.Forms.RadioButton rbnAutoMapping;
        private System.Windows.Forms.RadioButton rbnManualMapping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRxnSchemeCtrls;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnRxn_CrossRef;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private MDL.Draw.Renderer.Renderer productRenderer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlRxnRef;
        private System.Windows.Forms.Button btnResetRxnRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStepInfo;
        private System.Windows.Forms.TextBox txtMultiStep2;
        private System.Windows.Forms.RadioButton rbnMultiStep;
        private System.Windows.Forms.RadioButton rbnSingleStep;
        private System.Windows.Forms.Button btnAddRxnRef;
        private System.Windows.Forms.DataGridView dgvRxnRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnStep;
        private System.Windows.Forms.DataGridViewLinkColumn ColEditRxnRef;
        private System.Windows.Forms.DataGridViewLinkColumn colDeleteRxnRef;
        private System.Windows.Forms.TextBox txtMultiStep1;
        private System.Windows.Forms.TextBox txtExtRegNo;
        private System.Windows.Forms.Label lblExtReg;
        private System.Windows.Forms.TextBox txtRxnPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel pnlCrossRef;
        private System.Windows.Forms.Button btnResetCrossRef;
        private System.Windows.Forms.Button btnAddCrossRef;
        private System.Windows.Forms.DataGridView dgvCrossRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrossRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrossRefPreRxn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrossRefSuccRxn;
        private System.Windows.Forms.DataGridViewLinkColumn colEditCrossRef;
        private System.Windows.Forms.DataGridViewLinkColumn colDeleteCrossRef;
        private System.Windows.Forms.TextBox txtSuccRxn;
        private System.Windows.Forms.Label lblSuccRxn;
        private System.Windows.Forms.TextBox txtPreRxn;
        private System.Windows.Forms.Label lblPreRxn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductStructure;
        private System.Windows.Forms.DataGridViewImageColumn colProductStructImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductStructNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductYield;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewImageColumn colproductEdit;
        private System.Windows.Forms.DataGridViewImageColumn colProductDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInchiKey;
        private System.Windows.Forms.CheckBox chkRxnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.SplitContainer splContRxnTree_RxnView;
        private System.Windows.Forms.TreeView tvReactions;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtEndPage;
        private System.Windows.Forms.Label lblEndPage;
        private System.Windows.Forms.TextBox txtStartPage;
        private System.Windows.Forms.Label lblStartPage;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.Label lblDOI;
        private System.Windows.Forms.CheckBox chkImpReaction;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label lblRefNo;

    }
}