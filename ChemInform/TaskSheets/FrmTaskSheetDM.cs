using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Dal;

namespace ChemInform.TaskSheets
{
    public partial class FrmTaskSheetDM : Form
    {
        public FrmTaskSheetDM()
        {
            InitializeComponent();
        }

        private void FrmTaskSheetPM_DM_TP_Load(object sender, EventArgs e)
        {
            BindAllShipments();
        }

        /// <summary>
        /// Filling Task sheet with Assigned shipments.
        /// </summary>
        private void FillTaskPrepGrid()
        {
            try
            {
                dgvTaskPrep.AutoGenerateColumns = false;
                colSaDocId.DataPropertyName = "SHIPMENT_ID";
                colTpShipmentName.DataPropertyName = "SHIPMENT_NAME";
                colTpAssignedTo.DataPropertyName = "USER_NAME";
                colTpAssignedDate.DataPropertyName = "START_DATE";
                colTpEndDate.DataPropertyName = "END_DATE";
                colTpStatus.DataPropertyName = "DOC_STATUS_NAME";
                dgvTaskPrep.DataSource = TaskManagementDB.GetDMAssignedTaskPreP(Common.GlobalVariables.UR_ID);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        ///   Bind AllShipments.
        /// </summary>
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

        private void tcModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcModules.SelectedTab == tpTaskPrep)
            {
                cmbShipmentName.Enabled = false;
                cmbShipmentName.SelectedIndex = -1;
                FillTaskPrepGrid();
            }
            else
            {
                cmbShipmentName.Enabled = true;
                cmbShipmentName.SelectedIndex = -1;
            }
        }

    }
}
