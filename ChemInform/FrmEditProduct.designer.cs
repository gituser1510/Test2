namespace ChemInform
{
    partial class FrmEditProduct
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
            MDL.Draw.Chemistry.Molecule molecule2 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences2 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCntrls = new System.Windows.Forms.Panel();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStrcuture = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.pnlstructure = new System.Windows.Forms.Panel();
            this.ChemRenditor = new MDL.Draw.Renditor.Renditor();
            this.lblCS = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.lblDs = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtEE = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblEe = new System.Windows.Forms.Label();
            this.txtYieldFrom = new System.Windows.Forms.TextBox();
            this.lblStructNo = new System.Windows.Forms.Label();
            this.txtStructNo = new System.Windows.Forms.TextBox();
            this.lblYield = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStructureInchi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYieldTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlCntrls.SuspendLayout();
            this.pnlstructure.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(707, 286);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlCntrls
            // 
            this.pnlCntrls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCntrls.Controls.Add(this.label1);
            this.pnlCntrls.Controls.Add(this.txtYieldTo);
            this.pnlCntrls.Controls.Add(this.txtGrade);
            this.pnlCntrls.Controls.Add(this.lblGrade);
            this.pnlCntrls.Controls.Add(this.lblStrcuture);
            this.pnlCntrls.Controls.Add(this.txtCS);
            this.pnlCntrls.Controls.Add(this.pnlstructure);
            this.pnlCntrls.Controls.Add(this.lblCS);
            this.pnlCntrls.Controls.Add(this.txtDe);
            this.pnlCntrls.Controls.Add(this.lblDs);
            this.pnlCntrls.Controls.Add(this.lblDE);
            this.pnlCntrls.Controls.Add(this.txtDS);
            this.pnlCntrls.Controls.Add(this.txtProductName);
            this.pnlCntrls.Controls.Add(this.txtEE);
            this.pnlCntrls.Controls.Add(this.lblProduct);
            this.pnlCntrls.Controls.Add(this.lblEe);
            this.pnlCntrls.Controls.Add(this.txtYieldFrom);
            this.pnlCntrls.Controls.Add(this.lblStructNo);
            this.pnlCntrls.Controls.Add(this.txtStructNo);
            this.pnlCntrls.Controls.Add(this.lblYield);
            this.pnlCntrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCntrls.Location = new System.Drawing.Point(0, 0);
            this.pnlCntrls.Name = "pnlCntrls";
            this.pnlCntrls.Size = new System.Drawing.Size(707, 249);
            this.pnlCntrls.TabIndex = 18;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(74, 124);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(114, 25);
            this.txtGrade.TabIndex = 17;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(26, 127);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(44, 17);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "Grade";
            // 
            // lblStrcuture
            // 
            this.lblStrcuture.AutoSize = true;
            this.lblStrcuture.Location = new System.Drawing.Point(371, 3);
            this.lblStrcuture.Name = "lblStrcuture";
            this.lblStrcuture.Size = new System.Drawing.Size(62, 17);
            this.lblStrcuture.TabIndex = 16;
            this.lblStrcuture.Text = "Structure";
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(74, 64);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(114, 25);
            this.txtCS.TabIndex = 4;
            this.txtCS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCS_KeyPress);
            // 
            // pnlstructure
            // 
            this.pnlstructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlstructure.Controls.Add(this.ChemRenditor);
            this.pnlstructure.Location = new System.Drawing.Point(372, 21);
            this.pnlstructure.Name = "pnlstructure";
            this.pnlstructure.Size = new System.Drawing.Size(330, 224);
            this.pnlstructure.TabIndex = 15;
            // 
            // ChemRenditor
            // 
            this.ChemRenditor.AutoSizeStructure = true;
            this.ChemRenditor.BinHexSketch = "010300044122001F4372656174656420627920416363656C7279734472617720342E312E312E34020" +
    "40000005805000000005905000000000B0B0005417269616C780000140200";
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
            this.ChemRenditor.Location = new System.Drawing.Point(0, 0);
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
            molecule2.Id = 3576;
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
            molecule2.RefId = 3576;
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
            molecule2.ZLayer = -96521;
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
            this.ChemRenditor.Size = new System.Drawing.Size(330, 224);
            this.ChemRenditor.SketchString = "AQMABEEiAB9DcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMS40AgQAAABYBQAAAABZBQAAAAALCwAFQ" +
    "XJpYWx4AAAUAgA=";
            this.ChemRenditor.SmilesString = "";
            this.ChemRenditor.TabIndex = 1;
            this.ChemRenditor.URLEncodedMolfileString = "";
            this.ChemRenditor.UseLocalXMLConfig = false;
            this.ChemRenditor.ComStructureChanged += new MDL.Draw.Renditor.StructureChangedEventHandler(this.ChemRenditor_ComStructureChanged);
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(44, 68);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(26, 17);
            this.lblCS.TabIndex = 7;
            this.lblCS.Text = "CS";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(74, 94);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(114, 25);
            this.txtDe.TabIndex = 6;
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Location = new System.Drawing.Point(210, 68);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(27, 17);
            this.lblDs.TabIndex = 11;
            this.lblDs.Text = "DS";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(42, 97);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(28, 17);
            this.lblDE.TabIndex = 13;
            this.lblDE.Text = "DE";
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(241, 64);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(125, 25);
            this.txtDS.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(74, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(292, 25);
            this.txtProductName.TabIndex = 1;
            // 
            // txtEE
            // 
            this.txtEE.Location = new System.Drawing.Point(241, 94);
            this.txtEE.Name = "txtEE";
            this.txtEE.Size = new System.Drawing.Size(125, 25);
            this.txtEE.TabIndex = 7;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(16, 8);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 17);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // lblEe
            // 
            this.lblEe.AutoSize = true;
            this.lblEe.Location = new System.Drawing.Point(211, 98);
            this.lblEe.Name = "lblEe";
            this.lblEe.Size = new System.Drawing.Size(26, 17);
            this.lblEe.TabIndex = 11;
            this.lblEe.Text = "EE";
            // 
            // txtYieldFrom
            // 
            this.txtYieldFrom.Location = new System.Drawing.Point(241, 34);
            this.txtYieldFrom.Name = "txtYieldFrom";
            this.txtYieldFrom.Size = new System.Drawing.Size(50, 25);
            this.txtYieldFrom.TabIndex = 3;
            this.txtYieldFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYield_KeyPress);
            // 
            // lblStructNo
            // 
            this.lblStructNo.AutoSize = true;
            this.lblStructNo.Location = new System.Drawing.Point(5, 38);
            this.lblStructNo.Name = "lblStructNo";
            this.lblStructNo.Size = new System.Drawing.Size(65, 17);
            this.lblStructNo.TabIndex = 5;
            this.lblStructNo.Text = "Struct No";
            // 
            // txtStructNo
            // 
            this.txtStructNo.Location = new System.Drawing.Point(74, 34);
            this.txtStructNo.Name = "txtStructNo";
            this.txtStructNo.Size = new System.Drawing.Size(114, 25);
            this.txtStructNo.TabIndex = 2;
            // 
            // lblYield
            // 
            this.lblYield.AutoSize = true;
            this.lblYield.Location = new System.Drawing.Point(199, 37);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(38, 17);
            this.lblYield.TabIndex = 9;
            this.lblYield.Text = "Yield";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblStructureInchi);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 249);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(707, 37);
            this.pnlBottom.TabIndex = 17;
            // 
            // lblStructureInchi
            // 
            this.lblStructureInchi.AutoSize = true;
            this.lblStructureInchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStructureInchi.Location = new System.Drawing.Point(114, 10);
            this.lblStructureInchi.Name = "lblStructureInchi";
            this.lblStructureInchi.Size = new System.Drawing.Size(18, 17);
            this.lblStructureInchi.TabIndex = 12;
            this.lblStructureInchi.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Structure Inchi: ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::ChemInform.Properties.Resources.save_1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(627, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYieldTo
            // 
            this.txtYieldTo.Location = new System.Drawing.Point(316, 34);
            this.txtYieldTo.Name = "txtYieldTo";
            this.txtYieldTo.Size = new System.Drawing.Size(50, 25);
            this.txtYieldTo.TabIndex = 19;
            this.txtYieldTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYieldTo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "to";
            // 
            // FrmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 286);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlCntrls.ResumeLayout(false);
            this.pnlCntrls.PerformLayout();
            this.pnlstructure.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStrcuture;
        private System.Windows.Forms.Panel pnlstructure;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtEE;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.Label lblEe;
        private System.Windows.Forms.Label lblDs;
        private System.Windows.Forms.TextBox txtYieldFrom;
        private System.Windows.Forms.Label lblYield;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.TextBox txtStructNo;
        private System.Windows.Forms.Label lblStructNo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlBottom;
        private MDL.Draw.Renditor.Renditor ChemRenditor;
        private System.Windows.Forms.Panel pnlCntrls;
        private System.Windows.Forms.Label lblStructureInchi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYieldTo;
    }
}