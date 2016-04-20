namespace ChemInform
{
    partial class frmRxnReference
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
            this.splCont = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRxnRef = new System.Windows.Forms.DataGridView();
            this.lblRxnRef = new System.Windows.Forms.Label();
            this.dgvCrossRef = new System.Windows.Forms.DataGridView();
            this.lblCrossRef = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPathNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnSNo_CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrevRxnNo_CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccRxnNo_CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.splCont.Panel1.SuspendLayout();
            this.splCont.Panel2.SuspendLayout();
            this.splCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRxnRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splCont);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(885, 447);
            this.pnlMain.TabIndex = 1;
            // 
            // splCont
            // 
            this.splCont.BackColor = System.Drawing.Color.White;
            this.splCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont.Location = new System.Drawing.Point(0, 0);
            this.splCont.Name = "splCont";
            // 
            // splCont.Panel1
            // 
            this.splCont.Panel1.Controls.Add(this.dgvTest);
            this.splCont.Panel1.Controls.Add(this.button1);
            this.splCont.Panel1.Controls.Add(this.dgvRxnRef);
            this.splCont.Panel1.Controls.Add(this.lblRxnRef);
            // 
            // splCont.Panel2
            // 
            this.splCont.Panel2.Controls.Add(this.dgvCrossRef);
            this.splCont.Panel2.Controls.Add(this.lblCrossRef);
            this.splCont.Size = new System.Drawing.Size(885, 447);
            this.splCont.SplitterDistance = 569;
            this.splCont.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRxnRef
            // 
            this.dgvRxnRef.AllowUserToAddRows = false;
            this.dgvRxnRef.AllowUserToDeleteRows = false;
            this.dgvRxnRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRxnRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRxnRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRxnRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRxnSNo,
            this.colPathNo,
            this.colPath,
            this.colStep});
            this.dgvRxnRef.Location = new System.Drawing.Point(0, 26);
            this.dgvRxnRef.Name = "dgvRxnRef";
            this.dgvRxnRef.ReadOnly = true;
            this.dgvRxnRef.Size = new System.Drawing.Size(567, 254);
            this.dgvRxnRef.TabIndex = 0;
            this.dgvRxnRef.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRxnRef_RowPostPaint);
            // 
            // lblRxnRef
            // 
            this.lblRxnRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRxnRef.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRxnRef.Location = new System.Drawing.Point(0, 0);
            this.lblRxnRef.Name = "lblRxnRef";
            this.lblRxnRef.Size = new System.Drawing.Size(567, 26);
            this.lblRxnRef.TabIndex = 1;
            this.lblRxnRef.Text = "Reaction Reference";
            this.lblRxnRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCrossRef
            // 
            this.dgvCrossRef.AllowUserToAddRows = false;
            this.dgvCrossRef.AllowUserToDeleteRows = false;
            this.dgvCrossRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrossRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCrossRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrossRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRxnSNo_CR,
            this.colPrevRxnNo_CR,
            this.colSuccRxnNo_CR});
            this.dgvCrossRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCrossRef.Location = new System.Drawing.Point(0, 26);
            this.dgvCrossRef.Name = "dgvCrossRef";
            this.dgvCrossRef.ReadOnly = true;
            this.dgvCrossRef.Size = new System.Drawing.Size(310, 419);
            this.dgvCrossRef.TabIndex = 1;
            this.dgvCrossRef.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCrossRef_RowPostPaint);
            // 
            // lblCrossRef
            // 
            this.lblCrossRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrossRef.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCrossRef.Location = new System.Drawing.Point(0, 0);
            this.lblCrossRef.Name = "lblCrossRef";
            this.lblCrossRef.Size = new System.Drawing.Size(310, 26);
            this.lblCrossRef.TabIndex = 2;
            this.lblCrossRef.Text = "Cross Reference";
            this.lblCrossRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Rxn.No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PathNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Path";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 122;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Step";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Rxn.S.No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PrecRxnNo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 82;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "SuccRxnNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // colRxnSNo
            // 
            this.colRxnSNo.HeaderText = "RxnNo";
            this.colRxnSNo.Name = "colRxnSNo";
            this.colRxnSNo.ReadOnly = true;
            // 
            // colPathNo
            // 
            this.colPathNo.HeaderText = "Path No";
            this.colPathNo.Name = "colPathNo";
            this.colPathNo.ReadOnly = true;
            // 
            // colPath
            // 
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            // 
            // colStep
            // 
            this.colStep.HeaderText = "Step";
            this.colStep.Name = "colStep";
            this.colStep.ReadOnly = true;
            // 
            // colRxnSNo_CR
            // 
            this.colRxnSNo_CR.HeaderText = "RxnNo";
            this.colRxnSNo_CR.Name = "colRxnSNo_CR";
            this.colRxnSNo_CR.ReadOnly = true;
            // 
            // colPrevRxnNo_CR
            // 
            this.colPrevRxnNo_CR.HeaderText = "Prec.RxnNo";
            this.colPrevRxnNo_CR.Name = "colPrevRxnNo_CR";
            this.colPrevRxnNo_CR.ReadOnly = true;
            // 
            // colSuccRxnNo_CR
            // 
            this.colSuccRxnNo_CR.HeaderText = "Succ.RxnNo";
            this.colSuccRxnNo_CR.Name = "colSuccRxnNo_CR";
            this.colSuccRxnNo_CR.ReadOnly = true;
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(2, 292);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.Size = new System.Drawing.Size(562, 150);
            this.dgvTest.TabIndex = 3;
            // 
            // frmRxnReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 447);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRxnReference";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reaction Reference / Cross Reference";
            this.Load += new System.EventHandler(this.frmRxnReference_Load);
            this.pnlMain.ResumeLayout(false);
            this.splCont.Panel1.ResumeLayout(false);
            this.splCont.Panel2.ResumeLayout(false);
            this.splCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRxnRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvRxnRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SplitContainer splCont;
        private System.Windows.Forms.DataGridView dgvCrossRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPathNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnSNo_CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrevRxnNo_CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccRxnNo_CR;
        private System.Windows.Forms.Label lblRxnRef;
        private System.Windows.Forms.Label lblCrossRef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTest;
    }
}