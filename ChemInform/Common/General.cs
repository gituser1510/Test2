using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChemInform.Common
{
    public static class General
    {
        /// <summary>
        /// Allow only numbers in textbox.
        /// </summary>
        /// <param name="e"></param>
        public static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            //e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Check Is form open or not.
        /// </summary>
        /// <param name="formName">Name of Form</param>
        /// <param name="objForm">Form Object</param>
        /// <returns>True if form is already opened else false.</returns>
        public static bool CheckFormIsOpenedORnot(string formName, Form objForm)
        {
            objForm = null;
            List<Form> formsFromOtherAssemblies = new List<Form>();
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name.ToUpper() == formName.ToUpper())
                    {
                        objForm = form;
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }

            return false;
        }

        public static bool CloseForm(string strfrmname)
        {
            try
            {
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);
                foreach (Form f in openForms)
                {
                    if (f.Name == strfrmname)
                        f.Close();
                }

                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == strfrmname)
                    {
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }

            return false;
        }

    }


}
