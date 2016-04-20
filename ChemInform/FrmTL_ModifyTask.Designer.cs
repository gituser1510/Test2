namespace ChemInform
{
    partial class FrmTL_ModifyTask
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
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.lblDocId = new System.Windows.Forms.Label();
            this.lblAnalyst = new System.Windows.Forms.Label();
            this.lblQc = new System.Windows.Forms.Label();
            this.txtReviewer = new System.Windows.Forms.TextBox();
            this.txtAnalyst = new System.Windows.Forms.TextBox();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.lblModfiedReviewer = new System.Windows.Forms.Label();
            this.lblModifiedQc = new System.Windows.Forms.Label();
            this.lblModifiedAnalyst = new System.Windows.Forms.Label();
            this.cmbModifiedQc = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQc = new System.Windows.Forms.TextBox();
            this.cmbModifiedReviewer = new System.Windows.Forms.ComboBox();
            this.cmbModifiedAnalyst = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txtDocId);
            this.pnlMain.Controls.Add(this.lblDocId);
            this.pnlMain.Controls.Add(this.cmbModifiedReviewer);
            this.pnlMain.Controls.Add(this.cmbModifiedAnalyst);
            this.pnlMain.Controls.Add(this.cmbModifiedQc);
            this.pnlMain.Controls.Add(this.lblModifiedAnalyst);
            this.pnlMain.Controls.Add(this.lblAnalyst);
            this.pnlMain.Controls.Add(this.lblModifiedQc);
            this.pnlMain.Controls.Add(this.lblQc);
            this.pnlMain.Controls.Add(this.txtQc);
            this.pnlMain.Controls.Add(this.txtReviewer);
            this.pnlMain.Controls.Add(this.lblModfiedReviewer);
            this.pnlMain.Controls.Add(this.txtAnalyst);
            this.pnlMain.Controls.Add(this.lblReviewer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(867, 169);
            this.pnlMain.TabIndex = 0;
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(142, 8);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.ReadOnly = true;
            this.txtDocId.Size = new System.Drawing.Size(269, 26);
            this.txtDocId.TabIndex = 5;
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Location = new System.Drawing.Point(84, 11);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(52, 19);
            this.lblDocId.TabIndex = 10;
            this.lblDocId.Text = "Doc Id";
            // 
            // lblAnalyst
            // 
            this.lblAnalyst.AutoSize = true;
            this.lblAnalyst.Location = new System.Drawing.Point(82, 42);
            this.lblAnalyst.Name = "lblAnalyst";
            this.lblAnalyst.Size = new System.Drawing.Size(54, 19);
            this.lblAnalyst.TabIndex = 11;
            this.lblAnalyst.Text = "Analyst";
            // 
            // lblQc
            // 
            this.lblQc.AutoSize = true;
            this.lblQc.Location = new System.Drawing.Point(36, 104);
            this.lblQc.Name = "lblQc";
            this.lblQc.Size = new System.Drawing.Size(100, 19);
            this.lblQc.TabIndex = 9;
            this.lblQc.Text = "Quality Analyst";
            // 
            // txtReviewer
            // 
            this.txtReviewer.Location = new System.Drawing.Point(142, 70);
            this.txtReviewer.Name = "txtReviewer";
            this.txtReviewer.ReadOnly = true;
            this.txtReviewer.Size = new System.Drawing.Size(269, 26);
            this.txtReviewer.TabIndex = 7;
            // 
            // txtAnalyst
            // 
            this.txtAnalyst.Location = new System.Drawing.Point(142, 39);
            this.txtAnalyst.Name = "txtAnalyst";
            this.txtAnalyst.ReadOnly = true;
            this.txtAnalyst.Size = new System.Drawing.Size(269, 26);
            this.txtAnalyst.TabIndex = 6;
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(34, 73);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(102, 19);
            this.lblReviewer.TabIndex = 8;
            this.lblReviewer.Text = "Review Analyst";
            // 
            // lblModfiedReviewer
            // 
            this.lblModfiedReviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModfiedReviewer.AutoSize = true;
            this.lblModfiedReviewer.Location = new System.Drawing.Point(421, 72);
            this.lblModfiedReviewer.Name = "lblModfiedReviewer";
            this.lblModfiedReviewer.Size = new System.Drawing.Size(161, 19);
            this.lblModfiedReviewer.TabIndex = 8;
            this.lblModfiedReviewer.Text = "Modified Review Analyst";
            // 
            // lblModifiedQc
            // 
            this.lblModifiedQc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifiedQc.AutoSize = true;
            this.lblModifiedQc.Location = new System.Drawing.Point(423, 104);
            this.lblModifiedQc.Name = "lblModifiedQc";
            this.lblModifiedQc.Size = new System.Drawing.Size(159, 19);
            this.lblModifiedQc.TabIndex = 9;
            this.lblModifiedQc.Text = "Modified Quality Analyst";
            // 
            // lblModifiedAnalyst
            // 
            this.lblModifiedAnalyst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifiedAnalyst.AutoSize = true;
            this.lblModifiedAnalyst.Location = new System.Drawing.Point(454, 42);
            this.lblModifiedAnalyst.Name = "lblModifiedAnalyst";
            this.lblModifiedAnalyst.Size = new System.Drawing.Size(128, 19);
            this.lblModifiedAnalyst.TabIndex = 11;
            this.lblModifiedAnalyst.Text = "Modified to Analyst";
            // 
            // cmbModifiedQc
            // 
            this.cmbModifiedQc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModifiedQc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifiedQc.FormattingEnabled = true;
            this.cmbModifiedQc.Location = new System.Drawing.Point(588, 101);
            this.cmbModifiedQc.Name = "cmbModifiedQc";
            this.cmbModifiedQc.Size = new System.Drawing.Size(269, 27);
            this.cmbModifiedQc.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(690, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQc
            // 
            this.txtQc.Location = new System.Drawing.Point(142, 101);
            this.txtQc.Name = "txtQc";
            this.txtQc.ReadOnly = true;
            this.txtQc.Size = new System.Drawing.Size(269, 26);
            this.txtQc.TabIndex = 7;
            // 
            // cmbModifiedReviewer
            // 
            this.cmbModifiedReviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModifiedReviewer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifiedReviewer.FormattingEnabled = true;
            this.cmbModifiedReviewer.Location = new System.Drawing.Point(588, 69);
            this.cmbModifiedReviewer.Name = "cmbModifiedReviewer";
            this.cmbModifiedReviewer.Size = new System.Drawing.Size(269, 27);
            this.cmbModifiedReviewer.TabIndex = 12;
            // 
            // cmbModifiedAnalyst
            // 
            this.cmbModifiedAnalyst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModifiedAnalyst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifiedAnalyst.FormattingEnabled = true;
            this.cmbModifiedAnalyst.Location = new System.Drawing.Point(588, 36);
            this.cmbModifiedAnalyst.Name = "cmbModifiedAnalyst";
            this.cmbModifiedAnalyst.Size = new System.Drawing.Size(269, 27);
            this.cmbModifiedAnalyst.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(782, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmTL_ModifyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 169);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTL_ModifyTask";
            this.Text = "Modify Task";
            this.Load += new System.EventHandler(this.FrmTL_ModifyTask_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.ComboBox cmbModifiedQc;
        private System.Windows.Forms.Label lblModifiedAnalyst;
        private System.Windows.Forms.Label lblAnalyst;
        private System.Windows.Forms.Label lblModifiedQc;
        private System.Windows.Forms.Label lblQc;
        private System.Windows.Forms.TextBox txtReviewer;
        private System.Windows.Forms.Label lblModfiedReviewer;
        private System.Windows.Forms.TextBox txtAnalyst;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQc;
        private System.Windows.Forms.ComboBox cmbModifiedReviewer;
        private System.Windows.Forms.ComboBox cmbModifiedAnalyst;
        private System.Windows.Forms.Button btnCancel;
    }
}