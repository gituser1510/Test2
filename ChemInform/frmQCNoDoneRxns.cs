using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Bll;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class frmQCNotDoneRxns : Form
    {
        public frmQCNotDoneRxns()
        {
            InitializeComponent();
        }

        public DataTable NonQcRxns
        { get; set; }

        public int ShipmentRefID { get; set; }

        public bool QC_Done
        { get; set; }

        private void frmQCNotDoneRxns_Load(object sender, EventArgs e)
        {
            try
            {
                if (NonQcRxns != null)
                {
                    BindNonQCReactionsToGrid(NonQcRxns);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindNonQCReactionsToGrid(DataTable nonQCRxns)
        {
            try
            {
                dgvReactions.AutoGenerateColumns = false;
                dgvReactions.DataSource = nonQCRxns;

                colRxnID.DataPropertyName = "REACTION_ID";
                colRxnSNo.DataPropertyName = "REACTION_SNO";
                
                colSelRxn.ReadOnly = false;
                colRxnSNo.ReadOnly = true;                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvReactions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvReactions.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;
                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvReactions.Font);
                if (dgvReactions.RowHeadersWidth < (int)(size.Width + 20)) dgvReactions.RowHeadersWidth = (int)(size.Width + 20);
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnQCDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReactions.Rows.Count > 0)
                {                                                           
                    List<int> lstRxnIDs = GetSelectedRxnIDsFromGrid();
                    if (lstRxnIDs != null)
                    {
                        if (ReactionCurationDB.UpdateReactionsQCCompleteStatus(ShipmentRefID, lstRxnIDs, GlobalVariables.UR_ID))
                        {
                            //Refresh Reactions table
                            ReactionInfo objReactionInfo = new ReactionInfo();
                            objReactionInfo.ShipmentRefID = ShipmentRefID;
                            DataTable dtReaction = new DataTable();
                            ReactionCurationDB.SaveReactionInfo(DmlOperations.SELECT, objReactionInfo, out dtReaction);

                            DataTable dtNonQcRxns = GetQcNotCompletedReactionsFromTable(dtReaction);

                            if (dtNonQcRxns != null)
                            {
                                if (dtNonQcRxns.Rows.Count == 0)
                                {
                                    QC_Done = true;
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    BindNonQCReactionsToGrid(dtNonQcRxns);
                                }
                            }
                            //else
                            //{
                            //    QC_Done = true;
                            //    DialogResult = System.Windows.Forms.DialogResult.OK;
                            //    this.Close();
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private List<int> GetSelectedRxnIDsFromGrid()
        {
            List<Int32> lstRxnIDs = null;
            try
            {
                 lstRxnIDs = new List<Int32>();

                    //Update QC status for selected reactions
                    for (int i = 0; i < dgvReactions.Rows.Count; i++)
                    {
                        if (dgvReactions.Rows[i].Cells[colSelRxn.Name].Value != null && dgvReactions.Rows[i].Cells[colSelRxn.Name].Value.ToString() == bool.TrueString)
                        {
                            lstRxnIDs.Add(Convert.ToInt32(dgvReactions.Rows[i].Cells[colRxnID.Name].Value));                          
                        }
                    }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstRxnIDs;
        }

        private DataTable GetQcNotCompletedReactionsFromTable(DataTable reactionsData)
        {
            DataTable dtNocQCRxns = null;
            try
            {
                if (reactionsData != null)
                {
                    var rows = reactionsData.AsEnumerable()
                                                 .Where(r => r.Field<Int64?>("QC_BY") == null);
                    dtNocQCRxns = rows.Any() ? rows.CopyToDataTable() : reactionsData.Clone();            
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtNocQCRxns;
        }

        private void chkSelAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSelAll.Checked)
                {
                    Select_UnSelectRecords(true);
                }
                else
                {
                    Select_UnSelectRecords(false);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void Select_UnSelectRecords(bool sel_status)
        {
            try
            {
                if (dgvReactions.Rows.Count > 0)
                {

                    for (int i = 0; i < dgvReactions.Rows.Count; i++)
                    {
                        dgvReactions.Rows[i].Cells["colSelRxn"].Value = sel_status;
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
