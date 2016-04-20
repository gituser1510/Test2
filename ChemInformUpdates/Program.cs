using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace ChemInformUpdates
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //Check for updates
                GetPatchUpdateFiles();
                            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void GetPatchUpdateFiles()
        {
            int setupNumber = 1;
            int patchNumber = 1;
            int maxBuildNumber = 1;
            IList<PatchFile> patchFiles = null;

            // Copy Config.xml file to application path.
            AppPatchUpdates.DownloadConfigFile();
            AppPatchUpdates.GetPatchReleaseInfo(out setupNumber, out patchNumber);

            try
            {
                patchFiles = AppPatchUpdates.GetPublishedFiles(setupNumber, patchNumber, out maxBuildNumber);
            }
            catch (Exception ex)
            {
                AppPatchUpdates.WriteErrorLog(ex.ToString());
            }

            if (patchFiles != null && patchFiles.Count > 0)
            {
                frmPatchUpdates wciUpdates = new frmPatchUpdates(patchFiles);
                wciUpdates.Show();

                AppPatchUpdates.UpdatePatchReleaseInfo(setupNumber, maxBuildNumber);
            }

            //Start WCI application
            StartMainApplication();
        }

        /// <summary>
        /// To Start main application - IRN.exe
        /// </summary>
        private static void StartMainApplication()
        {
            try
            {
                string mainAppPath = Path.Combine(Application.StartupPath, "ChemInform.exe");
                Process.Start(mainAppPath);
            }
            catch (Exception ex)
            {
                AppPatchUpdates.WriteErrorLog(ex.ToString());
            }
        }
    }
}
