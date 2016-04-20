namespace ChemInform.UserControls
{
    partial class ucSpectrlData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splCont_Main = new System.Windows.Forms.SplitContainer();
            this.gbCompound = new System.Windows.Forms.GroupBox();
            this.txtCompLabel = new System.Windows.Forms.TextBox();
            this.lblCompoundLabel = new System.Windows.Forms.Label();
            this.txtMolWeight = new System.Windows.Forms.TextBox();
            this.txtPageLabel = new System.Windows.Forms.TextBox();
            this.txtMolFormula = new System.Windows.Forms.TextBox();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.txtCompNo = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblCompoundNum = new System.Windows.Forms.Label();
            this.txtIUPAC = new System.Windows.Forms.TextBox();
            this.lblPageLable = new System.Windows.Forms.Label();
            this.lblMolWeight = new System.Windows.Forms.Label();
            this.lblIupacName = new System.Windows.Forms.Label();
            this.lblCmpComments = new System.Windows.Forms.Label();
            this.lblCmpSynonyms = new System.Windows.Forms.Label();
            this.lblMolFormula = new System.Windows.Forms.Label();
            this.pnlCompoundStruct = new System.Windows.Forms.Panel();
            this.ChemRenditor = new MDL.Draw.Renditor.Renditor();
            this.tcNmrMassIrUv = new System.Windows.Forms.TabControl();
            this.tpNmr = new System.Windows.Forms.TabPage();
            this.dgvNmrValues = new System.Windows.Forms.DataGridView();
            this.colNMRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrNucles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrSpectrometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrSolvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrShiftValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmrEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colNmrDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlNMR = new System.Windows.Forms.Panel();
            this.cmbNmrSpectroMeter = new System.Windows.Forms.ComboBox();
            this.cmbNmrNucleus = new System.Windows.Forms.ComboBox();
            this.lblNmrSpectoMeter = new System.Windows.Forms.Label();
            this.cmbNmrFreq = new System.Windows.Forms.ComboBox();
            this.lblNmrFreq = new System.Windows.Forms.Label();
            this.btnAddNMR = new System.Windows.Forms.Button();
            this.lblNmrStandard = new System.Windows.Forms.Label();
            this.cmbNmrSolvent = new System.Windows.Forms.ComboBox();
            this.lblNmrSolvent = new System.Windows.Forms.Label();
            this.lblNmrNucleus = new System.Windows.Forms.Label();
            this.txtNmrShiftValues = new System.Windows.Forms.TextBox();
            this.lblNmrShiftVal = new System.Windows.Forms.Label();
            this.txtNmrStandard = new System.Windows.Forms.TextBox();
            this.tpMassIrUv = new System.Windows.Forms.TabPage();
            this.dgvMassIrUv = new System.Windows.Forms.DataGridView();
            this.colOtherNMRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRValueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRSpectrometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMREv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRPeaks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMRSamplePrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNMREdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colOtherNMRDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlMass_IR = new System.Windows.Forms.Panel();
            this.cmbMassSpectrometer = new System.Windows.Forms.ComboBox();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.lblMassIrUvSpectrometer = new System.Windows.Forms.Label();
            this.txtMassIrUvComments = new System.Windows.Forms.TextBox();
            this.lblMassIrUvComments = new System.Windows.Forms.Label();
            this.txtMassIrUvPeaks = new System.Windows.Forms.TextBox();
            this.lblMassIrUvMethod = new System.Windows.Forms.Label();
            this.txtMassIrUvMethod = new System.Windows.Forms.TextBox();
            this.lblMassIrUvType = new System.Windows.Forms.Label();
            this.btnAddMass_IR = new System.Windows.Forms.Button();
            this.lblMassIrUvEv = new System.Windows.Forms.Label();
            this.cmbMassIrUvType = new System.Windows.Forms.ComboBox();
            this.lblMassIrUvPeaks = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.splCont_Main.Panel1.SuspendLayout();
            this.splCont_Main.Panel2.SuspendLayout();
            this.splCont_Main.SuspendLayout();
            this.gbCompound.SuspendLayout();
            this.pnlCompoundStruct.SuspendLayout();
            this.tcNmrMassIrUv.SuspendLayout();
            this.tpNmr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNmrValues)).BeginInit();
            this.pnlNMR.SuspendLayout();
            this.tpMassIrUv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMassIrUv)).BeginInit();
            this.pnlMass_IR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splCont_Main);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1083, 527);
            this.pnlMain.TabIndex = 0;
            // 
            // splCont_Main
            // 
            this.splCont_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCont_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont_Main.Location = new System.Drawing.Point(0, 0);
            this.splCont_Main.Name = "splCont_Main";
            this.splCont_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCont_Main.Panel1
            // 
            this.splCont_Main.Panel1.Controls.Add(this.gbCompound);
            // 
            // splCont_Main.Panel2
            // 
            this.splCont_Main.Panel2.Controls.Add(this.tcNmrMassIrUv);
            this.splCont_Main.Size = new System.Drawing.Size(1083, 527);
            this.splCont_Main.SplitterDistance = 276;
            this.splCont_Main.SplitterWidth = 5;
            this.splCont_Main.TabIndex = 2;
            // 
            // gbCompound
            // 
            this.gbCompound.Controls.Add(this.txtCompLabel);
            this.gbCompound.Controls.Add(this.lblCompoundLabel);
            this.gbCompound.Controls.Add(this.txtMolWeight);
            this.gbCompound.Controls.Add(this.txtPageLabel);
            this.gbCompound.Controls.Add(this.txtMolFormula);
            this.gbCompound.Controls.Add(this.txtSynonyms);
            this.gbCompound.Controls.Add(this.txtCompNo);
            this.gbCompound.Controls.Add(this.txtComments);
            this.gbCompound.Controls.Add(this.lblCompoundNum);
            this.gbCompound.Controls.Add(this.txtIUPAC);
            this.gbCompound.Controls.Add(this.lblPageLable);
            this.gbCompound.Controls.Add(this.lblMolWeight);
            this.gbCompound.Controls.Add(this.lblIupacName);
            this.gbCompound.Controls.Add(this.lblCmpComments);
            this.gbCompound.Controls.Add(this.lblCmpSynonyms);
            this.gbCompound.Controls.Add(this.lblMolFormula);
            this.gbCompound.Controls.Add(this.pnlCompoundStruct);
            this.gbCompound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompound.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompound.Location = new System.Drawing.Point(0, 0);
            this.gbCompound.Margin = new System.Windows.Forms.Padding(4);
            this.gbCompound.Name = "gbCompound";
            this.gbCompound.Padding = new System.Windows.Forms.Padding(4);
            this.gbCompound.Size = new System.Drawing.Size(1081, 274);
            this.gbCompound.TabIndex = 4;
            this.gbCompound.TabStop = false;
            this.gbCompound.Text = "Compound Info";
            // 
            // txtCompLabel
            // 
            this.txtCompLabel.Location = new System.Drawing.Point(550, 15);
            this.txtCompLabel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompLabel.Name = "txtCompLabel";
            this.txtCompLabel.Size = new System.Drawing.Size(102, 25);
            this.txtCompLabel.TabIndex = 1;
            // 
            // lblCompoundLabel
            // 
            this.lblCompoundLabel.AutoSize = true;
            this.lblCompoundLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundLabel.Location = new System.Drawing.Point(438, 19);
            this.lblCompoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompoundLabel.Name = "lblCompoundLabel";
            this.lblCompoundLabel.Size = new System.Drawing.Size(108, 17);
            this.lblCompoundLabel.TabIndex = 13;
            this.lblCompoundLabel.Text = "Compound Label";
            // 
            // txtMolWeight
            // 
            this.txtMolWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMolWeight.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtMolWeight.Location = new System.Drawing.Point(949, 44);
            this.txtMolWeight.Name = "txtMolWeight";
            this.txtMolWeight.ReadOnly = true;
            this.txtMolWeight.Size = new System.Drawing.Size(125, 25);
            this.txtMolWeight.TabIndex = 4;
            // 
            // txtPageLabel
            // 
            this.txtPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageLabel.Location = new System.Drawing.Point(950, 73);
            this.txtPageLabel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageLabel.Name = "txtPageLabel";
            this.txtPageLabel.Size = new System.Drawing.Size(124, 25);
            this.txtPageLabel.TabIndex = 6;
            // 
            // txtMolFormula
            // 
            this.txtMolFormula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMolFormula.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtMolFormula.Location = new System.Drawing.Point(550, 44);
            this.txtMolFormula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMolFormula.Name = "txtMolFormula";
            this.txtMolFormula.ReadOnly = true;
            this.txtMolFormula.Size = new System.Drawing.Size(304, 25);
            this.txtMolFormula.TabIndex = 3;
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSynonyms.Location = new System.Drawing.Point(550, 133);
            this.txtSynonyms.Margin = new System.Windows.Forms.Padding(4);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSynonyms.Size = new System.Drawing.Size(523, 133);
            this.txtSynonyms.TabIndex = 8;
            // 
            // txtCompNo
            // 
            this.txtCompNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCompNo.Location = new System.Drawing.Point(949, 15);
            this.txtCompNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompNo.Name = "txtCompNo";
            this.txtCompNo.Size = new System.Drawing.Size(125, 25);
            this.txtCompNo.TabIndex = 2;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.Location = new System.Drawing.Point(550, 103);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(524, 25);
            this.txtComments.TabIndex = 7;
            // 
            // lblCompoundNum
            // 
            this.lblCompoundNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompoundNum.AutoSize = true;
            this.lblCompoundNum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundNum.Location = new System.Drawing.Point(848, 20);
            this.lblCompoundNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompoundNum.Name = "lblCompoundNum";
            this.lblCompoundNum.Size = new System.Drawing.Size(97, 17);
            this.lblCompoundNum.TabIndex = 11;
            this.lblCompoundNum.Text = "Compound No.";
            // 
            // txtIUPAC
            // 
            this.txtIUPAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIUPAC.Location = new System.Drawing.Point(550, 73);
            this.txtIUPAC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIUPAC.MinimumSize = new System.Drawing.Size(139, 25);
            this.txtIUPAC.Name = "txtIUPAC";
            this.txtIUPAC.Size = new System.Drawing.Size(304, 25);
            this.txtIUPAC.TabIndex = 5;
            // 
            // lblPageLable
            // 
            this.lblPageLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageLable.AutoSize = true;
            this.lblPageLable.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageLable.Location = new System.Drawing.Point(871, 77);
            this.lblPageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageLable.Name = "lblPageLable";
            this.lblPageLable.Size = new System.Drawing.Size(75, 17);
            this.lblPageLable.TabIndex = 7;
            this.lblPageLable.Text = "Page Label";
            // 
            // lblMolWeight
            // 
            this.lblMolWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMolWeight.AutoSize = true;
            this.lblMolWeight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMolWeight.Location = new System.Drawing.Point(869, 49);
            this.lblMolWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMolWeight.Name = "lblMolWeight";
            this.lblMolWeight.Size = new System.Drawing.Size(76, 17);
            this.lblMolWeight.TabIndex = 6;
            this.lblMolWeight.Text = "Mol.Weight";
            // 
            // lblIupacName
            // 
            this.lblIupacName.AutoSize = true;
            this.lblIupacName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIupacName.Location = new System.Drawing.Point(453, 77);
            this.lblIupacName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIupacName.Name = "lblIupacName";
            this.lblIupacName.Size = new System.Drawing.Size(93, 17);
            this.lblIupacName.TabIndex = 5;
            this.lblIupacName.Text = "IUPAC Name";
            // 
            // lblCmpComments
            // 
            this.lblCmpComments.AutoSize = true;
            this.lblCmpComments.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpComments.Location = new System.Drawing.Point(475, 107);
            this.lblCmpComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmpComments.Name = "lblCmpComments";
            this.lblCmpComments.Size = new System.Drawing.Size(71, 17);
            this.lblCmpComments.TabIndex = 4;
            this.lblCmpComments.Text = "Comments";
            // 
            // lblCmpSynonyms
            // 
            this.lblCmpSynonyms.AutoSize = true;
            this.lblCmpSynonyms.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpSynonyms.Location = new System.Drawing.Point(478, 136);
            this.lblCmpSynonyms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmpSynonyms.Name = "lblCmpSynonyms";
            this.lblCmpSynonyms.Size = new System.Drawing.Size(68, 17);
            this.lblCmpSynonyms.TabIndex = 3;
            this.lblCmpSynonyms.Text = "Synonyms";
            // 
            // lblMolFormula
            // 
            this.lblMolFormula.AutoSize = true;
            this.lblMolFormula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMolFormula.Location = new System.Drawing.Point(463, 48);
            this.lblMolFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMolFormula.Name = "lblMolFormula";
            this.lblMolFormula.Size = new System.Drawing.Size(83, 17);
            this.lblMolFormula.TabIndex = 1;
            this.lblMolFormula.Text = "Mol.Formula";
            // 
            // pnlCompoundStruct
            // 
            this.pnlCompoundStruct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCompoundStruct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompoundStruct.Controls.Add(this.ChemRenditor);
            this.pnlCompoundStruct.Location = new System.Drawing.Point(8, 21);
            this.pnlCompoundStruct.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCompoundStruct.Name = "pnlCompoundStruct";
            this.pnlCompoundStruct.Size = new System.Drawing.Size(421, 245);
            this.pnlCompoundStruct.TabIndex = 0;
            // 
            // ChemRenditor
            // 
            this.ChemRenditor.AutoSizeStructure = true;
            this.ChemRenditor.BinHexSketch = "01030004412500224372656174656420627920416363656C7279734472617720342E312E3130302E3" +
    "73002040000005805000000005905000000000B0B0005417269616C780000140200";
            this.ChemRenditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChemRenditor.ChimeString = null;
            this.ChemRenditor.ClearingEnabled = true;
            this.ChemRenditor.CopyingEnabled = true;
            this.ChemRenditor.DisplayOnEmpty = "No Structure";
            this.ChemRenditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChemRenditor.EditingEnabled = true;
            this.ChemRenditor.FileName = null;
            this.ChemRenditor.HighlightInfo = "";
            this.ChemRenditor.IsBitmapFromOLE = false;
            this.ChemRenditor.Location = new System.Drawing.Point(0, 0);
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
            molecule1.Id = 53;
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
            molecule1.RefId = 53;
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
            molecule1.ZLayer = -99948;
            this.ChemRenditor.Molecule = molecule1;
            this.ChemRenditor.MolfileString = "";
            this.ChemRenditor.Name = "ChemRenditor";
            this.ChemRenditor.OldScalingMode = MDL.Draw.Renderer.Preferences.StructureScalingMode.ScaleToFitBox;
            this.ChemRenditor.PastingEnabled = true;
            this.ChemRenditor.Preferences = displayPreferences1;
            this.ChemRenditor.PreferencesFileName = "default.xml";
            this.ChemRenditor.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.ChemRenditor.RenditorMolecule = molecule1;
            this.ChemRenditor.RenditorName = "Renditor";
            this.ChemRenditor.Size = new System.Drawing.Size(419, 243);
            this.ChemRenditor.SketchString = "AQMABEElACJDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMTAwLjcwAgQAAABYBQAAAABZBQAAAAALC" +
    "wAFQXJpYWx4AAAUAgA=";
            this.ChemRenditor.SmilesString = "";
            this.ChemRenditor.TabIndex = 0;
            this.ChemRenditor.URLEncodedMolfileString = "";
            this.ChemRenditor.UseLocalXMLConfig = false;
            this.ChemRenditor.ComStructureChanged += new MDL.Draw.Renditor.StructureChangedEventHandler(this.ChemRenditor_ComStructureChanged);
            this.ChemRenditor.Click += new System.EventHandler(this.ChemRenditor_Click);
            // 
            // tcNmrMassIrUv
            // 
            this.tcNmrMassIrUv.Controls.Add(this.tpNmr);
            this.tcNmrMassIrUv.Controls.Add(this.tpMassIrUv);
            this.tcNmrMassIrUv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcNmrMassIrUv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcNmrMassIrUv.Location = new System.Drawing.Point(0, 0);
            this.tcNmrMassIrUv.Margin = new System.Windows.Forms.Padding(0);
            this.tcNmrMassIrUv.Name = "tcNmrMassIrUv";
            this.tcNmrMassIrUv.Padding = new System.Drawing.Point(0, 0);
            this.tcNmrMassIrUv.SelectedIndex = 0;
            this.tcNmrMassIrUv.Size = new System.Drawing.Size(1081, 244);
            this.tcNmrMassIrUv.TabIndex = 9;
            // 
            // tpNmr
            // 
            this.tpNmr.Controls.Add(this.dgvNmrValues);
            this.tpNmr.Controls.Add(this.pnlNMR);
            this.tpNmr.Location = new System.Drawing.Point(4, 26);
            this.tpNmr.Margin = new System.Windows.Forms.Padding(4);
            this.tpNmr.Name = "tpNmr";
            this.tpNmr.Padding = new System.Windows.Forms.Padding(4);
            this.tpNmr.Size = new System.Drawing.Size(1073, 214);
            this.tpNmr.TabIndex = 0;
            this.tpNmr.Text = "NMR";
            this.tpNmr.UseVisualStyleBackColor = true;
            // 
            // dgvNmrValues
            // 
            this.dgvNmrValues.AllowUserToAddRows = false;
            this.dgvNmrValues.AllowUserToDeleteRows = false;
            this.dgvNmrValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNmrValues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNmrValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNmrValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNMRID,
            this.colNmrNucles,
            this.colNmrSpectrometer,
            this.colNmrSolvent,
            this.colNmrFreq,
            this.colNmrStandard,
            this.colNmrShiftValues,
            this.colNmrEdit,
            this.colNmrDelete});
            this.dgvNmrValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNmrValues.Location = new System.Drawing.Point(4, 130);
            this.dgvNmrValues.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNmrValues.Name = "dgvNmrValues";
            this.dgvNmrValues.ReadOnly = true;
            this.dgvNmrValues.Size = new System.Drawing.Size(1065, 80);
            this.dgvNmrValues.TabIndex = 0;
            this.dgvNmrValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNmrValues_CellClick);
            this.dgvNmrValues.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvNmrValues_RowPostPaint);
            // 
            // colNMRID
            // 
            this.colNMRID.HeaderText = "NMRID";
            this.colNMRID.Name = "colNMRID";
            this.colNMRID.ReadOnly = true;
            this.colNMRID.Visible = false;
            // 
            // colNmrNucles
            // 
            this.colNmrNucles.FillWeight = 71.08449F;
            this.colNmrNucles.HeaderText = "Nucles";
            this.colNmrNucles.Name = "colNmrNucles";
            this.colNmrNucles.ReadOnly = true;
            // 
            // colNmrSpectrometer
            // 
            this.colNmrSpectrometer.FillWeight = 160.6337F;
            this.colNmrSpectrometer.HeaderText = "Spectrometer";
            this.colNmrSpectrometer.Name = "colNmrSpectrometer";
            this.colNmrSpectrometer.ReadOnly = true;
            // 
            // colNmrSolvent
            // 
            this.colNmrSolvent.FillWeight = 73.09644F;
            this.colNmrSolvent.HeaderText = "Solvent";
            this.colNmrSolvent.Name = "colNmrSolvent";
            this.colNmrSolvent.ReadOnly = true;
            // 
            // colNmrFreq
            // 
            this.colNmrFreq.FillWeight = 105.8552F;
            this.colNmrFreq.HeaderText = "Frequency";
            this.colNmrFreq.Name = "colNmrFreq";
            this.colNmrFreq.ReadOnly = true;
            // 
            // colNmrStandard
            // 
            this.colNmrStandard.FillWeight = 105.8552F;
            this.colNmrStandard.HeaderText = "Standard";
            this.colNmrStandard.Name = "colNmrStandard";
            this.colNmrStandard.ReadOnly = true;
            // 
            // colNmrShiftValues
            // 
            this.colNmrShiftValues.FillWeight = 165.0256F;
            this.colNmrShiftValues.HeaderText = "ShiftValues";
            this.colNmrShiftValues.Name = "colNmrShiftValues";
            this.colNmrShiftValues.ReadOnly = true;
            // 
            // colNmrEdit
            // 
            this.colNmrEdit.FillWeight = 61.07029F;
            this.colNmrEdit.HeaderText = "Edit";
            this.colNmrEdit.Name = "colNmrEdit";
            this.colNmrEdit.ReadOnly = true;
            this.colNmrEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNmrEdit.Text = "Edit";
            this.colNmrEdit.UseColumnTextForLinkValue = true;
            // 
            // colNmrDelete
            // 
            this.colNmrDelete.FillWeight = 57.37922F;
            this.colNmrDelete.HeaderText = "Delete";
            this.colNmrDelete.Name = "colNmrDelete";
            this.colNmrDelete.ReadOnly = true;
            this.colNmrDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNmrDelete.Text = "Delete";
            this.colNmrDelete.UseColumnTextForLinkValue = true;
            // 
            // pnlNMR
            // 
            this.pnlNMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNMR.Controls.Add(this.cmbNmrSpectroMeter);
            this.pnlNMR.Controls.Add(this.cmbNmrNucleus);
            this.pnlNMR.Controls.Add(this.lblNmrSpectoMeter);
            this.pnlNMR.Controls.Add(this.cmbNmrFreq);
            this.pnlNMR.Controls.Add(this.lblNmrFreq);
            this.pnlNMR.Controls.Add(this.btnAddNMR);
            this.pnlNMR.Controls.Add(this.lblNmrStandard);
            this.pnlNMR.Controls.Add(this.cmbNmrSolvent);
            this.pnlNMR.Controls.Add(this.lblNmrSolvent);
            this.pnlNMR.Controls.Add(this.lblNmrNucleus);
            this.pnlNMR.Controls.Add(this.txtNmrShiftValues);
            this.pnlNMR.Controls.Add(this.lblNmrShiftVal);
            this.pnlNMR.Controls.Add(this.txtNmrStandard);
            this.pnlNMR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNMR.Location = new System.Drawing.Point(4, 4);
            this.pnlNMR.Name = "pnlNMR";
            this.pnlNMR.Size = new System.Drawing.Size(1065, 126);
            this.pnlNMR.TabIndex = 19;
            // 
            // cmbNmrSpectroMeter
            // 
            this.cmbNmrSpectroMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNmrSpectroMeter.FormattingEnabled = true;
            this.cmbNmrSpectroMeter.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.cmbNmrSpectroMeter.Location = new System.Drawing.Point(94, 4);
            this.cmbNmrSpectroMeter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNmrSpectroMeter.Name = "cmbNmrSpectroMeter";
            this.cmbNmrSpectroMeter.Size = new System.Drawing.Size(209, 25);
            this.cmbNmrSpectroMeter.TabIndex = 10;
            // 
            // cmbNmrNucleus
            // 
            this.cmbNmrNucleus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNmrNucleus.FormattingEnabled = true;
            this.cmbNmrNucleus.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.cmbNmrNucleus.Location = new System.Drawing.Point(374, 34);
            this.cmbNmrNucleus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNmrNucleus.Name = "cmbNmrNucleus";
            this.cmbNmrNucleus.Size = new System.Drawing.Size(209, 25);
            this.cmbNmrNucleus.TabIndex = 13;
            // 
            // lblNmrSpectoMeter
            // 
            this.lblNmrSpectoMeter.AutoSize = true;
            this.lblNmrSpectoMeter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrSpectoMeter.Location = new System.Drawing.Point(4, 8);
            this.lblNmrSpectoMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrSpectoMeter.Name = "lblNmrSpectoMeter";
            this.lblNmrSpectoMeter.Size = new System.Drawing.Size(87, 17);
            this.lblNmrSpectoMeter.TabIndex = 1;
            this.lblNmrSpectoMeter.Text = "Spectrometer";
            // 
            // cmbNmrFreq
            // 
            this.cmbNmrFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNmrFreq.FormattingEnabled = true;
            this.cmbNmrFreq.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.cmbNmrFreq.Location = new System.Drawing.Point(94, 34);
            this.cmbNmrFreq.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNmrFreq.Name = "cmbNmrFreq";
            this.cmbNmrFreq.Size = new System.Drawing.Size(209, 25);
            this.cmbNmrFreq.TabIndex = 12;
            // 
            // lblNmrFreq
            // 
            this.lblNmrFreq.AutoSize = true;
            this.lblNmrFreq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrFreq.Location = new System.Drawing.Point(19, 38);
            this.lblNmrFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrFreq.Name = "lblNmrFreq";
            this.lblNmrFreq.Size = new System.Drawing.Size(70, 17);
            this.lblNmrFreq.TabIndex = 2;
            this.lblNmrFreq.Text = "Frequency";
            // 
            // btnAddNMR
            // 
            this.btnAddNMR.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNMR.Location = new System.Drawing.Point(512, 92);
            this.btnAddNMR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNMR.Name = "btnAddNMR";
            this.btnAddNMR.Size = new System.Drawing.Size(71, 29);
            this.btnAddNMR.TabIndex = 16;
            this.btnAddNMR.Text = "Add";
            this.btnAddNMR.UseVisualStyleBackColor = true;
            this.btnAddNMR.Click += new System.EventHandler(this.btnAddNMR_Click);
            // 
            // lblNmrStandard
            // 
            this.lblNmrStandard.AutoSize = true;
            this.lblNmrStandard.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrStandard.Location = new System.Drawing.Point(17, 68);
            this.lblNmrStandard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrStandard.Name = "lblNmrStandard";
            this.lblNmrStandard.Size = new System.Drawing.Size(74, 17);
            this.lblNmrStandard.TabIndex = 3;
            this.lblNmrStandard.Text = "Std.Solvent";
            // 
            // cmbNmrSolvent
            // 
            this.cmbNmrSolvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNmrSolvent.FormattingEnabled = true;
            this.cmbNmrSolvent.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.cmbNmrSolvent.Location = new System.Drawing.Point(374, 4);
            this.cmbNmrSolvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNmrSolvent.Name = "cmbNmrSolvent";
            this.cmbNmrSolvent.Size = new System.Drawing.Size(209, 25);
            this.cmbNmrSolvent.TabIndex = 11;
            // 
            // lblNmrSolvent
            // 
            this.lblNmrSolvent.AutoSize = true;
            this.lblNmrSolvent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrSolvent.Location = new System.Drawing.Point(315, 7);
            this.lblNmrSolvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrSolvent.Name = "lblNmrSolvent";
            this.lblNmrSolvent.Size = new System.Drawing.Size(51, 17);
            this.lblNmrSolvent.TabIndex = 4;
            this.lblNmrSolvent.Text = "Solvent";
            // 
            // lblNmrNucleus
            // 
            this.lblNmrNucleus.AutoSize = true;
            this.lblNmrNucleus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrNucleus.Location = new System.Drawing.Point(315, 38);
            this.lblNmrNucleus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrNucleus.Name = "lblNmrNucleus";
            this.lblNmrNucleus.Size = new System.Drawing.Size(56, 17);
            this.lblNmrNucleus.TabIndex = 5;
            this.lblNmrNucleus.Text = "Nucleus";
            // 
            // txtNmrShiftValues
            // 
            this.txtNmrShiftValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmrShiftValues.Location = new System.Drawing.Point(676, 4);
            this.txtNmrShiftValues.Margin = new System.Windows.Forms.Padding(4);
            this.txtNmrShiftValues.Multiline = true;
            this.txtNmrShiftValues.Name = "txtNmrShiftValues";
            this.txtNmrShiftValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNmrShiftValues.Size = new System.Drawing.Size(385, 117);
            this.txtNmrShiftValues.TabIndex = 15;
            // 
            // lblNmrShiftVal
            // 
            this.lblNmrShiftVal.AutoSize = true;
            this.lblNmrShiftVal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrShiftVal.Location = new System.Drawing.Point(595, 7);
            this.lblNmrShiftVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmrShiftVal.Name = "lblNmrShiftVal";
            this.lblNmrShiftVal.Size = new System.Drawing.Size(78, 17);
            this.lblNmrShiftVal.TabIndex = 6;
            this.lblNmrShiftVal.Text = "Shift Values";
            // 
            // txtNmrStandard
            // 
            this.txtNmrStandard.Location = new System.Drawing.Point(94, 64);
            this.txtNmrStandard.Margin = new System.Windows.Forms.Padding(4);
            this.txtNmrStandard.Name = "txtNmrStandard";
            this.txtNmrStandard.Size = new System.Drawing.Size(489, 25);
            this.txtNmrStandard.TabIndex = 14;
            // 
            // tpMassIrUv
            // 
            this.tpMassIrUv.Controls.Add(this.dgvMassIrUv);
            this.tpMassIrUv.Controls.Add(this.pnlMass_IR);
            this.tpMassIrUv.Location = new System.Drawing.Point(4, 26);
            this.tpMassIrUv.Margin = new System.Windows.Forms.Padding(4);
            this.tpMassIrUv.Name = "tpMassIrUv";
            this.tpMassIrUv.Padding = new System.Windows.Forms.Padding(4);
            this.tpMassIrUv.Size = new System.Drawing.Size(1073, 214);
            this.tpMassIrUv.TabIndex = 1;
            this.tpMassIrUv.Text = "Mass / Ir / Uv";
            this.tpMassIrUv.UseVisualStyleBackColor = true;
            // 
            // dgvMassIrUv
            // 
            this.dgvMassIrUv.AllowUserToAddRows = false;
            this.dgvMassIrUv.AllowUserToDeleteRows = false;
            this.dgvMassIrUv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMassIrUv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMassIrUv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMassIrUv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOtherNMRID,
            this.colOtherNMRValueType,
            this.colOtherNMRSpectrometer,
            this.colOtherNMRMethod,
            this.colOtherNMREv,
            this.colOtherNMRComments,
            this.colOtherNMRPeaks,
            this.colOtherNMRSamplePrep,
            this.colOtherNMREdit,
            this.colOtherNMRDelete});
            this.dgvMassIrUv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMassIrUv.Location = new System.Drawing.Point(4, 130);
            this.dgvMassIrUv.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMassIrUv.Name = "dgvMassIrUv";
            this.dgvMassIrUv.ReadOnly = true;
            this.dgvMassIrUv.Size = new System.Drawing.Size(1065, 80);
            this.dgvMassIrUv.TabIndex = 24;
            this.dgvMassIrUv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMassIrUv_CellClick);
            this.dgvMassIrUv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMassIrUv_RowPostPaint);
            // 
            // colOtherNMRID
            // 
            this.colOtherNMRID.HeaderText = "OtherNMRID";
            this.colOtherNMRID.Name = "colOtherNMRID";
            this.colOtherNMRID.ReadOnly = true;
            this.colOtherNMRID.Visible = false;
            // 
            // colOtherNMRValueType
            // 
            this.colOtherNMRValueType.HeaderText = "Type";
            this.colOtherNMRValueType.Name = "colOtherNMRValueType";
            this.colOtherNMRValueType.ReadOnly = true;
            // 
            // colOtherNMRSpectrometer
            // 
            this.colOtherNMRSpectrometer.FillWeight = 228.4264F;
            this.colOtherNMRSpectrometer.HeaderText = "Spectrometer";
            this.colOtherNMRSpectrometer.Name = "colOtherNMRSpectrometer";
            this.colOtherNMRSpectrometer.ReadOnly = true;
            // 
            // colOtherNMRMethod
            // 
            this.colOtherNMRMethod.FillWeight = 74.56937F;
            this.colOtherNMRMethod.HeaderText = "Method";
            this.colOtherNMRMethod.Name = "colOtherNMRMethod";
            this.colOtherNMRMethod.ReadOnly = true;
            // 
            // colOtherNMREv
            // 
            this.colOtherNMREv.FillWeight = 58.87971F;
            this.colOtherNMREv.HeaderText = "eV";
            this.colOtherNMREv.Name = "colOtherNMREv";
            this.colOtherNMREv.ReadOnly = true;
            // 
            // colOtherNMRComments
            // 
            this.colOtherNMRComments.FillWeight = 101.7132F;
            this.colOtherNMRComments.HeaderText = "Comments";
            this.colOtherNMRComments.Name = "colOtherNMRComments";
            this.colOtherNMRComments.ReadOnly = true;
            // 
            // colOtherNMRPeaks
            // 
            this.colOtherNMRPeaks.FillWeight = 101.7132F;
            this.colOtherNMRPeaks.HeaderText = "Peaks Value";
            this.colOtherNMRPeaks.Name = "colOtherNMRPeaks";
            this.colOtherNMRPeaks.ReadOnly = true;
            // 
            // colOtherNMRSamplePrep
            // 
            this.colOtherNMRSamplePrep.FillWeight = 101.7132F;
            this.colOtherNMRSamplePrep.HeaderText = "Sample Prep";
            this.colOtherNMRSamplePrep.Name = "colOtherNMRSamplePrep";
            this.colOtherNMRSamplePrep.ReadOnly = true;
            // 
            // colOtherNMREdit
            // 
            this.colOtherNMREdit.FillWeight = 67.06366F;
            this.colOtherNMREdit.HeaderText = "Edit";
            this.colOtherNMREdit.Name = "colOtherNMREdit";
            this.colOtherNMREdit.ReadOnly = true;
            this.colOtherNMREdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOtherNMREdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOtherNMREdit.Text = "Edit";
            this.colOtherNMREdit.UseColumnTextForLinkValue = true;
            // 
            // colOtherNMRDelete
            // 
            this.colOtherNMRDelete.FillWeight = 64.20793F;
            this.colOtherNMRDelete.HeaderText = "Delete";
            this.colOtherNMRDelete.Name = "colOtherNMRDelete";
            this.colOtherNMRDelete.ReadOnly = true;
            this.colOtherNMRDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOtherNMRDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOtherNMRDelete.Text = "Delete";
            this.colOtherNMRDelete.UseColumnTextForLinkValue = true;
            // 
            // pnlMass_IR
            // 
            this.pnlMass_IR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMass_IR.Controls.Add(this.cmbMassSpectrometer);
            this.pnlMass_IR.Controls.Add(this.txtEv);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvSpectrometer);
            this.pnlMass_IR.Controls.Add(this.txtMassIrUvComments);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvComments);
            this.pnlMass_IR.Controls.Add(this.txtMassIrUvPeaks);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvMethod);
            this.pnlMass_IR.Controls.Add(this.txtMassIrUvMethod);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvType);
            this.pnlMass_IR.Controls.Add(this.btnAddMass_IR);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvEv);
            this.pnlMass_IR.Controls.Add(this.cmbMassIrUvType);
            this.pnlMass_IR.Controls.Add(this.lblMassIrUvPeaks);
            this.pnlMass_IR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMass_IR.Location = new System.Drawing.Point(4, 4);
            this.pnlMass_IR.Name = "pnlMass_IR";
            this.pnlMass_IR.Size = new System.Drawing.Size(1065, 126);
            this.pnlMass_IR.TabIndex = 33;
            // 
            // cmbMassSpectrometer
            // 
            this.cmbMassSpectrometer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMassSpectrometer.FormattingEnabled = true;
            this.cmbMassSpectrometer.Items.AddRange(new object[] {
            "test",
            "test1"});
            this.cmbMassSpectrometer.Location = new System.Drawing.Point(94, 4);
            this.cmbMassSpectrometer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMassSpectrometer.Name = "cmbMassSpectrometer";
            this.cmbMassSpectrometer.Size = new System.Drawing.Size(209, 25);
            this.cmbMassSpectrometer.TabIndex = 17;
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(514, 4);
            this.txtEv.Margin = new System.Windows.Forms.Padding(4);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(123, 25);
            this.txtEv.TabIndex = 19;
            // 
            // lblMassIrUvSpectrometer
            // 
            this.lblMassIrUvSpectrometer.AutoSize = true;
            this.lblMassIrUvSpectrometer.Location = new System.Drawing.Point(4, 8);
            this.lblMassIrUvSpectrometer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvSpectrometer.Name = "lblMassIrUvSpectrometer";
            this.lblMassIrUvSpectrometer.Size = new System.Drawing.Size(87, 17);
            this.lblMassIrUvSpectrometer.TabIndex = 20;
            this.lblMassIrUvSpectrometer.Text = "Spectrometer";
            // 
            // txtMassIrUvComments
            // 
            this.txtMassIrUvComments.Location = new System.Drawing.Point(94, 34);
            this.txtMassIrUvComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtMassIrUvComments.Name = "txtMassIrUvComments";
            this.txtMassIrUvComments.Size = new System.Drawing.Size(543, 25);
            this.txtMassIrUvComments.TabIndex = 20;
            // 
            // lblMassIrUvComments
            // 
            this.lblMassIrUvComments.AutoSize = true;
            this.lblMassIrUvComments.Location = new System.Drawing.Point(19, 38);
            this.lblMassIrUvComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvComments.Name = "lblMassIrUvComments";
            this.lblMassIrUvComments.Size = new System.Drawing.Size(71, 17);
            this.lblMassIrUvComments.TabIndex = 21;
            this.lblMassIrUvComments.Text = "Comments";
            // 
            // txtMassIrUvPeaks
            // 
            this.txtMassIrUvPeaks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMassIrUvPeaks.Location = new System.Drawing.Point(688, 4);
            this.txtMassIrUvPeaks.Margin = new System.Windows.Forms.Padding(4);
            this.txtMassIrUvPeaks.Multiline = true;
            this.txtMassIrUvPeaks.Name = "txtMassIrUvPeaks";
            this.txtMassIrUvPeaks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMassIrUvPeaks.Size = new System.Drawing.Size(372, 117);
            this.txtMassIrUvPeaks.TabIndex = 22;
            // 
            // lblMassIrUvMethod
            // 
            this.lblMassIrUvMethod.AutoSize = true;
            this.lblMassIrUvMethod.Location = new System.Drawing.Point(38, 66);
            this.lblMassIrUvMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvMethod.Name = "lblMassIrUvMethod";
            this.lblMassIrUvMethod.Size = new System.Drawing.Size(53, 17);
            this.lblMassIrUvMethod.TabIndex = 22;
            this.lblMassIrUvMethod.Text = "Method";
            // 
            // txtMassIrUvMethod
            // 
            this.txtMassIrUvMethod.Location = new System.Drawing.Point(94, 63);
            this.txtMassIrUvMethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtMassIrUvMethod.Name = "txtMassIrUvMethod";
            this.txtMassIrUvMethod.Size = new System.Drawing.Size(543, 25);
            this.txtMassIrUvMethod.TabIndex = 21;
            // 
            // lblMassIrUvType
            // 
            this.lblMassIrUvType.AutoSize = true;
            this.lblMassIrUvType.Location = new System.Drawing.Point(325, 7);
            this.lblMassIrUvType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvType.Name = "lblMassIrUvType";
            this.lblMassIrUvType.Size = new System.Drawing.Size(37, 17);
            this.lblMassIrUvType.TabIndex = 23;
            this.lblMassIrUvType.Text = "Type";
            // 
            // btnAddMass_IR
            // 
            this.btnAddMass_IR.Location = new System.Drawing.Point(566, 92);
            this.btnAddMass_IR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMass_IR.Name = "btnAddMass_IR";
            this.btnAddMass_IR.Size = new System.Drawing.Size(71, 29);
            this.btnAddMass_IR.TabIndex = 23;
            this.btnAddMass_IR.Text = "Add";
            this.btnAddMass_IR.UseVisualStyleBackColor = true;
            this.btnAddMass_IR.Click += new System.EventHandler(this.btnAddMassIRUV_Click);
            // 
            // lblMassIrUvEv
            // 
            this.lblMassIrUvEv.AutoSize = true;
            this.lblMassIrUvEv.Location = new System.Drawing.Point(485, 8);
            this.lblMassIrUvEv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvEv.Name = "lblMassIrUvEv";
            this.lblMassIrUvEv.Size = new System.Drawing.Size(26, 17);
            this.lblMassIrUvEv.TabIndex = 24;
            this.lblMassIrUvEv.Text = "eV";
            // 
            // cmbMassIrUvType
            // 
            this.cmbMassIrUvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMassIrUvType.FormattingEnabled = true;
            this.cmbMassIrUvType.Items.AddRange(new object[] {
            "Mass",
            "IR",
            "UV"});
            this.cmbMassIrUvType.Location = new System.Drawing.Point(365, 4);
            this.cmbMassIrUvType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMassIrUvType.Name = "cmbMassIrUvType";
            this.cmbMassIrUvType.Size = new System.Drawing.Size(113, 25);
            this.cmbMassIrUvType.TabIndex = 18;
            // 
            // lblMassIrUvPeaks
            // 
            this.lblMassIrUvPeaks.AutoSize = true;
            this.lblMassIrUvPeaks.Location = new System.Drawing.Point(643, 7);
            this.lblMassIrUvPeaks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMassIrUvPeaks.Name = "lblMassIrUvPeaks";
            this.lblMassIrUvPeaks.Size = new System.Drawing.Size(44, 17);
            this.lblMassIrUvPeaks.TabIndex = 25;
            this.lblMassIrUvPeaks.Text = "Peaks";
            // 
            // ucSpectrlData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSpectrlData";
            this.Size = new System.Drawing.Size(1083, 527);
            this.Load += new System.EventHandler(this.UcSpectrlDataCuration_Load);
            this.pnlMain.ResumeLayout(false);
            this.splCont_Main.Panel1.ResumeLayout(false);
            this.splCont_Main.Panel2.ResumeLayout(false);
            this.splCont_Main.ResumeLayout(false);
            this.gbCompound.ResumeLayout(false);
            this.gbCompound.PerformLayout();
            this.pnlCompoundStruct.ResumeLayout(false);
            this.tcNmrMassIrUv.ResumeLayout(false);
            this.tpNmr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNmrValues)).EndInit();
            this.pnlNMR.ResumeLayout(false);
            this.pnlNMR.PerformLayout();
            this.tpMassIrUv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMassIrUv)).EndInit();
            this.pnlMass_IR.ResumeLayout(false);
            this.pnlMass_IR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splCont_Main;
        private System.Windows.Forms.TabControl tcNmrMassIrUv;
        private System.Windows.Forms.TabPage tpNmr;
        private System.Windows.Forms.ComboBox cmbNmrNucleus;
        private System.Windows.Forms.ComboBox cmbNmrFreq;
        private System.Windows.Forms.Button btnAddNMR;
        private System.Windows.Forms.ComboBox cmbNmrSolvent;
        private System.Windows.Forms.ComboBox cmbNmrSpectroMeter;
        private System.Windows.Forms.TextBox txtNmrShiftValues;
        private System.Windows.Forms.TextBox txtNmrStandard;
        private System.Windows.Forms.Label lblNmrShiftVal;
        private System.Windows.Forms.Label lblNmrNucleus;
        private System.Windows.Forms.Label lblNmrSolvent;
        private System.Windows.Forms.Label lblNmrStandard;
        private System.Windows.Forms.Label lblNmrFreq;
        private System.Windows.Forms.Label lblNmrSpectoMeter;
        private System.Windows.Forms.DataGridView dgvNmrValues;
        private System.Windows.Forms.TabPage tpMassIrUv;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.TextBox txtMassIrUvComments;
        private System.Windows.Forms.TextBox txtMassIrUvPeaks;
        private System.Windows.Forms.TextBox txtMassIrUvMethod;
        private System.Windows.Forms.Button btnAddMass_IR;
        private System.Windows.Forms.ComboBox cmbMassIrUvType;
        private System.Windows.Forms.ComboBox cmbMassSpectrometer;
        private System.Windows.Forms.Label lblMassIrUvPeaks;
        private System.Windows.Forms.Label lblMassIrUvEv;
        private System.Windows.Forms.Label lblMassIrUvType;
        private System.Windows.Forms.Label lblMassIrUvMethod;
        private System.Windows.Forms.Label lblMassIrUvComments;
        private System.Windows.Forms.Label lblMassIrUvSpectrometer;
        private System.Windows.Forms.DataGridView dgvMassIrUv;
        private System.Windows.Forms.GroupBox gbCompound;
        private System.Windows.Forms.TextBox txtMolWeight;
        private System.Windows.Forms.TextBox txtPageLabel;
        private System.Windows.Forms.TextBox txtMolFormula;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblCompoundNum;
        private System.Windows.Forms.TextBox txtIUPAC;
        private System.Windows.Forms.Label lblPageLable;
        private System.Windows.Forms.Label lblMolWeight;
        private System.Windows.Forms.Label lblIupacName;
        private System.Windows.Forms.Label lblCmpComments;
        private System.Windows.Forms.Label lblCmpSynonyms;
        private System.Windows.Forms.Label lblMolFormula;
        private System.Windows.Forms.Panel pnlCompoundStruct;
        private System.Windows.Forms.TextBox txtCompLabel;
        private System.Windows.Forms.Label lblCompoundLabel;
        private MDL.Draw.Renditor.Renditor ChemRenditor;
        private System.Windows.Forms.Panel pnlNMR;
        private System.Windows.Forms.Panel pnlMass_IR;
        public System.Windows.Forms.TextBox txtCompNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNMRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrNucles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrSpectrometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrSolvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmrShiftValues;
        private System.Windows.Forms.DataGridViewLinkColumn colNmrEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colNmrDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRValueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRSpectrometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMREv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRPeaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNMRSamplePrep;
        private System.Windows.Forms.DataGridViewLinkColumn colOtherNMREdit;
        private System.Windows.Forms.DataGridViewLinkColumn colOtherNMRDelete;
    }
}
