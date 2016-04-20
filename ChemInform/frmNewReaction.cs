using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform
{
    public partial class frmNewReaction : Form
    {
        public frmNewReaction()
        {
            InitializeComponent();
        }

        #region Public Properties
        
        public int ShipmentRefID { get; set; }
        public DataTable ReactionsTbl { get; set; }
        public int CurrentRxnID { get; set; }
        public int NewRxnID { get; set; }
        public int NewRxnSNo { get; set; }

        public bool DuplicateRxn { get; set; }
        public int DuplicateRxnID { get; set; } 
       
        #endregion

        private void frmNewReaction_Load(object sender, EventArgs e)
        {
            try
            {
                if (ReactionsTbl != null)
                {
                    cmbRxnNo.DataSource = ReactionsTbl;
                    cmbRxnNo.DisplayMember = "REACTION_SNO";
                    cmbRxnNo.ValueMember = "REACTION_ID";

                    if (CurrentRxnID > 0)
                    {
                        cmbRxnNo.SelectedValue = CurrentRxnID;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCreateRxn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtReactions = null;
                int newRxnSNo = 0;
                if (cmbRxnNo.SelectedItem != null)
                {
                    int selRxnNo = Convert.ToInt32(cmbRxnNo.Text);
                    newRxnSNo = rbnAfter.Checked ? selRxnNo + 1 : selRxnNo;
                }
                else if (ReactionsTbl.Rows.Count == 0)
                {
                    newRxnSNo = 1;
                }

                if (!chkDuplicateWithRxn.Checked)//New Reaction
                {                   
                    ReactionInfo rxnInfo = new ReactionInfo();
                    rxnInfo.ShipmentRefID = ShipmentRefID;                                        
                    rxnInfo.ReactionSNo = newRxnSNo;
                    rxnInfo.UR_ID = GlobalVariables.UR_ID;

                    if (ReactionCurationDB.SaveReactionInfo(DmlOperations.INSERT, rxnInfo, out dtReactions))
                    {
                        ReactionsTbl = dtReactions;
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                        var query = from r in dtReactions.AsEnumerable()
                                    where r.Field<Int64>("REACTION_SNO") == newRxnSNo
                                    select new
                                    {
                                        NewRxn_Id = r["REACTION_ID"]
                                    };

                        if (query != null)
                        {
                            NewRxnID = Convert.ToInt32(query.ElementAt(0).NewRxn_Id);
                            NewRxnSNo = newRxnSNo;
                        }

                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding new reaction", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //Duplicate Reaction
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to duplicate the reaction?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes == System.Windows.Forms.DialogResult.Yes)
                    {
                        int dupRxnID = cmbDuplicateWithRxn.SelectedItem != null ? Convert.ToInt32(cmbDuplicateWithRxn.SelectedValue) : 0;
                        int newRxnID = ReactionCurationDB.DuplicateReactionData(ShipmentRefID, dupRxnID, newRxnSNo, GlobalVariables.UR_ID);
                        if (newRxnID > 0)
                        {
                            NewRxnID = newRxnID;
                            NewRxnSNo = newRxnSNo;
                            DuplicateRxn = true;
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error in duplicating reaction", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void chkDuplicateWithRxn_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkDuplicateWithRxn.Checked)
                {
                    if (ReactionsTbl != null)
                    {
                        cmbDuplicateWithRxn.DataSource = ReactionsTbl.Copy();
                        cmbDuplicateWithRxn.DisplayMember = "REACTION_SNO";
                        cmbDuplicateWithRxn.ValueMember = "REACTION_ID";
                    }

                    cmbDuplicateWithRxn.Enabled = true;
                    cmbDuplicateWithRxn.SelectedIndex = 0;
                }
                else
                {
                    cmbDuplicateWithRxn.Enabled = false;
                    cmbDuplicateWithRxn.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
