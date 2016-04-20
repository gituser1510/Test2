namespace ChemInform
{
    partial class frmSYSNoMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelectedClassType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedSysNo = new System.Windows.Forms.TextBox();
            this.txtSelectedSysText = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvClassificationMaster = new System.Windows.Forms.DataGridView();
            this.colCMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSYsNos = new System.Windows.Forms.DataGridView();
            this.colSysNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splContSecSubSec = new System.Windows.Forms.SplitContainer();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblTan = new System.Windows.Forms.Label();
            this.txtSrchSysNo = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificationMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSYsNos)).BeginInit();
            this.splContSecSubSec.Panel1.SuspendLayout();
            this.splContSecSubSec.Panel2.SuspendLayout();
            this.splContSecSubSec.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(900, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.label3);
            this.pnlBottom.Controls.Add(this.txtSelectedClassType);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.txtSelectedSysNo);
            this.pnlBottom.Controls.Add(this.txtSelectedSysText);
            this.pnlBottom.Controls.Add(this.btnReset);
            this.pnlBottom.Controls.Add(this.btnSubmit);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 405);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(980, 55);
            this.pnlBottom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 211;
            this.label3.Text = "Class Type";
            // 
            // txtSelectedClassType
            // 
            this.txtSelectedClassType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedClassType.BackColor = System.Drawing.Color.SeaShell;
            this.txtSelectedClassType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedClassType.ForeColor = System.Drawing.Color.Blue;
            this.txtSelectedClassType.Location = new System.Drawing.Point(5, 24);
            this.txtSelectedClassType.Name = "txtSelectedClassType";
            this.txtSelectedClassType.ReadOnly = true;
            this.txtSelectedClassType.Size = new System.Drawing.Size(137, 22);
            this.txtSelectedClassType.TabIndex = 210;
            this.txtSelectedClassType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 209;
            this.label2.Text = "SysNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 208;
            this.label1.Text = "SysText";
            // 
            // txtSelectedSysNo
            // 
            this.txtSelectedSysNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedSysNo.BackColor = System.Drawing.Color.SeaShell;
            this.txtSelectedSysNo.Location = new System.Drawing.Point(197, 29);
            this.txtSelectedSysNo.Name = "txtSelectedSysNo";
            this.txtSelectedSysNo.ReadOnly = true;
            this.txtSelectedSysNo.Size = new System.Drawing.Size(616, 22);
            this.txtSelectedSysNo.TabIndex = 3;
            // 
            // txtSelectedSysText
            // 
            this.txtSelectedSysText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedSysText.BackColor = System.Drawing.Color.SeaShell;
            this.txtSelectedSysText.Location = new System.Drawing.Point(197, 3);
            this.txtSelectedSysText.Name = "txtSelectedSysText";
            this.txtSelectedSysText.ReadOnly = true;
            this.txtSelectedSysText.Size = new System.Drawing.Size(778, 22);
            this.txtSelectedSysText.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(819, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvClassificationMaster
            // 
            this.dgvClassificationMaster.AllowUserToAddRows = false;
            this.dgvClassificationMaster.AllowUserToDeleteRows = false;
            this.dgvClassificationMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            this.dgvClassificationMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassificationMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassificationMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClassificationMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassificationMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCMID,
            this.colClassType,
            this.colClass_Name});
            this.dgvClassificationMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassificationMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvClassificationMaster.MultiSelect = false;
            this.dgvClassificationMaster.Name = "dgvClassificationMaster";
            this.dgvClassificationMaster.ReadOnly = true;
            this.dgvClassificationMaster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClassificationMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassificationMaster.Size = new System.Drawing.Size(485, 403);
            this.dgvClassificationMaster.StandardTab = true;
            this.dgvClassificationMaster.TabIndex = 4;
            this.dgvClassificationMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassificationMaster_CellClick);
            this.dgvClassificationMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassificationMaster_CellDoubleClick);
            this.dgvClassificationMaster.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvClassificationMaster_RowPostPaint);
            // 
            // colCMID
            // 
            this.colCMID.HeaderText = "CMID";
            this.colCMID.Name = "colCMID";
            this.colCMID.ReadOnly = true;
            this.colCMID.Visible = false;
            // 
            // colClassType
            // 
            this.colClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClassType.HeaderText = "Type";
            this.colClassType.Name = "colClassType";
            this.colClassType.ReadOnly = true;
            this.colClassType.Width = 60;
            // 
            // colClass_Name
            // 
            this.colClass_Name.HeaderText = "Classification Name";
            this.colClass_Name.Name = "colClass_Name";
            this.colClass_Name.ReadOnly = true;
            // 
            // dgvSYsNos
            // 
            this.dgvSYsNos.AllowUserToAddRows = false;
            this.dgvSYsNos.AllowUserToDeleteRows = false;
            this.dgvSYsNos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            this.dgvSYsNos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSYsNos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSYsNos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSYsNos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSYsNos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSysNo,
            this.colSysText});
            this.dgvSYsNos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSYsNos.Location = new System.Drawing.Point(0, 32);
            this.dgvSYsNos.Name = "dgvSYsNos";
            this.dgvSYsNos.ReadOnly = true;
            this.dgvSYsNos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSYsNos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSYsNos.Size = new System.Drawing.Size(487, 371);
            this.dgvSYsNos.StandardTab = true;
            this.dgvSYsNos.TabIndex = 5;
            this.dgvSYsNos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSYsNos_CellDoubleClick);
            this.dgvSYsNos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSYsNos_RowPostPaint);
            // 
            // colSysNo
            // 
            this.colSysNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSysNo.HeaderText = "SYSNo";
            this.colSysNo.Name = "colSysNo";
            this.colSysNo.ReadOnly = true;
            this.colSysNo.Width = 60;
            // 
            // colSysText
            // 
            this.colSysText.HeaderText = "Sys Text";
            this.colSysText.Name = "colSysText";
            this.colSysText.ReadOnly = true;
            // 
            // splContSecSubSec
            // 
            this.splContSecSubSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splContSecSubSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContSecSubSec.Location = new System.Drawing.Point(0, 0);
            this.splContSecSubSec.Name = "splContSecSubSec";
            // 
            // splContSecSubSec.Panel1
            // 
            this.splContSecSubSec.Panel1.Controls.Add(this.dgvClassificationMaster);
            // 
            // splContSecSubSec.Panel2
            // 
            this.splContSecSubSec.Panel2.Controls.Add(this.dgvSYsNos);
            this.splContSecSubSec.Panel2.Controls.Add(this.pnlSearch);
            this.splContSecSubSec.Size = new System.Drawing.Size(980, 405);
            this.splContSecSubSec.SplitterDistance = 487;
            this.splContSecSubSec.TabIndex = 7;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.lblTan);
            this.pnlSearch.Controls.Add(this.txtSrchSysNo);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(487, 32);
            this.pnlSearch.TabIndex = 7;
            // 
            // lblTan
            // 
            this.lblTan.AutoSize = true;
            this.lblTan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTan.ForeColor = System.Drawing.Color.Black;
            this.lblTan.Location = new System.Drawing.Point(5, 8);
            this.lblTan.Name = "lblTan";
            this.lblTan.Size = new System.Drawing.Size(85, 15);
            this.lblTan.TabIndex = 207;
            this.lblTan.Text = "Search SysNo";
            // 
            // txtSrchSysNo
            // 
            this.txtSrchSysNo.Location = new System.Drawing.Point(96, 4);
            this.txtSrchSysNo.Name = "txtSrchSysNo";
            this.txtSrchSysNo.Size = new System.Drawing.Size(379, 22);
            this.txtSrchSysNo.TabIndex = 0;
            this.txtSrchSysNo.TextChanged += new System.EventHandler(this.txtSrchSysNo_TextChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.splContSecSubSec);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 460);
            this.pnlMain.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SECTION_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Section ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 259;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SECTION_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Section Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SECTION_CODE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Section Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 260;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DISPLAY_ORDER";
            this.dataGridViewTextBoxColumn4.HeaderText = "Display Order";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 260;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SECTION_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sec.No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SECTION_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sub Section Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 334;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Sub Section Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 334;
            // 
            // frmSYSNoMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 460);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSYSNoMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSNo Master";
            this.Load += new System.EventHandler(this.frmSYSNoMaster_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificationMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSYsNos)).EndInit();
            this.splContSecSubSec.Panel1.ResumeLayout(false);
            this.splContSecSubSec.Panel2.ResumeLayout(false);
            this.splContSecSubSec.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvClassificationMaster;
        private System.Windows.Forms.DataGridView dgvSYsNos;
        private System.Windows.Forms.SplitContainer splContSecSubSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TextBox txtSelectedSysNo;
        public System.Windows.Forms.TextBox txtSelectedSysText;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSelectedClassType;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTan;
        private System.Windows.Forms.TextBox txtSrchSysNo;
    }
}