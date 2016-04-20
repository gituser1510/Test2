using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ChemInform.UserManagement;
using ChemInform.Common;
using ChemInform;

namespace ChemInform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmLogin objLogin = new frmLogin())
                {
                    if (objLogin.ShowDialog() == DialogResult.OK)
                    {
                        tssLblUserNameValue.Text = GlobalVariables.UserName;
                        tsslRoleNameValue.Text = GlobalVariables.RoleName;

                        //string dbUserName = System.Configuration.ConfigurationManager.AppSettings["USERNAME"].ToString();

                        //if (dbUserName.Contains("PRODUCTION"))
                        //    tssLblDataBase.Text = "Database: Connected to Production";
                        //else if (dbUserName.Contains("TRAINING"))
                        //    tssLblDataBase.Text = "Database: Connected to UAT/Training";

                        EnableMenu_SubMenuItems(GlobalVariables.RoleName);

                        logInToolStripMenuItem.Enabled = false;
                        logOffToolStripMenuItem.Enabled = true;

                        //Open User Task Sheet based on UserRole
                        if (GlobalVariables.RoleName.Trim().ToUpper() == "Curator" || GlobalVariables.RoleName.Trim().ToUpper() == "QC"
                            || GlobalVariables.RoleName.Trim().ToUpper() == ""
                            || GlobalVariables.RoleName.Trim().ToUpper() == "")
                        {
                            //getUserTaskToolStripMenuItem_Click(null, null);
                        }
                        else if (GlobalVariables.RoleName.Trim().ToUpper() == "ADMINSTRATOR")
                        {
                            createUserToolStripMenuItem_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void EnableMenu_SubMenuItems(string userRole)
        {
            try
            {
                logInToolStripMenuItem.Enabled = false;
                logOffToolStripMenuItem.Enabled = true;
                if (Equals(userRole.Trim().ToUpper(), "Adminstrator"))
                {
                    userManagementToolStripMenuItem.Enabled = true;
                }
                else if (Equals(userRole.Trim().ToUpper(), "Curator") ||
                         Equals(userRole.Trim().ToUpper(), "QC"))
                {
                    taskSheetToolStripMenuItem.Enabled = true;
                    //Reports - errorcount report enabling - by Eswar 01-Oct-2014
                    reportsToolStripMenuItem.Enabled = true;

                }
                else if (Equals(userRole.Trim().ToUpper(), "ProjectManager"))
                {
                    shipmentToolStripMenuItem.Enabled = true;
                    // taskSheetToolStripMenuItem.Enabled = true;
                    //taskManagementToolStripMenuItem.Enabled = true;
                    reportsToolStripMenuItem.Enabled = true;

                }

                else if (Equals(userRole.Trim().ToUpper(), "QA"))
                {
                    taskSheetToolStripMenuItem.Enabled = true;
                    //Reports - errorcount report enabling - by Eswar 01-Oct-2014
                    reportsToolStripMenuItem.Enabled = true;
                }
                aboutToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Load event of the mdiMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mdiMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DisableMenu_SubMenuItems();

            logInToolStripMenuItem_Click(null, null);


        }

        private void DisableMenu_SubMenuItems()
        {
            try
            {
                foreach (ToolStripMenuItem item in menuStrip.Items)
                {
                    if (item.Text != fileToolStripMenuItem.ToString())
                    {
                        item.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }


        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaRes = MessageBox.Show("Do you want to log off?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.Yes)
                {
                    //Form[] frmColl = this.MdiChildren;
                    //foreach (Form frm in frmColl)
                    //{
                    //    if (frm != this)
                    //    {
                    //        frm.Close();
                    //    }
                    //}

                    List<Form> openForms = new List<Form>();
                    foreach (Form f in Application.OpenForms)
                        openForms.Add(f);


                    //if (General.CheckFormIsOpenedORnot(typeof(FrmIndexingCuration).Name.ToUpper(),
                    //          objIndexingCur))
                    //{
                    //    objIndexingCur.Close();
                    //}                                     


                    if (MdiChildren.Length == 0)
                    {
                        DisableMenu_SubMenuItems();

                        logInToolStripMenuItem.Enabled = true;
                        logOffToolStripMenuItem.Enabled = false;

                        //Reset User information
                        tssLblUserNameValue.Text = "";
                        tsslRoleNameValue.Text = "";
                        tssLblDataBase.Text = "";

                        GlobalVariables.UserName = "";
                        GlobalVariables.RoleName = "";
                        GlobalVariables.UrId = 0;

                        GlobalVariables.UserName = string.Empty;
                        GlobalVariables.RoleName = string.Empty;
                        GlobalVariables.RoleId = 0;
                        GlobalVariables.UserID = 0;
                        GlobalVariables.UrId = 0;
                        GlobalVariables.IsLoginSuccess = false;
                        //msMainMenu.Enabled = false;

                        logInToolStripMenuItem_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaRes = MessageBox.Show("Do you want to exit?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        frmUserCreate _objUserCreate = null;
        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!General.CheckFormIsOpenedORnot(typeof(frmUserCreate).Name.ToUpper(), _objUserCreate))
                {
                    _objUserCreate = new frmUserCreate();
                    _objUserCreate.WindowState = FormWindowState.Maximized;
                }
                _objUserCreate.MdiParent = this;
                _objUserCreate.Show(pnlMain);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        //FrmCreateShipment _objCreateShipment = null;
        private void createShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!General.CheckFormIsOpenedORnot(typeof(frmCreateShipment).Name.ToUpper(), _objCreateShipment))
                //{
                //    _objCreateShipment = new frmCreateShipment();// { WindowState = FormWindowState.Maximized };
                //}
                //_objCreateShipment.MdiParent = this;

                //_objCreateShipment.Show(dockPanel);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void loadTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taskAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAbout frmAb = new frmAbout();
            //frmAb.ShowDialog();

        }


    }
}