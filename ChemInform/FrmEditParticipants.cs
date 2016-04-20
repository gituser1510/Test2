using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class FrmEditParticipants : Form
    {
        public FrmEditParticipants()
        {
            InitializeComponent();
        }

        #region Public Properties
        MDL.Draw.Renditor.Renditor renditor1 = new MDL.Draw.Renditor.Renditor();
        public ParticipantInfo PaticipantData { set; get; }
        public bool IsEdit { get; set; }
        public int EditRowIndex { get; set; }

        public DataTable OthRxnsProducts { get; set; }
        public int shipmentRefID { get; set; }
        #endregion

        private void FrmParticipants_Load(object sender, EventArgs e)
        {
            try
            {
                if (PaticipantData != null)
                {
                    txtName.Text = PaticipantData.ParticipantName;
                    txtStructNo.Text = PaticipantData.StructureNo;
                    txtGrade.Text = PaticipantData.Grade;
                    if (PaticipantData.Structure != null)
                    {
                        ChemRenditor.MolfileString = PaticipantData.Structure.ToString();
                    }

                    cmbType.SelectedIndex = cmbType.FindStringExact(PaticipantData.ParticipantType);
                }               
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetOtherReactionsProductsAndBindToGrid()
        {
            try
            {
                if (OthRxnsProducts == null)
                {
                    OthRxnsProducts = ReactionCurationDB.GetProductsOnShipmentRefID(GlobalVariables.ShipmentRefID);

                    //Add Structure Image
                    if (OthRxnsProducts.Rows.Count > 0)
                    {
                        OthRxnsProducts.Columns.Add("STRUCT_IMAGE", typeof(Image));

                        foreach (DataRow drow in OthRxnsProducts.Rows)
                        {
                            renditor1.MolfileString = "";
                            renditor1.MolfileString = drow["PROD_STRUCTURE"].ToString();
                            drow["STRUCT_IMAGE"] = (object)renditor1.Image;
                        }
                    }
                }

                if (OthRxnsProducts.Rows.Count > 0)
                {
                    colRxnNo.DataPropertyName = "REACTION_SNO";
                    colProductName.DataPropertyName = "PRODUCT_NAME";
                    colProdMolFile.DataPropertyName = "PROD_STRUCTURE";                    
                    colProdMolImage.DataPropertyName = "STRUCT_IMAGE";
                    colProdStructNo.DataPropertyName = "STRUCTURE_NO";
                    colProdInchi.DataPropertyName = "INCHI_KEY";

                    dgvProducts.AutoGenerateColumns = false;
                    dgvProducts.DataSource = OthRxnsProducts;
                }      
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidatePaticipantControls(ref strErrMsg))
                {
                    if (PaticipantData == null)
                    {
                        PaticipantData = new ParticipantInfo();
                    }                   

                    PaticipantData.ParticipantName = txtName.Text;
                    PaticipantData.StructureNo = txtStructNo.Text;
                    PaticipantData.Grade = txtGrade.Text;
                    PaticipantData.ParticipantType = (string)cmbType.SelectedItem;
                    PaticipantData.Structure = ChemRenditor.MolfileString;
                    PaticipantData.StructureImage = (object)ChemRenditor.Image;
                    PaticipantData.InchiKey = Convert.ToString(ChemistryOperations.GetStructureInchiKey(ChemRenditor.MolfileString));

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(strErrMsg.Trim(), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool ValidatePaticipantControls(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += Environment.NewLine + "Name can't be null";
                }
                if (string.IsNullOrEmpty(txtStructNo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += Environment.NewLine + "Structure Number can't be null";
                }
                //if (string.IsNullOrEmpty(txtGrade.Text.Trim()))//Grade is optional
                //{
                //    blStatus = false;
                //    errmsg_out += "\r\n" + " Grade can't be null";
                //}

                if (cmbType.SelectedItem == null)
                {
                    blStatus = false;
                    errmsg_out += Environment.NewLine + "Type can't be null";
                }

                if (string.IsNullOrEmpty(lblStructureInchi.Text.Trim()))//Grade is optional
                {
                    blStatus = false;
                    errmsg_out += Environment.NewLine + "Inchi Key is not generated. Invalid Structure";
                }
                else if (lblStructureInchi.Text.Trim().ToUpper() == "INCHI NOT GENERATED")
                {
                    if (txtName.Text.Trim().ToUpper() != "POLYPHOSPHORIC ACID")//Temperoty condition
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Inchi Key is not generated. Invalid Structure";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private void lnkSolvAgentRef_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (GlobalVariables.SolvCatalystMaster == null)
                {
                    MessageBox.Show("Master table not yet loaded. Please try later.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (frmSolAgentReference frmSolAgent = new frmSolAgentReference())
                    {
                        if (frmSolAgent.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!String.IsNullOrEmpty(frmSolAgent.IupacName.Trim()) && !String.IsNullOrEmpty(frmSolAgent.MoleFile.Trim()))
                            {
                                txtName.Text = frmSolAgent.IupacName;
                                ChemRenditor.MolfileString = frmSolAgent.MoleFile;
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

        private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbType.SelectedIndex != -1)
                {
                    if (cmbType.Text.ToUpper() == "AGENT" || cmbType.Text.ToUpper() == "SOLVENT" || cmbType.Text.ToUpper() == "CATALYST")
                    {
                        lnkSolvAgentRef.Enabled = true;

                        dgvProducts.DataSource = null;
                        //ChemRenditor.MolfileString = "";

                        //Grade is not required for Agent/Solvent/Catalyst in ABSTRACTs
                        txtGrade.Clear();
                        txtGrade.Enabled = false;
                    }
                    else if (cmbType.Text.ToUpper() == "REACTANT")
                    {
                        Cursor = Cursors.WaitCursor;

                        //Bind Other Reactions Products to grid
                        GetOtherReactionsProductsAndBindToGrid();

                        lnkSolvAgentRef.Enabled = false;

                        txtGrade.Enabled = true;

                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        lnkSolvAgentRef.Enabled = false;
                    }
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
                Cursor = Cursors.Default;
            }
        }

        private void ChemRenditor_ComStructureChanged()
        {
            try
            {
                if (!string.IsNullOrEmpty(ChemRenditor.MolfileString))
                {
                    lblStructureInchi.Text = ChemistryOperations.GetStructureInchiKey(ChemRenditor.MolfileString);
                }
                else
                {
                    lblStructureInchi.Text = "";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    ChemRenditor.MolfileString = dgvProducts.Rows[e.RowIndex].Cells[colProdMolFile.Name].Value.ToString();
                    txtName.Text = dgvProducts.Rows[e.RowIndex].Cells[colProductName.Name].Value.ToString();
                    txtStructNo.Text = dgvProducts.Rows[e.RowIndex].Cells[colProdStructNo.Name].Value.ToString();

                    btnSave_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }       
        
        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    renderer1.MolfileString = dgvProducts.Rows[e.RowIndex].Cells[colProdMolFile.Name].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvProducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvProducts.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvProducts.Font);

                if (dgvProducts.RowHeadersWidth < (int)(size.Width + 20)) dgvProducts.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtStructNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
