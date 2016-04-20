using System;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.UserManagement;
using ChemInform.Task_Management;
using System.Data;
using ChemInform.Dal;
using ChemInform.Reports;
using System.Threading;
using System.IO;
using ChemInform.TaskManagement_New;
using ChemInform.Export;

namespace ChemInform
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void EnableMenu_SubMenuItems(int roleId)
        {
            try
            {
                loginToolStripMenuItem.Enabled = false;
                LogoutToolStripMenuItem.Enabled = true;
                exitToolStripMenuItem.Enabled = true;

                otherTSMenuItem.Enabled = true;

                switch (roleId)
                {
                    case 1://Administrator
                        usersTSMenuItem.Enabled = true;
                        taskToolStripMenuItem.Enabled = true;
                        exportToolStripMenuItem.Enabled = true;
                        reportsToolStripMenuItem.Enabled = true;
                        deliveryMenuItem.Enabled = true;
                        break;

                    case 2://Project Manager
                        taskToolStripMenuItem.Enabled = true;
                        createShipmentToolStripMenuItem.Enabled = true;
                        taskAssingnmentTSMenuItem.Enabled = true;
                        reportsToolStripMenuItem.Enabled = true;
                        break;

                    case 3://Tool Manager   
                        usersTSMenuItem.Enabled = true;
                        taskToolStripMenuItem.Enabled = true;
                        createShipmentToolStripMenuItem.Enabled = true;
                        taskAssingnmentTSMenuItem.Enabled = true;
                        exportToolStripMenuItem.Enabled = true;
                        reportsToolStripMenuItem.Enabled = true;
                        deliveryMenuItem.Enabled = true;
                        break;
                    case 4://QC
                    case 5://Review
                    case 6://Analyst                
                        loadTaskTSMenuItem.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void loadTaskTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAssignedTans = TaskManagementDB.GetUserTasksOnModule(GlobalVariables.UR_ID, GlobalVariables.Module);

                if (GlobalVariables.Module == "RA")
                {
                    using (frmTaskSheet usrTaskSheet = new frmTaskSheet())
                    {
                        usrTaskSheet.AssignedTANs = dtAssignedTans;
                        if (usrTaskSheet.ShowDialog() == DialogResult.OK)
                        {
                            if (usrTaskSheet.DocType == "ABSTRACT")
                            {
                                frmReactionCuration absCuration = new frmReactionCuration();
                                absCuration.TaskID = usrTaskSheet.Task_ID;
                                absCuration.TaskAllocationID = usrTaskSheet.TaskAllocation_ID;
                                absCuration.ShipmentRefID = usrTaskSheet.ShipmentRef_ID;
                                absCuration.AbstractRefNo = usrTaskSheet.SelectedRef;
                                sslblRefName.Text = usrTaskSheet.SelectedRef;
                                sslblShipment.Text = usrTaskSheet.ShipmentName;

                                absCuration.MdiParent = this;
                                absCuration.Show();
                            }
                            else if (usrTaskSheet.DocType == "JOURNAL")
                            {
                                frmReactionCuration_Journal journlCuration = new frmReactionCuration_Journal();
                                journlCuration.TaskID = usrTaskSheet.Task_ID;
                                journlCuration.TaskAllocationID = usrTaskSheet.TaskAllocation_ID;
                                journlCuration.ShipmentRefID = usrTaskSheet.ShipmentRef_ID;
                                journlCuration.AbstractRefNo = usrTaskSheet.SelectedRef;
                                sslblRefName.Text = usrTaskSheet.SelectedRef;
                                sslblShipment.Text = usrTaskSheet.ShipmentName;

                                journlCuration.MdiParent = this;
                                journlCuration.Show();
                            }
                        }
                    }
                }
                //  Task Preparation users task sheet.
                else if (GlobalVariables.Module == "TP")
                {
                    using (TaskSheets.FrmTaskSheetTP taskSheet = new TaskSheets.FrmTaskSheetTP())
                    {
                        taskSheet.UserTasks = dtAssignedTans;
                        if (taskSheet.ShowDialog() == DialogResult.OK)
                        {
                            if (taskSheet.userTaskStatus.Task_ID > 0)
                            {
                                GlobalVariables.TaskId = taskSheet.userTaskStatus.Task_ID;

                                FrmPdfGererationOnAbstract objTaskPrepare = new FrmPdfGererationOnAbstract();
                                objTaskPrepare.TaskID = taskSheet.userTaskStatus.Task_ID;
                                objTaskPrepare.TaskAllocationID = taskSheet.userTaskStatus.TaskAllocation_ID;
                                objTaskPrepare.Shipment_Name = taskSheet.ShipmentName;
                                objTaskPrepare.ShipmentYear = taskSheet.ShipmentYear;
                                objTaskPrepare.ShipmentIssue = taskSheet.ShipmentIssue;
                                objTaskPrepare.Abstract_RefNo = taskSheet.AbstractRefNo;
                                objTaskPrepare.ShipmentRefID = taskSheet.ShipmentRef_ID;

                                objTaskPrepare.MdiParent = this;
                                objTaskPrepare.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            try
            {                
                this.WindowState = FormWindowState.Maximized;
                LogoutToolStripMenuItem.Enabled = false;
                //Disable Nenu Items
                DisableMenu_SubMenuItems();

                DataSet dtTemp = new DataSet();
                if (GlobalVariables.SolvCatalystMaster == null)
                {
                    Thread trdDictionary = new Thread(delegate()
                    {
                        if (File.Exists(System.IO.Path.Combine(Application.StartupPath, "solvcats.xml")))
                        {
                            dtTemp.ReadXml(System.IO.Path.Combine(Application.StartupPath, "solvcats.xml"));
                            GlobalVariables.SolvCatalystMaster = dtTemp.Tables[0];
                        }
                    });

                    trdDictionary.IsBackground = true;
                    trdDictionary.Start();
                }

                ssLblAppVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

                loginToolStripMenuItem_Click(null, null);

                #region MyRegion
                //DataTable dtSolvCats = DataOperations.GetAgentSolevtMasterDetails();
                //DataSet dsTemp = new DataSet();
                //dsTemp.Tables.Add(dtSolvCats);
                //dsTemp.WriteXml(System.IO.Path.Combine(Application.StartupPath, "solvcats.xml"));

                //SdfImport.ImportAgentsMaster(System.IO.Path.Combine(Application.StartupPath, "solvcats.sdf"));
                //GlobalVariables.SolvCatalystMaster.TableName = "Solvents"; 
                #endregion                                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void DisableMenu_SubMenuItems()
        {
            try
            {
                foreach (ToolStripMenuItem item in menuStrip.Items)
                {
                    if (item.Text != fileMenu.ToString() && item.Text != aboutTSMenuItem.ToString())
                    {
                        item.Enabled = false;
                    }
                }
                helpToolStripMenuItem.Enabled = true;
                loadTaskTSMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaRes = MessageBox.Show("Do you want to log off?", GlobalVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.Yes)
                {
                    Form[] frmColl = this.MdiChildren;
                    foreach (Form frm in frmColl)
                    {
                        frm.Close();
                    }

                    DisableMenu_SubMenuItems();

                    ResetUserRelatedVariables();

                    loginToolStripMenuItem.Enabled = true;
                    LogoutToolStripMenuItem.Enabled = false;

                    loginToolStripMenuItem_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetUserRelatedVariables()
        {
            try
            {
                GlobalVariables.RoleId = -1;
                GlobalVariables.Module = null;

                sslblRefName.Text = "";
                sslblShipment.Text = "";
                sslblUserName.Text = "";
                sslblRoleName.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void createShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateShipment objCreateShipment = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMCREATESHIPMENT")
                    {
                        objCreateShipment = (frmCreateShipment)objfrm;
                        blFrmOpen = true;
                        objCreateShipment.Show();
                        objCreateShipment.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    objCreateShipment = new frmCreateShipment();
                    objCreateShipment.MdiParent = this;
                    objCreateShipment.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmLogin objLogin = new frmLogin())
                {
                    if (objLogin.ShowDialog() == DialogResult.OK)
                    {                       
                        loginToolStripMenuItem.Enabled = false;
                        LogoutToolStripMenuItem.Enabled = true;

                        sslblUserName.Text = GlobalVariables.UserName;
                        sslblRoleName.Text = GlobalVariables.RoleName;

                        EnableMenu_SubMenuItems(GlobalVariables.RoleId);
                        //if (GlobalVariables.RoleId == 1)//Administrator
                        //{
                        //    userProfileTSMenuItem_Click(null, null);
                        //}
                        if (GlobalVariables.RoleId != 2 && GlobalVariables.RoleId != 3)//Project Manager / Tool Manager
                        {
                            loadTaskTSMenuItem_Click(null, null);
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void reactionAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmSpectralCuration obj = new FrmSpectralCuration())
            {
                obj.ShowDialog();
            }
        }

        private void shipmentExportTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBatchExport objExport = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMBATCHEXPORT")
                    {
                        objExport = (frmBatchExport)objfrm;
                        blFrmOpen = true;
                        objExport.Show();
                        objExport.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    objExport = new frmBatchExport();
                    objExport.MdiParent = this;
                    objExport.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void validateTaskPreparationTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReviewTaskPreparation objValidate = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMREVIEWTASKPREPARATION")
                    {
                        objValidate = (frmReviewTaskPreparation)objfrm;
                        blFrmOpen = true;
                        objValidate.Show();
                        objValidate.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    objValidate = new frmReviewTaskPreparation();
                    objValidate.MdiParent = this;
                    objValidate.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void taskAssingnmentTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTaskAssignment frmTaskAlloc = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMTASKASSIGNMENT")
                    {
                        frmTaskAlloc = (frmTaskAssignment)objfrm;
                        blFrmOpen = true;
                        frmTaskAlloc.Show();
                        frmTaskAlloc.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    frmTaskAlloc = new frmTaskAssignment();
                    frmTaskAlloc.MdiParent = this;
                    frmTaskAlloc.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void userProfileTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserCreate objCreateUser = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMCREATEUSER")
                    {
                        objCreateUser = (frmUserCreate)objfrm;
                        blFrmOpen = true;
                        objCreateUser.Show();
                        objCreateUser.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    objCreateUser = new frmUserCreate();
                    objCreateUser.MdiParent = this;
                    objCreateUser.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void shipmentStatusReportTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmShipmentStatusReport objCreateUser = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMSHIPMENTREPORT_NEW")
                    {
                        objCreateUser = (frmShipmentStatusReport)objfrm;
                        blFrmOpen = true;
                        objCreateUser.Show();
                        objCreateUser.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    objCreateUser = new frmShipmentStatusReport();
                    objCreateUser.MdiParent = this;
                    objCreateUser.Show();
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void aboutTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                aboutWCI frmAbt = new aboutWCI();
                frmAbt.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void solventAgentsMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSolAgentReference solvAgents = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMSOLAGENTREFERENCE")
                    {
                        solvAgents = (frmSolAgentReference)objfrm;
                        blFrmOpen = true;
                        solvAgents.Show();
                        solvAgents.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    solvAgents = new frmSolAgentReference();
                    solvAgents.MdiParent = this;
                    solvAgents.Show();
                    solvAgents.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void usersStatusReportTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDailyStatusReport dailyStatusRep = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMDAILYSTATUSREPORT")
                    {
                        dailyStatusRep = (frmDailyStatusReport)objfrm;
                        blFrmOpen = true;
                        dailyStatusRep.Show();
                        dailyStatusRep.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    dailyStatusRep = new frmDailyStatusReport();
                    dailyStatusRep.MdiParent = this;
                    dailyStatusRep.Show();
                    dailyStatusRep.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void taskModificationTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifyTask taskModify = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMMODIFYTASK")
                    {
                        taskModify = (frmModifyTask)objfrm;
                        blFrmOpen = true;
                        taskModify.Show();
                        taskModify.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    taskModify = new frmModifyTask();
                    taskModify.MdiParent = this;
                    taskModify.Show();
                    taskModify.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }        

        private void shipmentDeliveryTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmShipmentDelivery shipmentDelivery = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMSHIPMENTDELIVERY")
                    {
                        shipmentDelivery = (frmShipmentDelivery)objfrm;
                        blFrmOpen = true;
                        shipmentDelivery.Show();
                        shipmentDelivery.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    shipmentDelivery = new frmShipmentDelivery();
                    shipmentDelivery.MdiParent = this;
                    shipmentDelivery.Show();
                    shipmentDelivery.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }        

        private void deliveryStatusReportTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeliveryReport deliveryReport = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMDELIVERYREPORT")
                    {
                        deliveryReport = (frmDeliveryReport)objfrm;
                        blFrmOpen = true;
                        deliveryReport.Show();
                        deliveryReport.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    deliveryReport = new frmDeliveryReport();
                    deliveryReport.MdiParent = this;
                    deliveryReport.Show();
                    deliveryReport.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void deliveredSolventsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeliveredSolvents deliveredSolvs = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMDELIVEREDSOLVENTS")
                    {
                        deliveredSolvs = (frmDeliveredSolvents)objfrm;
                        blFrmOpen = true;
                        deliveredSolvs.Show();
                        deliveredSolvs.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    deliveredSolvs = new frmDeliveredSolvents();
                    deliveredSolvs.MdiParent = this;
                    deliveredSolvs.Show();
                    deliveredSolvs.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void userHourlyStatusReportTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserHourlyReport hourlyReport = null;
                FormCollection frmColl = Application.OpenForms;
                bool blFrmOpen = false;
                foreach (Form objfrm in frmColl)
                {
                    if (objfrm.Name.ToUpper() == "FRMUSERHOURLYREPORT")
                    {
                        hourlyReport = (frmUserHourlyReport)objfrm;
                        blFrmOpen = true;
                        hourlyReport.Show();
                        hourlyReport.WindowState = FormWindowState.Maximized;
                    }
                }
                if (!blFrmOpen)
                {
                    hourlyReport = new frmUserHourlyReport();
                    hourlyReport.MdiParent = this;
                    hourlyReport.Show();
                    hourlyReport.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

    }
}
