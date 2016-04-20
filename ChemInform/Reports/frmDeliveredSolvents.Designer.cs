namespace ChemInform.Reports
{
    partial class frmDeliveredSolvents
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
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splcontSolvents = new System.Windows.Forms.SplitContainer();
            this.dgvDeliverySolvents = new System.Windows.Forms.DataGridView();
            this.solventRenderer = new MDL.Draw.Renderer.Renderer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentRef_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventName_Solv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolventMolFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.splcontSolvents.Panel1.SuspendLayout();
            this.splcontSolvents.Panel2.SuspendLayout();
            this.splcontSolvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySolvents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splcontSolvents);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1123, 470);
            this.pnlMain.TabIndex = 0;
            // 
            // splcontSolvents
            // 
            this.splcontSolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcontSolvents.Location = new System.Drawing.Point(0, 0);
            this.splcontSolvents.Name = "splcontSolvents";
            // 
            // splcontSolvents.Panel1
            // 
            this.splcontSolvents.Panel1.Controls.Add(this.dgvDeliverySolvents);
            // 
            // splcontSolvents.Panel2
            // 
            this.splcontSolvents.Panel2.Controls.Add(this.solventRenderer);
            this.splcontSolvents.Size = new System.Drawing.Size(1123, 470);
            this.splcontSolvents.SplitterDistance = 808;
            this.splcontSolvents.TabIndex = 2;
            // 
            // dgvDeliverySolvents
            // 
            this.dgvDeliverySolvents.AllowUserToAddRows = false;
            this.dgvDeliverySolvents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvDeliverySolvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliverySolvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeliverySolvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverySolvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeliveryName,
            this.colShipmentRef_Solv,
            this.colSolventName_Solv,
            this.colSolventMolFile});
            this.dgvDeliverySolvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliverySolvents.Location = new System.Drawing.Point(0, 0);
            this.dgvDeliverySolvents.Name = "dgvDeliverySolvents";
            this.dgvDeliverySolvents.ReadOnly = true;
            this.dgvDeliverySolvents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDeliverySolvents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDeliverySolvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliverySolvents.Size = new System.Drawing.Size(808, 470);
            this.dgvDeliverySolvents.TabIndex = 16;
            this.dgvDeliverySolvents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliverySolvents_RowEnter);
            this.dgvDeliverySolvents.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeliverySolvents_RowPostPaint);
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
            //molecule1.DisableAgeUp = false;
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
            molecule1.Id = 131;
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
            molecule1.RefId = 131;
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
            //molecule1.Tag = null;
            molecule1.TextBorder = 0.1D;
            molecule1.Transparent = false;
            molecule1.UndoableEditListener = null;
            molecule1.WedgeWidth = 0.1D;
            molecule1.ZLayer = -99870;
            this.solventRenderer.Molecule = molecule1;
            this.solventRenderer.MolfileString = "";
            this.solventRenderer.Name = "solventRenderer";
            this.solventRenderer.PastingEnabled = true;
            this.solventRenderer.Preferences = displayPreferences1;
            this.solventRenderer.PreferencesFileName = "default.xml";
            this.solventRenderer.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.solventRenderer.Size = new System.Drawing.Size(311, 470);
            this.solventRenderer.SketchString = "AQMABEEkACFDcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjIuMC42MDUCBAAAAFgFAAAAAFkFAAAAAAsLA" +
    "AVBcmlhbHgAABQCAA==";
            this.solventRenderer.SmilesString = "";
            this.solventRenderer.TabIndex = 33;
            this.solventRenderer.URLEncodedMolfileString = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 121;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Solvent Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "SolventMolfile";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "SolventMolfile";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // colDeliveryName
            // 
            this.colDeliveryName.HeaderText = "DeliveryName";
            this.colDeliveryName.Name = "colDeliveryName";
            this.colDeliveryName.ReadOnly = true;
            this.colDeliveryName.Width = 200;
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
            // frmDeliveredSolvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 470);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmDeliveredSolvents";
            this.ShowIcon = false;
            this.Text = "Delivered Solvents";
            this.Load += new System.EventHandler(this.frmDeliveredSolvents_Load);
            this.pnlMain.ResumeLayout(false);
            this.splcontSolvents.Panel1.ResumeLayout(false);
            this.splcontSolvents.Panel2.ResumeLayout(false);
            this.splcontSolvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySolvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splcontSolvents;
        private System.Windows.Forms.DataGridView dgvDeliverySolvents;
        private MDL.Draw.Renderer.Renderer solventRenderer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRef_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventName_Solv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolventMolFile;
    }
}