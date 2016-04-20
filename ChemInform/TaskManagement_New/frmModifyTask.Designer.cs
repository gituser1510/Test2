namespace ChemInform.TaskManagement_New
{
    partial class frmModifyTask
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
            this.pnlGrids = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlAssignContrls = new System.Windows.Forms.Panel();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnReAssignTask = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblHelpNote = new System.Windows.Forms.Label();
            this.txtModifyTaskSearch = new System.Windows.Forms.TextBox();
            this.lblSearchTans = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.dgvUserTasks = new System.Windows.Forms.DataGridView();
            this.lblAllocatedTans = new System.Windows.Forms.Label();
            this.dgvReallocateToUser = new System.Windows.Forms.DataGridView();
            this.colReallocateToUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReallocateToRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReallocateToURID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReallocateToAssignedCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReallocteToInPrgressCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.chkReallocateSelectTan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRellocateTanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReallocateTanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskAllocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlGrids.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlAssignContrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReallocateToUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGrids);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 475);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlGrids
            // 
            this.pnlGrids.BackColor = System.Drawing.Color.White;
            this.pnlGrids.Controls.Add(this.pnlControls);
            this.pnlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrids.Location = new System.Drawing.Point(0, 0);
            this.pnlGrids.Name = "pnlGrids";
            this.pnlGrids.Size = new System.Drawing.Size(980, 475);
            this.pnlGrids.TabIndex = 30;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.pnlAssignContrls);
            this.pnlControls.Controls.Add(this.lblHelpNote);
            this.pnlControls.Controls.Add(this.txtModifyTaskSearch);
            this.pnlControls.Controls.Add(this.lblSearchTans);
            this.pnlControls.Controls.Add(this.cmbRole);
            this.pnlControls.Controls.Add(this.lblRole);
            this.pnlControls.Controls.Add(this.cmbUsers);
            this.pnlControls.Controls.Add(this.dgvUserTasks);
            this.pnlControls.Controls.Add(this.lblAllocatedTans);
            this.pnlControls.Controls.Add(this.dgvReallocateToUser);
            this.pnlControls.Controls.Add(this.lblUserName);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(980, 475);
            this.pnlControls.TabIndex = 2;
            // 
            // pnlAssignContrls
            // 
            this.pnlAssignContrls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAssignContrls.Controls.Add(this.btnCancelTask);
            this.pnlAssignContrls.Controls.Add(this.btnReAssignTask);
            this.pnlAssignContrls.Controls.Add(this.lblSelected);
            this.pnlAssignContrls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssignContrls.Location = new System.Drawing.Point(0, 444);
            this.pnlAssignContrls.Name = "pnlAssignContrls";
            this.pnlAssignContrls.Size = new System.Drawing.Size(980, 31);
            this.pnlAssignContrls.TabIndex = 82;
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTask.Location = new System.Drawing.Point(809, 1);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(78, 26);
            this.btnCancelTask.TabIndex = 50;
            this.btnCancelTask.Text = "Cancel";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnReAssignTask
            // 
            this.btnReAssignTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReAssignTask.Location = new System.Drawing.Point(893, 1);
            this.btnReAssignTask.Name = "btnReAssignTask";
            this.btnReAssignTask.Size = new System.Drawing.Size(78, 26);
            this.btnReAssignTask.TabIndex = 5;
            this.btnReAssignTask.Text = "Re-Assign";
            this.btnReAssignTask.UseVisualStyleBackColor = true;
            this.btnReAssignTask.Click += new System.EventHandler(this.btnReAssign_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(3, 5);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(184, 17);
            this.lblSelected.TabIndex = 49;
            this.lblSelected.Text = "Selected References count : 0";
            // 
            // lblHelpNote
            // 
            this.lblHelpNote.AutoSize = true;
            this.lblHelpNote.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpNote.Location = new System.Drawing.Point(10, 58);
            this.lblHelpNote.Name = "lblHelpNote";
            this.lblHelpNote.Size = new System.Drawing.Size(105, 15);
            this.lblHelpNote.TabIndex = 79;
            this.lblHelpNote.Text = "*Use ; as delimiter";
            this.lblHelpNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModifyTaskSearch
            // 
            this.txtModifyTaskSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifyTaskSearch.Location = new System.Drawing.Point(120, 34);
            this.txtModifyTaskSearch.Multiline = true;
            this.txtModifyTaskSearch.Name = "txtModifyTaskSearch";
            this.txtModifyTaskSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModifyTaskSearch.Size = new System.Drawing.Size(856, 43);
            this.txtModifyTaskSearch.TabIndex = 76;
            this.txtModifyTaskSearch.TextChanged += new System.EventHandler(this.txtModifyTaskSearch_TextChanged);
            // 
            // lblSearchTans
            // 
            this.lblSearchTans.AutoSize = true;
            this.lblSearchTans.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTans.Location = new System.Drawing.Point(2, 37);
            this.lblSearchTans.Name = "lblSearchTans";
            this.lblSearchTans.Size = new System.Drawing.Size(115, 17);
            this.lblSearchTans.TabIndex = 75;
            this.lblSearchTans.Text = "Search Reference";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(121, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(196, 25);
            this.cmbRole.TabIndex = 2;
            this.cmbRole.SelectionChangeCommitted += new System.EventHandler(this.cmbRole_SelectionChangeCommitted);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(80, 9);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 17);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(414, 5);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(250, 25);
            this.cmbUsers.TabIndex = 3;
            this.cmbUsers.SelectionChangeCommitted += new System.EventHandler(this.cmbUsers_SelectionChangeCommitted);
            // 
            // dgvUserTasks
            // 
            this.dgvUserTasks.AllowUserToAddRows = false;
            this.dgvUserTasks.AllowUserToDeleteRows = false;
            this.dgvUserTasks.AllowUserToResizeRows = false;
            this.dgvUserTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkReallocateSelectTan,
            this.colRellocateTanId,
            this.colReallocateTanName,
            this.colTaskId,
            this.colTaskAllocId,
            this.colTaskStatus});
            this.dgvUserTasks.Location = new System.Drawing.Point(3, 81);
            this.dgvUserTasks.MultiSelect = false;
            this.dgvUserTasks.Name = "dgvUserTasks";
            this.dgvUserTasks.Size = new System.Drawing.Size(973, 176);
            this.dgvUserTasks.TabIndex = 1;
            this.dgvUserTasks.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvModify_RowPostPaint);
            this.dgvUserTasks.SelectionChanged += new System.EventHandler(this.dgvModify_SelectionChanged);
            // 
            // lblAllocatedTans
            // 
            this.lblAllocatedTans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllocatedTans.AutoSize = true;
            this.lblAllocatedTans.Location = new System.Drawing.Point(2, 264);
            this.lblAllocatedTans.Name = "lblAllocatedTans";
            this.lblAllocatedTans.Size = new System.Drawing.Size(177, 17);
            this.lblAllocatedTans.TabIndex = 41;
            this.lblAllocatedTans.Text = "Users Allocated References:";
            // 
            // dgvReallocateToUser
            // 
            this.dgvReallocateToUser.AllowUserToAddRows = false;
            this.dgvReallocateToUser.AllowUserToDeleteRows = false;
            this.dgvReallocateToUser.AllowUserToResizeRows = false;
            this.dgvReallocateToUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReallocateToUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReallocateToUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReallocateToUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReallocateToUserName,
            this.colReallocateToRoleName,
            this.colReallocateToURID,
            this.colReallocateToAssignedCnt,
            this.colReallocteToInPrgressCnt});
            this.dgvReallocateToUser.Location = new System.Drawing.Point(2, 287);
            this.dgvReallocateToUser.MultiSelect = false;
            this.dgvReallocateToUser.Name = "dgvReallocateToUser";
            this.dgvReallocateToUser.ReadOnly = true;
            this.dgvReallocateToUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReallocateToUser.Size = new System.Drawing.Size(974, 154);
            this.dgvReallocateToUser.TabIndex = 50;
            this.dgvReallocateToUser.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvReallocateTo_RowPostPaint);
            // 
            // colReallocateToUserName
            // 
            this.colReallocateToUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReallocateToUserName.DataPropertyName = "USER_NAME";
            this.colReallocateToUserName.HeaderText = "User Name";
            this.colReallocateToUserName.Name = "colReallocateToUserName";
            this.colReallocateToUserName.ReadOnly = true;
            // 
            // colReallocateToRoleName
            // 
            this.colReallocateToRoleName.DataPropertyName = "ROLE_NAME";
            this.colReallocateToRoleName.HeaderText = "Role";
            this.colReallocateToRoleName.Name = "colReallocateToRoleName";
            this.colReallocateToRoleName.ReadOnly = true;
            this.colReallocateToRoleName.Width = 140;
            // 
            // colReallocateToURID
            // 
            this.colReallocateToURID.DataPropertyName = "UR_ID";
            this.colReallocateToURID.HeaderText = "UR_ID";
            this.colReallocateToURID.Name = "colReallocateToURID";
            this.colReallocateToURID.ReadOnly = true;
            this.colReallocateToURID.Visible = false;
            // 
            // colReallocateToAssignedCnt
            // 
            this.colReallocateToAssignedCnt.DataPropertyName = "ASSIGNED_CNT";
            this.colReallocateToAssignedCnt.HeaderText = "Assigned";
            this.colReallocateToAssignedCnt.Name = "colReallocateToAssignedCnt";
            this.colReallocateToAssignedCnt.ReadOnly = true;
            // 
            // colReallocteToInPrgressCnt
            // 
            this.colReallocteToInPrgressCnt.DataPropertyName = "PROGRESS_CNT";
            this.colReallocteToInPrgressCnt.HeaderText = "In Progress";
            this.colReallocteToInPrgressCnt.Name = "colReallocteToInPrgressCnt";
            this.colReallocteToInPrgressCnt.ReadOnly = true;
            this.colReallocteToInPrgressCnt.Width = 130;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(332, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "FALSE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "TRUE";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TAN_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tan Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TAN_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "TAN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DISPLAY_SECTION_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Section";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TASK_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Task Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TASK_ALLOC_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Task Alloc Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ALLOCATION_STATUS";
            this.dataGridViewTextBoxColumn6.HeaderText = "Task Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "USER_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ROLE_NAME";
            this.dataGridViewTextBoxColumn8.HeaderText = "Role";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UR_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "UR_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ASSIGNED_CNT";
            this.dataGridViewTextBoxColumn10.HeaderText = "Assigned";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PROGRESS_CNT";
            this.dataGridViewTextBoxColumn11.HeaderText = "In Progress";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 130;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "COMPLETED_CNT";
            this.dataGridViewTextBoxColumn12.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // chkReallocateSelectTan
            // 
            this.chkReallocateSelectTan.FalseValue = "false";
            this.chkReallocateSelectTan.HeaderText = "";
            this.chkReallocateSelectTan.Name = "chkReallocateSelectTan";
            this.chkReallocateSelectTan.TrueValue = "true";
            // 
            // colRellocateTanId
            // 
            this.colRellocateTanId.DataPropertyName = "SHIPMENT_REF_ID";
            this.colRellocateTanId.HeaderText = "ShipmentRefId";
            this.colRellocateTanId.Name = "colRellocateTanId";
            this.colRellocateTanId.ReadOnly = true;
            this.colRellocateTanId.Visible = false;
            // 
            // colReallocateTanName
            // 
            this.colReallocateTanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReallocateTanName.DataPropertyName = "REFERENCE_NAME";
            this.colReallocateTanName.HeaderText = "Ref.Name";
            this.colReallocateTanName.Name = "colReallocateTanName";
            this.colReallocateTanName.ReadOnly = true;
            // 
            // colTaskId
            // 
            this.colTaskId.DataPropertyName = "TASK_ID";
            this.colTaskId.HeaderText = "Task Id";
            this.colTaskId.Name = "colTaskId";
            this.colTaskId.ReadOnly = true;
            this.colTaskId.Visible = false;
            // 
            // colTaskAllocId
            // 
            this.colTaskAllocId.DataPropertyName = "TASK_ALLOC_ID";
            this.colTaskAllocId.HeaderText = "Task Alloc Id";
            this.colTaskAllocId.Name = "colTaskAllocId";
            this.colTaskAllocId.ReadOnly = true;
            this.colTaskAllocId.Visible = false;
            // 
            // colTaskStatus
            // 
            this.colTaskStatus.DataPropertyName = "ALLOCATION_STATUS";
            this.colTaskStatus.HeaderText = "Task Status";
            this.colTaskStatus.Name = "colTaskStatus";
            this.colTaskStatus.ReadOnly = true;
            this.colTaskStatus.Width = 250;
            // 
            // frmModifyTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(980, 475);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmModifyTask";
            this.ShowIcon = false;
            this.Text = "Modify / Cancel Task";
            this.Load += new System.EventHandler(this.frmModifyTask_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlGrids.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlAssignContrls.ResumeLayout(false);
            this.pnlAssignContrls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReallocateToUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlGrids;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlAssignContrls;
        private System.Windows.Forms.Button btnReAssignTask;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblHelpNote;
        private System.Windows.Forms.TextBox txtModifyTaskSearch;
        private System.Windows.Forms.Label lblSearchTans;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridView dgvUserTasks;
        private System.Windows.Forms.Label lblAllocatedTans;
        private System.Windows.Forms.DataGridView dgvReallocateToUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocateToUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocateToRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocateToURID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocateToAssignedCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocteToInPrgressCnt;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkReallocateSelectTan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRellocateTanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReallocateTanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskAllocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStatus;
    }
}