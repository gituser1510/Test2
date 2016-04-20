using System;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Dal;
using System.Data;

namespace ChemInform
{
    public partial class frmSolAgentReference : Form
    {
        public frmSolAgentReference()
        {
            InitializeComponent();
        }

        public string IupacName { get; set; }
        public string MoleFile { get; set; }

        private void frmSolAgentReference_Load(object sender, EventArgs e)
        {
            try
            {
                //Bind  Reference  to grid
                BindReferenceToGrid(GlobalVariables.SolvCatalystMaster);

                cmbSearchBy.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindReferenceToGrid(DataTable solvAgentData)
        {
            try
            {
                if (solvAgentData != null)
                {                    
                    dgvSolAgentRef.AutoGenerateColumns = false;
                    dgvSolAgentRef.DataSource = solvAgentData;

                    colIupacName.DataPropertyName = "IUPAC_NAME";
                    colMolFile.DataPropertyName = "MOL_FILE";
                    colSolAgeId.DataPropertyName = "SOL_AGE_ID";
                    colInchiKey.DataPropertyName = "INCHI_KEY";
                    colInchiString.DataPropertyName = "INCHI_STRING";
                    colOtherNames.DataPropertyName = "OTHER_NAMES";                    
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvSolAgentRef_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvSolAgentRef.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvSolAgentRef.Font);

                if (dgvSolAgentRef.RowHeadersWidth < (int)(size.Width + 20)) dgvSolAgentRef.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
            
        private void dgvSolAgentRef_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    MoleFile = Convert.ToString(dgvSolAgentRef.Rows[e.RowIndex].Cells[colMolFile.Name].Value);
                    IupacName = Convert.ToString(dgvSolAgentRef.Rows[e.RowIndex].Cells[colIupacName.Name].Value);
                    renderer1.MolfileString = MoleFile;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvSolAgentRef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    MoleFile = Convert.ToString(dgvSolAgentRef.Rows[e.RowIndex].Cells[colMolFile.Name].Value);
                    IupacName = Convert.ToString(dgvSolAgentRef.Rows[e.RowIndex].Cells[colIupacName.Name].Value);
                    renderer1.MolfileString = MoleFile;

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }      
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void txtIUPACName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIUPACName.Text.Trim()))
                {
                    DataTable dtFiltered = GetFilteredData(txtIUPACName.Text.Trim(), "NAME");
                    BindReferenceToGrid(dtFiltered);

                    //if (dgvSolAgentRef.Rows.Count == 0)
                    //{
                    //    renderer1.MolfileString = "";
                    //}
                }
                else
                {
                    BindReferenceToGrid(GlobalVariables.SolvCatalystMaster);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void chkSrchByStruct_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSrchByStruct.Checked)
                {
                    string inchi = ChemistryOperations.GetStructureInchiKey(renderer1.MolfileString);
                    DataTable dtFiltered = GetFilteredData(inchi, "INCHI");
                    BindReferenceToGrid(dtFiltered);
                }
                else
                {
                    BindReferenceToGrid(GlobalVariables.SolvCatalystMaster);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private DataTable GetFilteredData(string filterVal, string srcColumn)
        {
            DataTable dtFilterd = null;
            try
            {
                string filterCond = "";                
                //var rows = GlobalVariables.SolAgentMaster.AsEnumerable().Where(n => n.Field<string>("IUPAC_NAME").StartsWith(filterVal.ToUpper(), true, null)).Select(r => r);

                using (DataView dvTemp = GlobalVariables.SolvCatalystMaster.Copy().DefaultView)
                {
                    if (srcColumn.ToUpper() == "INCHI")
                    {
                        filterCond = "INCHI_KEY = '" + filterVal + "'";
                        //var rows = GlobalVariables.SolAgentMaster.AsEnumerable().Where(n => n.Field<string>("IUPAC_NAME").StartsWith(filterVal.ToUpper(), true, null)).Select(r => r);
                        //dtFilterd = rows != null ? rows.CopyToDataTable() : GlobalVariables.SolAgentMaster.Clone();
                    }
                    else
                    {
                        if (cmbSearchBy.Text.ToUpper() == "IUPAC NAME")
                        {
                            filterCond = "IUPAC_NAME like '" + filterVal + "%'";
                        }
                        else
                        {
                            filterCond = "OTHER_NAMES like '%" + filterVal + "%'";
                        }
                        // "IUPAC_NAME like '" + filterVal + "%' or OTHER_NAMES like '%" + filterVal + "%'";
                    }

                    dvTemp.RowFilter = filterCond;
                    dtFilterd = dvTemp.ToTable();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return dtFilterd;
        }

        private void renderer1_StructureChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSrchByStruct.Checked)
                {
                    string inchi = ChemistryOperations.GetStructureInchiKey(renderer1.MolfileString);
                    DataTable dtFiltered = GetFilteredData(inchi, "INCHI");
                    BindReferenceToGrid(dtFiltered);
                }
                //else
                //{
                //    BindReferenceToGrid(GlobalVariables.SolAgentMaster);
                //}
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }        
    }
}
