namespace ChemInform
{
    partial class frmBatchExport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splCont = new System.Windows.Forms.SplitContainer();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.chkSkipQcCheck = new System.Windows.Forms.CheckBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblReAssCur_Cnt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblReAssRev_Cnt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReAssQC_Cnt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAssQC_Cnt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAssRev_Cnt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAssCur_Cnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCur_Done_Cnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRev_Done_Cnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQC_Done_Cnt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelRefCnt = new System.Windows.Forms.Label();
            this.lblSelRefs = new System.Windows.Forms.Label();
            this.lblAvlRefCnt = new System.Windows.Forms.Label();
            this.lblAvailRefs = new System.Windows.Forms.Label();
            this.dgvSelectedRefs = new System.Windows.Forms.DataGridView();
            this.btnDelOne = new System.Windows.Forms.Button();
            this.btnSelOne = new System.Windows.Forms.Button();
            this.dgvAvailableRefs = new System.Windows.Forms.DataGridView();
            this.dgvRDFRefs = new System.Windows.Forms.DataGridView();
            this.pnlXML = new System.Windows.Forms.Panel();
            this.lblRdfRefCnt = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTAN = new System.Windows.Forms.Label();
            this.txtRefSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShipmentName = new System.Windows.Forms.TextBox();
            this.btnGetShipmentRefs = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.chkExpClientDelivery = new System.Windows.Forms.CheckBox();
            this.lblStartMdl = new System.Windows.Forms.Label();
            this.txtMDLNo = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnGenerateRDF = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefID_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReference_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysClassType_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnCnt_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefStatus_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelivered_Sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipmentRefID_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefName_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysClassType_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnCnt_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefStatus_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelivered_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefID_RDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReference_RDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysClassType_Rdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRxnCnt_RDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipment_RDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefStatus_RDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelivered_Rdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.splCont.Panel1.SuspendLayout();
            this.splCont.Panel2.SuspendLayout();
            this.splCont.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedRefs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRefs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDFRefs)).BeginInit();
            this.pnlXML.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splCont);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1229, 644);
            this.pnlMain.TabIndex = 0;
            // 
            // splCont
            // 
            this.splCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont.Location = new System.Drawing.Point(0, 31);
            this.splCont.Name = "splCont";
            this.splCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCont.Panel1
            // 
            this.splCont.Panel1.Controls.Add(this.pnlGrid);
            // 
            // splCont.Panel2
            // 
            this.splCont.Panel2.Controls.Add(this.dgvRDFRefs);
            this.splCont.Panel2.Controls.Add(this.pnlXML);
            this.splCont.Size = new System.Drawing.Size(1229, 582);
            this.splCont.SplitterDistance = 370;
            this.splCont.SplitterWidth = 2;
            this.splCont.TabIndex = 13;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.chkSkipQcCheck);
            this.pnlGrid.Controls.Add(this.pnlStatus);
            this.pnlGrid.Controls.Add(this.lblSelRefCnt);
            this.pnlGrid.Controls.Add(this.lblSelRefs);
            this.pnlGrid.Controls.Add(this.lblAvlRefCnt);
            this.pnlGrid.Controls.Add(this.lblAvailRefs);
            this.pnlGrid.Controls.Add(this.dgvSelectedRefs);
            this.pnlGrid.Controls.Add(this.btnDelOne);
            this.pnlGrid.Controls.Add(this.btnSelOne);
            this.pnlGrid.Controls.Add(this.dgvAvailableRefs);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1225, 366);
            this.pnlGrid.TabIndex = 9;
            // 
            // chkSkipQcCheck
            // 
            this.chkSkipQcCheck.AutoSize = true;
            this.chkSkipQcCheck.Location = new System.Drawing.Point(322, 3);
            this.chkSkipQcCheck.Name = "chkSkipQcCheck";
            this.chkSkipQcCheck.Size = new System.Drawing.Size(136, 21);
            this.chkSkipQcCheck.TabIndex = 36;
            this.chkSkipQcCheck.Text = "Skip QC validation";
            this.chkSkipQcCheck.UseVisualStyleBackColor = true;
            this.chkSkipQcCheck.Visible = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblReAssCur_Cnt);
            this.pnlStatus.Controls.Add(this.label14);
            this.pnlStatus.Controls.Add(this.lblReAssRev_Cnt);
            this.pnlStatus.Controls.Add(this.label13);
            this.pnlStatus.Controls.Add(this.lblReAssQC_Cnt);
            this.pnlStatus.Controls.Add(this.label12);
            this.pnlStatus.Controls.Add(this.lblAssQC_Cnt);
            this.pnlStatus.Controls.Add(this.label11);
            this.pnlStatus.Controls.Add(this.lblAssRev_Cnt);
            this.pnlStatus.Controls.Add(this.label10);
            this.pnlStatus.Controls.Add(this.lblAssCur_Cnt);
            this.pnlStatus.Controls.Add(this.label9);
            this.pnlStatus.Controls.Add(this.lblCur_Done_Cnt);
            this.pnlStatus.Controls.Add(this.label8);
            this.pnlStatus.Controls.Add(this.lblRev_Done_Cnt);
            this.pnlStatus.Controls.Add(this.label7);
            this.pnlStatus.Controls.Add(this.lblQC_Done_Cnt);
            this.pnlStatus.Controls.Add(this.label5);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 315);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1225, 51);
            this.pnlStatus.TabIndex = 35;
            // 
            // lblReAssCur_Cnt
            // 
            this.lblReAssCur_Cnt.AutoSize = true;
            this.lblReAssCur_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAssCur_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblReAssCur_Cnt.Location = new System.Drawing.Point(1054, 28);
            this.lblReAssCur_Cnt.Name = "lblReAssCur_Cnt";
            this.lblReAssCur_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblReAssCur_Cnt.TabIndex = 52;
            this.lblReAssCur_Cnt.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(886, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Re-Assigned for Curation:";
            // 
            // lblReAssRev_Cnt
            // 
            this.lblReAssRev_Cnt.AutoSize = true;
            this.lblReAssRev_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAssRev_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblReAssRev_Cnt.Location = new System.Drawing.Point(848, 28);
            this.lblReAssRev_Cnt.Name = "lblReAssRev_Cnt";
            this.lblReAssRev_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblReAssRev_Cnt.TabIndex = 50;
            this.lblReAssRev_Cnt.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(689, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Re-Assigned for Review:";
            // 
            // lblReAssQC_Cnt
            // 
            this.lblReAssQC_Cnt.AutoSize = true;
            this.lblReAssQC_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAssQC_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblReAssQC_Cnt.Location = new System.Drawing.Point(644, 28);
            this.lblReAssQC_Cnt.Name = "lblReAssQC_Cnt";
            this.lblReAssQC_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblReAssQC_Cnt.TabIndex = 48;
            this.lblReAssQC_Cnt.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Re-Assigned for QC:";
            // 
            // lblAssQC_Cnt
            // 
            this.lblAssQC_Cnt.AutoSize = true;
            this.lblAssQC_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssQC_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblAssQC_Cnt.Location = new System.Drawing.Point(644, 3);
            this.lblAssQC_Cnt.Name = "lblAssQC_Cnt";
            this.lblAssQC_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblAssQC_Cnt.TabIndex = 46;
            this.lblAssQC_Cnt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Assigned for QC:";
            // 
            // lblAssRev_Cnt
            // 
            this.lblAssRev_Cnt.AutoSize = true;
            this.lblAssRev_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssRev_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblAssRev_Cnt.Location = new System.Drawing.Point(847, 3);
            this.lblAssRev_Cnt.Name = "lblAssRev_Cnt";
            this.lblAssRev_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblAssRev_Cnt.TabIndex = 44;
            this.lblAssRev_Cnt.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(711, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Assigned for Review:";
            // 
            // lblAssCur_Cnt
            // 
            this.lblAssCur_Cnt.AutoSize = true;
            this.lblAssCur_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssCur_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblAssCur_Cnt.Location = new System.Drawing.Point(1054, 3);
            this.lblAssCur_Cnt.Name = "lblAssCur_Cnt";
            this.lblAssCur_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblAssCur_Cnt.TabIndex = 42;
            this.lblAssCur_Cnt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(908, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Assigned for Curation:";
            // 
            // lblCur_Done_Cnt
            // 
            this.lblCur_Done_Cnt.AutoSize = true;
            this.lblCur_Done_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCur_Done_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblCur_Done_Cnt.Location = new System.Drawing.Point(470, 3);
            this.lblCur_Done_Cnt.Name = "lblCur_Done_Cnt";
            this.lblCur_Done_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblCur_Done_Cnt.TabIndex = 40;
            this.lblCur_Done_Cnt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Curation Completed:";
            // 
            // lblRev_Done_Cnt
            // 
            this.lblRev_Done_Cnt.AutoSize = true;
            this.lblRev_Done_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRev_Done_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblRev_Done_Cnt.Location = new System.Drawing.Point(283, 3);
            this.lblRev_Done_Cnt.Name = "lblRev_Done_Cnt";
            this.lblRev_Done_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblRev_Done_Cnt.TabIndex = 38;
            this.lblRev_Done_Cnt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Review Completed:";
            // 
            // lblQC_Done_Cnt
            // 
            this.lblQC_Done_Cnt.AutoSize = true;
            this.lblQC_Done_Cnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQC_Done_Cnt.ForeColor = System.Drawing.Color.Red;
            this.lblQC_Done_Cnt.Location = new System.Drawing.Point(101, 3);
            this.lblQC_Done_Cnt.Name = "lblQC_Done_Cnt";
            this.lblQC_Done_Cnt.Size = new System.Drawing.Size(16, 17);
            this.lblQC_Done_Cnt.TabIndex = 36;
            this.lblQC_Done_Cnt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "QC Completed:";
            // 
            // lblSelRefCnt
            // 
            this.lblSelRefCnt.AutoSize = true;
            this.lblSelRefCnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelRefCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblSelRefCnt.Location = new System.Drawing.Point(809, 5);
            this.lblSelRefCnt.Name = "lblSelRefCnt";
            this.lblSelRefCnt.Size = new System.Drawing.Size(16, 17);
            this.lblSelRefCnt.TabIndex = 34;
            this.lblSelRefCnt.Text = "0";
            // 
            // lblSelRefs
            // 
            this.lblSelRefs.AutoSize = true;
            this.lblSelRefs.Location = new System.Drawing.Point(629, 5);
            this.lblSelRefs.Name = "lblSelRefs";
            this.lblSelRefs.Size = new System.Drawing.Size(169, 17);
            this.lblSelRefs.TabIndex = 32;
            this.lblSelRefs.Text = "Selected References Count";
            // 
            // lblAvlRefCnt
            // 
            this.lblAvlRefCnt.AutoSize = true;
            this.lblAvlRefCnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvlRefCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblAvlRefCnt.Location = new System.Drawing.Point(184, 4);
            this.lblAvlRefCnt.Name = "lblAvlRefCnt";
            this.lblAvlRefCnt.Size = new System.Drawing.Size(16, 17);
            this.lblAvlRefCnt.TabIndex = 31;
            this.lblAvlRefCnt.Text = "0";
            // 
            // lblAvailRefs
            // 
            this.lblAvailRefs.AutoSize = true;
            this.lblAvailRefs.Location = new System.Drawing.Point(3, 4);
            this.lblAvailRefs.Name = "lblAvailRefs";
            this.lblAvailRefs.Size = new System.Drawing.Size(173, 17);
            this.lblAvailRefs.TabIndex = 29;
            this.lblAvailRefs.Text = "Available References Count";
            // 
            // dgvSelectedRefs
            // 
            this.dgvSelectedRefs.AllowUserToAddRows = false;
            this.dgvSelectedRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSelectedRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedRefs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSelectedRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRefID_Sel,
            this.colReference_Sel,
            this.colSysClassType_Sel,
            this.colRxnCnt_Sel,
            this.colRefStatus_Sel,
            this.colIsDelivered_Sel});
            this.dgvSelectedRefs.Location = new System.Drawing.Point(631, 25);
            this.dgvSelectedRefs.Name = "dgvSelectedRefs";
            this.dgvSelectedRefs.ReadOnly = true;
            this.dgvSelectedRefs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvSelectedRefs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSelectedRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedRefs.Size = new System.Drawing.Size(590, 287);
            this.dgvSelectedRefs.TabIndex = 12;
            this.dgvSelectedRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSelectedTANs_RowPostPaint);
            // 
            // btnDelOne
            // 
            this.btnDelOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelOne.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOne.Location = new System.Drawing.Point(598, 178);
            this.btnDelOne.Name = "btnDelOne";
            this.btnDelOne.Size = new System.Drawing.Size(30, 41);
            this.btnDelOne.TabIndex = 11;
            this.btnDelOne.Text = "<";
            this.btnDelOne.UseVisualStyleBackColor = true;
            this.btnDelOne.Click += new System.EventHandler(this.btnDelOne_Click);
            // 
            // btnSelOne
            // 
            this.btnSelOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelOne.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelOne.Location = new System.Drawing.Point(598, 127);
            this.btnSelOne.Name = "btnSelOne";
            this.btnSelOne.Size = new System.Drawing.Size(30, 40);
            this.btnSelOne.TabIndex = 10;
            this.btnSelOne.Text = ">";
            this.btnSelOne.UseVisualStyleBackColor = true;
            this.btnSelOne.Click += new System.EventHandler(this.btnSelOne_Click);
            // 
            // dgvAvailableRefs
            // 
            this.dgvAvailableRefs.AllowUserToAddRows = false;
            this.dgvAvailableRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvAvailableRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableRefs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAvailableRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAvailableRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipmentRefID_Avail,
            this.colRefName_Avail,
            this.colSysClassType_Avail,
            this.colRxnCnt_Avail,
            this.colRefStatus_Avail,
            this.colIsDelivered_Avail});
            this.dgvAvailableRefs.Location = new System.Drawing.Point(0, 24);
            this.dgvAvailableRefs.Name = "dgvAvailableRefs";
            this.dgvAvailableRefs.ReadOnly = true;
            this.dgvAvailableRefs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAvailableRefs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAvailableRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableRefs.Size = new System.Drawing.Size(592, 288);
            this.dgvAvailableRefs.TabIndex = 0;
            this.dgvAvailableRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgTANs_RowPostPaint);
            // 
            // dgvRDFRefs
            // 
            this.dgvRDFRefs.AllowUserToAddRows = false;
            this.dgvRDFRefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvRDFRefs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRDFRefs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRDFRefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRDFRefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRefID_RDF,
            this.colReference_RDF,
            this.colSysClassType_Rdf,
            this.colRxnCnt_RDF,
            this.colShipment_RDF,
            this.colRefStatus_RDF,
            this.colIsDelivered_Rdf});
            this.dgvRDFRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRDFRefs.Location = new System.Drawing.Point(0, 31);
            this.dgvRDFRefs.Name = "dgvRDFRefs";
            this.dgvRDFRefs.ReadOnly = true;
            this.dgvRDFRefs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvRDFRefs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRDFRefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRDFRefs.Size = new System.Drawing.Size(1225, 175);
            this.dgvRDFRefs.TabIndex = 1;
            this.dgvRDFRefs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvXmlTANs_RowPostPaint);
            // 
            // pnlXML
            // 
            this.pnlXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlXML.Controls.Add(this.lblRdfRefCnt);
            this.pnlXML.Controls.Add(this.lbl);
            this.pnlXML.Controls.Add(this.btnAppend);
            this.pnlXML.Controls.Add(this.label4);
            this.pnlXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXML.Location = new System.Drawing.Point(0, 0);
            this.pnlXML.Name = "pnlXML";
            this.pnlXML.Size = new System.Drawing.Size(1225, 31);
            this.pnlXML.TabIndex = 14;
            // 
            // lblRdfRefCnt
            // 
            this.lblRdfRefCnt.AutoSize = true;
            this.lblRdfRefCnt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdfRefCnt.ForeColor = System.Drawing.Color.Blue;
            this.lblRdfRefCnt.Location = new System.Drawing.Point(300, 6);
            this.lblRdfRefCnt.Name = "lblRdfRefCnt";
            this.lblRdfRefCnt.Size = new System.Drawing.Size(16, 17);
            this.lblRdfRefCnt.TabIndex = 33;
            this.lblRdfRefCnt.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(244, 6);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 17);
            this.lbl.TabIndex = 32;
            this.lbl.Text = "Count: ";
            // 
            // btnAppend
            // 
            this.btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppend.AutoSize = true;
            this.btnAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.Location = new System.Drawing.Point(1147, 2);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(73, 25);
            this.btnAppend.TabIndex = 17;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "References for RDF files generation";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTAN);
            this.pnlTop.Controls.Add(this.txtRefSearch);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtShipmentName);
            this.pnlTop.Controls.Add(this.btnGetShipmentRefs);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1229, 31);
            this.pnlTop.TabIndex = 12;
            // 
            // lblTAN
            // 
            this.lblTAN.AutoSize = true;
            this.lblTAN.ForeColor = System.Drawing.Color.Black;
            this.lblTAN.Location = new System.Drawing.Point(547, 7);
            this.lblTAN.Name = "lblTAN";
            this.lblTAN.Size = new System.Drawing.Size(79, 17);
            this.lblTAN.TabIndex = 26;
            this.lblTAN.Text = "Ref. Search";
            // 
            // txtRefSearch
            // 
            this.txtRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefSearch.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtRefSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefSearch.ForeColor = System.Drawing.Color.Blue;
            this.txtRefSearch.Location = new System.Drawing.Point(633, 3);
            this.txtRefSearch.Name = "txtRefSearch";
            this.txtRefSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRefSearch.Size = new System.Drawing.Size(590, 25);
            this.txtRefSearch.TabIndex = 25;
            this.txtRefSearch.TextChanged += new System.EventHandler(this.txtRefSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment Name";
            // 
            // txtShipmentName
            // 
            this.txtShipmentName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipmentName.ForeColor = System.Drawing.Color.Red;
            this.txtShipmentName.Location = new System.Drawing.Point(107, 5);
            this.txtShipmentName.Name = "txtShipmentName";
            this.txtShipmentName.Size = new System.Drawing.Size(199, 21);
            this.txtShipmentName.TabIndex = 1;
            // 
            // btnGetShipmentRefs
            // 
            this.btnGetShipmentRefs.AutoSize = true;
            this.btnGetShipmentRefs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetShipmentRefs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetShipmentRefs.Location = new System.Drawing.Point(312, 3);
            this.btnGetShipmentRefs.Name = "btnGetShipmentRefs";
            this.btnGetShipmentRefs.Size = new System.Drawing.Size(80, 25);
            this.btnGetShipmentRefs.TabIndex = 8;
            this.btnGetShipmentRefs.Text = "Get";
            this.btnGetShipmentRefs.UseVisualStyleBackColor = true;
            this.btnGetShipmentRefs.Click += new System.EventHandler(this.btnGetShipmentRefs_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.chkExpClientDelivery);
            this.pnlBottom.Controls.Add(this.lblStartMdl);
            this.pnlBottom.Controls.Add(this.txtMDLNo);
            this.pnlBottom.Controls.Add(this.btnBrowse);
            this.pnlBottom.Controls.Add(this.label3);
            this.pnlBottom.Controls.Add(this.txtFolderPath);
            this.pnlBottom.Controls.Add(this.btnGenerateRDF);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 613);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1229, 31);
            this.pnlBottom.TabIndex = 10;
            // 
            // chkExpClientDelivery
            // 
            this.chkExpClientDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExpClientDelivery.AutoSize = true;
            this.chkExpClientDelivery.Location = new System.Drawing.Point(963, 3);
            this.chkExpClientDelivery.Name = "chkExpClientDelivery";
            this.chkExpClientDelivery.Size = new System.Drawing.Size(179, 21);
            this.chkExpClientDelivery.TabIndex = 43;
            this.chkExpClientDelivery.Text = "Export for Client Delivery";
            this.chkExpClientDelivery.UseVisualStyleBackColor = true;
            // 
            // lblStartMdl
            // 
            this.lblStartMdl.AutoSize = true;
            this.lblStartMdl.Location = new System.Drawing.Point(690, 6);
            this.lblStartMdl.Name = "lblStartMdl";
            this.lblStartMdl.Size = new System.Drawing.Size(98, 17);
            this.lblStartMdl.TabIndex = 42;
            this.lblStartMdl.Text = "Start MDL No.";
            // 
            // txtMDLNo
            // 
            this.txtMDLNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDLNo.ForeColor = System.Drawing.Color.Blue;
            this.txtMDLNo.Location = new System.Drawing.Point(789, 2);
            this.txtMDLNo.Name = "txtMDLNo";
            this.txtMDLNo.Size = new System.Drawing.Size(98, 25);
            this.txtMDLNo.TabIndex = 41;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(598, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 24);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output Folder Path";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.ForeColor = System.Drawing.Color.Black;
            this.txtFolderPath.Location = new System.Drawing.Point(127, 3);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(465, 21);
            this.txtFolderPath.TabIndex = 10;
            // 
            // btnGenerateRDF
            // 
            this.btnGenerateRDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRDF.AutoSize = true;
            this.btnGenerateRDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRDF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRDF.Location = new System.Drawing.Point(1148, 1);
            this.btnGenerateRDF.Name = "btnGenerateRDF";
            this.btnGenerateRDF.Size = new System.Drawing.Size(73, 25);
            this.btnGenerateRDF.TabIndex = 9;
            this.btnGenerateRDF.Text = "Generate";
            this.btnGenerateRDF.UseVisualStyleBackColor = true;
            this.btnGenerateRDF.Click += new System.EventHandler(this.btnGenerateRDF_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "BNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Rxns";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Freezed";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "TANStatus";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.FillWeight = 50F;
            this.dataGridViewTextBoxColumn7.HeaderText = "DocClass";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 127;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 50F;
            this.dataGridViewTextBoxColumn9.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.FillWeight = 50F;
            this.dataGridViewTextBoxColumn10.HeaderText = "BNo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.FillWeight = 50F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Type";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.FillWeight = 50F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Rxns";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 40;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.HeaderText = "Freezed";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.FillWeight = 50F;
            this.dataGridViewTextBoxColumn14.HeaderText = "TANStatus";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.FillWeight = 150F;
            this.dataGridViewTextBoxColumn15.HeaderText = "DocClass";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 40;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn16.FillWeight = 150F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 40;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn17.FillWeight = 150F;
            this.dataGridViewTextBoxColumn17.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 121;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn18.HeaderText = "Type";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 40;
            // 
            // colRefID_Sel
            // 
            this.colRefID_Sel.HeaderText = "Ref_ID";
            this.colRefID_Sel.Name = "colRefID_Sel";
            this.colRefID_Sel.ReadOnly = true;
            this.colRefID_Sel.Visible = false;
            // 
            // colReference_Sel
            // 
            this.colReference_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReference_Sel.HeaderText = "Reference";
            this.colReference_Sel.Name = "colReference_Sel";
            this.colReference_Sel.ReadOnly = true;
            this.colReference_Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSysClassType_Sel
            // 
            this.colSysClassType_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSysClassType_Sel.HeaderText = "Class";
            this.colSysClassType_Sel.Name = "colSysClassType_Sel";
            this.colSysClassType_Sel.ReadOnly = true;
            this.colSysClassType_Sel.Width = 50;
            // 
            // colRxnCnt_Sel
            // 
            this.colRxnCnt_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnCnt_Sel.FillWeight = 50F;
            this.colRxnCnt_Sel.HeaderText = "Rxns";
            this.colRxnCnt_Sel.Name = "colRxnCnt_Sel";
            this.colRxnCnt_Sel.ReadOnly = true;
            this.colRxnCnt_Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRxnCnt_Sel.Width = 40;
            // 
            // colRefStatus_Sel
            // 
            this.colRefStatus_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRefStatus_Sel.HeaderText = "Status";
            this.colRefStatus_Sel.Name = "colRefStatus_Sel";
            this.colRefStatus_Sel.ReadOnly = true;
            // 
            // colIsDelivered_Sel
            // 
            this.colIsDelivered_Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsDelivered_Sel.HeaderText = "Delivered";
            this.colIsDelivered_Sel.Name = "colIsDelivered_Sel";
            this.colIsDelivered_Sel.ReadOnly = true;
            this.colIsDelivered_Sel.Width = 60;
            // 
            // colShipmentRefID_Avail
            // 
            this.colShipmentRefID_Avail.HeaderText = "Ref_ID";
            this.colShipmentRefID_Avail.Name = "colShipmentRefID_Avail";
            this.colShipmentRefID_Avail.ReadOnly = true;
            this.colShipmentRefID_Avail.Visible = false;
            // 
            // colRefName_Avail
            // 
            this.colRefName_Avail.HeaderText = "Reference";
            this.colRefName_Avail.Name = "colRefName_Avail";
            this.colRefName_Avail.ReadOnly = true;
            // 
            // colSysClassType_Avail
            // 
            this.colSysClassType_Avail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSysClassType_Avail.HeaderText = "Class";
            this.colSysClassType_Avail.Name = "colSysClassType_Avail";
            this.colSysClassType_Avail.ReadOnly = true;
            this.colSysClassType_Avail.Width = 50;
            // 
            // colRxnCnt_Avail
            // 
            this.colRxnCnt_Avail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRxnCnt_Avail.FillWeight = 50F;
            this.colRxnCnt_Avail.HeaderText = "Rxns";
            this.colRxnCnt_Avail.Name = "colRxnCnt_Avail";
            this.colRxnCnt_Avail.ReadOnly = true;
            this.colRxnCnt_Avail.Width = 40;
            // 
            // colRefStatus_Avail
            // 
            this.colRefStatus_Avail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRefStatus_Avail.HeaderText = "Status";
            this.colRefStatus_Avail.Name = "colRefStatus_Avail";
            this.colRefStatus_Avail.ReadOnly = true;
            // 
            // colIsDelivered_Avail
            // 
            this.colIsDelivered_Avail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsDelivered_Avail.HeaderText = "Delivered";
            this.colIsDelivered_Avail.Name = "colIsDelivered_Avail";
            this.colIsDelivered_Avail.ReadOnly = true;
            this.colIsDelivered_Avail.Width = 70;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.FillWeight = 50F;
            this.dataGridViewTextBoxColumn19.HeaderText = "RxnCount";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn19.Visible = false;
            this.dataGridViewTextBoxColumn19.Width = 70;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.FillWeight = 150F;
            this.dataGridViewTextBoxColumn20.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.FillWeight = 50F;
            this.dataGridViewTextBoxColumn21.HeaderText = "BNo";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 60;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.FillWeight = 50F;
            this.dataGridViewTextBoxColumn22.HeaderText = "TAN Status";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.FillWeight = 150F;
            this.dataGridViewTextBoxColumn23.HeaderText = "Doc Class";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.FillWeight = 50F;
            this.dataGridViewTextBoxColumn24.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 60;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.HeaderText = "TAN Status";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Doc Class";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // colRefID_RDF
            // 
            this.colRefID_RDF.HeaderText = "Ref_ID";
            this.colRefID_RDF.Name = "colRefID_RDF";
            this.colRefID_RDF.ReadOnly = true;
            this.colRefID_RDF.Visible = false;
            // 
            // colReference_RDF
            // 
            this.colReference_RDF.HeaderText = "Reference";
            this.colReference_RDF.Name = "colReference_RDF";
            this.colReference_RDF.ReadOnly = true;
            this.colReference_RDF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReference_RDF.Width = 121;
            // 
            // colSysClassType_Rdf
            // 
            this.colSysClassType_Rdf.HeaderText = "Class";
            this.colSysClassType_Rdf.Name = "colSysClassType_Rdf";
            this.colSysClassType_Rdf.ReadOnly = true;
            // 
            // colRxnCnt_RDF
            // 
            this.colRxnCnt_RDF.FillWeight = 50F;
            this.colRxnCnt_RDF.HeaderText = "Rxns";
            this.colRxnCnt_RDF.Name = "colRxnCnt_RDF";
            this.colRxnCnt_RDF.ReadOnly = true;
            this.colRxnCnt_RDF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRxnCnt_RDF.Width = 70;
            // 
            // colShipment_RDF
            // 
            this.colShipment_RDF.FillWeight = 150F;
            this.colShipment_RDF.HeaderText = "Shipment";
            this.colShipment_RDF.Name = "colShipment_RDF";
            this.colShipment_RDF.ReadOnly = true;
            this.colShipment_RDF.Width = 150;
            // 
            // colRefStatus_RDF
            // 
            this.colRefStatus_RDF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRefStatus_RDF.HeaderText = "Status";
            this.colRefStatus_RDF.Name = "colRefStatus_RDF";
            this.colRefStatus_RDF.ReadOnly = true;
            // 
            // colIsDelivered_Rdf
            // 
            this.colIsDelivered_Rdf.HeaderText = "Delivered";
            this.colIsDelivered_Rdf.Name = "colIsDelivered_Rdf";
            this.colIsDelivered_Rdf.ReadOnly = true;
            // 
            // frmBatchExport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 644);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmBatchExport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch RDF";
            this.Load += new System.EventHandler(this.frmBatchXml_Load);
            this.pnlMain.ResumeLayout(false);
            this.splCont.Panel1.ResumeLayout(false);
            this.splCont.Panel2.ResumeLayout(false);
            this.splCont.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedRefs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRefs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDFRefs)).EndInit();
            this.pnlXML.ResumeLayout(false);
            this.pnlXML.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShipmentName;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnGenerateRDF;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnGetShipmentRefs;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvAvailableRefs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvRDFRefs;
        private System.Windows.Forms.Button btnDelOne;
        private System.Windows.Forms.Button btnSelOne;
        private System.Windows.Forms.DataGridView dgvSelectedRefs;
        private System.Windows.Forms.Label lblAvlRefCnt;
        private System.Windows.Forms.Label lblAvailRefs;
        private System.Windows.Forms.Label lblSelRefCnt;
        private System.Windows.Forms.Label lblSelRefs;
        private System.Windows.Forms.SplitContainer splCont;
        private System.Windows.Forms.Label lblTAN;
        private System.Windows.Forms.TextBox txtRefSearch;
        private System.Windows.Forms.Panel pnlXML;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRdfRefCnt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblQC_Done_Cnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCur_Done_Cnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRev_Done_Cnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAssQC_Cnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAssRev_Cnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAssCur_Cnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReAssCur_Cnt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblReAssRev_Cnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReAssQC_Cnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkSkipQcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.Label lblStartMdl;
        private System.Windows.Forms.TextBox txtMDLNo;
        private System.Windows.Forms.CheckBox chkExpClientDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefID_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysClassType_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnCnt_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefStatus_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelivered_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipmentRefID_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefName_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysClassType_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnCnt_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefStatus_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelivered_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefID_RDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference_RDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysClassType_Rdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRxnCnt_RDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipment_RDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefStatus_RDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelivered_Rdf;
    }
}