namespace ChemInform
{
    partial class FrmEditParticipants
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
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            MDL.Draw.Chemistry.Molecule molecule2 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences2 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCntrls = new System.Windows.Forms.Panel();
            this.splCont = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colRxnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdStructNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdMolFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdInchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdMolImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.renderer1 = new MDL.Draw.Renderer.Renderer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lnkSolvAgentRef = new System.Windows.Forms.LinkLabel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtStructNo = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStructNo = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.ChemRenditor = new MDL.Draw.Renditor.Renditor();
            this.lblStructure = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStructureInchi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlMain.SuspendLayout();
            this.pnlCntrls.SuspendLayout();
            this.splCont.Panel1.SuspendLayout();
            this.splCont.Panel2.SuspendLayout();
            this.splCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlCntrls);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1006, 362);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlCntrls
            // 
            this.pnlCntrls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCntrls.Controls.Add(this.splCont);
            this.pnlCntrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCntrls.Location = new System.Drawing.Point(0, 0);
            this.pnlCntrls.Name = "pnlCntrls";
            this.pnlCntrls.Size = new System.Drawing.Size(1006, 331);
            this.pnlCntrls.TabIndex = 19;
            // 
            // splCont
            // 
            this.splCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont.Location = new System.Drawing.Point(0, 0);
            this.splCont.Name = "splCont";
            // 
            // splCont.Panel1
            // 
            this.splCont.Panel1.Controls.Add(this.dgvProducts);
            this.splCont.Panel1.Controls.Add(this.renderer1);
            this.splCont.Panel1.Controls.Add(this.pnlTop);
            // 
            // splCont.Panel2
            // 
            this.splCont.Panel2.Controls.Add(this.ChemRenditor);
            this.splCont.Panel2.Controls.Add(this.lblStructure);
            this.splCont.Size = new System.Drawing.Size(1002, 327);
            this.splCont.SplitterDistance = 578;
            this.splCont.TabIndex = 31;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRxnNo,
            this.colProdStructNo,
            this.colProductName,
            this.colProdMolFile,
            this.colProdInchi,
            this.colProdMolImage});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 110);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(354, 215);
            this.dgvProducts.TabIndex = 29;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
            this.dgvProducts.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProducts_RowPostPaint);
            // 
            // colRxnNo
            // 
            this.colRxnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnNo.HeaderText = "RxnNo";
            this.colRxnNo.Name = "colRxnNo";
            this.colRxnNo.ReadOnly = true;
            this.colRxnNo.Width = 60;
            // 
            // colProdStructNo
            // 
            this.colProdStructNo.HeaderText = "StructNo";
            this.colProdStructNo.Name = "colProdStructNo";
            this.colProdStructNo.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.HeaderText = "Product";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colProdMolFile
            // 
            this.colProdMolFile.HeaderText = "MolFile";
            this.colProdMolFile.Name = "colProdMolFile";
            this.colProdMolFile.ReadOnly = true;
            this.colProdMolFile.Visible = false;
            // 
            // colProdInchi
            // 
            this.colProdInchi.HeaderText = "Inchi";
            this.colProdInchi.Name = "colProdInchi";
            this.colProdInchi.ReadOnly = true;
            this.colProdInchi.Visible = false;
            // 
            // colProdMolImage
            // 
            this.colProdMolImage.HeaderText = "MolImage";
            this.colProdMolImage.Name = "colProdMolImage";
            this.colProdMolImage.ReadOnly = true;
            this.colProdMolImage.Visible = false;
            // 
            // renderer1
            // 
            this.renderer1.AutoSizeStructure = true;
            this.renderer1.BinHexSketch = "01030004412400214372656174656420627920416363656C7279734472617720342E322E302E36303" +
    "502040000005805000000005905000000000B0B0005417269616C780000140200";
            this.renderer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderer1.ChimeString = null;
            this.renderer1.CopyingEnabled = true;
            this.renderer1.DisplayOnEmpty = null;
            this.renderer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.renderer1.FileName = null;
            this.renderer1.HighlightInfo = "";
            this.renderer1.IsBitmapFromOLE = false;
            this.renderer1.Location = new System.Drawing.Point(354, 110);
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
            molecule1.Id = 81;
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
            molecule1.RefId = 81;
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
            molecule1.ZLayer = -99920;
            this.renderer1.Molecule = molecule1;
            this.renderer1.MolfileString = "";
            this.renderer1.Name = "renderer1";
            this.renderer1.PastingEnabled = true;
            displayPreferences1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.renderer1.Preferences = displayPreferences1;
            this.renderer1.PreferencesFileName = "default.xml";
            this.renderer1.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.renderer1.Size = new System.Drawing.Size(222, 215);
            this.renderer1.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.renderer1.SmilesString = "";
            this.renderer1.TabIndex = 30;
            this.renderer1.URLEncodedMolfileString = "";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtName);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Controls.Add(this.lblType);
            this.pnlTop.Controls.Add(this.lnkSolvAgentRef);
            this.pnlTop.Controls.Add(this.cmbType);
            this.pnlTop.Controls.Add(this.txtStructNo);
            this.pnlTop.Controls.Add(this.lblGrade);
            this.pnlTop.Controls.Add(this.lblStructNo);
            this.pnlTop.Controls.Add(this.txtGrade);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(576, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(431, 25);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Other Reaction - Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(37, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lnkSolvAgentRef
            // 
            this.lnkSolvAgentRef.AutoSize = true;
            this.lnkSolvAgentRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSolvAgentRef.Enabled = false;
            this.lnkSolvAgentRef.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSolvAgentRef.Location = new System.Drawing.Point(300, 64);
            this.lnkSolvAgentRef.Name = "lnkSolvAgentRef";
            this.lnkSolvAgentRef.Size = new System.Drawing.Size(209, 17);
            this.lnkSolvAgentRef.TabIndex = 28;
            this.lnkSolvAgentRef.TabStop = true;
            this.lnkSolvAgentRef.Text = "Solvent/Agent/Catalyst Reference";
            this.lnkSolvAgentRef.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSolvAgentRef_LinkClicked);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Reactant",
            "Agent",
            "Solvent",
            "Catalyst"});
            this.cmbType.Location = new System.Drawing.Point(80, 59);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(194, 25);
            this.cmbType.TabIndex = 4;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.SelectionChangeCommitted += new System.EventHandler(this.cmbType_SelectionChangeCommitted);
            // 
            // txtStructNo
            // 
            this.txtStructNo.Location = new System.Drawing.Point(80, 31);
            this.txtStructNo.Name = "txtStructNo";
            this.txtStructNo.Size = new System.Drawing.Size(194, 25);
            this.txtStructNo.TabIndex = 2;
            this.txtStructNo.TextChanged += new System.EventHandler(this.txtStructNo_TextChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(309, 35);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(44, 17);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Grade";
            // 
            // lblStructNo
            // 
            this.lblStructNo.AutoSize = true;
            this.lblStructNo.Location = new System.Drawing.Point(5, 35);
            this.lblStructNo.Name = "lblStructNo";
            this.lblStructNo.Size = new System.Drawing.Size(69, 17);
            this.lblStructNo.TabIndex = 3;
            this.lblStructNo.Text = "Struct No.";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(356, 31);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(155, 25);
            this.txtGrade.TabIndex = 3;
            // 
            // ChemRenditor
            // 
            this.ChemRenditor.AutoSizeStructure = true;
            this.ChemRenditor.BinHexSketch = "01030004412400214372656174656420627920416363656C7279734472617720342E322E302E36303" +
    "502040000005805000000005905000000000B0B0005417269616C780000140200";
            this.ChemRenditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChemRenditor.ChimeString = null;
            this.ChemRenditor.ClearingEnabled = true;
            this.ChemRenditor.CopyingEnabled = true;
            this.ChemRenditor.DisplayOnEmpty = null;
            this.ChemRenditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChemRenditor.EditingEnabled = true;
            this.ChemRenditor.FileName = null;
            this.ChemRenditor.HighlightInfo = "";
            this.ChemRenditor.IsBitmapFromOLE = false;
            this.ChemRenditor.Location = new System.Drawing.Point(0, 20);
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
            molecule2.Id = 105;
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
            molecule2.RefId = 105;
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
            molecule2.ZLayer = -99896;
            this.ChemRenditor.Molecule = molecule2;
            this.ChemRenditor.MolfileString = "";
            this.ChemRenditor.Name = "ChemRenditor";
            this.ChemRenditor.OldScalingMode = MDL.Draw.Renderer.Preferences.StructureScalingMode.ScaleToFitBox;
            this.ChemRenditor.PastingEnabled = true;
            this.ChemRenditor.Preferences = displayPreferences2;
            this.ChemRenditor.PreferencesFileName = "default.xml";
            this.ChemRenditor.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.ChemRenditor.RenditorMolecule = molecule2;
            this.ChemRenditor.RenditorName = "Renditor";
            this.ChemRenditor.Size = new System.Drawing.Size(418, 305);
            this.ChemRenditor.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.ChemRenditor.SmilesString = "";
            this.ChemRenditor.TabIndex = 2;
            this.ChemRenditor.URLEncodedMolfileString = "";
            this.ChemRenditor.UseLocalXMLConfig = false;
            this.ChemRenditor.ComStructureChanged += new MDL.Draw.Renditor.StructureChangedEventHandler(this.ChemRenditor_ComStructureChanged);
            // 
            // lblStructure
            // 
            this.lblStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStructure.Location = new System.Drawing.Point(0, 0);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(418, 20);
            this.lblStructure.TabIndex = 7;
            this.lblStructure.Text = "Structure";
            this.lblStructure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblStructureInchi);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 331);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1006, 31);
            this.pnlBottom.TabIndex = 18;
            // 
            // lblStructureInchi
            // 
            this.lblStructureInchi.AutoSize = true;
            this.lblStructureInchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStructureInchi.Location = new System.Drawing.Point(112, 6);
            this.lblStructureInchi.Name = "lblStructureInchi";
            this.lblStructureInchi.Size = new System.Drawing.Size(18, 17);
            this.lblStructureInchi.TabIndex = 10;
            this.lblStructureInchi.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Structure Inchi: ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::ChemInform.Properties.Resources.save_1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(926, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "RxnNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "StructNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Product";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "MolFile";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Inchi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "MolImage";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // FrmEditParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 362);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditParticipants";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Participants";
            this.Load += new System.EventHandler(this.FrmParticipants_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlCntrls.ResumeLayout(false);
            this.splCont.Panel1.ResumeLayout(false);
            this.splCont.Panel2.ResumeLayout(false);
            this.splCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtStructNo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStructNo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.Label lblStructure;
        private MDL.Draw.Renditor.Renditor ChemRenditor;
        private System.Windows.Forms.LinkLabel lnkSolvAgentRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblStructureInchi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SplitContainer splCont;
        private System.Windows.Forms.Panel pnlTop;
        private MDL.Draw.Renderer.Renderer renderer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdStructNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdMolFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdInchi;
        private System.Windows.Forms.DataGridViewImageColumn colProdMolImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}