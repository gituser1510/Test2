namespace ChemInform
{
    partial class frmSolAgentReference
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSolAgentRef = new System.Windows.Forms.DataGridView();
            this.colSolAgeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMolFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIupacName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInchiString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInchiKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSrchByStruct = new System.Windows.Forms.CheckBox();
            this.lblStructure = new System.Windows.Forms.Label();
            this.pnlStructure = new System.Windows.Forms.Panel();
            this.renderer1 = new MDL.Draw.Renderer.Renderer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIUPACName = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolAgentRef)).BeginInit();
            this.pnlStructure.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1089, 422);
            this.pnlMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 422);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 422);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSolAgentRef);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkSrchByStruct);
            this.splitContainer1.Panel2.Controls.Add(this.lblStructure);
            this.splitContainer1.Panel2.Controls.Add(this.pnlStructure);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 422);
            this.splitContainer1.SplitterDistance = 746;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvSolAgentRef
            // 
            this.dgvSolAgentRef.AllowUserToAddRows = false;
            this.dgvSolAgentRef.AllowUserToDeleteRows = false;
            this.dgvSolAgentRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolAgentRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSolAgentRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolAgentRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSolAgeId,
            this.colMolFile,
            this.colIupacName,
            this.colInchiString,
            this.colInchiKey,
            this.colOtherNames});
            this.dgvSolAgentRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolAgentRef.Location = new System.Drawing.Point(0, 0);
            this.dgvSolAgentRef.MultiSelect = false;
            this.dgvSolAgentRef.Name = "dgvSolAgentRef";
            this.dgvSolAgentRef.ReadOnly = true;
            this.dgvSolAgentRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolAgentRef.Size = new System.Drawing.Size(746, 422);
            this.dgvSolAgentRef.TabIndex = 0;
            this.dgvSolAgentRef.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolAgentRef_CellDoubleClick);
            this.dgvSolAgentRef.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolAgentRef_RowEnter);
            this.dgvSolAgentRef.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSolAgentRef_RowPostPaint);
            // 
            // colSolAgeId
            // 
            this.colSolAgeId.HeaderText = "SolAgeId";
            this.colSolAgeId.Name = "colSolAgeId";
            this.colSolAgeId.ReadOnly = true;
            this.colSolAgeId.Visible = false;
            // 
            // colMolFile
            // 
            this.colMolFile.HeaderText = "Mol File";
            this.colMolFile.Name = "colMolFile";
            this.colMolFile.ReadOnly = true;
            this.colMolFile.Visible = false;
            // 
            // colIupacName
            // 
            this.colIupacName.HeaderText = "IUPAC Name";
            this.colIupacName.Name = "colIupacName";
            this.colIupacName.ReadOnly = true;
            // 
            // colInchiString
            // 
            this.colInchiString.HeaderText = "Inchi String";
            this.colInchiString.Name = "colInchiString";
            this.colInchiString.ReadOnly = true;
            this.colInchiString.Visible = false;
            // 
            // colInchiKey
            // 
            this.colInchiKey.HeaderText = "Inchi Key";
            this.colInchiKey.Name = "colInchiKey";
            this.colInchiKey.ReadOnly = true;
            this.colInchiKey.Visible = false;
            // 
            // colOtherNames
            // 
            this.colOtherNames.HeaderText = "Other Names";
            this.colOtherNames.Name = "colOtherNames";
            this.colOtherNames.ReadOnly = true;
            // 
            // chkSrchByStruct
            // 
            this.chkSrchByStruct.AutoSize = true;
            this.chkSrchByStruct.Location = new System.Drawing.Point(151, 9);
            this.chkSrchByStruct.Name = "chkSrchByStruct";
            this.chkSrchByStruct.Size = new System.Drawing.Size(147, 21);
            this.chkSrchByStruct.TabIndex = 10;
            this.chkSrchByStruct.Text = "Search By Structure";
            this.chkSrchByStruct.UseVisualStyleBackColor = true;
            this.chkSrchByStruct.CheckStateChanged += new System.EventHandler(this.chkSrchByStruct_CheckStateChanged);
            // 
            // lblStructure
            // 
            this.lblStructure.AutoSize = true;
            this.lblStructure.Location = new System.Drawing.Point(10, 9);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(62, 17);
            this.lblStructure.TabIndex = 9;
            this.lblStructure.Text = "Structure";
            // 
            // pnlStructure
            // 
            this.pnlStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStructure.Controls.Add(this.renderer1);
            this.pnlStructure.Location = new System.Drawing.Point(2, 34);
            this.pnlStructure.Name = "pnlStructure";
            this.pnlStructure.Size = new System.Drawing.Size(331, 385);
            this.pnlStructure.TabIndex = 8;
            // 
            // renderer1
            // 
            this.renderer1.AutoSizeStructure = true;
            this.renderer1.BinHexSketch = "010300044122001F4372656174656420627920416363656C7279734472617720342E312E312E34020" +
    "40000005805000000005905000000000B0B0005417269616C780000140200";
            this.renderer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderer1.ChimeString = null;
            this.renderer1.CopyingEnabled = true;
            this.renderer1.DisplayOnEmpty = null;
            this.renderer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderer1.FileName = null;
            this.renderer1.HighlightInfo = "";
            this.renderer1.IsBitmapFromOLE = false;
            this.renderer1.Location = new System.Drawing.Point(0, 0);
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
            molecule1.Id = 105;
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
            molecule1.RefId = 105;
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
            molecule1.ZLayer = -99896;
            this.renderer1.Molecule = molecule1;
            this.renderer1.MolfileString = "";
            this.renderer1.Name = "renderer1";
            this.renderer1.PastingEnabled = true;
            this.renderer1.Preferences = displayPreferences1;
            this.renderer1.PreferencesFileName = "default.xml";
            this.renderer1.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.renderer1.Size = new System.Drawing.Size(331, 385);
            this.renderer1.SketchString = "AQMABEEiAB9DcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMS40AgQAAABYBQAAAABZBQAAAAALCwAFQ" +
    "XJpYWx4AAAUAgA=";
            this.renderer1.SmilesString = "";
            this.renderer1.TabIndex = 9;
            this.renderer1.URLEncodedMolfileString = "";
            this.renderer1.StructureChanged += new System.EventHandler(this.renderer1_StructureChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.cmbSearchBy);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtIUPACName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1089, 34);
            this.pnlTop.TabIndex = 2;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "IUPAC Name",
            "Other Name"});
            this.cmbSearchBy.Location = new System.Drawing.Point(79, 3);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(167, 25);
            this.cmbSearchBy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By";
            // 
            // txtIUPACName
            // 
            this.txtIUPACName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIUPACName.Location = new System.Drawing.Point(252, 3);
            this.txtIUPACName.Name = "txtIUPACName";
            this.txtIUPACName.Size = new System.Drawing.Size(830, 25);
            this.txtIUPACName.TabIndex = 0;
            this.txtIUPACName.TextChanged += new System.EventHandler(this.txtIUPACName_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Section No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Section Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "IUPAC Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 178;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Inchi String";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 178;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Inchi Key";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 178;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Other Names";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 178;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // frmSolAgentReference
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1089, 456);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.MinimizeBox = false;
            this.Name = "frmSolAgentReference";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solvent & Agent Reference";
            this.Load += new System.EventHandler(this.frmSolAgentReference_Load);
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolAgentRef)).EndInit();
            this.pnlStructure.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvSolAgentRef;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStructure;
        private System.Windows.Forms.Panel pnlStructure;
        private System.Windows.Forms.Panel panel2;
        private MDL.Draw.Renderer.Renderer renderer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtIUPACName;
        private System.Windows.Forms.CheckBox chkSrchByStruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolAgeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMolFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIupacName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInchiString;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInchiKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherNames;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label1;
    }
}