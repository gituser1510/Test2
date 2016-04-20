namespace ChemInform
{
    partial class frmNewReaction
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
            this.chkDuplicateWithRxn = new System.Windows.Forms.CheckBox();
            this.cmbDuplicateWithRxn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateRxn = new System.Windows.Forms.Button();
            this.cmbRxnNo = new System.Windows.Forms.ComboBox();
            this.lblRXNNUM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnAfter = new System.Windows.Forms.RadioButton();
            this.rbnBefore = new System.Windows.Forms.RadioButton();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.chkDuplicateWithRxn);
            this.pnlMain.Controls.Add(this.cmbDuplicateWithRxn);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.cmbRxnNo);
            this.pnlMain.Controls.Add(this.lblRXNNUM);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.rbnAfter);
            this.pnlMain.Controls.Add(this.rbnBefore);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(425, 97);
            this.pnlMain.TabIndex = 0;
            // 
            // chkDuplicateWithRxn
            // 
            this.chkDuplicateWithRxn.AutoSize = true;
            this.chkDuplicateWithRxn.Location = new System.Drawing.Point(177, 42);
            this.chkDuplicateWithRxn.Name = "chkDuplicateWithRxn";
            this.chkDuplicateWithRxn.Size = new System.Drawing.Size(168, 21);
            this.chkDuplicateWithRxn.TabIndex = 43;
            this.chkDuplicateWithRxn.Text = "Duplicate with Reaction";
            this.chkDuplicateWithRxn.UseVisualStyleBackColor = true;
            this.chkDuplicateWithRxn.CheckStateChanged += new System.EventHandler(this.chkDuplicateWithRxn_CheckStateChanged);
            // 
            // cmbDuplicateWithRxn
            // 
            this.cmbDuplicateWithRxn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuplicateWithRxn.Enabled = false;
            this.cmbDuplicateWithRxn.FormattingEnabled = true;
            this.cmbDuplicateWithRxn.Location = new System.Drawing.Point(348, 40);
            this.cmbDuplicateWithRxn.Name = "cmbDuplicateWithRxn";
            this.cmbDuplicateWithRxn.Size = new System.Drawing.Size(73, 25);
            this.cmbDuplicateWithRxn.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreateRxn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 28);
            this.panel1.TabIndex = 41;
            // 
            // btnCreateRxn
            // 
            this.btnCreateRxn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRxn.Location = new System.Drawing.Point(345, 0);
            this.btnCreateRxn.Name = "btnCreateRxn";
            this.btnCreateRxn.Size = new System.Drawing.Size(75, 26);
            this.btnCreateRxn.TabIndex = 0;
            this.btnCreateRxn.Text = "Create";
            this.btnCreateRxn.UseVisualStyleBackColor = true;
            this.btnCreateRxn.Click += new System.EventHandler(this.btnCreateRxn_Click);
            // 
            // cmbRxnNo
            // 
            this.cmbRxnNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRxnNo.FormattingEnabled = true;
            this.cmbRxnNo.Location = new System.Drawing.Point(349, 9);
            this.cmbRxnNo.Name = "cmbRxnNo";
            this.cmbRxnNo.Size = new System.Drawing.Size(73, 25);
            this.cmbRxnNo.TabIndex = 40;
            // 
            // lblRXNNUM
            // 
            this.lblRXNNUM.AutoSize = true;
            this.lblRXNNUM.ForeColor = System.Drawing.Color.Blue;
            this.lblRXNNUM.Location = new System.Drawing.Point(280, 13);
            this.lblRXNNUM.Name = "lblRXNNUM";
            this.lblRXNNUM.Size = new System.Drawing.Size(66, 17);
            this.lblRXNNUM.TabIndex = 36;
            this.lblRXNNUM.Text = "Rxn S.No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Insert new Reaction";
            // 
            // rbnAfter
            // 
            this.rbnAfter.AutoSize = true;
            this.rbnAfter.Checked = true;
            this.rbnAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnAfter.ForeColor = System.Drawing.Color.Red;
            this.rbnAfter.Location = new System.Drawing.Point(218, 12);
            this.rbnAfter.Name = "rbnAfter";
            this.rbnAfter.Size = new System.Drawing.Size(58, 21);
            this.rbnAfter.TabIndex = 38;
            this.rbnAfter.TabStop = true;
            this.rbnAfter.Text = "After";
            this.rbnAfter.UseVisualStyleBackColor = true;
            // 
            // rbnBefore
            // 
            this.rbnBefore.AutoSize = true;
            this.rbnBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnBefore.ForeColor = System.Drawing.Color.Red;
            this.rbnBefore.Location = new System.Drawing.Point(136, 12);
            this.rbnBefore.Name = "rbnBefore";
            this.rbnBefore.Size = new System.Drawing.Size(67, 21);
            this.rbnBefore.TabIndex = 37;
            this.rbnBefore.Text = "Before";
            this.rbnBefore.UseVisualStyleBackColor = true;
            // 
            // frmNewReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 97);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewReaction";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Reaction";
            this.Load += new System.EventHandler(this.frmNewReaction_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbRxnNo;
        private System.Windows.Forms.Label lblRXNNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnAfter;
        private System.Windows.Forms.RadioButton rbnBefore;
        private System.Windows.Forms.Button btnCreateRxn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDuplicateWithRxn;
        private System.Windows.Forms.ComboBox cmbDuplicateWithRxn;
    }
}