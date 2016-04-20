using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TreeGenerator;

namespace ChemInform
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public DataTable RxnsPathData { get; set; }
        public List<object> Paths { get; set; }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            ShowChart();
        }
        /// <summary>
        /// Generate the chart and link it to the pictorebox control
        /// </summary>
        private TreeBuilder myTree=null;
        private void ShowChart()
        {
            //Bitmap bmp =new Bitmap(Image.FromStream(myOrgChart.GenerateOrgChart(640, 480, "1001", System.Drawing.Imaging.ImageFormat.Bmp)));
            try
            {
                //bmp.Save(@"d:\temp\1.bmp");

                myTree = new TreeBuilder(GetTreeData(RxnsPathData));

                picOrgChart.Image = Image.FromStream(myTree.GenerateTree(1000, -1, "Rxn6", System.Drawing.Imaging.ImageFormat.Bmp));
                //picOrgChart.Image = Image.FromFile(@"d:\temp\1.bmp");
            }
            catch (Exception e)
            {
                
                //throw;
            }
        }
        private TreeGenerator.TreeBuilder myOrgChart;
        
        private void TestForm_Load(object sender, EventArgs e)
        {
            #region Code commeted
            ////Build the data for the org chart - this will be doen differently in real life. 
            ////The DataTable will be filled from a database, probably.
            //OrgChartGenerator.OrgData.OrgDetailsDataTable myOrgData = new OrgChartGenerator.OrgData.OrgDetailsDataTable();
            ////myOrgData.AddOrgDetailsRow("1001", "Alon", "", "Manager");
            ////myOrgData.AddOrgDetailsRow("2001", "Yoram", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("2002", "Dana", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("3001", "Moshe", "2003", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3002", "Oren", "2003", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3003", "Noa", "2003", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3004", "Mor", "2002", "Consultant");
            ////myOrgData.AddOrgDetailsRow("3005", "Omer", "2002", "Consultant");
            ////myOrgData.AddOrgDetailsRow("2003", "Avi", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("2004", "Esty", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("2005", "Danny", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("2006", "Shlomo", "1001", "Team Leader");
            ////for (int a = 4001; a < 4005; a++)
            ////{
            ////    myOrgData.AddOrgDetailsRow(a.ToString(), "Name " + a.ToString(), "3002", "Consultant");
            ////}
            ////for (int a = 3006; a < 3010; a++)
            ////{
            ////    myOrgData.AddOrgDetailsRow(a.ToString(), "Name " + a.ToString(), "2005", "Consultant");
            ////}
            ////myOrgData.AddOrgDetailsRow("1001", "Alon", "", "Manager");
            ////myOrgData.AddOrgDetailsRow("2001", "Yoram", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("2002", "Dana", "1001", "Team Leader");
            ////myOrgData.AddOrgDetailsRow("3001", "Moshe", "2002", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3002", "Oren", "2002", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3003", "Noa", "3001", "SW Engineer");

            //////myOrgData.AddOrgDetailsRow("2005", "Danny", "1001", "Team Leader");

            //myOrgData.AddOrgDetailsRow("Rxn1", "A-1 of 4\r\nB-1 of 3", "", "Path - A, B");
            //myOrgData.AddOrgDetailsRow("Rxn2", "2 of 4", "Rxn1", "Path - A");
            //myOrgData.AddOrgDetailsRow("Rxn3", "3 of 4", "Rxn2", "Path - A");
            //myOrgData.AddOrgDetailsRow("Rxn4", "4 of 4", "Rxn3", "Path - A");
            //myOrgData.AddOrgDetailsRow("Rxn6", "B - 2 of 3", "Rxn1", "Path - B");
            //myOrgData.AddOrgDetailsRow("Rxn7", "B - 3 of 3", "Rxn6", "Path - B");


            ////myOrgData.AddOrgDetailsRow("3002", "Oren", "2002", "SW Engineer");
            ////myOrgData.AddOrgDetailsRow("3003", "Noa", "3001", "SW Engineer");

            ////instantiate the object
            //myOrgChart = new OrgChartGenerator.OrgChart(myOrgData);
            //SetControlValues(); 
            #endregion  

            try
            {

                // CreateReactionsPathChart(RxnsPathData);

                myTree = new TreeBuilder(GetTreeData(RxnsPathData));

                if (RxnsPathData != null && Paths != null)
                {
                    tableLayoutPanel1.RowCount = Paths.Count;

                    for (int i = 0; i <= tableLayoutPanel1.RowCount; i++)
                    {
                        RowStyle rStyle = new RowStyle();
                        rStyle.Height = 420;
                        rStyle.SizeType = SizeType.Absolute;
                        tableLayoutPanel1.RowStyles.Add(rStyle);
                    }

                    int chartIndx = 0;
                    for (int i = 0; i < RxnsPathData.Rows.Count; i++)
                    {
                        if (string.IsNullOrEmpty(RxnsPathData.Rows[i]["ParentRxnNo"].ToString()))
                        {
                            PictureBox pbChart = new PictureBox();
                            pbChart.Dock = DockStyle.Fill;
                            pbChart.SizeMode = PictureBoxSizeMode.Zoom;
                            pbChart.MouseClick -= new MouseEventHandler(picOrgChart_MouseClick);
                            pbChart.MouseClick += new MouseEventHandler(picOrgChart_MouseClick);
                            pbChart.Image = Image.FromStream(myTree.GenerateTree(1000, -1, "Rxn" + RxnsPathData.Rows[i]["RxnNo"].ToString(), System.Drawing.Imaging.ImageFormat.Bmp));

                            tableLayoutPanel1.Controls.Add(pbChart, 0, chartIndx);
                            tableLayoutPanel1.ScrollControlIntoView(pbChart);
                            chartIndx++;
                        }
                    }

                    for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                    {
                        tableLayoutPanel1.RowStyles[i].Height = 300;
                        tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                    } 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        private void SetControlValues()
        {
            if (myOrgChart != null)
            {
                //lblBGColor.BackColor = myOrgChart.BGColor;
               // lblBoxFillColor.BackColor = myOrgChart.BoxFillColor;
               // lblFontColor.BackColor = myOrgChart.FontColor;
               // lblLineColor.BackColor = myOrgChart.LineColor;
                nudBoxHeight.Value = Convert.ToDecimal( myOrgChart.BoxHeight);
                nudBoxWidth.Value  = Convert.ToDecimal( myOrgChart.BoxWidth);
                nudFontSize.Value = Convert.ToDecimal( myOrgChart.FontSize);
                nudHorizontalSpace.Value = Convert.ToDecimal( myOrgChart.HorizontalSpace);
                nudLineWidth.Value =Convert.ToDecimal(  myOrgChart.LineWidth);
                nudMargin.Value =Convert.ToDecimal(  myOrgChart.Margin);
                nudVerticalSpace.Value = Convert.ToDecimal(myOrgChart.VerticalSpace);
            
            
            }
        
        }

        private TreeData.TreeDataTableDataTable GetTreeData(DataTable rxnsPaths)
        {
            TreeData.TreeDataTableDataTable dt = null;
            if (rxnsPaths != null && Paths != null)
            {               
                 dt = new TreeData.TreeDataTableDataTable();
                //dt.AddTreeDataTableRow("1", "", "Localhost", "This is your Local Server");
                //dt.AddTreeDataTableRow("2", "1", "Child 1", "This is the first child.");
                //dt.AddTreeDataTableRow("3", "1", "Child 2", "This is the second child.");
                //dt.AddTreeDataTableRow("4", "1", "Child 3", "This is the third child.");
                //dt.AddTreeDataTableRow("5", "2", "GrandChild 1", "This is the only Grandchild.");
                //for (int i = 6; i < 150; i++)
                //{
                //    Random rand = new Random();
                //    dt.AddTreeDataTableRow(i.ToString(), rand.Next(1, i).ToString(), "GrandChild " + i.ToString(), "This is the only Grandchild.");
                //}

                string rxnNo = "";
                string paths = "";
                string parentRxnNo = "";
                string steps = "";

                for (int i = 0; i < rxnsPaths.Rows.Count; i++)
                {

                    rxnNo = "Rxn" + rxnsPaths.Rows[i]["RxnNo"].ToString();
                    parentRxnNo = !string.IsNullOrEmpty(rxnsPaths.Rows[i]["ParentRxnNo"].ToString()) ? "Rxn" + rxnsPaths.Rows[i]["ParentRxnNo"].ToString() : "";
                    paths = rxnsPaths.Rows[i]["Paths"].ToString();
                    steps = rxnsPaths.Rows[i]["Steps"].ToString();

                    dt.AddTreeDataTableRow(rxnNo, parentRxnNo, rxnNo, paths);
                }               
            }
            return dt;
        }


        //private void CreateReactionsPathChart(DataTable rxnsPaths)
        //{
        //    try
        //    {
        //        if (rxnsPaths != null && Paths != null)
        //        {
        //            tableLayoutPanel1.RowCount = Paths.Count;

        //            for (int i = 0; i <= tableLayoutPanel1.RowCount; i++)
        //            {
        //                RowStyle rStyle = new RowStyle();
        //                rStyle.Height = 420;
        //                rStyle.SizeType = SizeType.Absolute;
        //                tableLayoutPanel1.RowStyles.Add(rStyle);
        //            }


        //            //for (int pathIndx = 0; pathIndx < Paths.Count; pathIndx++)
        //            //{
        //                try
        //                {
        //                    OrgChartGenerator.OrgData.OrgDetailsDataTable myOrgData = new OrgChartGenerator.OrgData.OrgDetailsDataTable();

        //                    string rxnNo = "";
        //                    string paths = "";
        //                    string parentRxnNo = "";
        //                    string steps = "";

        //                    for (int i = 0; i < rxnsPaths.Rows.Count; i++)
        //                    {
        //                        //if (rxnsPaths.Rows[i]["Path"].ToString() == Paths[pathIndx].ToString())
        //                        //{
        //                            rxnNo = "Rxn" + rxnsPaths.Rows[i]["RxnNo"].ToString();
        //                            parentRxnNo = !string.IsNullOrEmpty(rxnsPaths.Rows[i]["ParentRxnNo"].ToString()) ? "Rxn" + rxnsPaths.Rows[i]["ParentRxnNo"].ToString() : "";
        //                            paths = rxnsPaths.Rows[i]["Paths"].ToString();
        //                            steps = rxnsPaths.Rows[i]["Steps"].ToString();

        //                            myOrgData.AddOrgDetailsRow(rxnNo, steps, parentRxnNo, paths);
        //                       // }
        //                    }
        //                    myOrgChart = new OrgChartGenerator.OrgChart(myOrgData);

        //                    int chartIndx = 0;
        //                    for (int i = 0; i < rxnsPaths.Rows.Count; i++)
        //                    {
        //                        if (string.IsNullOrEmpty(rxnsPaths.Rows[i]["ParentRxnNo"].ToString()))
        //                        {
        //                            PictureBox pbChart = new PictureBox();
        //                            pbChart.Dock = DockStyle.Fill;
        //                            pbChart.SizeMode = PictureBoxSizeMode.Zoom;
        //                            pbChart.MouseClick -= new MouseEventHandler(picOrgChart_MouseClick);
        //                            pbChart.MouseClick += new MouseEventHandler(picOrgChart_MouseClick);
        //                            pbChart.Image = Image.FromStream(myOrgChart.GenerateOrgChart(1000, -1, "Rxn" + rxnsPaths.Rows[i]["RxnNo"].ToString(), System.Drawing.Imaging.ImageFormat.Bmp));

        //                            tableLayoutPanel1.Controls.Add(pbChart, 0, chartIndx);
        //                            tableLayoutPanel1.ScrollControlIntoView(pbChart);
        //                            chartIndx++;
        //                        }
        //                    }
        //                }
        //                catch
        //                { 
                        
        //                }

        //               // SetControlValues();
        //            //}

        //            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
        //            {
        //                tableLayoutPanel1.RowStyles[i].Height = 300;
        //                tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
        //            } 
        //        }
        //    }
        //    catch (Exception)
        //    {                
        //        throw;
        //    }
        //}

        private void lblFontColor_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = colorDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            myOrgChart.FontColor = colorDialog1.Color;
            ShowChart();
        }

        private void lblBoxFillColor_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = colorDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            myOrgChart.BoxFillColor  = colorDialog1.Color;
            ShowChart();
        }

        private void lblLineColor_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = colorDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            myOrgChart.LineColor = colorDialog1.Color;
            ShowChart();
        }

        private void lblBGColor_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = colorDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            myOrgChart.BGColor = colorDialog1.Color;
            ShowChart();
        }

        private void nudLineWidth_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.LineWidth =(float) nudLineWidth.Value;
            ShowChart();
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.FontSize = (int)nudFontSize.Value;
            ShowChart();
        }

        private void nudVerticalSpace_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.VerticalSpace = (int)nudVerticalSpace.Value;
            ShowChart();
        }

        private void nudHorizontalSpace_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.HorizontalSpace = (int)nudHorizontalSpace.Value;
            ShowChart();
        }

        private void nudMargin_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.Margin = (int)nudMargin.Value;
            ShowChart();
        }

        private void nudBoxHeight_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.BoxHeight = (int)nudBoxHeight.Value;
            ShowChart();
        }

        private void nudBoxWidth_ValueChanged(object sender, EventArgs e)
        {
            myOrgChart.BoxWidth = (int)nudBoxWidth.Value;
            ShowChart();
        }

        private void picOrgChart_MouseClick(object sender, MouseEventArgs e)
        {
            //determine if the mouse clicked on a box, if so, show the employee name.
            //string SelectedEmployee = "No Reaction";
            //foreach (OrgChartGenerator.OrgChartRecord EmpRec in myOrgChart.EmployeeData.Values)
            //{
            //    if (e.X >= EmpRec.EmployeePos.Left &&
            //        e.X <= EmpRec.EmployeePos.Right &&
            //        e.Y >= EmpRec.EmployeePos.Top &&
            //        e.Y <= EmpRec.EmployeePos.Bottom)
            //    {
            //        SelectedEmployee = EmpRec.EmployeeData.EmployeeName;
            //        break;
            //    }
            
            //}
            //MessageBox.Show(SelectedEmployee);
        }

       
    }
}