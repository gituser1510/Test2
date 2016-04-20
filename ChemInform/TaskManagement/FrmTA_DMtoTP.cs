using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform.Task_Management
{
    public partial class FrmTA_DMtoTP : Form
    {
        public FrmTA_DMtoTP()
        {
            InitializeComponent();
        }

        private DataTable DtTasks { get; set; }

        private void FrmTA_DMtoTP_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;

                BindAllShipments();
                BindTaskPreparationUsers();
                FillAssignmentGrid();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Bind TakPreparation user.
        private void BindTaskPreparationUsers()
        {
            try
            {
                int TaskPreparationRoleid = 9;

                cmbUserName.DataSource = UserManagementDB.GetUserNamesAndUserRoleIds(TaskPreparationRoleid);
                cmbUserName.DisplayMember = "USER_NAME";
                cmbUserName.ValueMember = "UR_ID";
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Bind AllShipments.
        private void BindAllShipments()
        {
            try
            {
                DataTable dtShipMents = Dal.DataOperations.GetAllShipments();
                if (dtShipMents.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbShipmentName.DataSource = dtShipMents;
                    cmbShipmentName.DisplayMember = "SHIPMENT_NAME";
                    cmbShipmentName.ValueMember = "SHIPMENT_ID";
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }      


        // Assign Task.
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    int ShipMentId = Convert.ToInt32(cmbShipmentName.SelectedValue);
                    int TaskPrepUrId = Convert.ToInt32(cmbUserName.SelectedValue);

                    TaskManagementDB.TAtoTaskPrep(ShipMentId, TaskPrepUrId, Common.GlobalVariables.UrId);
                    MessageBox.Show("Task Assigned Successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillAssignmentGrid();
                    ResetUserInPuts();
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void FillAssignmentGrid()
        {
            try
            {
                dgvAssignedTaskPreparation.AutoGenerateColumns = false;
                ColTpShipmentId.DataPropertyName = "SHIPMENT_ID";
                colTPShipMentName.DataPropertyName = "SHIPMENT_NAME";
                colTPAssignedTo.DataPropertyName = "USER_NAME";
                colTPAssignedDate.DataPropertyName = "START_DATE";
                colTpEndDate.DataPropertyName = "END_DATE";
                colTPStatus.DataPropertyName = "DOC_STATUS_NAME";
                dgvAssignedTaskPreparation.DataSource = TaskManagementDB.GetDMAssignedTaskPreP(Common.GlobalVariables.UrId);
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }



        #region Reset Controls
        private void ResetUserInPuts()
        {
            cmbShipmentName.SelectedIndex = -1;
            cmbUserName.SelectedIndex = -1;
        }

        #endregion

        #region Validate InputControls
        private bool ValidateUserInputs(out string _errmsg)
        {
            bool blStatus = true;
           
               
                string strErrMsg = "";
                try
                {
                    if (cmbShipmentName.SelectedItem == null)
                    {
                        strErrMsg = String.Format("{0}\r\nPlease select Shipment Name", strErrMsg.Trim());
                        blStatus = false;
                    }
                    if (cmbUserName.SelectedItem == null)
                    {
                        strErrMsg = String.Format("{0}\r\nPlease select User Name", strErrMsg.Trim());
                        blStatus = false;
                    }
                    if (blStatus)
                    {
                        DataView dvTemp = DataGridView2DataTable(dgvAssignedTaskPreparation).DefaultView;
                        dvTemp.RowFilter = "colTPShipMentName = '" + cmbShipmentName.Text + " ' and colTPAssignedTo = '" + cmbUserName.Text + "'";
                        DataTable dtTemp = dvTemp.ToTable();
                        if (dtTemp != null)
                        {
                            if (dtTemp.Rows.Count > 0)
                            {
                                blStatus = false;
                                strErrMsg = cmbShipmentName.Text + " already assigned to " + cmbUserName.Text + ".";
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                   ErrorHandling.WriteErrorLog(ex.ToString());
                }
                _errmsg = strErrMsg;
                return blStatus;
            
        }
        #endregion

        //Converts the DataGridView to DataTable
        public DataTable DataGridView2DataTable(DataGridView dgv)
        {
            try
            {
                if (dgv != null)
                {

                    DataTable dt = new DataTable();

                    // Header columns
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        DataColumn dc = new DataColumn(column.Name.ToString());
                        dt.Columns.Add(dc);
                    }

                    // Data cells
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                        }
                        dt.Rows.Add(dr);
                    }

                    // Related to the bug arround min size when using ExcelLibrary for export
                    for (int i = dgv.Rows.Count; i < 0; i++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            dr[j] = "  ";
                        }
                        dt.Rows.Add(dr);
                    }
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return null;
        }


        #region Row post paint datagridview
        private void dgvAssignedTaskPreparation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAssignedTaskPreparation.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedTaskPreparation.Font);

                if (dgvAssignedTaskPreparation.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedTaskPreparation.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }


        }
        #endregion
    }
}
