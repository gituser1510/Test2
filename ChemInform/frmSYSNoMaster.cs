using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class frmSYSNoMaster : Form
    {
        public frmSYSNoMaster()
        {
            InitializeComponent();
        }

        DataTable ClassSysNosData = null;

        private void frmSYSNoMaster_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.ClasificationMaster == null)
                {
                    DataSet dsClafMaster = ReactionCurationDB.GetSysNoClassificationMasterDetails();
                    if (dsClafMaster != null)
                    {
                        if (dsClafMaster.Tables.Count == 2)
                        {
                            GlobalVariables.ClasificationMaster = dsClafMaster.Tables[0];
                            GlobalVariables.SysNoClasifications = dsClafMaster.Tables[1];
                        }
                    }
                }

                if (GlobalVariables.ClasificationMaster != null)
                {
                    BindClasificationsToGrid(GlobalVariables.ClasificationMaster);
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        private void BindClasificationsToGrid(DataTable clasifMaster)
        {
            try
            {
                if (clasifMaster != null)
                {
                    dgvClassificationMaster.AutoGenerateColumns = false;
                    dgvClassificationMaster.DataSource = clasifMaster;

                    colCMID.DataPropertyName = "CM_ID";
                    colClassType.DataPropertyName = "CLASS_TYPE";
                    colClass_Name.DataPropertyName = "CLASS_NAME";
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindSysNoClasificationsToGrid(DataTable sysNos)
        {
            try
            {
                if (sysNos != null)
                {
                    dgvSYsNos.AutoGenerateColumns = false;
                    dgvSYsNos.DataSource = sysNos;
                    colSysNo.DataPropertyName = "SYS_NO";
                    colSysText.DataPropertyName = "SYS_TEXT";                    
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        private DataTable GetSysNosOnClassID(int classID)
        {
            DataTable dtSysNos = null;
            try
            {
                if (GlobalVariables.SysNoClasifications != null && classID > 0)
                {
                    var rows = from r in GlobalVariables.SysNoClasifications.AsEnumerable()
                               where r.Field<Int64>("CM_ID") == classID
                               select r;

                    dtSysNos = rows.Any() ? rows.CopyToDataTable() : GlobalVariables.SysNoClasifications.Clone();
                }

            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtSysNos;
        }

        #region Grid RowPostPaint Events

        private void dgvClassificationMaster_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvClassificationMaster.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvClassificationMaster.Font);

                if (dgvClassificationMaster.RowHeadersWidth < (int)(size.Width + 20)) dgvClassificationMaster.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvSYsNos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvSYsNos.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvSYsNos.Font);

                if (dgvSYsNos.RowHeadersWidth < (int)(size.Width + 20)) dgvSYsNos.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void dgvClassificationMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    //if (dgvClassificationMaster.Rows[e.RowIndex].Cells[colClass_Name.Name].Value != null)
                    //{
                    //    if (!string.IsNullOrEmpty(dgvClassificationMaster.Rows[e.RowIndex].Cells[colClass_Name.Name].Value.ToString()))
                    //    {
                    //        txtSelectedSysNo.Clear();
                    //        txtSelectedSysText.Clear();

                    //        txtSelectedClassType.Text = dgvClassificationMaster.Rows[e.RowIndex].Cells[colClassType.Name].Value.ToString();
                    //        int intClassID = Convert.ToInt32(dgvClassificationMaster.Rows[e.RowIndex].Cells[colCMID.Name].Value.ToString());

                    //        if (intClassID > 0)
                    //        {
                    //            ClassSysNosData = GetSysNosOnClassID(intClassID);

                    //            BindSysNoClasificationsToGrid(ClassSysNosData);
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvSYsNos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvSYsNos.Rows[e.RowIndex].Cells[colSysNo.Name].Value != null)
                    {
                        string sysNo = dgvSYsNos.Rows[e.RowIndex].Cells[colSysNo.Name].Value.ToString().Trim();
                        string sysText = dgvSYsNos.Rows[e.RowIndex].Cells[colSysText.Name].Value.ToString().Trim();

                        txtSelectedSysText.Text = string.IsNullOrEmpty(txtSelectedSysText.Text.Trim()) ? sysText : txtSelectedSysText.Text.Trim() + ";" + sysText;
                        txtSelectedSysNo.Text = string.IsNullOrEmpty(txtSelectedSysNo.Text.Trim()) ? sysNo : txtSelectedSysNo.Text.Trim() + ";" + sysNo;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSelectedSysText.Text) && !string.IsNullOrEmpty(txtSelectedSysNo.Text))
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtSelectedClassType.Clear();
                txtSelectedSysText.Clear();
                txtSelectedSysNo.Clear();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtSrchSysNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ClassSysNosData != null)
                {
                    string strFiltCond = "SYS_NO like '" + txtSrchSysNo.Text.Trim() + "%'";
                    if (!string.IsNullOrEmpty(strFiltCond.Trim()))
                    {
                        DataView dtView = ClassSysNosData.Copy().DefaultView;
                        dtView.RowFilter = strFiltCond;
                        DataTable dtSysNos = dtView.ToTable();

                        BindSysNoClasificationsToGrid(dtSysNos);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvClassificationMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string classType = dgvClassificationMaster.Rows[e.RowIndex].Cells[colClassType.Name].Value.ToString();
                    txtSelectedClassType.Text = string.IsNullOrEmpty(txtSelectedClassType.Text.Trim()) ? classType : txtSelectedClassType.Text.Trim() + ";" + classType;

                    int intClassID = Convert.ToInt32(dgvClassificationMaster.Rows[e.RowIndex].Cells[colCMID.Name].Value.ToString());
                    if (intClassID > 0)
                    {
                        ClassSysNosData = GetSysNosOnClassID(intClassID);

                        BindSysNoClasificationsToGrid(ClassSysNosData);
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
