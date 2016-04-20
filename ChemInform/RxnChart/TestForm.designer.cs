namespace ChemInform
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picOrgChart = new System.Windows.Forms.PictureBox();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.nudVerticalSpace = new System.Windows.Forms.NumericUpDown();
            this.nudHorizontalSpace = new System.Windows.Forms.NumericUpDown();
            this.nudMargin = new System.Windows.Forms.NumericUpDown();
            this.nudBoxHeight = new System.Windows.Forms.NumericUpDown();
            this.nudBoxWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.lblBoxFillColor = new System.Windows.Forms.Label();
            this.lblLineColor = new System.Windows.Forms.Label();
            this.lblBGColor = new System.Windows.Forms.Label();
            this.tipColor = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picOrgChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxWidth)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowChart
            // 
            this.btnShowChart.Location = new System.Drawing.Point(12, 12);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(113, 23);
            this.btnShowChart.TabIndex = 0;
            this.btnShowChart.Text = "Show Org Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line width";
            // 
            // picOrgChart
            // 
            this.picOrgChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOrgChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOrgChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOrgChart.Location = new System.Drawing.Point(0, 0);
            this.picOrgChart.Name = "picOrgChart";
            this.picOrgChart.Size = new System.Drawing.Size(119, 126);
            this.picOrgChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOrgChart.TabIndex = 4;
            this.picOrgChart.TabStop = false;
            this.picOrgChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOrgChart_MouseClick);
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.Location = new System.Drawing.Point(98, 64);
            this.nudLineWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(62, 20);
            this.nudLineWidth.TabIndex = 5;
            this.nudLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.ValueChanged += new System.EventHandler(this.nudLineWidth_ValueChanged);
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(98, 90);
            this.nudFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(62, 20);
            this.nudFontSize.TabIndex = 5;
            this.nudFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // nudVerticalSpace
            // 
            this.nudVerticalSpace.Location = new System.Drawing.Point(98, 116);
            this.nudVerticalSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVerticalSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVerticalSpace.Name = "nudVerticalSpace";
            this.nudVerticalSpace.Size = new System.Drawing.Size(62, 20);
            this.nudVerticalSpace.TabIndex = 5;
            this.nudVerticalSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVerticalSpace.ValueChanged += new System.EventHandler(this.nudVerticalSpace_ValueChanged);
            // 
            // nudHorizontalSpace
            // 
            this.nudHorizontalSpace.Location = new System.Drawing.Point(98, 142);
            this.nudHorizontalSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHorizontalSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorizontalSpace.Name = "nudHorizontalSpace";
            this.nudHorizontalSpace.Size = new System.Drawing.Size(62, 20);
            this.nudHorizontalSpace.TabIndex = 5;
            this.nudHorizontalSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorizontalSpace.ValueChanged += new System.EventHandler(this.nudHorizontalSpace_ValueChanged);
            // 
            // nudMargin
            // 
            this.nudMargin.Location = new System.Drawing.Point(98, 168);
            this.nudMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMargin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMargin.Name = "nudMargin";
            this.nudMargin.Size = new System.Drawing.Size(62, 20);
            this.nudMargin.TabIndex = 5;
            this.nudMargin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMargin.ValueChanged += new System.EventHandler(this.nudMargin_ValueChanged);
            // 
            // nudBoxHeight
            // 
            this.nudBoxHeight.Location = new System.Drawing.Point(98, 194);
            this.nudBoxHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBoxHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBoxHeight.Name = "nudBoxHeight";
            this.nudBoxHeight.Size = new System.Drawing.Size(62, 20);
            this.nudBoxHeight.TabIndex = 5;
            this.nudBoxHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBoxHeight.ValueChanged += new System.EventHandler(this.nudBoxHeight_ValueChanged);
            // 
            // nudBoxWidth
            // 
            this.nudBoxWidth.Location = new System.Drawing.Point(98, 220);
            this.nudBoxWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBoxWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBoxWidth.Name = "nudBoxWidth";
            this.nudBoxWidth.Size = new System.Drawing.Size(62, 20);
            this.nudBoxWidth.TabIndex = 5;
            this.nudBoxWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBoxWidth.ValueChanged += new System.EventHandler(this.nudBoxWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vertical Space";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Horizontal Space";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Margin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Box Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Box Width";
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFontColor.Location = new System.Drawing.Point(9, 252);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(55, 13);
            this.lblFontColor.TabIndex = 2;
            this.lblFontColor.Text = "Font Color";
            this.tipColor.SetToolTip(this.lblFontColor, "Font color");
            this.lblFontColor.Click += new System.EventHandler(this.lblFontColor_Click);
            // 
            // lblBoxFillColor
            // 
            this.lblBoxFillColor.AutoSize = true;
            this.lblBoxFillColor.Location = new System.Drawing.Point(9, 274);
            this.lblBoxFillColor.Name = "lblBoxFillColor";
            this.lblBoxFillColor.Size = new System.Drawing.Size(46, 13);
            this.lblBoxFillColor.TabIndex = 2;
            this.lblBoxFillColor.Text = "Fill Color";
            this.tipColor.SetToolTip(this.lblBoxFillColor, "Fill color");
            this.lblBoxFillColor.Click += new System.EventHandler(this.lblBoxFillColor_Click);
            // 
            // lblLineColor
            // 
            this.lblLineColor.AutoSize = true;
            this.lblLineColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLineColor.Location = new System.Drawing.Point(9, 298);
            this.lblLineColor.Name = "lblLineColor";
            this.lblLineColor.Size = new System.Drawing.Size(54, 13);
            this.lblLineColor.TabIndex = 2;
            this.lblLineColor.Text = "Line Color";
            this.tipColor.SetToolTip(this.lblLineColor, "Line color");
            this.lblLineColor.Click += new System.EventHandler(this.lblLineColor_Click);
            // 
            // lblBGColor
            // 
            this.lblBGColor.AutoSize = true;
            this.lblBGColor.Location = new System.Drawing.Point(9, 321);
            this.lblBGColor.Name = "lblBGColor";
            this.lblBGColor.Size = new System.Drawing.Size(49, 13);
            this.lblBGColor.TabIndex = 2;
            this.lblBGColor.Text = "BG Color";
            this.tipColor.SetToolTip(this.lblBGColor, "BG Color");
            this.lblBGColor.Click += new System.EventHandler(this.lblBGColor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picOrgChart);
            this.panel1.Location = new System.Drawing.Point(12, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 128);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(166, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 485);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudBoxWidth);
            this.Controls.Add(this.nudBoxHeight);
            this.Controls.Add(this.nudMargin);
            this.Controls.Add(this.nudHorizontalSpace);
            this.Controls.Add(this.nudVerticalSpace);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.nudLineWidth);
            this.Controls.Add(this.lblBGColor);
            this.Controls.Add(this.lblLineColor);
            this.Controls.Add(this.lblBoxFillColor);
            this.Controls.Add(this.lblFontColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowChart);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrgChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOrgChart;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.NumericUpDown nudVerticalSpace;
        private System.Windows.Forms.NumericUpDown nudHorizontalSpace;
        private System.Windows.Forms.NumericUpDown nudMargin;
        private System.Windows.Forms.NumericUpDown nudBoxHeight;
        private System.Windows.Forms.NumericUpDown nudBoxWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.Label lblBoxFillColor;
        private System.Windows.Forms.Label lblLineColor;
        private System.Windows.Forms.Label lblBGColor;
        private System.Windows.Forms.ToolTip tipColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}