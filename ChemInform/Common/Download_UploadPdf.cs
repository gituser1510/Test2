using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using ChemInform;

namespace ChemInform.Common
{
    public class Download_UploadPdf
    {
        public static bool CallPSCPAndDownLoadFile(string _file_download,string _server_dirpath,string _target_path, out string error_out)
        {
            bool blStatus = false;
            string strError = "";
            try
            {
                //Create a pscp key in registry if not
                CheckAndCreatePscpKey(System.Configuration.ConfigurationSettings.AppSettings["PuttyKeyPath"].ToString());

                string strAppBase = Application.StartupPath.ToString();

                string pscpUserName = System.Configuration.ConfigurationSettings.AppSettings["pscpusername"].ToString();
                string pscpPassword = System.Configuration.ConfigurationSettings.AppSettings["pscppassword"].ToString();
                string pscpServer =  System.Configuration.ConfigurationSettings.AppSettings["pscpservername"].ToString();

                string pscpSettings = pscpUserName + "@" + pscpServer + ":" + _server_dirpath;          
                string pscpPath = "\"" + strAppBase + "\\pscp.exe\"";
                string pscpArgs = " -scp -pw " + pscpPassword + "  " + pscpSettings + "" + _file_download + "  " + "\"" + _target_path + "\"" + "";

                if (RunPscpProcess(strAppBase, pscpPath, pscpArgs, out strError))
                {
                    blStatus = true;
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }            
            error_out = strError;
            return blStatus;
        }

        private static bool RunPscpProcess(string _appbase, string _pscppath, string _pscpargs, out string _error_out)
        {
            Process objPscpProc = null;      
            string strProcError = "";
            bool blStatus = false;
            try
            {
                objPscpProc = new Process();
                objPscpProc.EnableRaisingEvents = true;
                objPscpProc.StartInfo.WorkingDirectory = _appbase;
                objPscpProc.StartInfo.FileName = _pscppath;
                objPscpProc.StartInfo.Arguments = _pscpargs;
                objPscpProc.StartInfo.RedirectStandardOutput = false;
                objPscpProc.StartInfo.CreateNoWindow = true;
                objPscpProc.StartInfo.RedirectStandardError = true;
                objPscpProc.StartInfo.UseShellExecute = false;
                objPscpProc.Start();
                
                strProcError = objPscpProc.StandardError.ReadToEnd();

                if (strProcError.Length > 0)
                {                 
                    blStatus = false;
                }
                else if (objPscpProc.HasExited)
                {
                    blStatus = true;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());               
            }
            finally
            {
                objPscpProc.Dispose();
            }
            _error_out = strProcError;
            return blStatus;
        }

        public static void CheckAndCreatePscpKey(string baseKey)
        {
            RegistryKey key;
            try
            {
                key = Registry.CurrentUser.OpenSubKey(baseKey, true);
                string strsettings = System.Configuration.ConfigurationSettings.AppSettings["PSCPSettings"];

                string strPuttyKeypath = System.Configuration.ConfigurationSettings.AppSettings["PuttyKeyPath"];
                string strPuttyKey = System.Configuration.ConfigurationSettings.AppSettings["PuttyKey"];
                string strKeyValue = System.Configuration.ConfigurationSettings.AppSettings["KeyValue"];

                //WriteLog("Start writing pscp cache key in registry");
                key = Registry.CurrentUser.CreateSubKey(strPuttyKeypath);
                //GrantAllAccessPermission(strPuttyKey);
                object objtest = (Object)strKeyValue;

                if (key.GetValue(strPuttyKey) == null)
                {
                    key.SetValue(strPuttyKey, objtest);  //Installer Changes //wyeth

                    //WriteLog("End writing pscp cache key in registry");
                }
                else if (key.GetValue(strPuttyKey).ToString() != strKeyValue)
                {
                    key.SetValue(strPuttyKey, objtest);  //Installer Changes //wyeth
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Creating Registry Key for PUTTY Problem");
            }
        }

        public static bool DownloadFileFromWindowsServer(string serverFilePath, string destFilePath, out string error_out)
        {
            string strError = "";
            bool blStatus = false;
            try
            {
                if (System.IO.File.Exists(serverFilePath))
                {
                    try
                    {
                        System.IO.File.Copy(serverFilePath, destFilePath, true);
                        blStatus = true;
                    }
                    catch(Exception ex)
                    {
                        error_out = ex.ToString();
                    }
                }
                else
                {
                    strError = serverFilePath + " file does not exist";
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            error_out = strError;
            return blStatus;
        }

        public static bool UploadFileToWindowsServer(string sourcePath,string destFilePath, out string error_out)
        {
            string strError = "";
            bool blStatus = false;
            try
            {
                if (!string.IsNullOrEmpty(sourcePath))
                {
                    //string pdfName = Path.GetFileName(sourcePath);                                       
                    //string serverPath = System.Configuration.ConfigurationSettings.AppSettings["FileServerPath"].ToString();
                    //string strFilepath = serverPath + "\\" + Enums.ApplicationName.NARRATIVES + "\\" + "TEST" + "\\" + pdfName;
                                      
                    if (System.IO.File.Exists(sourcePath))
                    {
                        try
                        {
                            System.IO.File.Copy(sourcePath, destFilePath, true);
                            blStatus = true;
                        }
                        catch (Exception ex)
                        {
                            error_out = ex.ToString();
                        }
                    }
                    else
                    {
                        strError = sourcePath + " file does not exist";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            error_out = strError;
            return blStatus;
        }
    }
}
