using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Bll;
using ChemInform.Common;

namespace ChemInform.TaskSheets
{
    public partial class FrmTaskSheetTP : Form
    {
        public FrmTaskSheetTP()
        {
            InitializeComponent();
        }

        #region Public properties

        public int TaskId { get; set; }       
        public string ShipmentName { get; set; }
        public string AbstractRefNo { get; set; }
        public int ShipmentYear { get; set; }
        public int ShipmentIssue { get; set; }
        public int ShipmentRef_ID { get; set; }
        public DataTable UserTasks { get; set; }

        public TaskStatus userTaskStatus { get; set; }

        #endregion

        private void FrmTaskSheetTP_Load(object sender, EventArgs e)
        {
            try
            {
                FillAssignTask();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Filling Task sheet with Assigned shipments.
        /// </summary>
        private void FillAssignTask()
        {
            try
            {
                dgvProjects.AutoGenerateColumns = false;
                dgvProjects.DataSource = UserTasks;

                colTaskId.DataPropertyName = "TASK_ID";
                colTaskAllocationId.DataPropertyName = "TASK_ALLOC_ID"; 
                colShipMentId.DataPropertyName = "SHIPMENT_ID";
                colShipmentName.DataPropertyName = "SHIPMENT_NAME";
                colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";
                colAbstactRefName.DataPropertyName = "REFERENCE_NAME";
                colIssue.DataPropertyName = "ISSUE";
                colYear.DataPropertyName = "SHIPMENT_YEAR";
                colStatus.DataPropertyName = "TASK_STATUS";

                colShipmentType.DataPropertyName = "DOC_TYPE";
                colAssignedDate.DataPropertyName = "START_DATE";
                //colStatus.DataPropertyName = "DOC_STATUS_NAME";
                colTaskAllocationId.DataPropertyName = "TASK_ALLOC_ID";
                //TaskManagementDB.GetTPassignedShipments(Common.GlobalVariables.UrId);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
       
        private void UpdateUserAssignedTaskStatus(DataGridViewRow gridRow)
        {
            try
            {
                if (gridRow != null)
                {
                    if (gridRow.Cells["colStatus"].Value != null)
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Report for Task Completion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjects.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are you sure Do you want Complete the task ?", GlobalVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int shipmentId = Convert.ToInt32(dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["colShipMentId"].Value);

                        TaskStatus objTStatus = new TaskStatus();
                        objTStatus.Task_ID = Convert.ToInt32(dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["colTaskId"].Value);
                        objTStatus.RoleName = GlobalVariables.RoleName;
                        objTStatus.TaskAllocation_ID = Convert.ToInt32(dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["colTaskAllocationId"].Value);
                        objTStatus.Status = "SET COMPLETE";
                        objTStatus.IsReassigned = 'N';

                        TaskManagementDB.UpdateTaskStatus(objTStatus);
                        MessageBox.Show("Task completed successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillAssignTask();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvProjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvProjects.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvProjects.Font);
                if (dgvProjects.RowHeadersWidth < (int)(size.Width + 20)) dgvProjects.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvProjects.Columns[e.ColumnIndex].Name.ToUpper() == colAbstactRefName.Name.ToUpper())
                    {

                        using (DataGridViewRow gridRow = dgvProjects.Rows[e.RowIndex])
                        {
                            TaskStatus objTStatus = new TaskStatus();
                            TaskId = Convert.ToInt32(gridRow.Cells[colTaskId.Name].Value.ToString());
                            objTStatus.Task_ID = TaskId;
                            objTStatus.Role_ID = GlobalVariables.RoleId;
                            objTStatus.TaskAllocation_ID = Convert.ToInt32(gridRow.Cells[colTaskAllocationId.Name].Value);

                            //Update User task status
                            if (gridRow.Cells[colStatus.Name].Value.ToString().ToUpper().Contains("ASSIGNED"))
                            {
                                objTStatus.TaskStatusName = "SET PROGRESS";
                                objTStatus.IsReassigned = 'N';

                                //Updates the status to Inprogress.
                                TaskManagementDB.UpdateTaskStatus(objTStatus);
                            }

                            userTaskStatus = objTStatus;

                            ShipmentRef_ID = Convert.ToInt32(gridRow.Cells[colShipmentRefID.Name].Value); 
                            ShipmentName = gridRow.Cells[colShipmentName.Name].Value.ToString();
                            ShipmentIssue = Convert.ToInt32(gridRow.Cells[colIssue.Name].Value.ToString());
                            ShipmentYear = Convert.ToInt32(gridRow.Cells[colYear.Name].Value.ToString());
                            AbstractRefNo = gridRow.Cells[colAbstactRefName.Name].Value.ToString(); 

                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

    }
}
