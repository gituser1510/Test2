namespace ChemInform
{
    partial class frmQCNotDoneRxns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvReactions = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.chkSelAll = new System.Windows.Forms.CheckBox();
            this.btnQCDone = new System.Windows.Forms.Button();
            this.colSelRxn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRxnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactions)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvReactions);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(286, 342);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvReactions
            // 
            this.dgvReactions.AllowUserToAddRows = false;
            this.dgvReactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvReactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelRxn,
            this.colRxnID,
            this.colRxnSNo});
            this.dgvReactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReactions.Location = new System.Drawing.Point(0, 26);
            this.dgvReactions.Name = "dgvReactions";
            this.dgvReactions.Size = new System.Drawing.Size(286, 283);
            this.dgvReactions.TabIndex = 1;
            this.dgvReactions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvReactions_RowPostPaint);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(286, 26);
            this.pnlTop.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(2, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(237, 19);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Please do QC for the below reactions";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.chkSelAll);
            this.pnlBottom.Controls.Add(this.btnQCDone);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 309);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(286, 33);
            this.pnlBottom.TabIndex = 2;
            // 
            // chkSelAll
            // 
            this.chkSelAll.AutoSize = true;
            this.chkSelAll.ForeColor = System.Drawing.Color.Blue;
            this.chkSelAll.Location = new System.Drawing.Point(4, 5);
            this.chkSelAll.Name = "chkSelAll";
            this.chkSelAll.Size = new System.Drawing.Size(83, 21);
            this.chkSelAll.TabIndex = 1;
            this.chkSelAll.Text = "Select All";
            this.chkSelAll.UseVisualStyleBackColor = true;
            this.chkSelAll.CheckedChanged += new System.EventHandler(this.chkSelAll_CheckedChanged);
            // 
            // btnQCDone
            // 
            this.btnQCDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQCDone.Location = new System.Drawing.Point(193, 0);
            this.btnQCDone.Name = "btnQCDone";
            this.btnQCDone.Size = new System.Drawing.Size(89, 29);
            this.btnQCDone.TabIndex = 0;
            this.btnQCDone.Text = "QC Done";
            this.btnQCDone.UseVisualStyleBackColor = true;
            this.btnQCDone.Click += new System.EventHandler(this.btnQCDone_Click);
            // 
            // colSelRxn
            // 
            this.colSelRxn.HeaderText = "Select";
            this.colSelRxn.Name = "colSelRxn";
            // 
            // colRxnID
            // 
            this.colRxnID.HeaderText = "RxnID";
            this.colRxnID.Name = "colRxnID";
            this.colRxnID.ReadOnly = true;
            this.colRxnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRxnID.Visible = false;
            // 
            // colRxnSNo
            // 
            this.colRxnSNo.FillWeight = 50F;
            this.colRxnSNo.HeaderText = "RxnS.No";
            this.colRxnSNo.Name = "colRxnSNo";
            this.colRxnSNo.ReadOnly = true;
            this.colRxnSNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmQCNotDoneRxns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 342);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQCNotDoneRxns";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QC not completed reactions";
            this.Load += new System.EventHandler(this.frmQCNotDoneRxns_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactions)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvReactions;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnQCDone;
        private System.Windows.Forms.CheckBox chkSelAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelRxn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnSNo;
    }
}