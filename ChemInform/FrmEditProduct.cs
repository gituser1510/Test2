using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.UserControls;
using ChemInform.Bll;
using ChemInform.Common;

namespace ChemInform
{
    public partial class FrmEditProduct : Form
    {
        public FrmEditProduct()
        {
            InitializeComponent();
        }

        public ProductInfo ProductData { set; get; }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {               
                ////// Sairam123 sai = (Sairam123)eswa;
                ////  Eswar123 eswa = new Eswar123();
                ////  string s = (eswa as Sairam123).TestFunction("Viswanath");

                ////  Sairam123 sai = new Sairam123();           
                ////  string s1 = (sai as Eswar123).TestFunction("Viswanath");

                BindProductDataToControls();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindProductDataToControls()
        {
            try
            {
                if (ProductData != null)
                {
                    txtProductName.Text = ProductData.ProductName;
                    txtStructNo.Text = ProductData.StructureNo;
                    ChemRenditor.MolfileString = ProductData.Structure != null ? ProductData.Structure.ToString() : null;
                              
                    txtCS.Text = ProductData.CS.ToString();
                    txtDS.Text = ProductData.DS.ToString();
                    txtDe.Text = ProductData.DE.ToString();
                    txtEE.Text = ProductData.EE.ToString();
                    txtGrade.Text = ProductData.ProductGrade;

                    string[] saYield = ProductData.Yield.Split(new string[] {"to"}, StringSplitOptions.RemoveEmptyEntries);
                    if (saYield != null && saYield.Length > 0)
                    {
                        txtYieldFrom.Text = saYield[0].Trim();

                        if (saYield.Length == 2)//Range values
                        {
                            txtYieldTo.Text = saYield[1].Trim();
                        }
                    }
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
                if (ValidateProductControls(ref strErrMsg))
                {
                    ProductData = new ProductInfo();
                    ProductData.ProductName = txtProductName.Text.Trim();
                    ProductData.StructureNo = txtStructNo.Text.Trim();
                    if (!string.IsNullOrEmpty(txtYieldFrom.Text.Trim()) && !string.IsNullOrEmpty(txtYieldTo.Text.Trim()))
                    {
                        ProductData.Yield = txtYieldFrom.Text.Trim() + " to " + txtYieldTo.Text.Trim();
                    }
                    else 
                    {
                        ProductData.Yield = txtYieldFrom.Text.Trim();
                    }

                    if (!string.IsNullOrEmpty(ChemRenditor.MolfileString))
                    {
                        ProductData.Structure = ChemRenditor.MolfileString;
                        ProductData.StructureImage = (object)ChemRenditor.Image;
                    }
                    ProductData.CS = txtCS.Text.Trim();
                    ProductData.DS = txtDS.Text.Trim();
                    ProductData.DE = txtDe.Text.Trim();
                    ProductData.EE = txtEE.Text.Trim();
                    ProductData.ProductGrade = txtGrade.Text.Trim();
                    ProductData.InchiKey = ChemistryOperations.GetStructureInchiKey(ChemRenditor.MolfileString);

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

        private bool ValidateProductControls(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                //if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
                //{
                //    blStatus = false;
                //    errmsg_out += "\r\n" + "Product can't be null";
                //}
                if (string.IsNullOrEmpty(txtStructNo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + " Structure Number can't be null";
                }

                if (string.IsNullOrEmpty(lblStructureInchi.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Inchi Key is not generated. Invalid Structure";
                }
                else if (lblStructureInchi.Text.Trim().ToUpper() == "INCHI NOT GENERATED")
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Inchi Key is not generated. Invalid Structure";
                }

                ////If Yield is there, CS/DS should be there
                //if (!string.IsNullOrEmpty(txtYield.Text.Trim()) && (string.IsNullOrEmpty(txtCS.Text.Trim()) && string.IsNullOrEmpty(txtDS.Text.Trim())))
                //{
                //    blStatus = false;
                //    errmsg_out += "\r\n" + "When Yield is available, CS/DS should be there";
                //}
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
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

        private void txtYield_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtYieldTo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCS_KeyPress(object sender, KeyPressEventArgs e)
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

    public class Sairam123
    {
        public string TestFunction(string input)
        {
            return "Hi HRU? THis is " + input;
        }
    }

    public class Eswar123 : Sairam123
    {       
        public string TestFunction(string input)
        {
            return "Hi How Are YOU? THis is " + input;
        }
    }
}
