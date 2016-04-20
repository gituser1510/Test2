namespace ChemInform.UserControls
{
    partial class ucRxnParticipants
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MDL.Draw.Chemistry.Molecule molecule1 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences1 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            MDL.Draw.Chemistry.Molecule molecule2 = new MDL.Draw.Chemistry.Molecule();
            MDL.Draw.Renderer.Preferences.DisplayPreferences displayPreferences2 = new MDL.Draw.Renderer.Preferences.DisplayPreferences();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlParticipants = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.colParticipantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipantStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStructureImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colParticipantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipantStructNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipantGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditParticipant = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDeleteParticipant = new System.Windows.Forms.DataGridViewImageColumn();
            this.cntMnuTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newRowTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPartpntHdr = new System.Windows.Forms.Panel();
            this.lblPartpnt = new System.Windows.Forms.Label();
            this.txtStepYield = new System.Windows.Forms.TextBox();
            this.lblStepYield = new System.Windows.Forms.Label();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.pnlConditions = new System.Windows.Forms.Panel();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.dgvConditions = new System.Windows.Forms.DataGridView();
            this.colConditionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPressureUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionPh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionWarmUp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConditionCoolDown = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConditionIsReflux = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConditionOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConditionOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditCondition = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDeleteCondition = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblCondition = new System.Windows.Forms.Label();
            this.ChemRenditor = new MDL.Draw.Renditor.Renditor();
            this.reactantRenderer = new MDL.Draw.Renderer.Renderer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlMain.SuspendLayout();
            this.pnlParticipants.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.cntMnuTab.SuspendLayout();
            this.pnlPartpntHdr.SuspendLayout();
            this.pnlConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlParticipants);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 254);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlParticipants
            // 
            this.pnlParticipants.Controls.Add(this.splitContainer1);
            this.pnlParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParticipants.Location = new System.Drawing.Point(0, 0);
            this.pnlParticipants.Name = "pnlParticipants";
            this.pnlParticipants.Size = new System.Drawing.Size(980, 254);
            this.pnlParticipants.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvParticipants);
            this.splitContainer1.Panel1.Controls.Add(this.pnlPartpntHdr);
            this.splitContainer1.Panel1.Controls.Add(this.pnlConditions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reactantRenderer);
            this.splitContainer1.Size = new System.Drawing.Size(980, 254);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.TabIndex = 32;
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParticipantID,
            this.colParticipantName,
            this.colParticipantStructure,
            this.colStructureImage,
            this.colParticipantType,
            this.colParticipantStructNo,
            this.colParticipantGrade,
            this.colEditParticipant,
            this.colDeleteParticipant});
            this.dgvParticipants.ContextMenuStrip = this.cntMnuTab;
            this.dgvParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParticipants.Location = new System.Drawing.Point(0, 30);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaShell;
            this.dgvParticipants.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(632, 135);
            this.dgvParticipants.TabIndex = 13;
            this.dgvParticipants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellClick);
            this.dgvParticipants.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParticipants_CellMouseClick);
            this.dgvParticipants.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_RowEnter);
            this.dgvParticipants.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvParticipants_RowPostPaint);
            // 
            // colParticipantID
            // 
            this.colParticipantID.HeaderText = "ParticipantID";
            this.colParticipantID.Name = "colParticipantID";
            this.colParticipantID.ReadOnly = true;
            this.colParticipantID.Visible = false;
            // 
            // colParticipantName
            // 
            this.colParticipantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParticipantName.HeaderText = "Name";
            this.colParticipantName.Name = "colParticipantName";
            this.colParticipantName.ReadOnly = true;
            // 
            // colParticipantStructure
            // 
            this.colParticipantStructure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colParticipantStructure.HeaderText = "Structure";
            this.colParticipantStructure.Name = "colParticipantStructure";
            this.colParticipantStructure.ReadOnly = true;
            this.colParticipantStructure.Visible = false;
            // 
            // colStructureImage
            // 
            this.colStructureImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStructureImage.HeaderText = "Structure";
            this.colStructureImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colStructureImage.Name = "colStructureImage";
            this.colStructureImage.ReadOnly = true;
            this.colStructureImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStructureImage.Visible = false;
            this.colStructureImage.Width = 80;
            // 
            // colParticipantType
            // 
            this.colParticipantType.HeaderText = "Type";
            this.colParticipantType.Name = "colParticipantType";
            this.colParticipantType.ReadOnly = true;
            // 
            // colParticipantStructNo
            // 
            this.colParticipantStructNo.HeaderText = "StructureNo";
            this.colParticipantStructNo.Name = "colParticipantStructNo";
            this.colParticipantStructNo.ReadOnly = true;
            // 
            // colParticipantGrade
            // 
            this.colParticipantGrade.HeaderText = "Grade";
            this.colParticipantGrade.Name = "colParticipantGrade";
            this.colParticipantGrade.ReadOnly = true;
            // 
            // colEditParticipant
            // 
            this.colEditParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEditParticipant.HeaderText = "Edit";
            this.colEditParticipant.Image = global::ChemInform.Properties.Resources.Edit;
            this.colEditParticipant.Name = "colEditParticipant";
            this.colEditParticipant.ReadOnly = true;
            this.colEditParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditParticipant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditParticipant.ToolTipText = "Edit Participant";
            this.colEditParticipant.Width = 40;
            // 
            // colDeleteParticipant
            // 
            this.colDeleteParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDeleteParticipant.HeaderText = "Delete";
            this.colDeleteParticipant.Image = global::ChemInform.Properties.Resources.delete_row;
            this.colDeleteParticipant.Name = "colDeleteParticipant";
            this.colDeleteParticipant.ReadOnly = true;
            this.colDeleteParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteParticipant.ToolTipText = "Delete Participant";
            this.colDeleteParticipant.Width = 40;
            // 
            // cntMnuTab
            // 
            this.cntMnuTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRowTSMenuItem});
            this.cntMnuTab.Name = "cntMnuTab";
            this.cntMnuTab.Size = new System.Drawing.Size(125, 26);
            // 
            // newRowTSMenuItem
            // 
            this.newRowTSMenuItem.Name = "newRowTSMenuItem";
            this.newRowTSMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newRowTSMenuItem.Text = "New Row";
            this.newRowTSMenuItem.Click += new System.EventHandler(this.newRowTSMenuItem_Click);
            // 
            // pnlPartpntHdr
            // 
            this.pnlPartpntHdr.BackColor = System.Drawing.Color.SeaShell;
            this.pnlPartpntHdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartpntHdr.Controls.Add(this.lblPartpnt);
            this.pnlPartpntHdr.Controls.Add(this.txtStepYield);
            this.pnlPartpntHdr.Controls.Add(this.lblStepYield);
            this.pnlPartpntHdr.Controls.Add(this.btnAddParticipant);
            this.pnlPartpntHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPartpntHdr.Location = new System.Drawing.Point(0, 0);
            this.pnlPartpntHdr.Name = "pnlPartpntHdr";
            this.pnlPartpntHdr.Size = new System.Drawing.Size(632, 30);
            this.pnlPartpntHdr.TabIndex = 18;
            // 
            // lblPartpnt
            // 
            this.lblPartpnt.AutoSize = true;
            this.lblPartpnt.Location = new System.Drawing.Point(2, 5);
            this.lblPartpnt.Name = "lblPartpnt";
            this.lblPartpnt.Size = new System.Drawing.Size(77, 17);
            this.lblPartpnt.TabIndex = 18;
            this.lblPartpnt.Text = "Participants";
            // 
            // txtStepYield
            // 
            this.txtStepYield.Location = new System.Drawing.Point(256, 1);
            this.txtStepYield.Name = "txtStepYield";
            this.txtStepYield.Size = new System.Drawing.Size(124, 25);
            this.txtStepYield.TabIndex = 10;
            // 
            // lblStepYield
            // 
            this.lblStepYield.AutoSize = true;
            this.lblStepYield.Location = new System.Drawing.Point(186, 5);
            this.lblStepYield.Name = "lblStepYield";
            this.lblStepYield.Size = new System.Drawing.Size(67, 17);
            this.lblStepYield.TabIndex = 9;
            this.lblStepYield.Text = "Step Yield\r\n";
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddParticipant.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddParticipant.Location = new System.Drawing.Point(85, 1);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(45, 26);
            this.btnAddParticipant.TabIndex = 17;
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // pnlConditions
            // 
            this.pnlConditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConditions.Controls.Add(this.btnAddCondition);
            this.pnlConditions.Controls.Add(this.dgvConditions);
            this.pnlConditions.Controls.Add(this.lblCondition);
            this.pnlConditions.Controls.Add(this.ChemRenditor);
            this.pnlConditions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConditions.Location = new System.Drawing.Point(0, 165);
            this.pnlConditions.Name = "pnlConditions";
            this.pnlConditions.Size = new System.Drawing.Size(632, 89);
            this.pnlConditions.TabIndex = 11;
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCondition.Image = global::ChemInform.Properties.Resources.Add;
            this.btnAddCondition.Location = new System.Drawing.Point(85, 1);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(45, 26);
            this.btnAddCondition.TabIndex = 16;
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // dgvConditions
            // 
            this.dgvConditions.AllowUserToAddRows = false;
            this.dgvConditions.AllowUserToDeleteRows = false;
            this.dgvConditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConditionID,
            this.colConditionTime,
            this.colTimeUnits,
            this.colConditionTemp,
            this.colTempUnits,
            this.colConditionPressure,
            this.colPressureUnits,
            this.colConditionPh,
            this.colConditionWarmUp,
            this.colConditionCoolDown,
            this.colConditionIsReflux,
            this.colConditionOther,
            this.colConditionOperation,
            this.colEditCondition,
            this.colDeleteCondition});
            this.dgvConditions.ContextMenuStrip = this.cntMnuTab;
            this.dgvConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConditions.Location = new System.Drawing.Point(0, 26);
            this.dgvConditions.Name = "dgvConditions";
            this.dgvConditions.ReadOnly = true;
            this.dgvConditions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaShell;
            this.dgvConditions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConditions.Size = new System.Drawing.Size(630, 61);
            this.dgvConditions.TabIndex = 1;
            this.dgvConditions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConditions_CellClick);
            this.dgvConditions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConditions_CellMouseClick);
            this.dgvConditions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvConditions_RowPostPaint);
            // 
            // colConditionID
            // 
            this.colConditionID.HeaderText = "ConditionID";
            this.colConditionID.Name = "colConditionID";
            this.colConditionID.ReadOnly = true;
            this.colConditionID.Visible = false;
            // 
            // colConditionTime
            // 
            this.colConditionTime.FillWeight = 19.7518F;
            this.colConditionTime.HeaderText = "Time";
            this.colConditionTime.Name = "colConditionTime";
            this.colConditionTime.ReadOnly = true;
            // 
            // colTimeUnits
            // 
            this.colTimeUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTimeUnits.HeaderText = "TimeUnits";
            this.colTimeUnits.Name = "colTimeUnits";
            this.colTimeUnits.ReadOnly = true;
            this.colTimeUnits.Width = 60;
            // 
            // colConditionTemp
            // 
            this.colConditionTemp.FillWeight = 15.39428F;
            this.colConditionTemp.HeaderText = "Temp";
            this.colConditionTemp.Name = "colConditionTemp";
            this.colConditionTemp.ReadOnly = true;
            // 
            // colTempUnits
            // 
            this.colTempUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTempUnits.HeaderText = "TempUnits";
            this.colTempUnits.Name = "colTempUnits";
            this.colTempUnits.ReadOnly = true;
            this.colTempUnits.Width = 60;
            // 
            // colConditionPressure
            // 
            this.colConditionPressure.FillWeight = 24.43059F;
            this.colConditionPressure.HeaderText = "Pressure";
            this.colConditionPressure.Name = "colConditionPressure";
            this.colConditionPressure.ReadOnly = true;
            // 
            // colPressureUnits
            // 
            this.colPressureUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPressureUnits.HeaderText = "PresUnits";
            this.colPressureUnits.Name = "colPressureUnits";
            this.colPressureUnits.ReadOnly = true;
            this.colPressureUnits.Width = 50;
            // 
            // colConditionPh
            // 
            this.colConditionPh.FillWeight = 11.54409F;
            this.colConditionPh.HeaderText = "pH";
            this.colConditionPh.Name = "colConditionPh";
            this.colConditionPh.ReadOnly = true;
            this.colConditionPh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colConditionWarmUp
            // 
            this.colConditionWarmUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colConditionWarmUp.FalseValue = "N";
            this.colConditionWarmUp.FillWeight = 30F;
            this.colConditionWarmUp.HeaderText = "WarmUp";
            this.colConditionWarmUp.Name = "colConditionWarmUp";
            this.colConditionWarmUp.ReadOnly = true;
            this.colConditionWarmUp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConditionWarmUp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConditionWarmUp.TrueValue = "Y";
            this.colConditionWarmUp.Width = 70;
            // 
            // colConditionCoolDown
            // 
            this.colConditionCoolDown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colConditionCoolDown.FalseValue = "N";
            this.colConditionCoolDown.FillWeight = 50F;
            this.colConditionCoolDown.HeaderText = "CoolDown";
            this.colConditionCoolDown.Name = "colConditionCoolDown";
            this.colConditionCoolDown.ReadOnly = true;
            this.colConditionCoolDown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConditionCoolDown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConditionCoolDown.TrueValue = "Y";
            this.colConditionCoolDown.Width = 75;
            // 
            // colConditionIsReflux
            // 
            this.colConditionIsReflux.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colConditionIsReflux.FalseValue = "N";
            this.colConditionIsReflux.FillWeight = 137.0557F;
            this.colConditionIsReflux.HeaderText = "IsReflux";
            this.colConditionIsReflux.Name = "colConditionIsReflux";
            this.colConditionIsReflux.ReadOnly = true;
            this.colConditionIsReflux.TrueValue = "Y";
            this.colConditionIsReflux.Width = 60;
            // 
            // colConditionOther
            // 
            this.colConditionOther.FillWeight = 19.3956F;
            this.colConditionOther.HeaderText = "Other";
            this.colConditionOther.Name = "colConditionOther";
            this.colConditionOther.ReadOnly = true;
            // 
            // colConditionOperation
            // 
            this.colConditionOperation.FillWeight = 30.5382F;
            this.colConditionOperation.HeaderText = "Operation";
            this.colConditionOperation.Name = "colConditionOperation";
            this.colConditionOperation.ReadOnly = true;
            // 
            // colEditCondition
            // 
            this.colEditCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEditCondition.FillWeight = 20.97376F;
            this.colEditCondition.HeaderText = "Edit";
            this.colEditCondition.Image = global::ChemInform.Properties.Resources.Edit;
            this.colEditCondition.Name = "colEditCondition";
            this.colEditCondition.ReadOnly = true;
            this.colEditCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditCondition.Width = 40;
            // 
            // colDeleteCondition
            // 
            this.colDeleteCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDeleteCondition.FillWeight = 20.35337F;
            this.colDeleteCondition.HeaderText = "Delete";
            this.colDeleteCondition.Image = global::ChemInform.Properties.Resources.delete_row;
            this.colDeleteCondition.Name = "colDeleteCondition";
            this.colDeleteCondition.ReadOnly = true;
            this.colDeleteCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteCondition.Width = 40;
            // 
            // lblCondition
            // 
            this.lblCondition.BackColor = System.Drawing.Color.SeaShell;
            this.lblCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCondition.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(0, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(630, 26);
            this.lblCondition.TabIndex = 10;
            this.lblCondition.Text = "Conditions";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChemRenditor
            // 
            this.ChemRenditor.AutoSizeStructure = true;
            this.ChemRenditor.BinHexSketch = "010300044122001F4372656174656420627920416363656C7279734472617720342E312E312E34020" +
    "40000005805000000005905000000000B0B0005417269616C780000140200";
            this.ChemRenditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChemRenditor.ChimeString = null;
            this.ChemRenditor.ClearingEnabled = true;
            this.ChemRenditor.CopyingEnabled = true;
            this.ChemRenditor.DisplayOnEmpty = null;
            this.ChemRenditor.EditingEnabled = true;
            this.ChemRenditor.FileName = null;
            this.ChemRenditor.HighlightInfo = "";
            this.ChemRenditor.IsBitmapFromOLE = false;
            this.ChemRenditor.Location = new System.Drawing.Point(313, -76);
            molecule1.ArrowDir = MDL.Draw.ArrowDirType.No;
            molecule1.ArrowStyle = MDL.Draw.ArrowStyleType.Empty;
            molecule1.AtomValenceDisplay = true;
            molecule1.BaseFormBoxSetting = 0;
            molecule1.BondLineThickness = 0D;
            molecule1.CarbonLabelDisplay = false;
            molecule1.ChemLabelFont = null;
            molecule1.ChemLabelFontString = "(none)";
            molecule1.ColorAtomsByTypeInSketch = false;
            molecule1.ConfigLabelFont = null;
            molecule1.ConfigLabelFontString = "(none)";
            molecule1.ConvertRingBondIntoOneToMany = true;
            molecule1.Coords = null;
            molecule1.DashSpacing = 0.1D;
            molecule1.DisplaySinCys = false;
            molecule1.DisplaySulfurInCysSequence = false;
            molecule1.DoubleBondWidth = 0.18D;
            molecule1.FillColor = System.Drawing.Color.Empty;
            molecule1.FillStyle = MDL.Draw.ChemGraphicsObject.FillStyles.SOLID;
            molecule1.ForeColor = System.Drawing.Color.Empty;
            molecule1.ForeColorString = "";
            molecule1.ForSubsequenceQuery = false;
            molecule1.HighlightChildren = "";
            molecule1.HighlightColor = System.Drawing.Color.Blue;
            molecule1.HydrogenDisplayMode = MDL.Draw.Chemistry.Atom.HydrogenDisplayMode.Off;
            molecule1.Id = 641;
            molecule1.Initial = "";
            molecule1.IsAModel = false;
            molecule1.IsARotatedModel = false;
            molecule1.KeepRSLabelsInSketch = true;
            molecule1.LastModifyChemText = -1;
            molecule1.MaintainXMLChildOrderFlag = false;
            molecule1.MustPerceiveStereo = true;
            molecule1.PenColor = System.Drawing.Color.Empty;
            molecule1.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            molecule1.PenStyleToken = 0;
            molecule1.PenWidth = ((byte)(0));
            molecule1.PenWidthUnit = MDL.Draw.ChemGraphicsObject.PenWidthUnits.Default;
            molecule1.RefId = 641;
            molecule1.Replaced = false;
            molecule1.RgroupCleeanUpNeeded = false;
            molecule1.RgroupLabelsPresentFlag = false;
            molecule1.RLabelAtAbsCenter = "R";
            molecule1.RLabelAtAndCenter = "R*";
            molecule1.RLabelAtOrCenter = "(R)";
            molecule1.ScaleLabelsToBondLength = false;
            molecule1.Selected = false;
            molecule1.SequenceDictionary = null;
            molecule1.SequenceNeedsRealign = false;
            molecule1.SequenceView = MDL.Draw.Chemistry.Molecule.SequenceViewEnum.None;
            molecule1.Size = 0;
            molecule1.SkcWritten = false;
            molecule1.SkNumber = ((short)(0));
            molecule1.SLabelAtAbsCenter = "S";
            molecule1.SLabelAtAndCenter = "S*";
            molecule1.SLabelAtOrCenter = "(S)";
            molecule1.StandardBondLength = 0D;
            molecule1.StereoChemistryMode = MDL.Draw.Chemistry.Molecule.StereoChemistryModeEnum.And;
            molecule1.TextBorder = 0.1D;
            molecule1.Transparent = false;
            molecule1.UndoableEditListener = null;
            molecule1.WedgeWidth = 0.1D;
            molecule1.ZLayer = -99374;
            this.ChemRenditor.Molecule = molecule1;
            this.ChemRenditor.MolfileString = "";
            this.ChemRenditor.Name = "ChemRenditor";
            this.ChemRenditor.OldScalingMode = MDL.Draw.Renderer.Preferences.StructureScalingMode.ScaleToFitBox;
            this.ChemRenditor.PastingEnabled = true;
            this.ChemRenditor.Preferences = displayPreferences1;
            this.ChemRenditor.PreferencesFileName = "default.xml";
            this.ChemRenditor.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.ChemRenditor.RenditorMolecule = molecule1;
            this.ChemRenditor.RenditorName = "Renditor";
            this.ChemRenditor.Size = new System.Drawing.Size(45, 41);
            this.ChemRenditor.SketchString = "AQMABEEiAB9DcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMS40AgQAAABYBQAAAABZBQAAAAALCwAFQ" +
    "XJpYWx4AAAUAgA=";
            this.ChemRenditor.SmilesString = "";
            this.ChemRenditor.TabIndex = 17;
            this.ChemRenditor.URLEncodedMolfileString = "";
            this.ChemRenditor.UseLocalXMLConfig = false;
            // 
            // reactantRenderer
            // 
            this.reactantRenderer.AutoSizeStructure = true;
            this.reactantRenderer.BinHexSketch = "010300044122001F4372656174656420627920416363656C7279734472617720342E312E312E34020" +
    "40000005805000000005905000000000B0B0005417269616C780000140200";
            this.reactantRenderer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reactantRenderer.ChimeString = null;
            this.reactantRenderer.CopyingEnabled = true;
            this.reactantRenderer.DisplayOnEmpty = null;
            this.reactantRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactantRenderer.FileName = null;
            this.reactantRenderer.HighlightInfo = "";
            this.reactantRenderer.IsBitmapFromOLE = false;
            this.reactantRenderer.Location = new System.Drawing.Point(0, 0);
            molecule2.ArrowDir = MDL.Draw.ArrowDirType.No;
            molecule2.ArrowStyle = MDL.Draw.ArrowStyleType.Empty;
            molecule2.AtomValenceDisplay = true;
            molecule2.BaseFormBoxSetting = 0;
            molecule2.BondLineThickness = 0D;
            molecule2.CarbonLabelDisplay = false;
            molecule2.ChemLabelFont = null;
            molecule2.ChemLabelFontString = "(none)";
            molecule2.ColorAtomsByTypeInSketch = false;
            molecule2.ConfigLabelFont = null;
            molecule2.ConfigLabelFontString = "(none)";
            molecule2.ConvertRingBondIntoOneToMany = true;
            molecule2.Coords = null;
            molecule2.DashSpacing = 0.1D;
            molecule2.DisplaySinCys = false;
            molecule2.DisplaySulfurInCysSequence = false;
            molecule2.DoubleBondWidth = 0.18D;
            molecule2.FillColor = System.Drawing.Color.Empty;
            molecule2.FillStyle = MDL.Draw.ChemGraphicsObject.FillStyles.SOLID;
            molecule2.ForeColor = System.Drawing.Color.Empty;
            molecule2.ForeColorString = "";
            molecule2.ForSubsequenceQuery = false;
            molecule2.HighlightChildren = "";
            molecule2.HighlightColor = System.Drawing.Color.Blue;
            molecule2.HydrogenDisplayMode = MDL.Draw.Chemistry.Atom.HydrogenDisplayMode.Off;
            molecule2.Id = 664;
            molecule2.Initial = "";
            molecule2.IsAModel = false;
            molecule2.IsARotatedModel = false;
            molecule2.KeepRSLabelsInSketch = true;
            molecule2.LastModifyChemText = -1;
            molecule2.MaintainXMLChildOrderFlag = false;
            molecule2.MustPerceiveStereo = true;
            molecule2.PenColor = System.Drawing.Color.Empty;
            molecule2.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            molecule2.PenStyleToken = 0;
            molecule2.PenWidth = ((byte)(0));
            molecule2.PenWidthUnit = MDL.Draw.ChemGraphicsObject.PenWidthUnits.Default;
            molecule2.RefId = 664;
            molecule2.Replaced = false;
            molecule2.RgroupCleeanUpNeeded = false;
            molecule2.RgroupLabelsPresentFlag = false;
            molecule2.RLabelAtAbsCenter = "R";
            molecule2.RLabelAtAndCenter = "R*";
            molecule2.RLabelAtOrCenter = "(R)";
            molecule2.ScaleLabelsToBondLength = false;
            molecule2.Selected = false;
            molecule2.SequenceDictionary = null;
            molecule2.SequenceNeedsRealign = false;
            molecule2.SequenceView = MDL.Draw.Chemistry.Molecule.SequenceViewEnum.None;
            molecule2.Size = 0;
            molecule2.SkcWritten = false;
            molecule2.SkNumber = ((short)(0));
            molecule2.SLabelAtAbsCenter = "S";
            molecule2.SLabelAtAndCenter = "S*";
            molecule2.SLabelAtOrCenter = "(S)";
            molecule2.StandardBondLength = 0D;
            molecule2.StereoChemistryMode = MDL.Draw.Chemistry.Molecule.StereoChemistryModeEnum.And;
            molecule2.TextBorder = 0.1D;
            molecule2.Transparent = false;
            molecule2.UndoableEditListener = null;
            molecule2.WedgeWidth = 0.1D;
            molecule2.ZLayer = -99351;
            this.reactantRenderer.Molecule = molecule2;
            this.reactantRenderer.MolfileString = "";
            this.reactantRenderer.Name = "reactantRenderer";
            this.reactantRenderer.PastingEnabled = true;
            this.reactantRenderer.Preferences = displayPreferences2;
            this.reactantRenderer.PreferencesFileName = "default.xml";
            this.reactantRenderer.RendererBorderStyle = System.Windows.Forms.ButtonBorderStyle.Inset;
            this.reactantRenderer.Size = new System.Drawing.Size(344, 254);
            this.reactantRenderer.SketchString = "AQMABEEiAB9DcmVhdGVkIGJ5IEFjY2VscnlzRHJhdyA0LjEuMS40AgQAAABYBQAAAABZBQAAAAALCwAFQ" +
    "XJpYWx4AAAUAgA=";
            this.reactantRenderer.SmilesString = "";
            this.reactantRenderer.TabIndex = 31;
            this.reactantRenderer.URLEncodedMolfileString = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ParticipantID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Structure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Structure";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "StructureNo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ChemInform.Properties.Resources.Edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.ToolTipText = "Edit Participant";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = global::ChemInform.Properties.Resources.delete_row;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.ToolTipText = "Delete Participant";
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ConditionID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 19.7518F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 15.39428F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Temp";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 78;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 24.43059F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Pressure";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 123;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.FillWeight = 11.54409F;
            this.dataGridViewTextBoxColumn11.HeaderText = "pH";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.Width = 59;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 19.3956F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Other";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 98;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.FillWeight = 30.5382F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Operation";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.Width = 154;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.FillWeight = 19.3956F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Other";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.Width = 79;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "FALSE";
            this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "WarmUp";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "TRUE";
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn2.FalseValue = "FALSE";
            this.dataGridViewCheckBoxColumn2.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "CoolDown";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "TRUE";
            this.dataGridViewCheckBoxColumn2.Width = 75;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn3.FalseValue = "FALSE";
            this.dataGridViewCheckBoxColumn3.FillWeight = 137.0557F;
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsReflux";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.TrueValue = "TRUE";
            this.dataGridViewCheckBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.FillWeight = 30.5382F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Operation";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 124;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.FillWeight = 30.5382F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Operation";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 112;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.FillWeight = 20.97376F;
            this.dataGridViewImageColumn4.HeaderText = "Edit";
            this.dataGridViewImageColumn4.Image = global::ChemInform.Properties.Resources.Edit;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 40;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn5.FillWeight = 20.35337F;
            this.dataGridViewImageColumn5.HeaderText = "Delete";
            this.dataGridViewImageColumn5.Image = global::ChemInform.Properties.Resources.delete_row;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn5.Width = 40;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn1.FillWeight = 20.97376F;
            this.dataGridViewLinkColumn1.HeaderText = "Edit";
            this.dataGridViewLinkColumn1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Text = "Edit";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.Width = 60;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn2.FillWeight = 20.35337F;
            this.dataGridViewLinkColumn2.HeaderText = "Delete";
            this.dataGridViewLinkColumn2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn2.Text = "Delete";
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn2.Width = 60;
            // 
            // dataGridViewLinkColumn3
            // 
            this.dataGridViewLinkColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn3.FillWeight = 20.97376F;
            this.dataGridViewLinkColumn3.HeaderText = "Edit";
            this.dataGridViewLinkColumn3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn3.Name = "dataGridViewLinkColumn3";
            this.dataGridViewLinkColumn3.ReadOnly = true;
            this.dataGridViewLinkColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn3.Text = "Edit";
            this.dataGridViewLinkColumn3.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn3.Width = 60;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn4.FillWeight = 20.35337F;
            this.dataGridViewLinkColumn4.HeaderText = "Delete";
            this.dataGridViewLinkColumn4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.ReadOnly = true;
            this.dataGridViewLinkColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn4.Text = "Delete";
            this.dataGridViewLinkColumn4.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn4.Width = 60;
            // 
            // ucRxnParticipants
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucRxnParticipants";
            this.Size = new System.Drawing.Size(980, 254);
            this.pnlMain.ResumeLayout(false);
            this.pnlParticipants.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.cntMnuTab.ResumeLayout(false);
            this.pnlPartpntHdr.ResumeLayout(false);
            this.pnlPartpntHdr.PerformLayout();
            this.pnlConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ContextMenuStrip cntMnuTab;
        private System.Windows.Forms.ToolStripMenuItem newRowTSMenuItem;
        private System.Windows.Forms.Label lblStepYield;
        private System.Windows.Forms.DataGridView dgvConditions;
        private System.Windows.Forms.Panel pnlConditions;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Panel pnlParticipants;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Panel pnlPartpntHdr;
        private System.Windows.Forms.Label lblPartpnt;
        public System.Windows.Forms.DataGridView dgvParticipants;
        private MDL.Draw.Renditor.Renditor ChemRenditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private MDL.Draw.Renderer.Renderer reactantRenderer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtStepYield;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantStructure;
        private System.Windows.Forms.DataGridViewImageColumn colStructureImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantStructNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantGrade;
        private System.Windows.Forms.DataGridViewImageColumn colEditParticipant;
        private System.Windows.Forms.DataGridViewImageColumn colDeleteParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPressureUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionPh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConditionWarmUp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConditionCoolDown;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConditionIsReflux;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConditionOperation;
        private System.Windows.Forms.DataGridViewImageColumn colEditCondition;
        private System.Windows.Forms.DataGridViewImageColumn colDeleteCondition;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;



    }
}
