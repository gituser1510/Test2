namespace ChemInform
{
    partial class frmCrossRefs
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
            this.dgvCrossRefs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecRxnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccRxnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRefs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvCrossRefs);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(439, 251);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvCrossRefs
            // 
            this.dgvCrossRefs.AllowUserToAddRows = false;
            this.dgvCrossRefs.AllowUserToDeleteRows = false;
            this.dgvCrossRefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrossRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCrossRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrossRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRxnSNo,
            this.colPrecRxnNo,
            this.colSuccRxnNo});
            this.dgvCrossRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCrossRefs.Location = new System.Drawing.Point(0, 0);
            this.dgvCrossRefs.Name = "dgvCrossRefs";
            this.dgvCrossRefs.ReadOnly = true;
            this.dgvCrossRefs.Size = new System.Drawing.Size(439, 251);
            this.dgvCrossRefs.TabIndex = 0;
            this.dgvCrossRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCrossRefs_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Rxn.S.No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 132;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PrecRxnNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 132;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SuccRxnNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 132;
            // 
            // colRxnSNo
            // 
            this.colRxnSNo.HeaderText = "Rxn.S.No";
            this.colRxnSNo.Name = "colRxnSNo";
            this.colRxnSNo.ReadOnly = true;
            // 
            // colPrecRxnNo
            // 
            this.colPrecRxnNo.HeaderText = "PrecRxnNo";
            this.colPrecRxnNo.Name = "colPrecRxnNo";
            this.colPrecRxnNo.ReadOnly = true;
            // 
            // colSuccRxnNo
            // 
            this.colSuccRxnNo.HeaderText = "SuccRxnNo";
            this.colSuccRxnNo.Name = "colSuccRxnNo";
            this.colSuccRxnNo.ReadOnly = true;
            // 
            // frmCrossRefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrossRefs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross References";
            this.Load += new System.EventHandler(this.frmCrossRefs_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRefs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvCrossRefs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecRxnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccRxnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}