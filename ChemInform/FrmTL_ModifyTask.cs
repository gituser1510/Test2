using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform
{
    public partial class FrmTL_ModifyTask : Form
    {
        public FrmTL_ModifyTask()
        {
            InitializeComponent();
        }

        public int DocId { get; set; }
        public string AnalystName { get; set; }
        public string ReviewerName { get; set; }
        public string QcAnalystName { get; set; }

        public string ModifiedAnalyst { get; set; }
        public string ModifiedReviewAnalst { get; set; }
        public string ModifiedQc { get; set; }

        private int ModifiedAnalystId { get; set; }
        private int ModifiedReviewAnalstId { get; set; }
        private int ModifiedQcId { get; set; }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = null;
            try
            {
                if (cmbModifiedAnalyst.SelectedItem != null && cmbModifiedAnalyst.Text != txtAnalyst.Text)
                {
                    ModifiedAnalystId = Convert.ToInt32(cmbModifiedAnalyst.SelectedValue);
                    ModifiedAnalyst = cmbModifiedAnalyst.Text;
                    message = "\r\n" + "Do You want to change modify Curation from " + txtAnalyst.Text + " to " + cmbModifiedAnalyst.Text + " ?";
                }
                if (cmbModifiedReviewer.SelectedItem != null && cmbModifiedReviewer.Text != txtReviewer.Text)
                {
                    ModifiedReviewAnalstId = Convert.ToInt32(cmbModifiedReviewer.SelectedValue);
                    ModifiedReviewAnalst = cmbModifiedReviewer.Text;
                    message += "\r\n" + "Do You want to change modify Reviewer from " + txtReviewer.Text + " to " + cmbModifiedReviewer.Text + " ?";
                }
                if (cmbModifiedQc.SelectedItem != null && cmbModifiedQc.Text != txtQc.Text)
                {
                    ModifiedQcId = Convert.ToInt32(cmbModifiedQc.SelectedValue);
                    ModifiedQc = cmbModifiedQc.Text;
                    message += "\r\n" + "Do You want to change modify QC from " + txtQc.Text + " to " + cmbModifiedQc.Text + " ?";
                }
                if (message != null)
                {
                    if (DialogResult.Yes == MessageBox.Show(message.Trim(), GlobalVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ModifyTask();
                    }
                }
                else
                {
                    ModifiedAnalyst = null;
                    ModifiedReviewAnalst = null;
                    ModifiedQc = null;
                    MessageBox.Show("Select Perticular user to modify task.", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ModifyTask()
        {
            // TODO :Database reflect.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmTL_ModifyTask_Load(object sender, EventArgs e)
        {
            if (DocId != -1)
            {
                txtDocId.Text = DocId.ToString();
            }
            if (AnalystName != null)
            {
                txtAnalyst.Text = AnalystName;
            }
            if (ReviewerName != null)
            {
                txtReviewer.Text = ReviewerName;
            }
            if (QcAnalystName != null)
            {
                txtQc.Text = QcAnalystName;
            }
            DataTable dtActiveCurators = UserManagementDB.GetUserDetailsOnRoleId(8, Common.GlobalVariables.Module);
            BindActiveCurators(dtActiveCurators);

            DataTable dtActiveReviewers = UserManagementDB.GetUserDetailsOnRoleId(7, Common.GlobalVariables.Module);
            BindActiveReviewers(dtActiveReviewers);

            DataTable dtActiveQcs = UserManagementDB.GetUserDetailsOnRoleId(6, Common.GlobalVariables.Module);
            BindActiveQcs(dtActiveQcs);
        }

        private void BindActiveQcs(DataTable dtActiveQcs)
        {
            if (dtActiveQcs.Rows.Count > 0 && dtActiveQcs != null)
            {
                cmbModifiedQc.DataSource = dtActiveQcs;
                cmbModifiedQc.DisplayMember = "USER_NAME";
                cmbModifiedQc.ValueMember = "USER_ID";
                cmbModifiedQc.SelectedIndex = -1;
            }
        }

        private void BindActiveReviewers(DataTable dtActiveReviewers)
        {
            if (dtActiveReviewers.Rows.Count > 0 && dtActiveReviewers != null)
            {
                cmbModifiedReviewer.DataSource = dtActiveReviewers;
                cmbModifiedReviewer.DisplayMember = "USER_NAME";
                cmbModifiedReviewer.ValueMember = "USER_ID";
                cmbModifiedReviewer.SelectedIndex = -1;
            }
        }

        private void BindActiveCurators(DataTable dtActiveCurators)
        {
            try
            {
                if (dtActiveCurators.Rows.Count > 0 && dtActiveCurators != null)
                {
                    cmbModifiedAnalyst.DataSource = dtActiveCurators;
                    cmbModifiedAnalyst.DisplayMember = "USER_NAME";
                    cmbModifiedAnalyst.ValueMember = "USER_ID";
                    cmbModifiedAnalyst.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
