namespace ChemInform
{
    partial class FrmSpectralCuration
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
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlNavig = new System.Windows.Forms.Panel();
            this.lblRxnCnt = new System.Windows.Forms.Label();
            this.pnlNavigCntrls = new System.Windows.Forms.Panel();
            this.numGotoRecord = new System.Windows.Forms.NumericUpDown();
            this.btnPrevComp = new System.Windows.Forms.Button();
            this.btnFirstComp = new System.Windows.Forms.Button();
            this.btnNextComp = new System.Windows.Forms.Button();
            this.btnLastComp = new System.Windows.Forms.Button();
            this.btnDeleteCompound = new System.Windows.Forms.Button();
            this.btnAddCompound = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txtDOI = new System.Windows.Forms.TextBox();
            this.lblDOI = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtJournalName = new System.Windows.Forms.TextBox();
            this.lblMolFormula = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucSpectral = new ChemInform.UserControls.ucSpectrlData();
            this.pnlMain.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlNavig.SuspendLayout();
            this.pnlNavigCntrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGotoRecord)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlNavigation);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Controls.Add(this.pnlSave);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1034, 576);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.ucSpectral);
            this.pnlNavigation.Controls.Add(this.pnlNavig);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 63);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(1034, 478);
            this.pnlNavigation.TabIndex = 9;
            // 
            // pnlNavig
            // 
            this.pnlNavig.Controls.Add(this.lblRxnCnt);
            this.pnlNavig.Controls.Add(this.pnlNavigCntrls);
            this.pnlNavig.Controls.Add(this.btnDeleteCompound);
            this.pnlNavig.Controls.Add(this.btnAddCompound);
            this.pnlNavig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavig.Location = new System.Drawing.Point(0, 0);
            this.pnlNavig.Name = "pnlNavig";
            this.pnlNavig.Size = new System.Drawing.Size(1034, 31);
            this.pnlNavig.TabIndex = 8;
            // 
            // lblRxnCnt
            // 
            this.lblRxnCnt.AutoSize = true;
            this.lblRxnCnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRxnCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblRxnCnt.Location = new System.Drawing.Point(7, 7);
            this.lblRxnCnt.Name = "lblRxnCnt";
            this.lblRxnCnt.Size = new System.Drawing.Size(16, 17);
            this.lblRxnCnt.TabIndex = 18;
            this.lblRxnCnt.Text = "0";
            // 
            // pnlNavigCntrls
            // 
            this.pnlNavigCntrls.Controls.Add(this.numGotoRecord);
            this.pnlNavigCntrls.Controls.Add(this.btnPrevComp);
            this.pnlNavigCntrls.Controls.Add(this.btnFirstComp);
            this.pnlNavigCntrls.Controls.Add(this.btnNextComp);
            this.pnlNavigCntrls.Controls.Add(this.btnLastComp);
            this.pnlNavigCntrls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNavigCntrls.Location = new System.Drawing.Point(815, 0);
            this.pnlNavigCntrls.Name = "pnlNavigCntrls";
            this.pnlNavigCntrls.Size = new System.Drawing.Size(219, 31);
            this.pnlNavigCntrls.TabIndex = 17;
            // 
            // numGotoRecord
            // 
            this.numGotoRecord.Location = new System.Drawing.Point(90, 3);
            this.numGotoRecord.Name = "numGotoRecord";
            this.numGotoRecord.Size = new System.Drawing.Size(43, 25);
            this.numGotoRecord.TabIndex = 17;
            this.numGotoRecord.ValueChanged += new System.EventHandler(this.numGotoRecord_ValueChanged);
            // 
            // btnPrevComp
            // 
            this.btnPrevComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevComp.Location = new System.Drawing.Point(47, 3);
            this.btnPrevComp.Name = "btnPrevComp";
            this.btnPrevComp.Size = new System.Drawing.Size(36, 25);
            this.btnPrevComp.TabIndex = 13;
            this.btnPrevComp.Text = "<";
            this.btnPrevComp.UseVisualStyleBackColor = true;
            this.btnPrevComp.Click += new System.EventHandler(this.btnPrevComp_Click);
            // 
            // btnFirstComp
            // 
            this.btnFirstComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstComp.Location = new System.Drawing.Point(5, 3);
            this.btnFirstComp.Name = "btnFirstComp";
            this.btnFirstComp.Size = new System.Drawing.Size(36, 25);
            this.btnFirstComp.TabIndex = 12;
            this.btnFirstComp.Text = "<<";
            this.btnFirstComp.UseVisualStyleBackColor = true;
            this.btnFirstComp.Click += new System.EventHandler(this.btnFirstComp_Click);
            // 
            // btnNextComp
            // 
            this.btnNextComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextComp.Location = new System.Drawing.Point(139, 3);
            this.btnNextComp.Name = "btnNextComp";
            this.btnNextComp.Size = new System.Drawing.Size(36, 25);
            this.btnNextComp.TabIndex = 15;
            this.btnNextComp.Text = ">";
            this.btnNextComp.UseVisualStyleBackColor = true;
            this.btnNextComp.Click += new System.EventHandler(this.btnNextComp_Click);
            // 
            // btnLastComp
            // 
            this.btnLastComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastComp.Location = new System.Drawing.Point(181, 3);
            this.btnLastComp.Name = "btnLastComp";
            this.btnLastComp.Size = new System.Drawing.Size(36, 25);
            this.btnLastComp.TabIndex = 16;
            this.btnLastComp.Text = ">>";
            this.btnLastComp.UseVisualStyleBackColor = true;
            this.btnLastComp.Click += new System.EventHandler(this.btnLastComp_Click);
            // 
            // btnDeleteCompound
            // 
            this.btnDeleteCompound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCompound.Location = new System.Drawing.Point(674, 2);
            this.btnDeleteCompound.Name = "btnDeleteCompound";
            this.btnDeleteCompound.Size = new System.Drawing.Size(135, 26);
            this.btnDeleteCompound.TabIndex = 1;
            this.btnDeleteCompound.Text = "Delete Compound";
            this.btnDeleteCompound.UseVisualStyleBackColor = true;
            this.btnDeleteCompound.Click += new System.EventHandler(this.btnDeleteCompound_Click);
            // 
            // btnAddCompound
            // 
            this.btnAddCompound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCompound.Location = new System.Drawing.Point(533, 2);
            this.btnAddCompound.Name = "btnAddCompound";
            this.btnAddCompound.Size = new System.Drawing.Size(135, 26);
            this.btnAddCompound.TabIndex = 0;
            this.btnAddCompound.Text = "Add Compound";
            this.btnAddCompound.UseVisualStyleBackColor = true;
            this.btnAddCompound.Click += new System.EventHandler(this.btnAddCompound_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.txtAuthors);
            this.pnlTop.Controls.Add(this.lblAuthors);
            this.pnlTop.Controls.Add(this.txtDOI);
            this.pnlTop.Controls.Add(this.lblDOI);
            this.pnlTop.Controls.Add(this.txtIssue);
            this.pnlTop.Controls.Add(this.lblIssue);
            this.pnlTop.Controls.Add(this.txtJournalName);
            this.pnlTop.Controls.Add(this.lblMolFormula);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1034, 63);
            this.pnlTop.TabIndex = 8;
            // 
            // txtAuthors
            // 
            this.txtAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthors.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAuthors.Location = new System.Drawing.Point(98, 33);
            this.txtAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(930, 25);
            this.txtAuthors.TabIndex = 11;
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(39, 37);
            this.lblAuthors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(55, 17);
            this.lblAuthors.TabIndex = 10;
            this.lblAuthors.Text = "Authors";
            // 
            // txtDOI
            // 
            this.txtDOI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDOI.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDOI.Location = new System.Drawing.Point(707, 4);
            this.txtDOI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOI.Name = "txtDOI";
            this.txtDOI.ReadOnly = true;
            this.txtDOI.Size = new System.Drawing.Size(321, 25);
            this.txtDOI.TabIndex = 9;
            // 
            // lblDOI
            // 
            this.lblDOI.AutoSize = true;
            this.lblDOI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOI.Location = new System.Drawing.Point(669, 8);
            this.lblDOI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOI.Name = "lblDOI";
            this.lblDOI.Size = new System.Drawing.Size(35, 17);
            this.lblDOI.TabIndex = 8;
            this.lblDOI.Text = "DOI";
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIssue.Location = new System.Drawing.Point(459, 4);
            this.txtIssue.Margin = new System.Windows.Forms.Padding(4);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(184, 25);
            this.txtIssue.TabIndex = 7;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.Location = new System.Drawing.Point(417, 7);
            this.lblIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(39, 17);
            this.lblIssue.TabIndex = 6;
            this.lblIssue.Text = "Issue";
            // 
            // txtJournalName
            // 
            this.txtJournalName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtJournalName.Location = new System.Drawing.Point(98, 4);
            this.txtJournalName.Margin = new System.Windows.Forms.Padding(4);
            this.txtJournalName.Name = "txtJournalName";
            this.txtJournalName.ReadOnly = true;
            this.txtJournalName.Size = new System.Drawing.Size(306, 25);
            this.txtJournalName.TabIndex = 5;
            // 
            // lblMolFormula
            // 
            this.lblMolFormula.AutoSize = true;
            this.lblMolFormula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMolFormula.Location = new System.Drawing.Point(4, 8);
            this.lblMolFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMolFormula.Name = "lblMolFormula";
            this.lblMolFormula.Size = new System.Drawing.Size(90, 17);
            this.lblMolFormula.TabIndex = 4;
            this.lblMolFormula.Text = "Journal Name";
            // 
            // pnlSave
            // 
            this.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 541);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(1034, 35);
            this.pnlSave.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(950, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucSpectral
            // 
            this.ucSpectral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSpectral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSpectral.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSpectral.Location = new System.Drawing.Point(0, 31);
            this.ucSpectral.Margin = new System.Windows.Forms.Padding(4);
            this.ucSpectral.Name = "ucSpectral";
            this.ucSpectral.NmrDetails = null;
            this.ucSpectral.Size = new System.Drawing.Size(1034, 447);
            this.ucSpectral.TabIndex = 7;
            // 
            // FrmSpectralCuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmSpectralCuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectral Curation";
            this.Load += new System.EventHandler(this.FrmSpectralCuration_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavig.ResumeLayout(false);
            this.pnlNavig.PerformLayout();
            this.pnlNavigCntrls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGotoRecord)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private UserControls.ucSpectrlData ucSpectral;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.Label lblDOI;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtJournalName;
        private System.Windows.Forms.Label lblMolFormula;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlNavig;
        private System.Windows.Forms.Button btnDeleteCompound;
        private System.Windows.Forms.Button btnAddCompound;
        private System.Windows.Forms.Panel pnlNavigCntrls;
        private System.Windows.Forms.Button btnPrevComp;
        private System.Windows.Forms.Button btnFirstComp;
        private System.Windows.Forms.Button btnNextComp;
        private System.Windows.Forms.Button btnLastComp;
        private System.Windows.Forms.NumericUpDown numGotoRecord;
        private System.Windows.Forms.Label lblRxnCnt;
    }
}