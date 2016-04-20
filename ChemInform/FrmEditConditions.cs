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
using System.Text.RegularExpressions;

namespace ChemInform
{
    public partial class FrmEditConditions : Form
    {
        #region Property Procedures
        
        public ConditionInfo condInfo { get; set; }
        public bool IsEdit { get; set; }
        public int EditRowIndex { get; set; }

        #endregion

        public FrmEditConditions()
        {
            InitializeComponent();
        }

        private void FrmConditions_Load(object sender, EventArgs e)
        {
            try
            {
                //Bind conditions to controls
                BindConditionInfoToControls();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindConditionInfoToControls()
        {
            try
            {
                if (condInfo != null)
                {
                    //Time
                    if (condInfo.Time != null)
                    {
                        string[] saTime = condInfo.Time.Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saTime != null)
                        {
                            if (saTime.Length > 0)
                            {
                                txtTimeFrom.Text = saTime[0].Trim();
                            }
                            if (saTime.Length == 2)
                            {
                                txtTimeTo.Text = saTime[1].Trim();
                            }
                        }
                    }

                    //Temperature
                    if (condInfo.Temperature != null)
                    {
                        string[] saTemp = condInfo.Temperature.Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saTemp != null)
                        {
                            if (saTemp.Length > 0)
                            {
                                txtTempFrom.Text = saTemp[0].Trim();
                            }
                            if (saTemp.Length == 2)
                            {
                                txtTempTo.Text = saTemp[1].Trim();
                            }
                        }
                    }

                    //Pressure
                    if (condInfo.Pressure != null)
                    {
                        string[] saPressure = condInfo.Pressure.Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saPressure != null)
                        {
                            if (saPressure.Length > 0)
                            {
                                txtPressureFrom.Text = saPressure[0].Trim();
                            }
                            if (saPressure.Length == 2)
                            {
                                txtPressureTo.Text = saPressure[1].Trim();
                            }
                        }
                    }

                    //PH
                    if (condInfo.PH != null)
                    {
                        string[] saPH = condInfo.PH.Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saPH != null)
                        {
                            if (saPH.Length > 0)
                            {
                                txtPHFrom.Text = saPH[0].Trim();
                            }
                            if (saPH.Length == 2)
                            {
                                txtPHTo.Text = saPH[1].Trim();
                            }
                        }
                    }

                    chkWarmUp.Checked = condInfo.WarmUp;
                    chkCoolDown.Checked = condInfo.CoolDown;
                    chkReflux.Checked = condInfo.Reflux;
                    txtOther.Text = condInfo.Other;
                    txtOperation.Text = condInfo.Operation;

                    cmbTempUnits.Text = !string.IsNullOrEmpty(condInfo.TempUnits) ? condInfo.TempUnits : "Deg C";
                    cmbTimeUnits.Text = !string.IsNullOrEmpty(condInfo.TimeUnits) ? condInfo.TimeUnits : "HR";
                    cmbPresUnits.Text = !string.IsNullOrEmpty(condInfo.PressureUnits) ? condInfo.PressureUnits : "";

                    ConvertToHours();

                    ConvertToDegrees();
                }
                else
                {
                    cmbTempUnits.Text = "Deg C";
                    cmbTimeUnits.Text = "HR";
                    cmbPresUnits.Text = "ATM";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ConvertToHours()
        {
            try
            {
                if (cmbTimeUnits.SelectedIndex != -1 && !String.IsNullOrEmpty(txtTimeFrom.Text.Trim()))
                {
                    string toHours = "";

                    if (!String.IsNullOrEmpty(txtTimeFrom.Text.Trim()))
                    {
                        if (cmbTimeUnits.Text == "HR")
                        {
                            toHours = txtTimeFrom.Text.Trim() + " HR";
                        }
                        else if (cmbTimeUnits.Text == "Mins")
                        {
                            toHours = DataConversions.ConvertMinutesToHours(txtTimeFrom.Text.Trim()) + " HR";
                        }
                        else if (cmbTimeUnits.Text == "Secs")
                        {
                            toHours = DataConversions.ConvertSecondsToHours(txtTimeFrom.Text.Trim()) + " HR";
                        }
                    }

                    if (!String.IsNullOrEmpty(txtTimeFrom.Text.Trim()) && !String.IsNullOrEmpty(txtTimeTo.Text.Trim()))
                    {
                        if (cmbTimeUnits.Text == "HR")
                        {
                            toHours = txtTimeFrom.Text.Trim() + " HR" + " to " + txtTimeTo.Text.Trim() + " HR";
                        }
                        else if (cmbTimeUnits.Text == "Mins")
                        {
                            toHours = DataConversions.ConvertMinutesToHours(txtTimeFrom.Text.Trim()) + " HR" + " to " +
                                      DataConversions.ConvertMinutesToHours(txtTimeTo.Text.Trim()) + " HR";
                        }
                        else if (cmbTimeUnits.Text == "Secs")
                        {
                            toHours = DataConversions.ConvertSecondsToHours(txtTimeFrom.Text.Trim()) + " HR" + " to " +
                                      DataConversions.ConvertSecondsToHours(txtTimeTo.Text.Trim()) + " HR";
                        }
                    }
                    lblTimeInHrs.Text = toHours;
                }
                else
                {
                    lblTimeInHrs.Text = "00.00 HR";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
        
        private void ConvertToDegrees()
        {
            try
            {
                if (cmbTempUnits.SelectedIndex != -1 && !String.IsNullOrEmpty(txtTempFrom.Text.Trim()))
                {
                    string toDegrees = string.Empty;

                    if (cmbTempUnits.Text == "Deg C")
                    {
                        toDegrees += txtTempFrom.Text.Trim() + " DEG C";
                    }
                    else if (cmbTempUnits.Text == "Fahrenheit")
                    {
                        toDegrees = DataConversions.ConvertFahrenheitToDegress(txtTempFrom.Text.Trim()) + " DEG C"; 
                    }
                    else if (cmbTempUnits.Text == "Kelvin")
                    {
                        toDegrees = DataConversions.ConvertKelvinsToDegress(txtTempFrom.Text.Trim()) + " DEG C"; 
                    }

                    if (!String.IsNullOrEmpty(txtTempFrom.Text.Trim()) && !String.IsNullOrEmpty(txtTempTo.Text.Trim()))
                    {
                        toDegrees = DataConversions.ConvertFahrenheitToDegress(txtTempFrom.Text.Trim()) + " - " + DataConversions.ConvertFahrenheitToDegress(txtTempTo.Text.Trim()) + " DEG C"; 
                    }
                   
                    lblTempInDegrees.Text = toDegrees;
                }
                else
                {
                    lblTempInDegrees.Text = "0 DEG C";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateConditionControls(ref strErrMsg))
                {
                    if (condInfo == null)
                    {
                        condInfo = new ConditionInfo();
                    }

                    if (!string.IsNullOrEmpty(txtTimeFrom.Text) && !string.IsNullOrEmpty(txtTimeTo.Text))
                    {
                        condInfo.Time = txtTimeFrom.Text + " to " + txtTimeTo.Text;
                        condInfo.TimeUnits = cmbTimeUnits.Text;
                    }
                    else if(!string.IsNullOrEmpty(txtTimeFrom.Text))
                    {
                        condInfo.Time = txtTimeFrom.Text;
                        condInfo.TimeUnits = cmbTimeUnits.Text;
                    }
                    
                    if (!string.IsNullOrEmpty(txtTempFrom.Text) && !string.IsNullOrEmpty(txtTempTo.Text))
                    {
                        condInfo.Temperature = txtTempFrom.Text + " to " + txtTempTo.Text;
                        condInfo.TempUnits = cmbTempUnits.Text;
                    }
                    else if (!string.IsNullOrEmpty(txtTempFrom.Text))
                    {
                        condInfo.Temperature = txtTempFrom.Text;
                        condInfo.TempUnits = cmbTempUnits.Text;
                    }
                    
                    if (!string.IsNullOrEmpty(txtPressureFrom.Text) && !string.IsNullOrEmpty(txtPressureTo.Text))
                    {
                        condInfo.Pressure = txtPressureFrom.Text + " to " + txtPressureTo.Text;
                        condInfo.PressureUnits = cmbPresUnits.Text;   
                    }
                    else if(!string.IsNullOrEmpty(txtPressureFrom.Text))
                    {
                        condInfo.Pressure = txtPressureFrom.Text;
                        condInfo.PressureUnits = cmbPresUnits.Text;   
                    }

                    if (!string.IsNullOrEmpty(txtPHFrom.Text) && !string.IsNullOrEmpty(txtPHTo.Text))
                    {
                        condInfo.PH = txtPHFrom.Text + " to " + txtPHTo.Text;                        
                    }
                    else if (!string.IsNullOrEmpty(txtPHFrom.Text))
                    {
                        condInfo.PH = txtPHFrom.Text;                        
                    }
                          
                    condInfo.WarmUp = chkWarmUp.Checked;
                    condInfo.CoolDown = chkCoolDown.Checked;
                    condInfo.Reflux = chkReflux.Checked;
                    condInfo.Other = txtOther.Text;
                    condInfo.Operation = txtOperation.Text;

                    IsEdit = false;
                    EditRowIndex = -1;

                    DialogResult = System.Windows.Forms.DialogResult.OK;                   
                }
                else
                {
                    MessageBox.Show(strErrMsg.Trim(),GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
               
        private bool ValidateConditionControls(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {                
                if (string.IsNullOrEmpty(txtTimeFrom.Text.Trim()) && string.IsNullOrEmpty(txtTimeTo.Text.Trim()) && string.IsNullOrEmpty(txtTempFrom.Text.Trim())
                    && string.IsNullOrEmpty(txtTempTo.Text.Trim()) && string.IsNullOrEmpty(txtPressureFrom.Text.Trim()) && string.IsNullOrEmpty(txtPressureTo.Text.Trim())
                    && string.IsNullOrEmpty(txtPHFrom.Text.Trim()) && string.IsNullOrEmpty(txtPHTo.Text.Trim()) && !chkCoolDown.Checked && !chkWarmUp.Checked && !chkReflux.Checked && string.IsNullOrEmpty(txtOperation.Text.Trim())
                    && string.IsNullOrEmpty(txtOther.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Atleast one condition should be there";
                }

                if (!string.IsNullOrEmpty(txtPHFrom.Text.Trim()))
                {
                    double phFrom = 0;
                    double.TryParse(txtPHFrom.Text.Trim(), out phFrom);
                    if (phFrom > 14)
                    {
                        blStatus = false;
                        errmsg_out += "\r\n" + "pH should be < 14";
                    }
                    else if (phFrom < 1)
                    {
                        blStatus = false;
                        errmsg_out += "\r\n" + "pH should be > 1";
                    }
                }
                if (!string.IsNullOrEmpty(txtPHTo.Text.Trim()))
                {
                    double phTo = 0;
                    double.TryParse(txtPHTo.Text.Trim(), out phTo);
                    if (phTo > 14)
                    {
                        blStatus = false;
                        errmsg_out += "\r\n" + "pH should be < 14";
                    }
                    else if (phTo < 1)
                    {
                        blStatus = false;
                        errmsg_out += "\r\n" + "pH should be > 1";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            ConvertToHours();
        }

        private void txtTimeFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //General.AllowOnlyNumbers(e);       
                if (e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void txtTimeTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //General.AllowOnlyNumbers(e);       
                if (e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void cmbTimeUnits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConvertToHours();
        }

        private void txtTempFrom_TextChanged(object sender, EventArgs e)
        {
            ConvertToDegrees();
        }

        private void cmbTempUnits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConvertToDegrees();
        }

        private void txtTempFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != '-' && e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }               
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void txtTempTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != '-' && e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void txtPHFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void txtPHTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
    }
}
