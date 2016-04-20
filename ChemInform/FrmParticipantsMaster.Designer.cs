namespace ChemInform
{
    partial class FrmParticipantsMaster
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
            this.PnlParticipants = new System.Windows.Forms.Panel();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.ColParticipantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipantSynonyms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipantInchiKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipantsEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlStructure = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnAddSynonym = new System.Windows.Forms.Button();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInchi = new System.Windows.Forms.TextBox();
            this.txtSynonym = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInchi = new System.Windows.Forms.Label();
            this.lblSynonyms = new System.Windows.Forms.Label();
            this.lblSynonym = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.PnlParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.PnlParticipants);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 471);
            this.pnlMain.TabIndex = 0;
            // 
            // PnlParticipants
            // 
            this.PnlParticipants.Controls.Add(this.dgvParticipants);
            this.PnlParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlParticipants.Location = new System.Drawing.Point(0, 191);
            this.PnlParticipants.Name = "PnlParticipants";
            this.PnlParticipants.Size = new System.Drawing.Size(950, 280);
            this.PnlParticipants.TabIndex = 5;
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            this.dgvParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParticipantId,
            this.ColParticipantName,
            this.ColParticipantSynonyms,
            this.ColParticipantInchiKey,
            this.ColParticipantsEdit});
            this.dgvParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParticipants.Location = new System.Drawing.Point(0, 0);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.Size = new System.Drawing.Size(950, 280);
            this.dgvParticipants.TabIndex = 3;
            this.dgvParticipants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellClick);
            this.dgvParticipants.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvParticipants_RowPostPaint);
            // 
            // ColParticipantId
            // 
            this.ColParticipantId.HeaderText = "Id";
            this.ColParticipantId.Name = "ColParticipantId";
            this.ColParticipantId.ReadOnly = true;
            this.ColParticipantId.Visible = false;
            // 
            // ColParticipantName
            // 
            this.ColParticipantName.FillWeight = 114.3824F;
            this.ColParticipantName.HeaderText = "Participant Name";
            this.ColParticipantName.Name = "ColParticipantName";
            this.ColParticipantName.ReadOnly = true;
            // 
            // ColParticipantSynonyms
            // 
            this.ColParticipantSynonyms.FillWeight = 114.3824F;
            this.ColParticipantSynonyms.HeaderText = "Synonyms";
            this.ColParticipantSynonyms.Name = "ColParticipantSynonyms";
            this.ColParticipantSynonyms.ReadOnly = true;
            // 
            // ColParticipantInchiKey
            // 
            this.ColParticipantInchiKey.FillWeight = 114.3824F;
            this.ColParticipantInchiKey.HeaderText = "Inchi Key";
            this.ColParticipantInchiKey.Name = "ColParticipantInchiKey";
            this.ColParticipantInchiKey.ReadOnly = true;
            // 
            // ColParticipantsEdit
            // 
            this.ColParticipantsEdit.FillWeight = 56.85279F;
            this.ColParticipantsEdit.HeaderText = "Edit";
            this.ColParticipantsEdit.Image = global::ChemInform.Properties.Resources.Edit;
            this.ColParticipantsEdit.Name = "ColParticipantsEdit";
            this.ColParticipantsEdit.ReadOnly = true;
            this.ColParticipantsEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColParticipantsEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnlStructure);
            this.pnlControls.Controls.Add(this.pnlInput);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(950, 191);
            this.pnlControls.TabIndex = 4;
            // 
            // pnlStructure
            // 
            this.pnlStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStructure.Location = new System.Drawing.Point(444, 0);
            this.pnlStructure.Name = "pnlStructure";
            this.pnlStructure.Size = new System.Drawing.Size(506, 191);
            this.pnlStructure.TabIndex = 6;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnAddSynonym);
            this.pnlInput.Controls.Add(this.txtSynonyms);
            this.pnlInput.Controls.Add(this.btnReset);
            this.pnlInput.Controls.Add(this.btnSave);
            this.pnlInput.Controls.Add(this.txtInchi);
            this.pnlInput.Controls.Add(this.txtSynonym);
            this.pnlInput.Controls.Add(this.txtName);
            this.pnlInput.Controls.Add(this.lblInchi);
            this.pnlInput.Controls.Add(this.lblSynonyms);
            this.pnlInput.Controls.Add(this.lblSynonym);
            this.pnlInput.Controls.Add(this.lblName);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(444, 191);
            this.pnlInput.TabIndex = 5;
            // 
            // btnAddSynonym
            // 
            this.btnAddSynonym.Location = new System.Drawing.Point(378, 43);
            this.btnAddSynonym.Name = "btnAddSynonym";
            this.btnAddSynonym.Size = new System.Drawing.Size(46, 26);
            this.btnAddSynonym.TabIndex = 3;
            this.btnAddSynonym.Text = "Add";
            this.btnAddSynonym.UseVisualStyleBackColor = true;
            this.btnAddSynonym.Click += new System.EventHandler(this.btnAddSynonym_Click);
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Location = new System.Drawing.Point(91, 76);
            this.txtSynonyms.Margin = new System.Windows.Forms.Padding(4);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSynonyms.Size = new System.Drawing.Size(333, 45);
            this.txtSynonyms.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(185, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(91, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save\t";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInchi
            // 
            this.txtInchi.Location = new System.Drawing.Point(91, 128);
            this.txtInchi.Name = "txtInchi";
            this.txtInchi.Size = new System.Drawing.Size(333, 26);
            this.txtInchi.TabIndex = 5;
            // 
            // txtSynonym
            // 
            this.txtSynonym.Location = new System.Drawing.Point(91, 43);
            this.txtSynonym.Name = "txtSynonym";
            this.txtSynonym.Size = new System.Drawing.Size(281, 26);
            this.txtSynonym.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblInchi
            // 
            this.lblInchi.AutoSize = true;
            this.lblInchi.Location = new System.Drawing.Point(47, 131);
            this.lblInchi.Name = "lblInchi";
            this.lblInchi.Size = new System.Drawing.Size(38, 19);
            this.lblInchi.TabIndex = 0;
            this.lblInchi.Text = "Inchi";
            // 
            // lblSynonyms
            // 
            this.lblSynonyms.AutoSize = true;
            this.lblSynonyms.Location = new System.Drawing.Point(14, 79);
            this.lblSynonyms.Name = "lblSynonyms";
            this.lblSynonyms.Size = new System.Drawing.Size(71, 19);
            this.lblSynonyms.TabIndex = 0;
            this.lblSynonyms.Text = "Synonyms";
            // 
            // lblSynonym
            // 
            this.lblSynonym.AutoSize = true;
            this.lblSynonym.Location = new System.Drawing.Point(20, 46);
            this.lblSynonym.Name = "lblSynonym";
            this.lblSynonym.Size = new System.Drawing.Size(65, 19);
            this.lblSynonym.TabIndex = 0;
            this.lblSynonym.Text = "Synonym";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // FrmParticipantsMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 471);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmParticipantsMaster";
            this.Text = "Participants Master";
            this.pnlMain.ResumeLayout(false);
            this.PnlParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlStructure;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtInchi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInchi;
        private System.Windows.Forms.Label lblSynonyms;
        private System.Windows.Forms.Label lblSynonym;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSynonym;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.Panel PnlParticipants;
        private System.Windows.Forms.Button btnAddSynonym;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipantSynonyms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipantInchiKey;
        private System.Windows.Forms.DataGridViewImageColumn ColParticipantsEdit;


    }
}