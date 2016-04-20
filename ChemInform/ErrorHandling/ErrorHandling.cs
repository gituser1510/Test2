using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog.Targets;
using NLog.Targets.Wrappers;
using NLog;
using ChemInform.Common;
using ChemInform.Bll;
using ChemInform.Dal;

namespace ChemInform
{
    public static class ErrorHandling
    {
        public static void WriteErrorLog(string message)
        {
            FileTarget target = new FileTarget();
            target.Layout = "${longdate} ${logger} ${message}";
            target.FileName = "${basedir}/Trace/ChemInformLog.txt";
            target.KeepFileOpen = false;
            target.Encoding = "iso-8859-2";

            AsyncTargetWrapper wrapper = new AsyncTargetWrapper();
            wrapper.WrappedTarget = target;
            wrapper.QueueLimit = 5000;
            wrapper.OverflowAction = AsyncTargetWrapperOverflowAction.Discard;

            NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(wrapper, NLog.LogLevel.Trace);

            Logger logger = LogManager.GetLogger(GlobalVariables.ProjectName);
            logger.Trace(message);

            try
            {
                ApplicationError appError = new ApplicationError();
                appError.UserName = GlobalVariables.UserName;
                appError.RoleName = GlobalVariables.RoleName;
                appError.AppError = message;
                CommonDB.SaveApplicationErrors(appError);
            }
            catch
            { }    
        }
    }
}
