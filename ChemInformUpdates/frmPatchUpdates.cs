using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using Microsoft.Win32;
using NLog.Targets;
using NLog.Targets.Wrappers;
using NLog;
using ChemInform;
using System.Threading;

namespace ChemInformUpdates
{
    public partial class frmPatchUpdates : Form
    {
        public frmPatchUpdates()
        {
            InitializeComponent();
        }

        #region Property Procedures

        private bool _isdownloaded;
        public bool isdownloaded
        {
            get { return _isdownloaded; }
            set { _isdownloaded = value; }
        }

        private Hashtable _htfilestobeupdate;
        public Hashtable HtFilestoupdates
        {
            get { return _htfilestobeupdate; }
            set { _htfilestobeupdate = value; }
        }

        private Hashtable _htFilesDone = null;
        public Hashtable HtFilesDownloaded
        {
            get { return _htFilesDone; }
            set { _htFilesDone = value; }
        }

        private string[] _strdllnames;
        public string[] StrDllNames
        {
            get { return _strdllnames; }
            set { _strdllnames = value; }
        }

        public DataTable DllBuildVersions
        {
            get;
            set;
        }

        #endregion

        private IList<PatchFile> PatchFiles
        {
            get;
            set;
        }

        public frmPatchUpdates(IList<PatchFile> patchFiles) : this()
        {
            this.PatchFiles = patchFiles;
        }        

        private void RunPatchUpdates()
        {
            CheckForIllegalCrossThreadCalls = false;

            this.Refresh();

            this.Visible = true;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (this.PatchFiles != null && this.PatchFiles.Count > 0)
                {
                    lblPatchUpdateStatus.Text = "Found new updates ...";
                    Application.DoEvents();

                    System.Threading.Thread.Sleep(500);

                    lblDownloadStatus.Text = "Downloading files ...";
                    Application.DoEvents();

                    AppPatchUpdates.Download(this.PatchFiles);

                    lblDownloadStatus.Text = "Download completed.";
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                AppPatchUpdates.WriteErrorLog(ex.ToString());
                lblPatchUpdateStatus.Text = "Failed to download patch files.";
                lblPatchUpdateStatus.Refresh();
                Thread.Sleep(500);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void frmPatchUpdates_Load(object sender, EventArgs e)
        {
            try
            {
                RunPatchUpdates();

                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  

    }
}
