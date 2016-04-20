using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Common;
using ChemInform.OSRA;
using chemaxon.util;
using chemaxon.struc;

namespace ChemInform.UserControls
{
    public partial class ucSpectrlData : UserControl
    {
        public ucSpectrlData()
        {
            InitializeComponent();
        }

        public NMRSpectralInfo NmrDetails
        {
            get;
            set;
        }

        NMRSpectralInfo objNmr = null;
        OtherSpectralInfo objMassIrUv = null;

        private void UcSpectrlDataCuration_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        protected DataTable GetNmrTableDefinition()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nucles", typeof(string));
            dt.Columns.Add("spectrometer", typeof(string));
            dt.Columns.Add("solvent", typeof(string));
            dt.Columns.Add("frequency", typeof(string));
            dt.Columns.Add("standard", typeof(string));
            dt.Columns.Add("shiftvalues", typeof(string));
            #region MyRegion
            //DataRow dr;

            //dr = dt.NewRow();
            //dr["nucles"] = 0;
            //dr["spectrometer"] = Convert.ToDateTime("15:50");
            //dr["solvent"] = Convert.ToDateTime("15:55");
            //dr["frequency"] = "Event 1";
            //dr["standard"] = "red";
            //dr["shiftvalues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["nucles"] = 1;
            //dr["spectrometer"] = Convert.ToDateTime("16:00");
            //dr["solvent"] = Convert.ToDateTime("17:00");
            //dr["frequency"] = "Event 2";
            //dr["standard"] = "red";
            //dr["shiftvalues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["nucles"] = 2;
            //dr["spectrometer"] = Convert.ToDateTime("16:15");
            //dr["solvent"] = Convert.ToDateTime("18:45");
            //dr["frequency"] = "Event 3";
            //dr["shiftvalues"] = "red";
            //dr["standard"] = "red";

            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["nucles"] = 3;
            //dr["spectrometer"] = Convert.ToDateTime("16:30");
            //dr["solvent"] = Convert.ToDateTime("17:30");
            //dr["standard"] = "red";
            //dr["frequency"] = "Sales Dept. Meeting Once Again";
            //dr["shiftvalues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["nucles"] = 4;
            //dr["spectrometer"] = Convert.ToDateTime("8:00");
            //dr["solvent"] = Convert.ToDateTime("9:00");
            //dr["frequency"] = "Event 4";
            //dr["standard"] = "red";
            //dr["shiftvalues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["nucles"] = 5;
            //dr["spectrometer"] = Convert.ToDateTime("22:00");
            //dr["solvent"] = Convert.ToDateTime("6:00").AddDays(1);
            //dr["frequency"] = "Event 5";
            //dr["shiftvalues"] = "red";
            //dr["standard"] = "red";
            //dt.Rows.Add(dr);


            //dr = dt.NewRow();
            //dr["nucles"] = 6;
            //dr["spectrometer"] = Convert.ToDateTime("11:00");
            //dr["solvent"] = Convert.ToDateTime("13:00");
            //dr["frequency"] = "Event 6";
            //dr["standard"] = "red";
            //dr["shiftvalues"] = "red";
            //dt.Rows.Add(dr); 
            #endregion
            
            return dt;
        }

        protected DataTable GetMassIrUvTableDefinition()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("category", typeof(string));
            dt.Columns.Add("spectrometer", typeof(string));
            dt.Columns.Add("method", typeof(string));
            dt.Columns.Add("ev", typeof(string));
            dt.Columns.Add("samplePrep", typeof(string));
            dt.Columns.Add("comments", typeof(string));
            dt.Columns.Add("peakValues", typeof(string));
            #region MyRegion
            //DataRow dr;

