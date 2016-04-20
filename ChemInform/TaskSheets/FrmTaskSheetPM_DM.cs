using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemInform.TaskSheets
{
    public partial class FrmTaskSheetPM_DM : Form
    {
        public FrmTaskSheetPM_DM()
        {
            InitializeComponent();
        }

        private void FrmTaskSheetPM_DM_TP_Load(object sender, EventArgs e)
        {
            BindAllShipments();

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
            catch (Exception)
            {

                throw;
            }
        }



    }
}
