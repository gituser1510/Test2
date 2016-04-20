namespace ChemInform
{
    partial class FrmEditConditions
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPressureTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempTo = new System.Windows.Forms.TextBox();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.txtTimeTo = new System.Windows.Forms.TextBox();
            this.cmbTempUnits = new System.Windows.Forms.ComboBox();
            this.cmbPresUnits = new System.Windows.Forms.ComboBox();
            this.cmbTimeUnits = new System.Windows.Forms.ComboBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkReflux = new System.Windows.Forms.CheckBox();
            this.chkCoolDown = new System.Windows.Forms.CheckBox();
            this.chkWarmUp = new System.Windows.Forms.CheckBox();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblPh = new System.Windows.Forms.Label();
            this.txtPressureFrom = new System.Windows.Forms.TextBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.txtTempFrom = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTimeFrom = new System.Windows.Forms.TextBox();
            this.lblTempInDegrees = new System.Windows.Forms.Label();
            this.lblTimeInHrs = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPHTo = new System.Windows.Forms.TextBox();
            this.txtPHFrom = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtPHTo);
            this.pnlMain.Controls.Add(this.txtPHFrom);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtPressureTo);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtTempTo);
            this.pnlMain.Controls.Add(this.lblTimeTo);
            this.pnlMain.Controls.Add(this.txtTimeTo);
            this.pnlMain.Controls.Add(this.cmbTempUnits);
            this.pnlMain.Controls.Add(this.cmbPresUnits);
            this.pnlMain.Controls.Add(this.cmbTimeUnits);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.chkReflux);
            this.pnlMain.Controls.Add(this.chkCoolDown);
            this.pnlMain.Controls.Add(this.chkWarmUp);
            this.pnlMain.Controls.Add(this.txtOperation);
            this.pnlMain.Controls.Add(this.lblOperation);
            this.pnlMain.Controls.Add(this.txtOther);
            this.pnlMain.Controls.Add(this.lblOther);
            this.pnlMain.Controls.Add(this.lblPh);
            this.pnlMain.Controls.Add(this.txtPressureFrom);
            this.pnlMain.Controls.Add(this.lblPressure);
            this.pnlMain.Controls.Add(this.txtTempFrom);
            this.pnlMain.Controls.Add(this.lblTemp);
            this.pnlMain.Controls.Add(this.txtTimeFrom);
            this.pnlMain.Controls.Add(this.lblTempInDegrees);
            this.pnlMain.Controls.Add(this.lblTimeInHrs);
            this.pnlMain.Controls.Add(this.lblTime);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(734, 178);
            this.pnlMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "to";
            // 
            // txtPressureTo
            // 
            this.txtPressureTo.Location = new System.Drawing.Point(154, 62);
            this.txtPressureTo.Name = "txtPressureTo";
            this.txtPressureTo.Size = new System.Drawing.Size(53, 25);
            this.txtPressureTo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "to";
            // 
            // txtTempTo
            // 
            this.txtTempTo.Location = new System.Drawing.Point(478, 6);
            this.txtTempTo.Name = "txtTempTo";
            this.txtTempTo.Size = new System.Drawing.Size(53, 25);
            this.txtTempTo.TabIndex = 5;
            this.txtTempTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempTo_KeyPress);
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Location = new System.Drawing.Point(132, 9);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(19, 17);
            this.lblTimeTo.TabIndex = 23;
            this.lblTimeTo.Text = "to";
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Location = new System.Drawing.Point(154, 5);
            this.txtTimeTo.MaxLength = 11;
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.Size = new System.Drawing.Size(53, 25);
            this.txtTimeTo.TabIndex = 2;
            this.txtTimeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeTo_KeyPress);
            // 
            // cmbTempUnits
            // 
            this.cmbTempUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempUnits.FormattingEnabled = true;
            this.cmbTempUnits.Items.AddRange(new object[] {
            "Deg C",
            "Fahrenheit",
            "Kelvin"});
            this.cmbTempUnits.Location = new System.Drawing.Point(537, 6);
            this.cmbTempUnits.Name = "cmbTempUnits";
            this.cmbTempUnits.Size = new System.Drawing.Size(88, 25);
            this.cmbTempUnits.TabIndex = 6;
            this.cmbTempUnits.SelectionChangeCommitted += new System.EventHandler(this.cmbTempUnits_SelectionChangeCommitted);
            // 
            // cmbPresUnits
            // 
            this.cmbPresUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresUnits.FormattingEnabled = true;
            this.cmbPresUnits.Items.AddRange(new object[] {
            "PSI",
            "MM HG",
            "IN HG",
            "ATM",
            "BAR",
            "MBAR",
            "KPA"});
            this.cmbPresUnits.Location = new System.Drawing.Point(212, 62);
            this.cmbPresUnits.Name = "cmbPresUnits";
            this.cmbPresUnits.Size = new System.Drawing.Size(89, 25);
            this.cmbPresUnits.TabIndex = 9;
            // 
            // cmbTimeUnits
            // 
            this.cmbTimeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeUnits.FormattingEnabled = true;
            this.cmbTimeUnits.Items.AddRange(new object[] {
            "HR",
            "Mins",
            "Secs"});
            this.cmbTimeUnits.Location = new System.Drawing.Point(212, 5);
            this.cmbTimeUnits.Name = "cmbTimeUnits";
            this.cmbTimeUnits.Size = new System.Drawing.Size(89, 25);
            this.cmbTimeUnits.TabIndex = 3;
            this.cmbTimeUnits.SelectionChangeCommitted += new System.EventHandler(this.cmbTimeUnits_SelectionChangeCommitted);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 146);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(734, 32);
            this.pnlBottom.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::ChemInform.Properties.Resources.save_1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(654, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkReflux
            // 
            this.chkReflux.AutoSize = true;
            this.chkReflux.Location = new System.Drawing.Point(636, 64);
            this.chkReflux.Name = "chkReflux";
            this.chkReflux.Size = new System.Drawing.Size(66, 21);
            this.chkReflux.TabIndex = 13;
            this.chkReflux.Text = "Reflux";
            this.chkReflux.UseVisualStyleBackColor = true;
            // 
            // chkCoolDown
            // 
            this.chkCoolDown.AutoSize = true;
            this.chkCoolDown.Location = new System.Drawing.Point(636, 35);
            this.chkCoolDown.Name = "chkCoolDown";
            this.chkCoolDown.Size = new System.Drawing.Size(94, 21);
            this.chkCoolDown.TabIndex = 12;
            this.chkCoolDown.Text = "Cool Down";
            this.chkCoolDown.UseVisualStyleBackColor = true;
            // 
            // chkWarmUp
            // 
            this.chkWarmUp.AutoSize = true;
            this.chkWarmUp.Location = new System.Drawing.Point(636, 7);
            this.chkWarmUp.Name = "chkWarmUp";
            this.chkWarmUp.Size = new System.Drawing.Size(85, 21);
            this.chkWarmUp.TabIndex = 11;
            this.chkWarmUp.Text = "Warm Up";
            this.chkWarmUp.UseVisualStyleBackColor = true;
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(77, 119);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(654, 25);
            this.txtOperation.TabIndex = 15;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(4, 122);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(66, 17);
            this.lblOperation.TabIndex = 3;
            this.lblOperation.Text = "Operation";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(77, 91);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(654, 25);
            this.txtOther.TabIndex = 14;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(28, 94);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(42, 17);
            this.lblOther.TabIndex = 3;
            this.lblOther.Text = "Other";
            // 
            // lblPh
            // 
            this.lblPh.AutoSize = true;
            this.lblPh.Location = new System.Drawing.Point(367, 66);
            this.lblPh.Name = "lblPh";
            this.lblPh.Size = new System.Drawing.Size(26, 17);
            this.lblPh.TabIndex = 3;
            this.lblPh.Text = "pH";
            // 
            // txtPressureFrom
            // 
            this.txtPressureFrom.Location = new System.Drawing.Point(76, 62);
            this.txtPressureFrom.Name = "txtPressureFrom";
            this.txtPressureFrom.Size = new System.Drawing.Size(53, 25);
            this.txtPressureFrom.TabIndex = 7;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(10, 66);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(60, 17);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "Pressure";
            // 
            // txtTempFrom
            // 
            this.txtTempFrom.Location = new System.Drawing.Point(399, 6);
            this.txtTempFrom.Name = "txtTempFrom";
            this.txtTempFrom.Size = new System.Drawing.Size(53, 25);
            this.txtTempFrom.TabIndex = 4;
            this.txtTempFrom.TextChanged += new System.EventHandler(this.txtTempFrom_TextChanged);
            this.txtTempFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempFrom_KeyPress);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(313, 9);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(83, 17);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperature";
            // 
            // txtTimeFrom
            // 
            this.txtTimeFrom.Location = new System.Drawing.Point(76, 5);
            this.txtTimeFrom.MaxLength = 11;
            this.txtTimeFrom.Name = "txtTimeFrom";
            this.txtTimeFrom.Size = new System.Drawing.Size(53, 25);
            this.txtTimeFrom.TabIndex = 1;
            this.txtTimeFrom.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeFrom_KeyPress);
            // 
            // lblTempInDegrees
            // 
            this.lblTempInDegrees.AutoSize = true;
            this.lblTempInDegrees.ForeColor = System.Drawing.Color.Blue;
            this.lblTempInDegrees.Location = new System.Drawing.Point(400, 36);
            this.lblTempInDegrees.Name = "lblTempInDegrees";
            this.lblTempInDegrees.Size = new System.Drawing.Size(18, 17);
            this.lblTempInDegrees.TabIndex = 3;
            this.lblTempInDegrees.Text = "--";
            // 
            // lblTimeInHrs
            // 
            this.lblTimeInHrs.AutoSize = true;
            this.lblTimeInHrs.ForeColor = System.Drawing.Color.Blue;
            this.lblTimeInHrs.Location = new System.Drawing.Point(79, 39);
            this.lblTimeInHrs.Name = "lblTimeInHrs";
            this.lblTimeInHrs.Size = new System.Drawing.Size(18, 17);
            this.lblTimeInHrs.TabIndex = 3;
            this.lblTimeInHrs.Text = "--";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(33, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 17);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "to";
            // 
            // txtPHTo
            // 
            this.txtPHTo.Location = new System.Drawing.Point(478, 62);
            this.txtPHTo.Name = "txtPHTo";
            this.txtPHTo.Size = new System.Drawing.Size(53, 25);
            this.txtPHTo.TabIndex = 29;
            this.txtPHTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPHTo_KeyPress);
            // 
            // txtPHFrom
            // 
            this.txtPHFrom.Location = new System.Drawing.Point(399, 62);
            this.txtPHFrom.Name = "txtPHFrom";
            this.txtPHFrom.Size = new System.Drawing.Size(53, 25);
            this.txtPHFrom.TabIndex = 28;
            this.txtPHFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPHFrom_KeyPress);
            // 
            // FrmEditConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 178);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditConditions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Conditions";
            this.Load += new System.EventHandler(this.FrmConditions_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtTimeFrom;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox chkCoolDown;
        private System.Windows.Forms.CheckBox chkWarmUp;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.TextBox txtPressureFrom;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox txtTempFrom;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.CheckBox chkReflux;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTimeUnits;
        private System.Windows.Forms.ComboBox cmbTempUnits;
        private System.Windows.Forms.Label lblTempInDegrees;
        private System.Windows.Forms.Label lblTimeInHrs;
        private System.Windows.Forms.ComboBox cmbPresUnits;
        private System.Windows.Forms.TextBox txtTimeTo;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTempTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPressureTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPHTo;
        private System.Windows.Forms.TextBox txtPHFrom;
    }
}