            //dr = dt.NewRow();
            //dr["category"] = 0;
            //dr["spectrometer"] = Convert.ToDateTime("15:50");
            //dr["method"] = Convert.ToDateTime("15:55");
            //dr["ev"] = "Event 1";
            //dr["samplePrep"] = "Event 1";
            //dr["comments"] = "red";
            //dr["peakValues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["category"] = 1;
            //dr["spectrometer"] = Convert.ToDateTime("16:00");
            //dr["method"] = Convert.ToDateTime("17:00");
            //dr["ev"] = "Event 2";
            //dr["samplePrep"] = "Event 1";
            //dr["comments"] = "red";
            //dr["peakValues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["category"] = 2;
            //dr["spectrometer"] = Convert.ToDateTime("16:15");
            //dr["method"] = Convert.ToDateTime("18:45");
            //dr["ev"] = "Event 3";
            //dr["samplePrep"] = "Event 1";
            //dr["peakValues"] = "red";
            //dr["comments"] = "red";

            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["category"] = 3;
            //dr["spectrometer"] = Convert.ToDateTime("16:30");
            //dr["method"] = Convert.ToDateTime("17:30");
            //dr["comments"] = "red";
            //dr["ev"] = "Sales Dept. Meeting Once Again";
            //dr["samplePrep"] = "Event 1";
            //dr["peakValues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["category"] = 4;
            //dr["spectrometer"] = Convert.ToDateTime("8:00");
            //dr["method"] = Convert.ToDateTime("9:00");
            //dr["ev"] = "Event 4";
            //dr["samplePrep"] = "Event 1";
            //dr["comments"] = "red";
            //dr["peakValues"] = "red";
            //dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr["category"] = 5;
            //dr["spectrometer"] = Convert.ToDateTime("22:00");
            //dr["method"] = Convert.ToDateTime("6:00").AddDays(1);
            //dr["ev"] = "Event 5";
            //dr["samplePrep"] = "Event 1";
            //dr["peakValues"] = "red";
            //dr["comments"] = "red";
            //dt.Rows.Add(dr);


            //dr = dt.NewRow();
            //dr["category"] = 6;
            //dr["spectrometer"] = Convert.ToDateTime("11:00");
            //dr["method"] = Convert.ToDateTime("13:00");
            //dr["ev"] = "Event 6";
            //dr["samplePrep"] = "Event 1";
            //dr["comments"] = "red";
            //dr["peakValues"] = "red";
            //dt.Rows.Add(dr); 
            #endregion


