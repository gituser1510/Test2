namespace ChemInform.TaskSheets
{
    partial class FrmTaskSheetCuratorReviewQc
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.cntMnuTaskSubmission = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taskCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curationCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityCheckCompltedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.lblDocId = new System.Windows.Forms.Label();
            this.ColDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDocName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColPdf = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColAnalyst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQualityAnalyst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.cntMnuTaskSubmission.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvProjects);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(843, 391);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDocId,
            this.ColDocName,
            this.ColPdf,
            this.ColAnalyst,
            this.ColReviewer,
            this.ColQualityAnalyst,
            this.ColTeamLead,
            this.ColStatus});
            this.dgvProjects.ContextMenuStrip = this.cntMnuTaskSubmission;
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 38);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(843, 353);
            this.dgvProjects.TabIndex = 1;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            this.dgvProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjects_CellMouseClick);
            this.dgvProjects.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProjects_RowPostPaint);
            // 
            // cntMnuTaskSubmission
            // 
            this.cntMnuTaskSubmission.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskCompletedToolStripMenuItem});
            this.cntMnuTaskSubmission.Name = "cntMnuTaskSubmission";
            this.cntMnuTaskSubmission.Size = new System.Drawing.Size(169, 26);
            this.cntMnuTaskSubmission.Opening += new System.ComponentModel.CancelEventHandler(this.cntMnuTaskSubmission_Opening);
            // 
            // taskCompletedToolStripMenuItem
            // 
            this.taskCompletedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curationCompletedToolStripMenuItem,
            this.reviewCompletedToolStripMenuItem,
            this.qualityCheckCompltedToolStripMenuItem});
            this.taskCompletedToolStripMenuItem.Name = "taskCompletedToolStripMenuItem";
            this.taskCompletedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.taskCompletedToolStripMenuItem.Text = "Report TaskStatus";
            // 
            // curationCompletedToolStripMenuItem
            // 
            this.curationCompletedToolStripMenuItem.Name = "curationCompletedToolStripMenuItem";
            this.curationCompletedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.curationCompletedToolStripMenuItem.Text = "Curation Completed";
            this.curationCompletedToolStripMenuItem.Click += new System.EventHandler(this.curationCompletedToolStripMenuItem_Click);
            // 
            // reviewCompletedToolStripMenuItem
            // 
            this.reviewCompletedToolStripMenuItem.Name = "reviewCompletedToolStripMenuItem";
            this.reviewCompletedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.reviewCompletedToolStripMenuItem.Text = "Review Completed";
            this.reviewCompletedToolStripMenuItem.Click += new System.EventHandler(this.reviewCompletedToolStripMenuItem_Click);
            // 
            // qualityCheckCompltedToolStripMenuItem
            // 
            this.qualityCheckCompltedToolStripMenuItem.Name = "qualityCheckCompltedToolStripMenuItem";
            this.qualityCheckCompltedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.qualityCheckCompltedToolStripMenuItem.Text = "Quality Check Completed";
            this.qualityCheckCompltedToolStripMenuItem.Click += new System.EventHandler(this.qualityCheckCompltedToolStripMenuItem_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtDocId);
            this.pnlControls.Controls.Add(this.lblDocId);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(843, 38);
            this.pnlControls.TabIndex = 0;
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(117, 6);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(207, 26);
            this.txtDocId.TabIndex = 1;
            this.txtDocId.TextChanged += new System.EventHandler(this.txtDocId_TextChanged);
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Location = new System.Drawing.Point(47, 9);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(55, 19);
            this.lblDocId.TabIndex = 0;
            this.lblDocId.Text = "Doc ID";
            // 
            // ColDocId
            // 
            this.ColDocId.FillWeight = 92.978F;
            this.ColDocId.HeaderText = "Doc Id";
            this.ColDocId.Name = "ColDocId";
            this.ColDocId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDocId.Visible = false;
            // 
            // ColDocName
            // 
            this.ColDocName.HeaderText = "Doc Name";
            this.ColDocName.Name = "ColDocName";
            this.ColDocName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDocName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColPdf
            // 
            this.ColPdf.FillWeight = 92.978F;
            this.ColPdf.HeaderText = "Pdf";
            this.ColPdf.Name = "ColPdf";
            this.ColPdf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPdf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColAnalyst
            // 
            this.ColAnalyst.FillWeight = 92.978F;
            this.ColAnalyst.HeaderText = "Analyst";
            this.ColAnalyst.Name = "ColAnalyst";
            // 
            // ColReviewer
            // 
            this.ColReviewer.FillWeight = 92.978F;
            this.ColReviewer.HeaderText = "Reviewer";
            this.ColReviewer.Name = "ColReviewer";
            // 
            // ColQualityAnalyst
            // 
            this.ColQualityAnalyst.FillWeight = 92.978F;
            this.ColQualityAnalyst.HeaderText = "QC";
            this.ColQualityAnalyst.Name = "ColQualityAnalyst";
            // 
            // ColTeamLead
            // 
            this.ColTeamLead.FillWeight = 92.978F;
            this.ColTeamLead.HeaderText = "TL";
            this.ColTeamLead.Name = "ColTeamLead";
            // 
            // ColStatus
            // 
            this.ColStatus.FillWeight = 142.132F;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // FrmTaskSheetCuratorReviewQc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 391);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaskSheetCuratorReviewQc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Sheet";
            this.Load += new System.EventHandler(this.FrmTS_CuratorReviewQc_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.cntMnuTaskSubmission.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.ContextMenuStrip cntMnuTaskSubmission;
        private System.Windows.Forms.ToolStripMenuItem taskCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curationCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityCheckCompltedToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocId;
        private System.Windows.Forms.DataGridViewLinkColumn ColDocName;
        private System.Windows.Forms.DataGridViewLinkColumn ColPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnalyst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQualityAnalyst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}