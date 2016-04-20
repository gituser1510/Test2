using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace ChemInform.Common
{
    public static class Validation
    {
        public static bool CheckFormIsOpenedORnot(string strfrmname, Form obj)
        {
            obj = null;
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            List<Form> formsFromOtherAssemblies = new List<Form>();
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == strfrmname)
                    {
                        obj = form;
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }

            return false;
        }


   
    }
}