            return dt;
        }

        #region Add NMR/Mass Button Events
        
        private void btnAddNMR_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";

                if (ValidateNMRControlValues(out strErrMsg))
                {
                    objNmr = new NMRSpectralInfo();
                    objNmr.SpectroMeter = (string)cmbNmrSpectroMeter.SelectedItem;
                    objNmr.Frequency = (string)cmbNmrFreq.SelectedItem;
                    objNmr.StdSolvent = txtNmrStandard.Text;
                    objNmr.Solvent = (string)cmbNmrSolvent.SelectedItem;
                    objNmr.Nucleus = (string)cmbNmrNucleus.SelectedItem;
                    objNmr.ShiftValues = txtNmrShiftValues.Text;

                    if (blEditNmr)
                    {
                        if (bsNMR != null)
                        {  
                            bsNMR.List[editRowIndxNmr] = objNmr;
                            bsNMR.ResetBindings(true);
                        }             
                    }
                    else
                    {
                        List<NMRSpectralInfo> lstNMR = new List<NMRSpectralInfo>();
                        lstNMR.Add(objNmr);
                        BindDataToNMRGrid(lstNMR);                        
                    }

                    //Reset NMR controls
                    ResetNmrControls();
                }
                else
                {
                    MessageBox.Show(strErrMsg, "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnAddMassIRUV_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateMassIrUvControlValues(out strErrMsg))
                {
                    objMassIrUv = new OtherSpectralInfo();
                    objMassIrUv.SpectroMeter = (string)cmbMassSpectrometer.SelectedItem;
                    objMassIrUv.Comments = txtMassIrUvComments.Text;
                    objMassIrUv.Method = txtMassIrUvMethod.Text;
                    objMassIrUv.ValueType = (string)cmbMassIrUvType.SelectedItem;
                    objMassIrUv.ElectronVolts = txtEv.Text;
                    objMassIrUv.PeakValues = txtMassIrUvPeaks.Text;

                    if (blEditMassIrUv)
                    {
                        if (bsOtherNMR != null)
                        {
                            bsOtherNMR.List[editRowIndxMassIrUv] = objMassIrUv;
                            bsOtherNMR.ResetBindings(true);
                        }  
                    }
                    else
                    {
                        List<OtherSpectralInfo> lstOtherNMR = new List<OtherSpectralInfo>();
                        lstOtherNMR.Add(objMassIrUv);
                        BindDataToMassIrUVGrid(lstOtherNMR); 
                    }

                    //Reset Control values
                    ResetMassIrUvControls();
                }
                else
                {
                    MessageBox.Show(strErrMsg, "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
        
        #endregion

        private void UpdateRowNmrGrid(NMRSpectralInfo objNmr, int editRowIndx)
        {
            try
            {
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrSpectrometer"].Value = objNmr.SpectroMeter;
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrFreq"].Value = objNmr.Frequency;
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrStandard"].Value = objNmr.StdSolvent;
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrSolvent"].Value = objNmr.Solvent;
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrNucles"].Value = objNmr.Nucleus;
                dgvNmrValues.Rows[editRowIndx].Cells["colNmrShiftValues"].Value = objNmr.ShiftValues;

                editRowIndxNmr = -1;
                blEditNmr = false;
                MessageBox.Show("Updated successfully", "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void InsertIntoNmrGrid(NMRSpectralInfo objNmr)
        {
            try
            {
                dgvNmrValues.Rows.Add();
                int RowIndex = dgvNmrValues.Rows.Count - 1;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrSpectrometer"].Value = objNmr.SpectroMeter;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrFreq"].Value = objNmr.Frequency;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrStandard"].Value = objNmr.StdSolvent;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrSolvent"].Value = objNmr.Solvent;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrNucles"].Value = objNmr.Nucleus;
                dgvNmrValues.Rows[RowIndex].Cells["colNmrShiftValues"].Value = objNmr.ShiftValues;
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }     
                 
        private void InsertIntoMassIrUvGrid(OtherSpectralInfo objMassIrUv)
        {
            try
            {
                dgvMassIrUv.Rows.Add();
                int RowIndex = dgvMassIrUv.Rows.Count - 1;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvSpectrometer"].Value = objMassIrUv.SpectroMeter;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvComments"].Value = objMassIrUv.Comments;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvMethod"].Value = objMassIrUv.Method;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvCategory"].Value = objMassIrUv.ValueType;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvEv"].Value = objMassIrUv.ElectronVolts;
                dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvPeaks"].Value = objMassIrUv.PeakValues;
                //dgvMassIrUv.Rows[RowIndex].Cells["colMassIrUvSamplePrep"].Value = objMassIrUv.SamplePrep;
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
              
        private void UpdateRowMassIrUvGrid(OtherSpectralInfo objMassIrUv, int editRowIndxMassIrUv)
        {
            try
            {
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvSpectrometer"].Value = objMassIrUv.SpectroMeter;
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvComments"].Value = objMassIrUv.Comments;
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvMethod"].Value = objMassIrUv.Method;
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvCategory"].Value = objMassIrUv.ValueType;
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvEv"].Value = objMassIrUv.ElectronVolts;
                dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvPeaks"].Value = objMassIrUv.PeakValues;
                //dgvMassIrUv.Rows[editRowIndxMassIrUv].Cells["colMassIrUvSamplePrep"].Value = objMassIrUv.SamplePrep;

                editRowIndxMassIrUv = -1;
                blEditMassIrUv = false;
                MessageBox.Show("Updated successfully", "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool DeleteNmrValueFromTable(string strFieldVal)
        {
            throw new NotImplementedException();
        }

        #region Methods for Control values validation
        
        private bool ValidateMassIrUvControlValues(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbMassSpectrometer.SelectedItem == null)
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "Spectrometer can't be null";
                }

                if (string.IsNullOrEmpty(txtEv.Text.Trim()))
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "Ev can't be null";
                }
                if (string.IsNullOrEmpty(txtMassIrUvPeaks.Text.Trim()))
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "Peaks can't be null";
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg.Trim();
            return blStatus;
        }

        private bool ValidateCompoundControlValues(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (string.IsNullOrEmpty(txtCompLabel.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Compound Label can't be null";
                }
                if (string.IsNullOrEmpty(txtCompNo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Compound No. can't be null";
                }
                if (string.IsNullOrEmpty(txtMolFormula.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Mol.Formula can't be null";
                }
                if (string.IsNullOrEmpty(txtIUPAC.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "IUPAC Name can't be null";
                }
                if (string.IsNullOrEmpty(txtPageLabel.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "PageLabel can't be null";
                }
                if (string.IsNullOrEmpty(txtMolWeight.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Mol.Weight can't be null";
                }
                else
                {
                    //if (!SpectralDataCuration_BLL.clsValidations.IsDouble(txtMolWeight.Text))
                    //{
                    //    blStatus = false;
                    //    errmsg_out += "\r\n" + "Mol weight value should be Float value.";
                    //}
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private bool ValidateNMRControlValues(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbNmrSpectroMeter.SelectedItem == null)
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "Spectometer can't be null";
                }

                if (cmbNmrNucleus.SelectedItem == null)
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "Nucleus can't be null";

                }
                if (string.IsNullOrEmpty(txtNmrShiftValues.Text.Trim()))
                {
                    blStatus = false;
                    strErrMsg += "\r\n" + "ShiftValues can't be null";
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg.Trim();
            return blStatus;
        }

        public bool ValidateSpectralDataControlValues(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (!ValidateCompoundControlValues(ref errmsg_out))
                {
                    blStatus = false;
                }

                if (dgvNmrValues.Rows.Count == 0 && dgvMassIrUv.Rows.Count == 0)
                {
                    blStatus = false;
                    errmsg_out = errmsg_out + "\r\n" + "Atleast one NMR/Mass/IR/UV values should be there.";
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        #endregion

        #region GridViews CellClick Events
        
        int editRowIndxNmr = 0;
        bool blEditNmr = false;

        int editRowIndxMassIrUv = 0;
        bool blEditMassIrUv = false;

        private void dgvNmrValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvNmrValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        cmbNmrSpectroMeter.SelectedIndex = cmbNmrSpectroMeter.FindStringExact((string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrSpectrometer"].Value);
                        cmbNmrFreq.SelectedIndex = cmbNmrFreq.FindStringExact((string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrFreq"].Value);
                        cmbNmrSolvent.SelectedIndex = cmbNmrSolvent.FindStringExact((string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrSolvent"].Value);
                        cmbNmrNucleus.SelectedIndex = cmbNmrNucleus.FindStringExact((string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrNucles"].Value);
                        txtNmrStandard.Text = (string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrStandard"].Value;
                        txtNmrShiftValues.Text = (string)dgvNmrValues.Rows[e.RowIndex].Cells["colNmrShiftValues"].Value;

                        editRowIndxNmr = e.RowIndex;
                        blEditNmr = true;
                    }
                    else if (dgvNmrValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "DELETE")
                    {
                        //Reset NMR controls
                        editRowIndxNmr = 0;
                        blEditNmr = false;
                        ResetNmrControls();

                        if (MessageBox.Show("Do you want to delete this row ?", "Spectral Data Curation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bsNMR.RemoveAt(e.RowIndex);                         
                            MessageBox.Show("Deleted value successfully", "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvMassIrUv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvMassIrUv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        cmbMassSpectrometer.SelectedIndex = cmbMassSpectrometer.FindStringExact((string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvSpectrometer"].Value);
                        cmbMassIrUvType.SelectedIndex = cmbMassIrUvType.FindStringExact((string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvCategory"].Value);
                        txtMassIrUvComments.Text = (string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvComments"].Value;
                        txtMassIrUvMethod.Text = (string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvMethod"].Value;
                        txtEv.Text = (string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvEv"].Value;
                        txtMassIrUvPeaks.Text = (string)dgvMassIrUv.Rows[e.RowIndex].Cells["colMassIrUvPeaks"].Value;

                        editRowIndxMassIrUv = e.RowIndex;
                        blEditMassIrUv = true;
                    }
                    else if (dgvMassIrUv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "DELETE")
                    {
                        //Reset controls
                        editRowIndxMassIrUv = 0;
                        blEditMassIrUv = false;
                        ResetMassIrUvControls();

                        if (MessageBox.Show("Do you want to delete this row ?", "Spectral Data Curation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {                    
                            // TODO: place delete Record Code here

                            if (true)
                            {
                                MessageBox.Show("Deleted value successfully", "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error in deleting value", "Spectral Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        #endregion
        
        #region Grid RowPostPaint Events
        
        private void dgvNmrValues_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvNmrValues.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvNmrValues.Font);

                if (dgvNmrValues.RowHeadersWidth < (int)(size.Width + 20)) dgvNmrValues.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvMassIrUv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvMassIrUv.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvMassIrUv.Font);

                if (dgvMassIrUv.RowHeadersWidth < (int)(size.Width + 20)) dgvMassIrUv.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
        
        #endregion
              
        #region Reset Controls

        public void ResetAllControlValues()
        {
            try
            {
                ResetCompoundControls();

                ResetNmrControls();

                ResetMassIrUvControls();

                dgvMassIrUv.DataSource = null;
                dgvNmrValues.DataSource = null;
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetCompoundControls()
        {
            try
            {
                txtCompNo.Clear();
                txtMolFormula.Clear();
                txtMolWeight.Clear();
                txtIUPAC.Clear();
                txtPageLabel.Clear();
                txtComments.Clear();
                txtSynonyms.Clear();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetNmrControls()
        {
            try
            {
                cmbNmrSpectroMeter.SelectedIndex = -1;
                cmbNmrFreq.SelectedIndex = -1;
                cmbNmrSolvent.SelectedIndex = -1;
                cmbNmrNucleus.SelectedIndex = -1;
                txtNmrStandard.Clear();
                txtNmrShiftValues.Clear();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetMassIrUvControls()
        {
            try
            {
                cmbMassSpectrometer.SelectedIndex = -1;
                cmbMassIrUvType.SelectedIndex = -1;
                txtMassIrUvComments.Clear();
                txtEv.Clear();
                txtMassIrUvMethod.Clear();
                txtMassIrUvPeaks.Clear();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
       
        #endregion

        #region Bind Generic Lists to DataGridViews

        public void BindSpectralInfoToControls(SpectralInfo spectralData)
        {
            try
            {
                if (spectralData != null)
                {
                    //Bind Compound information
                    BindCompoundDataToControls(spectralData.CompoundInformation);

                    //Bind NMR information
                    BindDataToNMRGrid(spectralData.NMRSpectralList);

                    //Bind Other Spectral information
                    BindDataToMassIrUVGrid(spectralData.OtherSpectralList);
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindCompoundDataToControls(CompoundInfo compData)
        {
            try
            {
                if (compData != null)
                {
                    txtCompNo.Text = compData.CompoundNo;
                    txtMolFormula.Text = compData.MolFormula;
                    txtMolWeight.Text = compData.MolWeight;
                    txtIUPAC.Text = compData.IUPACName;
                    txtPageLabel.Text = compData.PageNo;
                    txtComments.Text = compData.Comments;
                    txtSynonyms.Text = compData.Synonyms;                    
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        BindingSource bsNMR;
        private void BindDataToNMRGrid(List<NMRSpectralInfo> nmrList)
        {
            try
            {
                if (nmrList != null)
                {
                    if (bsNMR == null)
                    {
                        bsNMR = new BindingSource();
                        bsNMR.AllowNew = true;
                    }

                    bsNMR.DataSource = typeof(NMRSpectralInfo);
                    for (int i = 0; i < nmrList.Count; i++)
                    {
                        bsNMR.Add(nmrList[i]);
                    }

                    dgvNmrValues.AutoGenerateColumns = false;
                    dgvNmrValues.DataSource = bsNMR;

                    colNMRID.DataPropertyName = "NMRSpectralID";
                    colNmrStandard.DataPropertyName = "StdSolvent";
                    colNmrSpectrometer.DataPropertyName = "SpectroMeter";
                    colNmrSolvent.DataPropertyName = "Solvent";
                    colNmrShiftValues.DataPropertyName = "ShiftValues";
                    colNmrNucles.DataPropertyName = "Nucleus";
                    colNmrFreq.DataPropertyName = "Frequency";                
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        BindingSource bsOtherNMR;
        private void BindDataToMassIrUVGrid(List<OtherSpectralInfo> othSpectralList)
        {
            try
            {
                if (othSpectralList != null)
                {
                    if (bsOtherNMR == null)
                    {
                        bsOtherNMR = new BindingSource();
                        bsOtherNMR.AllowNew = true;
                    }

                    bsOtherNMR.DataSource = typeof(OtherSpectralInfo);
                    for (int i = 0; i < othSpectralList.Count; i++)
                    {
                        bsOtherNMR.Add(othSpectralList[i]);
                    }

                    dgvMassIrUv.AutoGenerateColumns = false;
                    dgvMassIrUv.DataSource = bsOtherNMR;

                    colOtherNMRID.DataPropertyName = "OtherSpectralID";
                    colOtherNMRValueType.DataPropertyName = "ValueType";
                    colOtherNMRComments.DataPropertyName = "Comments";
                    colOtherNMRSpectrometer.DataPropertyName = "SpectroMeter";
                    colOtherNMRSamplePrep.DataPropertyName = "SamplePreparation";
                    colOtherNMRMethod.DataPropertyName = "Method";
                    colOtherNMRPeaks.DataPropertyName = "PeakValues";
                    colOtherNMREv.DataPropertyName = "ElectronVolts";  
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
        
        #endregion

        #region Get Control Values

        public CompoundInfo GetCompoundInformation()
        {
            CompoundInfo objCompInfo = null;
            try
            {
                objCompInfo = new CompoundInfo();
                objCompInfo.Compound = ChemRenditor.MolfileString;
                objCompInfo.CompoundNo = txtCompNo.Text.Trim();
                objCompInfo.CompoundLabel = txtCompLabel.Text.Trim();
                objCompInfo.MolFormula = txtMolFormula.Text.Trim();
                objCompInfo.MolWeight = txtMolWeight.Text.Trim();
                objCompInfo.IUPACName = txtIUPAC.Text.Trim();
                objCompInfo.PageNo = txtPageLabel.Text.Trim();
                objCompInfo.Synonyms = txtSynonyms.Text.Trim();
                objCompInfo.InchiKey = ChemistryOperations.GetStructureInchiKey(ChemRenditor.MolfileString);
                objCompInfo.Comments = txtComments.Text.Trim();

            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return objCompInfo;
        }

        public List<NMRSpectralInfo> GetNMRSpectralInformation()
        {
            List<NMRSpectralInfo> lstNMRSpectrals = null;
            try
            {
                if (dgvNmrValues.Rows.Count > 0)
                {
                    lstNMRSpectrals = new List<NMRSpectralInfo>();

                    for (int i = 0; i < dgvNmrValues.Rows.Count; i++)
                    {
                        NMRSpectralInfo objNMRSpectral = new NMRSpectralInfo();
                        objNMRSpectral.SpectroMeter = dgvNmrValues.Rows[i].Cells["colNmrSpectrometer"].Value.ToString();
                        objNMRSpectral.Solvent = dgvNmrValues.Rows[i].Cells["colNmrSolvent"].Value.ToString();
                        objNMRSpectral.Nucleus = dgvNmrValues.Rows[i].Cells["colNmrNucles"].Value.ToString();
                        objNMRSpectral.Frequency = dgvNmrValues.Rows[i].Cells["colNmrFreq"].Value.ToString();
                        objNMRSpectral.StdSolvent = dgvNmrValues.Rows[i].Cells["colNmrStandard"].Value.ToString();
                        objNMRSpectral.ShiftValues = dgvNmrValues.Rows[i].Cells["colNmrShiftValues"].Value.ToString();                        

                        lstNMRSpectrals.Add(objNMRSpectral);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstNMRSpectrals;
        }

        public List<OtherSpectralInfo> GetOtherSpectralInformation()
        {
            List<OtherSpectralInfo> lstOtherSpectrals = null;
            try
            {
                if (dgvMassIrUv.Rows.Count > 0)
                {
                    lstOtherSpectrals = new List<OtherSpectralInfo>();

                    for (int i = 0; i < dgvMassIrUv.Rows.Count; i++)
                    {
                        OtherSpectralInfo objOthSpectral = new OtherSpectralInfo();
                        objOthSpectral.SpectroMeter = dgvMassIrUv.Rows[i].Cells["colNmrSpectrometer"].Value.ToString();
                        objOthSpectral.Method = dgvMassIrUv.Rows[i].Cells["colMassIrUvMethod"].Value.ToString();
                        objOthSpectral.ValueType = dgvMassIrUv.Rows[i].Cells["colMassIrUvCategory"].Value.ToString();
                        objOthSpectral.SamplePreparation = dgvMassIrUv.Rows[i].Cells["colMassIrUvSamplePrep"].Value.ToString();
                        objOthSpectral.PeakValues = dgvMassIrUv.Rows[i].Cells["colMassIrUvPeaks"].Value.ToString();
                        objOthSpectral.ElectronVolts = dgvMassIrUv.Rows[i].Cells["colMassIrUvEv"].Value.ToString();

                        lstOtherSpectrals.Add(objOthSpectral);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstOtherSpectrals;
        }

        #endregion

        #region Bind data to ComboBoxes

        public void BindSpectroMetersToComboBox(DataTable spectralData)
        {
            try
            {
                if (spectralData != null)
                {                    
                    cmbNmrSpectroMeter.DataSource = spectralData;
                    cmbNmrSpectroMeter.ValueMember = "SPECTRAL_ID";
                    cmbNmrSpectroMeter.DisplayMember = "SPECTROMETER";

                    cmbMassSpectrometer.DataSource = spectralData;
                    cmbMassSpectrometer.ValueMember = "SPECTRAL_ID";
                    cmbMassSpectrometer.DisplayMember = "SPECTROMETER";
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        public void BindSolventsToComboBox(DataTable solventsData)
        {
            try
            {
                if (solventsData != null)
                {
                    cmbNmrSolvent.DataSource = solventsData;
                    cmbNmrSolvent.ValueMember = "SOLVENT_ID";
                    cmbNmrSolvent.DisplayMember = "SOLVENT";                    
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        public void BindFrequencyToComboBox(DataTable frequencyData)
        {
            try
            {
                if (frequencyData != null)
                {
                    cmbNmrFreq.DataSource = frequencyData;
                    cmbNmrFreq.ValueMember = "FREQUENCY_ID";
                    cmbNmrFreq.DisplayMember = "FREQUENCY";
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void ChemRenditor_ComStructureChanged()
        {
            try
            {
                if (!string.IsNullOrEmpty(ChemRenditor.MolfileString))
                {
                    string strMolFormula = "";
                    txtMolWeight.Text = ChemistryOperations.GetMoleculeWeightAndMolFormula(ChemRenditor.MolfileString, out strMolFormula);
                    txtMolFormula.Text = strMolFormula;

                    //string strIUPACName = "";
                    //string strErrMsg = "";
                    //if (ChemistryOperations.GetIUPACNameFromStructure(ChemRenditor.MolfileString, out strIUPACName, out strErrMsg))
                    //{
                    //    txtIUPAC.Text = strIUPACName;
                    //}
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }       
        
        public void BindDataToNMRGrid(DataTable dtNmr)
        {
            try
            {
                if (dtNmr != null)
                {
                    dgvNmrValues.AutoGenerateColumns = false;
                    // TODO: fill data PropertyName.
                    colNmrNucles.DataPropertyName = "";
                    colNmrSpectrometer.DataPropertyName = "";
                    colNmrSolvent.DataPropertyName = "";
                    colNmrFreq.DataPropertyName = "";
                    colNmrStandard.DataPropertyName = "";
                    colNmrShiftValues.DataPropertyName = "";
                    dgvNmrValues.DataSource = dtNmr;
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
                
        private void BindDataToMassIrUvGrid(DataTable dtMassIrUv)
        {
            try
            {
                if (dtMassIrUv != null)
                {
                    dgvMassIrUv.AutoGenerateColumns = false;
                    // TODO: fill data PropertyName.
                    //colMassIrUvCategory.DataPropertyName = "";
                    //colMassIrUvSpectrometer.DataPropertyName = "";
                    //colMassIrUvMethod.DataPropertyName = "";
                    //colMassIrUvEv.DataPropertyName = "";
                    //colMassIrUvComments.DataPropertyName = "";
                    //colMassIrUvPeaks.DataPropertyName = "";
                    //colMassIrUvSamplePrep.DataPropertyName = "";
                    //dgvNmrValues.DataSource = dtMassIrUv;
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ChemRenditor_Click(object sender, EventArgs e)
        {
            try
            {
                GetStructureFromImage();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetStructureFromImage()
        {
            try
            {
                IDataObject clipData = Clipboard.GetDataObject();
                if (clipData.GetDataPresent(DataFormats.Bitmap))
                {
                    Cursor = Cursors.WaitCursor;

                    Image imgChemistry = Clipboard.GetImage();

                    string strMol_out = "";
                    bool blIsChiral_out = false;
                    string strErrMsg_out = "";

                    if (ImageToStructure.GetStructureFromImage(imgChemistry, out strMol_out, out blIsChiral_out, out strErrMsg_out))
                    {
                        ChemRenditor.MolfileString = strMol_out;

                        try
                        {
                            chemaxon.util.MolHandler molHandler_Trgt = new MolHandler(ChemRenditor.MolfileString);
                            Molecule molObj = molHandler_Trgt.getMolecule();

                            txtMolWeight.Text = molObj.getMass().ToString();
                            txtMolFormula.Text = molObj.getFormula();

                            string strMolfile = molObj.toFormat("mol");
                            string strIUPACName = "";
                            string strErrMsg = "";
                            if (ChemistryOperations.GetIUPACNameFromStructure(strMolfile, out strIUPACName, out strErrMsg))
                            {
                                strIUPACName = ChemistryOperations.RemoveSMILESFromIUPACName(strIUPACName);
                                strIUPACName = ChemistryOperations.GetConvertedIUPACName(strIUPACName);
                            }
                            else
                            {
                                strIUPACName = "IUPAC name not provided";
                            }
                        }
                        catch
                        { 
                        
                        }

                        //if (molObj.isAbsStereo())
                        //{
                        //    lblChiral.Visible = true;
                        //}
                        //else
                        //{
                        //    lblChiral.Visible = false;
                        //}

                        
                        //txtIUPACName.Text = strIUPACName;

                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(strErrMsg_out);
                    }

                    Clipboard.Clear();
                }               
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            Cursor = Cursors.Default;
        }
        
    }
}
