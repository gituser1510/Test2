using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using ChemInform.Common;
using ChemInform.Bll;
using ChemInform.Dal;
using System.Collections;


namespace ChemInform
{
    public partial class FrmPdfGererationOnAbstract : Form
    {
        #region Local variables
               
        string OutputFilePath = null;
        int imageFilesCount = 0;
        Document docCreate = null;
        Document docAppend = null;
        PdfWriter writerAppend = null;
        bool IsCreateDocOpen = false;
        bool IsAppendDocOpen = false;
        BaseColor bgcol = new BaseColor(153, 255, 204);
        private iTextSharp.text.Font fontTinyItalic = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL);
        PdfWriter writerCreate = null;

        public int TaskID { get; set; }
        public int TaskAllocationID { get; set; }
        public string Shipment_Name { get; set; }
        public string Abstract_RefNo { get; set; }
        public int ShipmentIssue { get; set; }
        public int ShipmentYear { get; set; }
        public int ShipmentRefID { get; set; }

        #endregion

        #region Default constructor.

        public FrmPdfGererationOnAbstract()
        {
            InitializeComponent();
        }

        List<string> lstPdfFiles = new List<string>();
        #endregion

        #region Form load event

        private void FrmPdfGererationBasedOnAbstract_Load(object sender, EventArgs e)
        {
            try
            {
                // To view only single page or disable bookmarks menu etc.
                acroPdfExport.setPageMode("SinglePage");
                acroPdfExport.setZoom(200f);

                btnStop.Enabled = false;       

                //Get saved Reference details
                GetReferenceDetailsAndBindToControls();
                
                tblpnlPreview.ColumnCount = 1;
                tblpnlPreview.RowCount = 0;
                tblpnlPreview.RowStyles.Clear();
                tblpnlPreview.AutoScroll = true;
                tblpnlPreview.AutoSize = true;
                this.WindowState = FormWindowState.Maximized;
               
                //rbAppend.Enabled = false;                        
                tblpnlPreview.CellPaint += tableLayoutPanel_CellPaint;
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void GetReferenceDetailsAndBindToControls()
        {
            try
            {
                DataTable dtRefDetails = ShipmentManagementDB.GetReferenceDetailsOnRefID(ShipmentRefID);
                if (dtRefDetails != null)
                {
                    if (dtRefDetails.Rows.Count > 0)
                    {
                        txtShipment.Text = Shipment_Name;
                        txtAbstractRefNo.Text = dtRefDetails.Rows[0]["REFERENCE_NAME"].ToString().Trim();
                        txtIssue.Text = dtRefDetails.Rows[0]["ISSUE"].ToString().Trim();
                        txtYear.Text = dtRefDetails.Rows[0]["SHIPMENT_YEAR"].ToString().Trim();
                        txtSysNoClassType.Text = dtRefDetails.Rows[0]["SYS_CLASS_TYPE"].ToString().Trim();
                        txtSysText.Text = dtRefDetails.Rows[0]["SYS_TEXT"].ToString().Trim();
                        txtSysNum.Text = dtRefDetails.Rows[0]["SYS_NO"].ToString().Trim();
                        txtDoi.Text = dtRefDetails.Rows[0]["DOI"].ToString().Trim();

                        chkNoReaction.Checked = dtRefDetails.Rows[0]["ZERO_REACTIONS_STATUS"].ToString().Trim() == "Y" ? true : false;

                        //Load Pdf from File Server automatically
                        LoadShipmentReferencePdfFile(txtAbstractRefNo.Text, txtShipment.Text);

                        btnStop.Enabled = true;
                    }
                    else
                    {
                        txtShipment.Text = Shipment_Name;
                        txtAbstractRefNo.Text = Abstract_RefNo.ToString();
                        txtIssue.Text = ShipmentIssue.ToString();
                        txtYear.Text = ShipmentYear.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void LoadShipmentReferencePdfFile(string refName, string shipmentName)
        {
            try
            {
                if (!string.IsNullOrEmpty(refName) && !string.IsNullOrEmpty(shipmentName))
                {
                    string pdfName = refName + ".pdf";
                    string serverPath = System.Configuration.ConfigurationSettings.AppSettings["FileServerPath"].ToString();
                    string srcFilePath = serverPath + "\\" + shipmentName.Trim() + "\\" + pdfName;
                    //string destFilePath = Application.StartupPath + "\\" + System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString() + "\\" + pdfName;
                    string destFilePath = Application.StartupPath + "\\Temp_PdfFiles\\temp.pdf";

                    if (File.Exists(srcFilePath))
                    {
                        string errMsg = "";
                        if (Download_UploadPdf.DownloadFileFromWindowsServer(srcFilePath, destFilePath, out  errMsg))
                        {
                            LoadPdfPreview(destFilePath);

                            //acroPdfPreview.LoadFile(destFilePath);
                            //acroPdfPreview.setShowToolbar(true);
                        }
                        else
                        {
                            MessageBox.Show("Error in downloading Pdf from the file server", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //else
                    //{
                    //    MessageBox.Show("Pdf file not found in the file server", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            { 
            
            }
        }

        private bool UploadPdfToFileServer(out string errMsg)
        {
            bool blStatus = false;
            string strErrMsg = "";
            try
            {
                //Transfer newly generated Pdf to File Server
                string pdfName = txtAbstractRefNo.Text + ".pdf";
                string pdfPath = Application.StartupPath + "\\" + System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString() + "\\" + pdfName;//txtOutputFolderPath.Text 
                string serverPath = System.Configuration.ConfigurationSettings.AppSettings["FileServerPath"].ToString();
                string destFilepath = serverPath + "\\" + txtShipment.Text.Trim() + "\\" + pdfName;

                if (File.Exists(pdfPath))
                {
                    if (!Directory.Exists(serverPath + "\\" + txtShipment.Text.Trim()))
                    {
                        Directory.CreateDirectory(serverPath + "\\" + txtShipment.Text.Trim());
                    }

                    //Transfer Pdf to file server
                    if (Download_UploadPdf.UploadFileToWindowsServer(pdfPath, destFilepath, out strErrMsg))
                    {
                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg;
            return blStatus;
        }

        #region Append pdf

        #region Open Pdf file.

        private void btnBrowsePdf_Click(object sender, EventArgs e)
        {
            try
            {
                OpenPdfFile();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// Open pdf file in axAcroPDF1 control.
        /// </summary>
        private void OpenPdfFile()
        {
            try
            {
                using (OpenFileDialog ofDlg = new OpenFileDialog())
                {
                    ofDlg.Filter = "Pdf files (*.pdf)|*.pdf";
                    ofDlg.InitialDirectory = string.IsNullOrEmpty(GlobalVariables.TaskPrepInputPath) ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : GlobalVariables.TaskPrepInputPath;
                    
                    if (ofDlg.ShowDialog() == DialogResult.OK)
                    {
                        GlobalVariables.TaskPrepInputPath = Path.GetDirectoryName(ofDlg.FileName); 

                        //Validate Pdf with selected Shipment
                        string strErrMsg = "";
                        if (ValidateShipmentAndPdf(Path.GetFileNameWithoutExtension(ofDlg.FileName), out strErrMsg))
                        {
                            tblCntrlGeneratedPdfs.SelectedTab = tpPdf;
                            txtInputFilePath.Text = ofDlg.FileName;
                            acroPdfExport.LoadFile(ofDlg.FileName);
                            acroPdfExport.setShowToolbar(true);
                            // tblpnlPreview.Controls.Clear();
                        }
                        else
                        {
                            MessageBox.Show(strErrMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidateShipmentAndPdf(string selectedPdf, out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (!string.IsNullOrEmpty(selectedPdf))
                {                   
                    string pdfYear = "";
                    string pdfIssue = "";

                    string[] saValues = selectedPdf.Trim().Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                    if (saValues != null)
                    {
                        //Format is CI_1981-12_0005
                        if (saValues.Length == 2)
                        {
                            pdfYear = saValues[0].Replace("CI_", "").Trim();
                            pdfIssue = saValues[1].Trim().Substring(0, 2);
                        }
                    }

                    if (!ShipmentYear.ToString().Equals(pdfYear))
                    {
                        strErrMsg = "Shipment year is not matched with pdf year";
                        blStatus = false;
                    }
                    if (Convert.ToInt32(ShipmentIssue.ToString()) != Convert.ToInt32(pdfIssue))
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Shipment Issue is not matched with pdf Issue";
                        blStatus = false;
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg;
            return blStatus;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = string.Empty;
                if (!ValidationsToExportPdf(out  errMsg))
                {
                    string outputFolderPath = Path.Combine(Application.StartupPath, System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString());
                    if (!Directory.Exists(outputFolderPath))
                    {
                        Directory.CreateDirectory(outputFolderPath);
                    }

                    OutputFilePath = outputFolderPath + "\\" + txtAbstractRefNo.Text + ".pdf";
                   
                    // When create pdf for first time we open document.
                    if (rbCreate.Checked)
                    {
                        if (!IsCreateDocOpen)  //(!document.IsOpen())
                        {
                            docCreate = new Document(PageSize.A4);

                            if (File.Exists(OutputFilePath))
                            {
                                tblpnlPreview.Controls.Clear();
                                ExistedFilePreview(OutputFilePath);
                                if (MessageBox.Show("File already exists Do you want to overwrite ? ", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    writerCreate = PdfWriter.GetInstance(docCreate, new FileStream(OutputFilePath, FileMode.Create));
                                }
                                else
                                {
                                    return;
                                }
                                //else
                                //{
                                //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(OutputFilePath, FileMode.CreateNew));
                                //}
                            }
                            else
                            {
                                writerCreate = PdfWriter.GetInstance(docCreate, new FileStream(OutputFilePath, FileMode.Create));
                            }
                            tblpnlPreview.Controls.Clear();
                            docCreate.Open();
                            GlobalVariables.PrevTotalPageNumber = 0;
                            // To add pagenumbers in every page as footer.
                            writerCreate.PageEvent = new Footer();

                            // document.SetMargins(10f, 10f, 10f, 10f);
                            string Title = Path.GetFileNameWithoutExtension(txtAbstractRefNo.Text + ".pdf");
                            iTextSharp.text.Font georgia = FontFactory.GetFont("georgia", 15f);
                            docCreate.AddTitle(Title);
                            AddingHeader(Title);
                            IsCreateDocOpen = true;
                            rbCreate.Enabled = false;

                        }
                        CreateOrAppendPdf(Clipboard.GetImage());
                    }
                    else if (rbAppend.Checked)
                    {
                        if (File.Exists(OutputFilePath))
                        {
                            // Create a temp file to append already existed pdf.
                            if (!IsAppendDocOpen && !IsCreateDocOpen)
                            {
                                tblpnlPreview.Controls.Clear();
                                LoadPdfPreview(OutputFilePath);

                                docAppend = new Document();

                                if (!Directory.Exists(Application.StartupPath + "\\Temp_PdfFiles\\"))
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\Temp_PdfFiles\\");
                                }

                                if (!File.Exists(Application.StartupPath + "\\Temp_PdfFiles\\temp.pdf"))
                                {
                                    File.Create(Application.StartupPath + "\\Temp_PdfFiles\\temp.pdf");
                                }
                          
                                writerAppend = PdfWriter.GetInstance(docAppend, new FileStream(Application.StartupPath + "\\Temp_PdfFiles\\temp.pdf", FileMode.Create));

                                writerAppend.PageEvent = new Footer();
                                writerAppend.Close();
                           
                                docAppend.Open();
                                IsAppendDocOpen = true;
                            }
                            // Append content to pdf.
                            if (IsAppendDocOpen && !IsCreateDocOpen)
                            {
                                AppendPdfToExistingPdf(OutputFilePath, Clipboard.GetImage());
                                if (!lstPdfFiles.Contains(Path.GetFileName(txtInputFilePath.Text.Trim())))
                                {
                                    lstPdfFiles.Add(Path.GetFileName(txtInputFilePath.Text.Trim()));
                                }
                            }
                            else if (IsCreateDocOpen) // add content i.e creating pdf for firsttime.
                            {
                                CreateOrAppendPdf(Clipboard.GetImage());
                                if (!lstPdfFiles.Contains(Path.GetFileName(txtInputFilePath.Text.Trim())))
                                {
                                    lstPdfFiles.Add(Path.GetFileName(txtInputFilePath.Text.Trim()));
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("File not Found to append.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }                   

                    AddToPreview(Clipboard.GetImage());
                    MessageBox.Show("Selected area added to file " + txtAbstractRefNo.Text.Trim() + ".pdf", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.Clear();
                    rbAppend.Checked = true;
                    rbCreate.Enabled = false;
                    btnStop.Enabled = true;
                    btnExportPdf.Text = "Add";                   
                                
                }
                else
                {
                    MessageBox.Show(errMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Append pdf to Existing pdf.
        private void AppendPdfToExistingPdf(string outputfile, System.Drawing.Image imageToScale)
        {
            try
            {
                if (imageToScale != null)
                {
                    iTextSharp.text.Image image = ScaleAppendImage(imageToScale, docAppend);
                    docAppend.Add(image);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Adding header TODOcument.
        private void AddingHeader(string Title)
        {

            try
            {
                // Adding Header TODOcument.
                PdfPTable ptHdr = new PdfPTable(1);
                float[] widths = new float[] { PageSize.A4.Width };
                ptHdr.SetWidthPercentage(widths, PageSize.A4);
                PdfPCell pcGVKInfo = new PdfPCell(new Phrase("GVKBio Sciences Pvt. Ltd internal document", fontTinyItalic));
                // pcGVKInfo.Colspan = 3;
                pcGVKInfo.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pcGVKInfo.BackgroundColor = bgcol;// new BaseColor(255, 160, 122);              
                ptHdr.AddCell(pcGVKInfo);

                // Adding Header TODOcument.
                PdfPCell pTitle = new PdfPCell(new Phrase(Title + ": Reference details.", fontTinyItalic));
                //pTitle.Colspan = 3;
                pTitle.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pTitle.BackgroundColor = bgcol;// new BaseColor(255, 160, 122);              
                ptHdr.AddCell(pTitle);
                docCreate.Add(ptHdr);
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Validate to generate pdf.
        /// </summary>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        private bool ValidationsToExportPdf(out string errMsg)
        {
            errMsg = string.Empty;
            bool Status = false;
            try
            {
                if (txtSysText.Text.Trim() == "")
                {
                    errMsg += "Please enter sys text. \n";
                    Status = true;
                }
                if (txtSysNum.Text.Trim() == "")
                {
                    errMsg += "Please enter sys number. \n";
                    Status = true;
                }
                if (txtInputFilePath.Text.Trim() == "")
                {
                    errMsg += "Please browse pdf to generate Abstactwise pdfs. \n";
                    Status = true;
                }
                //if (txtOutputFolderPath.Text.Trim() == "")
                //{
                //    errMsg += "Please select output folder path. \n";
                //    Status = true;
                //}
                
                //if (!String.IsNullOrEmpty(txtRefNumber.Text.Trim()) && Path.GetExtension(txtRefNumber.Text).ToUpper() != ".PDF")
                //{
                //    errMsg += "out put file extension should be .pdf. \n";
                //    Status = true;
                //}
                if (!Clipboard.ContainsImage())
                {
                    errMsg += "Please select area to Add. \n";
                    Status = true;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return Status;
        }

        // Browse out put folder.
        private void btnBrowseOPutFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
                {
                    fbDlg.SelectedPath = GlobalVariables.TaskPrepOutputPath;                   

                    if (fbDlg.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(GlobalVariables.TaskPrepOutputPath))
                        {
                            GlobalVariables.TaskPrepOutputPath = fbDlg.SelectedPath;
                        }

                        string strpath = fbDlg.SelectedPath;                       
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // stop the creating pdf document.
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to complete the task?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    ClosePdfDocument();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool SaveAbstractRefTask()
        {
            bool blStatus = false;
            try
            {
                TaskPreparation objTaskPrep = new TaskPreparation();
                objTaskPrep.ShipmentRefID = ShipmentRefID;
                objTaskPrep.SysNo = txtSysNum.Text.Trim();
                objTaskPrep.SysText = txtSysText.Text.Trim();
                objTaskPrep.SysNoClassType = txtSysNoClassType.Text.Trim();
                objTaskPrep.AbstractRefNo = txtAbstractRefNo.Text.Trim();               
                objTaskPrep.DOI = txtDoi.Text.Trim();
                objTaskPrep.UrId = GlobalVariables.UR_ID;
                objTaskPrep.IsNoReaction = chkNoReaction.Checked;

                if(DataOperations.SaveTaskPrepation(objTaskPrep, String.Join(",", lstPdfFiles.ToArray())))
                {
                    blStatus = true;
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return blStatus;
        }
        
        // close pdf document if opened.
        private void ClosePdfDocument()
        {
            try
            {   
                bool blStatus = false;
                string errMsg = "";

                if (IsCreateDocOpen) //Newly created pdfs containing in 1 or more pages
                {
                    //Close Pdf document
                    docCreate.CloseDocument();
                    docCreate.Close();
                    docCreate.Dispose();

                    IsCreateDocOpen = false;
                    
                    //Transfer Pdf to file server
                    if (UploadPdfToFileServer(out errMsg))
                    {
                        if (SaveAbstractRefTask() && UpdateUserTaskStatus())
                        {                          

                            MessageBox.Show("Pdf saved successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Clear folder after pdf generation
                            ClearFolder(Application.StartupPath + "\\Temp_PdfFiles");
                            ClearFolder(Application.StartupPath + "\\Pdf_Images");
                            ClearFolder(Application.StartupPath + "\\" + System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString());

                            blStatus = true;

                            //Close form
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error in saving Pdf", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in Pdf file transfer to server", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (IsAppendDocOpen)//This for appending to existing pdf
                {
                    if (!Directory.Exists(Application.StartupPath + "\\Temp_PdfFiles\\"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + "\\Temp_PdfFiles\\");
                    }

                    //Close the temp files
                    docAppend.Close();
                    docAppend.Dispose();
                    writerAppend.Dispose();

                    //Append to eixsting pdf
                    AppendToExistedPdf(OutputFilePath, Application.StartupPath + "\\Temp_PdfFiles\\temp.pdf");
                    IsAppendDocOpen = false;                   

                    //Transfer Pdf to file server
                    if (UploadPdfToFileServer(out errMsg))
                    {
                        if (SaveAbstractRefTask() && UpdateUserTaskStatus())
                        {
                            MessageBox.Show("Pdf saved successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            blStatus = true;

                            //Clear folder after pdf generation
                            ClearFolder(Application.StartupPath + "\\Temp_PdfFiles");
                            ClearFolder(Application.StartupPath + "\\Pdf_Images");
                            ClearFolder(Application.StartupPath + "\\" + System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Error in saving Pdf", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in Pdf file transfer to server", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else //Complete Task in Reviewer/QC login
                //{
                //    //Transfer Pdf to file server
                //    if (UploadPdfToFileServer(out errMsg))
                //    {
                //        if (SaveAbstractRefTask() && UpdateUserTaskStatus())
                //        {

                //            MessageBox.Show("Pdf saved successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //            //Clear folder after pdf generation
                //            ClearFolder(Application.StartupPath + "\\Temp_PdfFiles");
                //            ClearFolder(Application.StartupPath + "\\Pdf_Images");

                //            blStatus = true;

                //            //Close form
                //            this.Close();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Error in saving Pdf", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Error in Pdf file transfer to server", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}

                if (blStatus)
                {
                    rbCreate.Enabled = true;
                    rbAppend.Checked = false;
                    rbAppend.Enabled = true;
                    rbCreate.Checked = true;
                    btnExportPdf.Text = "Create Pdf";
                    btnStop.Enabled = false;

                    Clipboard.Clear();
                    GlobalVariables.PrevTotalPageNumber = 0;
                    
                    tblpnlPreview.RowStyles.Clear();

                    txtDoi.Clear();
                    txtSysText.Clear();
                    txtSysNum.Clear();

                    this.Close();
                }                     
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool UpdateUserTaskStatus()
        {
            bool blStatus = false;
            try
            {
                TaskStatus taskStatus = new TaskStatus();
                taskStatus.TaskComments = "Task preparation completed";
                taskStatus.Task_ID = TaskID;
                taskStatus.Role_ID = GlobalVariables.RoleId;
                taskStatus.TaskAllocation_ID = TaskAllocationID;
                taskStatus.TaskStatusName = "SET COMPLETE";

                if (TaskManagementDB.UpdateTaskStatus(taskStatus))
                {
                    blStatus = true;
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private void ClearFolder(string folderName)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(folderName);

                foreach (FileInfo fi in dir.GetFiles())
                {
                    fi.Delete();
                }

                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    ClearFolder(di.FullName);
                    di.Delete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
        
        /// <summary>
        /// close the opened pdf documents.
        /// </summary>
        private void FrmPdfGererationBasedOnAbstract_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (docCreate != null)
                {
                    //Close Pdf document
                    docCreate.CloseDocument();
                    docCreate.Close();
                    docCreate.Dispose();
                }

                if (docAppend != null)
                {
                    docAppend.Close();
                    docAppend.Dispose();
                }

                acroPdfExport.Dispose();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Append pdf to Existing pdf.
        /// </summary>
        private static void AppendToExistedPdf(string AppendToFilePath, string fileToBeAppendPath)
        {
            try
            {
                using (var output = new MemoryStream())
                {
                    var document = new Document();
                    var writer = new PdfCopy(document, output);
                    document.Open();
                    foreach (var file in new[] { AppendToFilePath, fileToBeAppendPath })
                    {
                        var reader = new PdfReader(file);
                        int n = reader.NumberOfPages;
                        PdfImportedPage page;
                        for (int p = 1; p <= n; p++)
                        {
                            page = writer.GetImportedPage(reader, p);
                            writer.AddPage(page);

                        }
                        reader.Dispose();
                    }
                    document.Close();
                    File.WriteAllBytes(AppendToFilePath, output.ToArray());
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Auto complete of .pdf extension.
        /// </summary>
        private void txtOutputFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (e.KeyChar == '.')
                //{
                //    txtOutputFileName.Text = txtOutputFileName.Text + ".PDF";
                //    e.Handled = true;
                //    txtOutputFileName.Select(txtOutputFileName.TextLength, 1);
                //}
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        ///  To reset preview 
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                tblpnlPreview.Controls.Clear();
                ClosePdfDocument();
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        /// <summary>
        /// Auto complete of .pdf extension.
        /// </summary>
        private void txtOutputFileName_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (!String.IsNullOrEmpty(txtOutputFileName.Text.Trim()))
                //{
                //    if (Path.GetExtension(txtOutputFileName.Text).ToUpper() != ".PDF")
                //    {
                //        txtOutputFileName.Text += ".pdf";
                //    }
                //}
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void rbAppend_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAppend.Checked)
                {
                    string errMsg = String.Empty;
                    if (!AppendValidate(out errMsg))
                    {
                        if (!IsAppendDocOpen && !IsCreateDocOpen)
                        {
                            string outputPath = System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString();
                            string path = outputPath + "\\" + txtAbstractRefNo.Text + ".pdf";

                            if (File.Exists(path))
                            {
                                ExistedFilePreview(path);
                                btnExportPdf.Text = "Add";
                            }
                            else
                            {
                                MessageBox.Show("File Not Found To Append", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rbCreate.Checked = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(errMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ExistedFilePreview(string path)
        {
            try
            {
                tblCntrlGeneratedPdfs.SelectedTab = tpPreview;
                LoadPdfPreview(path);
               
               
                btnStop.Enabled = true;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool AppendValidate(out string errMsg)
        {
            errMsg = string.Empty;
            bool Status = false;
            try
            {
                string outputPath = System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString();
                if (outputPath != "")
                {
                    errMsg = "Please select oupput folder path.\n";
                    rbCreate.Checked = true;
                    Status = true;
                }               
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return Status;
        }

        #endregion

        #region Preview generated pdf.

        // Rescale the image and add it to preview.
        private void AddToPreview(System.Drawing.Image imageToScale)
        {
            try
            {
                System.Drawing.Image returnImage = null;
                returnImage = imageToScale;

                if (!Directory.Exists(Application.StartupPath + "\\Pdf_Images\\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Pdf_Images\\");
                }

                // Storing images into temporary location.
                string imagePath = Application.StartupPath + "\\Pdf_Images\\" + (++imageFilesCount) + ".jpeg";

                returnImage.Save(imagePath);
                // Resize image if width or height more than A4 size.
                if (returnImage.Width > 595 || returnImage.Height > 842)
                {
                    ResizeImage(imagePath, imagePath, 595, 842, true);
                }
                tblpnlPreview.RowCount += 1;
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = System.Drawing.Image.FromFile(imagePath).Size,
                    Location = new Point(10, 10),
                    ImageLocation = imagePath,
                    Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top)))
                };

                tblpnlPreview.Controls.Add(picture);
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Resize image for preview.
        public void ResizeImage(string OriginalFile, string NewFile, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            try
            {
                System.Drawing.Image FullsizeImage = System.Drawing.Image.FromFile(OriginalFile);

                // Prevent using images internal thumbnail
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

                if (OnlyResizeIfWider)
                {
                    if (FullsizeImage.Width <= NewWidth)
                    {
                        NewWidth = FullsizeImage.Width;
                    }
                }

                int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
                if (NewHeight > MaxHeight)
                {
                    // Resize with height instead
                    NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                    NewHeight = MaxHeight;
                }

                System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

                // Clear handle to original file so that we can overwrite it if necessary
                FullsizeImage.Dispose();

                // Save resized picture
                NewImage.Save(NewFile);
            }
            catch (Exception ex)
            { 
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Add image to pdf.
        private void CreateOrAppendPdf(System.Drawing.Image imageToScale)
        {
            try
            {
                iTextSharp.text.Image image = ScaleAppendImage(imageToScale, docCreate);
                docCreate.Add(image);
                if (!lstPdfFiles.Contains(Path.GetFileName(txtInputFilePath.Text.Trim())))
                {
                    lstPdfFiles.Add(Path.GetFileName(txtInputFilePath.Text.Trim()));
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        //// scale image according to A4 size and add it to pdf.
        //private iTextSharp.text.Image ScaleImage(System.Drawing.Image imageToScale)
        //{
        //    System.Drawing.Image returnImage = null;
        //    returnImage = imageToScale;
        //    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(returnImage, System.Drawing.Imaging.ImageFormat.Bmp);

        //    // Resizing image if image width or height is more than A4 size
        //    if (image.Height > PageSize.A4.Height || image.Width > PageSize.A4.Width)
        //    {
        //        // image.ScaleToFit(PageSize.A4.Width,image.Height);
        //        // image.ScaleAbsolute(PageSize.A4.Width, image.Height);
        //        //  image.ScaleToFit(PageSize.A4.Width, image.Height);
        //        // image.ScaleAbsoluteWidth(PageSize.A4.Width);
        //        float Scaler = 0;
        //        if (image.Height > PageSize.A4.Height)
        //        {
        //            Scaler = ((docCreate.PageSize.Height - docCreate.TopMargin
        //       - docCreate.BottomMargin) / image.Height) * 100;
        //        }
        //        if (image.Width > PageSize.A4.Width)
        //        {
        //            Scaler = ((docCreate.PageSize.Width - docCreate.LeftMargin
        //   - docCreate.RightMargin) / image.Width) * 100;
        //        }
        //        image.ScalePercent(Scaler);
        //    }
        //    else
        //    {
        //        image.ScalePercent(65f);
        //    }
        //    return image;
        //}

        //
        private iTextSharp.text.Image ScaleAppendImage(System.Drawing.Image imageToScale, Document doc)
        {
            try
            {
                System.Drawing.Image returnImage = null;
                returnImage = imageToScale;
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(returnImage, System.Drawing.Imaging.ImageFormat.Bmp);

                // Resizing image if image width or height is more than A4 size
                if (image.Height > PageSize.A4.Height || image.Width > PageSize.A4.Width)
                {
                    // image.ScaleToFit(PageSize.A4.Width,image.Height);
                    // image.ScaleAbsolute(PageSize.A4.Width, image.Height);
                    //  image.ScaleToFit(PageSize.A4.Width, image.Height);
                    // image.ScaleAbsoluteWidth(PageSize.A4.Width);
                    float Scaler = 0;
                    if (image.Height > PageSize.A4.Height)
                    {
                        Scaler = ((doc.PageSize.Height - doc.TopMargin
                   - doc.BottomMargin) / image.Height) * 100;
                    }
                    if (image.Width > PageSize.A4.Width)
                    {
                        Scaler = ((doc.PageSize.Width - doc.LeftMargin
               - doc.RightMargin) / image.Width) * 100;
                    }
                    image.ScalePercent(Scaler);
                }
                else
                {
                    image.ScalePercent(65f);
                }
                return image;
            }
            catch (Exception ex)
            {                
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return null;
        }
        
        // Draw seperate lines to view seperation in preview part.
        private void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            try
            {
                e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Folderwise pdf files

        private void btnPreviewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    string strpath = fb.SelectedPath;
                    txtPreviewFolderPath.Text = strpath;
                    LoadFileNames(strpath);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void lstvFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Acquire SelectedItems reference.
                var selectedItems = lstvFolder.SelectedItems;
                if (selectedItems.Count == 1)
                {
                    // Display text of first item selected.
                    if (Path.GetExtension(selectedItems[0].Text).ToUpper() == ".PDF")
                    {
                        acroPdfView.LoadFile(txtPreviewFolderPath.Text + "\\" + selectedItems[0].Text);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void tbPdfs_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (tblCntrlGeneratedPdfs.SelectedTab == tpGeneratedPdfs)
                {
                    string outputPath = System.Configuration.ConfigurationSettings.AppSettings["TaskPreparationFolder"].ToString();
                    if (outputPath != "")
                    {
                        txtPreviewFolderPath.Text = outputPath;
                    }
                    string path = outputPath;
                    LoadFileNames(path);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void LoadFileNames(string path)
        {
            try
            {
                if (path != "")
                {
                    string[] Files = Directory.GetFiles(path);
                    string[] Directories = Directory.GetDirectories(path);
                    string[] subinfo = new string[3];
                    lstvFolder.Clear();
                    lstvFolder.Columns.Add("Name", 255);
                    lstvFolder.Columns.Add("Size", 100);
                    lstvFolder.Columns.Add("Type", 80);
                    foreach (string Dname in Directories)
                    {
                        subinfo[0] = GetFileName(Dname);
                        subinfo[1] = "";
                        subinfo[2] = "FOLDER";
                        ListViewItem DItems = new ListViewItem(subinfo);
                        lstvFolder.Items.Add(DItems);
                    }
                    foreach (string Fname in Files)
                    {
                        if (Path.GetExtension(Fname).ToUpper() == ".PDF")
                        {
                            subinfo[0] = GetFileName(Fname);
                            subinfo[1] = GetSizeinfo(Fname);
                            subinfo[2] = GetTypeinfo(Fname);
                            ListViewItem FItems = new ListViewItem(subinfo);
                            lstvFolder.Items.Add(FItems);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        public string GetFileName(string path)
        {
            try
            {
                int Nameindex = path.LastIndexOf('\\');
                return path.Substring(Nameindex + 1);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        public string GetTypeinfo(string path)
        {
            string FType = "";
            try
            {
                int Typeindex = path.LastIndexOf('.');
               
                if (Typeindex != -1)
                {
                    FType = path.Substring(Typeindex + 1);
                    FType = FType.ToUpper();
                    if (FType == "AVI" || FType == "3GP" || FType == "WMV")
                    {
                        FType = "Video Clip";
                    }
                    else if (FType == "MP3")
                    {
                        FType = "MP3 Format Sound";
                    }
                    return FType;
                }
                else
                {
                    FType = "FILE";
                   
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return FType;
        }

        public string GetSizeinfo(string path)
        {
            string result = string.Empty;
            try
            {
                FileInfo fi = new FileInfo(path);
                long size = fi.Length;
                string txtsize = "";
                if (size < 1024)
                {
                    txtsize = "byte";
                }
                else if (size > 1024)
                {
                    size = size / 1024;
                    txtsize = "Kb";
                }
                if (size > 1024)
                {
                    size = size / 1024;
                    txtsize = "Mb";
                }
                if (size > 1024)
                {
                    size = size / 1024;
                    txtsize = "Gb";
                }
                result = size + " " + txtsize;
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return result;
        }

        #endregion


        // To swap tablelayout panel.
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Control c1 = this.tableLayoutPanel1.GetControlFromPosition(0, 0);
        //    Control c2 = this.tableLayoutPanel1.GetControlFromPosition(0, 1);

        //    if (c1 != null && c2 != null)
        //    {
        //        this.tableLayoutPanel1.SetRow(c2, 0);
        //        this.tableLayoutPanel1.SetRow(c1, 1);
        //    }
        //}

        // When Appending pdf to existing pdf load preview.
        private void LoadPdfPreview(string OutputFilePath)
        {
            try
            {
                SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                // f.Serial = "XXXXX";
                tblpnlPreview.Controls.Clear();
                f.OpenPdf(OutputFilePath);

                GlobalVariables.PrevTotalPageNumber = f.PageCount;
                if (f.PageCount > 0)
                {                //Set 200 dpi and jpeg format
                    f.ImageOptions.Dpi = 100;
                    f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    //Save all pages to jpegs into the folder 'Pictures'
                    //P.S. The folder 'Pictures' must be existed
                    for (int page = 1; page <= f.PageCount; page++)
                    {
                        f.ToImage(Application.StartupPath + "\\Pdf_Images\\" + page + ".jpg", page);
                        AddToPreview(System.Drawing.Image.FromFile(Application.StartupPath + "\\Pdf_Images\\" + page + ".jpg"));
                    }
                }

                //Close pdf
                f.ClosePdf();
               
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }            
        }

        private void lnkSysText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (frmSYSNoMaster frmSysNo = new frmSYSNoMaster())
                {
                    if (frmSysNo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        txtSysNum.Text = frmSysNo.txtSelectedSysNo.Text.Trim();
                        txtSysText.Text = frmSysNo.txtSelectedSysText.Text.Trim();
                        txtSysNoClassType.Text = frmSysNo.txtSelectedClassType.Text.Trim();
                    }
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private string GetIssueOnShipmentID(int shipmentID, out string year_out)
        {
            string strIssue = "";
            string strYear = "";
            try
            {
                if (GlobalVariables.ShipmentMaster != null)
                {
                 var query = from r in GlobalVariables.ShipmentMaster.AsEnumerable()
                                where r.Field<Int64>("SHIPMENT_ID") == shipmentID
                                select new
                                {
                                    issue = r["ISSUE"].ToString(),
                                    year = r["SHIPMENT_YEAR"].ToString()
                                };

                    if (query != null)
                    {
                        strIssue = query.ElementAt(0).issue.ToString();
                        strYear = query.ElementAt(0).year.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            year_out = strYear;
            return strIssue;
        }        

        private void txtRefNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }      

    }
}
