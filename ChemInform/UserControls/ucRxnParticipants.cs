using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform.UserControls
{
    public partial class ucRxnParticipants : UserControl
    {
        #region Constructor

        public ucRxnParticipants()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public ProductInfo Products { get; set; }

        public int StepID { get; set; }

        public int ReactionID { get; set; }

        public string StepName { get; set; }

        public string Yield { get; set; }

        public int SerialNo { get; set; }

        #endregion

        #region Grid CellMouseClick Events

        private void dgvParticipants_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cntMnuTab.Show(dgvParticipants, new Point(e.X, e.Y));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvConditions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cntMnuTab.Show(dgvConditions, new Point(e.X, e.Y));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Grid CellClick Events

        private void dgvParticipants_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    ParticipantInfo objPartpnt = new ParticipantInfo();
                    DataTable dtPartpnt = new DataTable();
                    if (dgvParticipants.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "EDIT")
                    {
                        using (FrmEditParticipants fParticipants = new FrmEditParticipants())
                        {
                            editRowIndxPartpnt = e.RowIndex;
                            blEditPartpnt = true;

                            objPartpnt.ReactionID = ReactionID;
                            objPartpnt.StepNo = SerialNo;
                            objPartpnt.RxnStepID = StepID;
                            objPartpnt.ParticipantID = Convert.ToInt32(dgvParticipants.Rows[e.RowIndex].Cells[colParticipantID.Name].Value);
                            objPartpnt.ParticipantName = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantName.Name].Value != null ? dgvParticipants.Rows[e.RowIndex].Cells[colParticipantName.Name].Value.ToString() : "";
                            objPartpnt.StructureNo = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantStructNo.Name].Value.ToString();
                            objPartpnt.Structure = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantStructure.Name].Value != null ? dgvParticipants.Rows[e.RowIndex].Cells[colParticipantStructure.Name].Value.ToString() : "";
                            objPartpnt.Grade = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantGrade.Name].Value != null ? dgvParticipants.Rows[e.RowIndex].Cells[colParticipantGrade.Name].Value.ToString() : "";
                            objPartpnt.ParticipantType = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantType.Name].Value.ToString(); 

                            fParticipants.PaticipantData = objPartpnt;
                            if (fParticipants.ShowDialog() == DialogResult.OK)
                            {
                                objPartpnt = fParticipants.PaticipantData;
                                objPartpnt.RxnStepID = StepID;
                                objPartpnt.StepNo = SerialNo;
                                objPartpnt.ReactionID = ReactionID;
                                objPartpnt.ParticipantID = Convert.ToInt32(dgvParticipants.Rows[e.RowIndex].Cells[colParticipantID.Name].Value);                                
                                objPartpnt.Option = objPartpnt.ParticipantID > 0 ? DmlOperations.UPDATE.ToString() : DmlOperations.INSERT.ToString();

                                if (ReactionCurationDB.SaveReactionParticipants(objPartpnt, out dtPartpnt))
                                {
                                    MessageBox.Show("Participant updated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindDataToParticipantsGrid(dtPartpnt);
                                }
                                else
                                {
                                    MessageBox.Show("Error in participant update.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }
                        }
                    }
                    else if (dgvParticipants.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "DELETE")
                    {
                        if (MessageBox.Show("Do you want to delete the selected participant?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            objPartpnt.ReactionID = ReactionID;
                            objPartpnt.ParticipantID = Convert.ToInt32(dgvParticipants.Rows[e.RowIndex].Cells[colParticipantID.Name].Value);
                            objPartpnt.Option = DmlOperations.DELETE.ToString();

                            if (ReactionCurationDB.SaveReactionParticipants(objPartpnt, out dtPartpnt))
                            {
                                MessageBox.Show("Participant deleted successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindDataToParticipantsGrid(dtPartpnt);
                            }
                            else
                            {
                                MessageBox.Show("Error in participant delete.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvConditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataTable dtConditions = new DataTable();
                    ConditionInfo condInfo = new ConditionInfo();
                    condInfo.ReactionID = ReactionID;
                    condInfo.RxnStepID = StepID;
                    condInfo.StepNo = SerialNo;
                    if (dgvConditions.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "EDIT")
                    {
                        using (FrmEditConditions fConditions = new FrmEditConditions())
                        {
                            editRowIndxCond = e.RowIndex;
                            blEditCond = true;

                            condInfo.ConditionID = Convert.ToInt32(dgvConditions.Rows[e.RowIndex].Cells[colConditionID.Name].Value);
                            condInfo.Time = dgvConditions.Rows[e.RowIndex].Cells[colConditionTime.Name].Value.ToString();
                            condInfo.TimeUnits = dgvConditions.Rows[e.RowIndex].Cells[colTimeUnits.Name].Value.ToString(); 
                            condInfo.Temperature = dgvConditions.Rows[e.RowIndex].Cells[colConditionTemp.Name].Value.ToString();
                            condInfo.TempUnits = dgvConditions.Rows[e.RowIndex].Cells[colTempUnits.Name].Value.ToString();  
                            condInfo.Pressure = dgvConditions.Rows[e.RowIndex].Cells[colConditionPressure.Name].Value.ToString();
                            condInfo.PressureUnits = dgvConditions.Rows[e.RowIndex].Cells[colPressureUnits.Name].Value.ToString();
                            condInfo.PH = dgvConditions.Rows[e.RowIndex].Cells[colConditionPh.Name].Value.ToString();
                            condInfo.WarmUp = dgvConditions.Rows[e.RowIndex].Cells[colConditionWarmUp.Name].Value.ToString().ToUpper() == "Y" ? true : false;
                            condInfo.CoolDown = dgvConditions.Rows[e.RowIndex].Cells[colConditionCoolDown.Name].Value.ToString().ToUpper() == "Y" ? true : false;
                            condInfo.Reflux = dgvConditions.Rows[e.RowIndex].Cells[colConditionIsReflux.Name].Value.ToString().ToUpper() == "Y" ? true : false;
                            condInfo.Operation = dgvConditions.Rows[e.RowIndex].Cells[colConditionOperation.Name].Value != null ? dgvConditions.Rows[e.RowIndex].Cells[colConditionOperation.Name].Value.ToString() : "";
                            condInfo.Other = dgvConditions.Rows[e.RowIndex].Cells[colConditionOther.Name].Value.ToString();
                            condInfo.Option = DmlOperations.UPDATE.ToString();

                            fConditions.condInfo = condInfo;
                            if (fConditions.ShowDialog() == DialogResult.OK)
                            {                               
                                if (ReactionCurationDB.SaveReactionConditions(condInfo, out dtConditions))
                                {
                                    BindDataToConditionsGrid(dtConditions);
                                    MessageBox.Show("Condition updated successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                                    
                                }
                                else
                                {
                                    MessageBox.Show("Error in condition update.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }            
                            }
                        }
                    }
                    else if (dgvConditions.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "DELETE")
                    {
                        if (MessageBox.Show("Do you want to delete the selected condition?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            condInfo.ReactionID = ReactionID;
                            condInfo.ConditionID = Convert.ToInt32(dgvConditions.Rows[e.RowIndex].Cells[colConditionID.Name].Value);
                            condInfo.Option = DmlOperations.DELETE.ToString();
                            if (ReactionCurationDB.SaveReactionConditions(condInfo, out dtConditions))
                            {
                                BindDataToConditionsGrid(dtConditions);
                                MessageBox.Show("Condition deleted successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error in condition delete.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void newRowTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cntMnuTab.SourceControl.Name == "dgvParticipants")
                {
                    using (FrmEditParticipants fParticipants = new FrmEditParticipants())
                    {
                        fParticipants.ShowDialog();
                    }
                    RefreshParticipantsGrid();
                }
                if (cntMnuTab.SourceControl.Name == "dgvConditions")
                {
                    using (FrmEditConditions fConditions = new FrmEditConditions())
                    {
                        fConditions.ShowDialog();
                    }
                    RefreshConditionsGrid();
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void RefreshConditionsGrid()
        {
            try
            {
                dgvConditions.ClearSelection();
                dgvConditions.AutoGenerateColumns = false;
                dgvConditions.DataSource = null;

                //if (GlobalVariables.lstConditions.Count > 0)
                //{
                //    for (int i = 0; i < GlobalVariables.lstConditions.Count; i++)
                //    {
                //        dgvConditions.Rows.Add();
                //        dgvConditions.Rows[i].Cells["colConditionTime"].Value = GlobalVariables.lstConditions[i].Time;
                //        dgvConditions.Rows[i].Cells["colConditionTemp"].Value = GlobalVariables.lstConditions[i].Temp;
                //        dgvConditions.Rows[i].Cells["colConditionPh"].Value = GlobalVariables.lstConditions[i].PH;

                //        dgvConditions.Rows[i].Cells["colConditionWarmUp"].Value = GlobalVariables.lstConditions[i].WarmUp;
                //        dgvConditions.Rows[i].Cells["colConditionCoolDown"].Value = GlobalVariables.lstConditions[i].CollDown;
                //        dgvConditions.Rows[i].Cells["colConditionIsReflux"].Value = GlobalVariables.lstConditions[i].Reflux;
                //        dgvConditions.Rows[i].Cells["colConditionOperation"].Value = GlobalVariables.lstConditions[i].Operation;
                //        dgvConditions.Rows[i].Cells["colConditionOther"].Value = GlobalVariables.lstConditions[i].Other;
                //    }
                //}
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void RefreshParticipantsGrid()
        {
            try
            {
                //dgvParticipants.ClearSelection();
                //dgvParticipants.AutoGenerateColumns = false;
                //dgvParticipants.DataSource = null;
                //colParticipantName.DataPropertyName = "Name";
                //colParticipantStructNum.DataPropertyName = "StructNo";
                //colParticipantGrade.DataPropertyName = "Grade";
                //colParticipantType.DataPropertyName = "Type";
                //colParticipantStruct.DataPropertyName = "Structure";
                ////dgvParticipants.DataSource = GlobalVariables.lstParticipants;
                //dgvParticipants.RefreshEdit();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool ValidateParticipants(ref string errMsg)
        {
            bool blStatus = true;
            try
            {
                if (dgvParticipants.Rows.Count == 0)
                {
                    blStatus = false;
                    errMsg = errMsg + "\r\n" + "Reaction Participants can't be null";
                }
                else
                {
                    //Check for Reactants
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        #region Bind BindingSource to Grid

        BindingSource bsParticipants;
        public void BindDataToParticipantsGrid(DataTable dtPartpnt)
        {
            try
            {
                if (dtPartpnt != null)
                {
                    //if (bsParticipants == null)
                    //{
                    //    bsParticipants = new BindingSource();
                    //    bsParticipants.AllowNew = true;
                    //}

                    //if (dtPartpnt.Rows.Count > 0)
                    //{
                    //    dtPartpnt = dtPartpnt.AsEnumerable()
                    //          .Where(r => r.Field<Int64>("RXN_STEP_ID") == StepID)
                    //          .CopyToDataTable();
                    //}

                    DataTable partpntData = GetStepParticipantsFromTable(dtPartpnt);

                   // bsParticipants.DataSource = partpntData;

                    colParticipantID.DataPropertyName = "PRPNT_ID";
                    colParticipantType.DataPropertyName = "PRPNT_TYPE";
                    colParticipantName.DataPropertyName = "PRPNT_NAME";
                    colParticipantStructure.DataPropertyName = "PRPNT_STRUCTURE";
                    colStructureImage.DataPropertyName = "STRUCT_IMAGE";
                    colParticipantStructNo.DataPropertyName = "STRUCTURE_NO";
                    colParticipantGrade.DataPropertyName = "GRADE";

                    dgvParticipants.AutoGenerateColumns = false;
                    dgvParticipants.DataSource = partpntData;// bsParticipants;

                    if (partpntData != null && partpntData.Rows.Count == 0)
                    {
                        reactantRenderer.MolfileString = "";
                    }

                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private DataTable GetStepParticipantsFromTable(DataTable partpntsData)
        {
            DataTable dtStepPartpnts = null;
            try
            {
                if (partpntsData != null && partpntsData.Rows.Count > 0)
                {
                    //dtStepPartpnts = partpntsData.AsEnumerable()
                    //      .Where(r => r.Field<Int64>("RXN_STEP_ID") == StepID)
                    //      .CopyToDataTable();

                    var rows = from r in partpntsData.AsEnumerable()
                               where r.Field<Int64>("RXN_STEP_ID") == StepID
                               select r;

                    dtStepPartpnts = rows.Any() ? rows.CopyToDataTable() : partpntsData.Clone();

                    if (dtStepPartpnts.Rows.Count > 0)
                    {
                        dtStepPartpnts.Columns.Add("STRUCT_IMAGE", typeof(Image));

                        foreach (DataRow drow in dtStepPartpnts.Rows)
                        {
                            ChemRenditor.MolfileString = "";
                            ChemRenditor.MolfileString = drow["PRPNT_STRUCTURE"].ToString();
                            drow["STRUCT_IMAGE"] = (object)ChemRenditor.Image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtStepPartpnts;
        }
               
        public void BindDataToConditionsGrid(DataTable conditionsData)
        {
            try
            {
                if (conditionsData != null)
                {
                    #region MyRegion
                    //if (bsConditions == null)
                    //{
                    //    bsConditions = new BindingSource();
                    //    bsConditions.AllowNew = true;
                    //}
                    //if (dtConditions.Rows.Count > 0)
                    //{
                    //    dtConditions.AsEnumerable().ToList<DataRow>().ForEach(r => { r.SetField("IS_WARMUP", r["IS_WARMUP"] == "Y" ? true : false); });
                    //    dtConditions.AsEnumerable().ToList<DataRow>().ForEach(r => { r.SetField("IS_COOL_DOWN", r["IS_COOL_DOWN"] == "Y" ? true : false); });
                    //    dtConditions.AsEnumerable().ToList<DataRow>().ForEach(r => { r.SetField("IS_REFLUX", r["IS_REFLUX"] == "Y" ? true : false); });
                    //}
                    //bsConditions.DataSource = dtConditions; 
                    #endregion

                    var rows = from r in conditionsData.AsEnumerable()
                               where r.Field<Int64>("RXN_STEP_ID") == StepID
                               select r;
                    DataTable stepConds = rows.Any() ? rows.CopyToDataTable() : conditionsData.Clone();    
                               
                   if (stepConds != null)
                   {
                       dgvConditions.AutoGenerateColumns = false;
                       dgvConditions.DataSource = stepConds;

                       colConditionID.DataPropertyName = "CONDITION_ID";
                       colConditionTime.DataPropertyName = "COND_TIME";
                       colConditionTemp.DataPropertyName = "TEMPERATURE";
                       colConditionPressure.DataPropertyName = "PRESSURE";
                       colConditionPh.DataPropertyName = "PH";
                       colConditionOther.DataPropertyName = "OTHER_CONDITIONS";
                       colConditionOperation.DataPropertyName = "OPERATION";
                       colConditionIsReflux.DataPropertyName = "IS_REFLUX";
                       colConditionCoolDown.DataPropertyName = "IS_COOL_DOWN";
                       colConditionWarmUp.DataPropertyName = "IS_WARMUP";
                       colTimeUnits.DataPropertyName = "COND_TIME_UNIT";
                       colTempUnits.DataPropertyName = "TEMPERATURE_UNIT";
                       colPressureUnits.DataPropertyName = "PRESSURE_UNIT";                       
                   }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Add Reaction Participants & Conditions

        int editRowIndxPartpnt = 0;
        bool blEditPartpnt = false;
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditParticipants frmEditPartpnt = new FrmEditParticipants();
                if (frmEditPartpnt.ShowDialog() == DialogResult.OK)
                {
                    ParticipantInfo objPartpnt = frmEditPartpnt.PaticipantData;
                    objPartpnt.ReactionID = ReactionID;
                    objPartpnt.RxnStepID = StepID;
                    objPartpnt.StepNo = SerialNo == 0 ? 1 : SerialNo;
                    objPartpnt.Option = objPartpnt.ParticipantID > 0 ? DmlOperations.UPDATE.ToString() : DmlOperations.INSERT.ToString();
                    
                    DataTable dtPartpnt = new DataTable();

                    if (ReactionCurationDB.SaveReactionParticipants(objPartpnt, out dtPartpnt))
                    {
                        MessageBox.Show("Participant updated successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindDataToParticipantsGrid(dtPartpnt);
                    }
                    else
                    {
                        MessageBox.Show("Error accured in participant updation.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        int editRowIndxCond = 0;
        bool blEditCond = false;
        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditConditions frmEditCondition = new FrmEditConditions();
                if (frmEditCondition.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtConditions = new DataTable();
                    ConditionInfo objCond = frmEditCondition.condInfo;
                    objCond.ReactionID = ReactionID;
                    objCond.RxnStepID = StepID;
                    objCond.StepNo = SerialNo;

                    objCond.Option = objCond.ConditionID == 0 ? DmlOperations.INSERT.ToString() : DmlOperations.UPDATE.ToString();

                    if (ReactionCurationDB.SaveReactionConditions(objCond, out dtConditions))
                    {
                        MessageBox.Show("Condition saved successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error accured in condition updation.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    BindDataToConditionsGrid(dtConditions);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Grid RowPostPaint Events

        private void dgvParticipants_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvParticipants.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvParticipants.Font);

                if (dgvParticipants.RowHeadersWidth < (int)(size.Width + 20)) dgvParticipants.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvConditions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvConditions.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvConditions.Font);

                if (dgvConditions.RowHeadersWidth < (int)(size.Width + 20)) dgvConditions.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void dgvParticipants_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    reactantRenderer.MolfileString = dgvParticipants.Rows[e.RowIndex].Cells[colParticipantStructure.Name].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
