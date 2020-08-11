using System;
using Microsoft.Win32;

using Atsam;
using Macro;

namespace ClientCommonLayer
{
    public class CA // Client Administrator
    {
        private static int intPortNumber = -1;
        private static string strServerIPAddress = string.Empty;
        private static string strReportServerUrl = string.Empty;
        private static ErrorCode ecErrorCode = ErrorCode.ecNone;

        public CA(string strKey)
        {
            try
            {
                RegistryKey rkRegistry = Registry.CurrentUser.OpenSubKey("Software\\" + strKey.Trim(), false);
                intPortNumber = Convert.ToInt32(rkRegistry.GetValue("PortNumber").ToString().Trim());
                strServerIPAddress = rkRegistry.GetValue("ServerIPAddress").ToString().Trim();
                strReportServerUrl = rkRegistry.GetValue("ReportServerUrl").ToString().Trim();
            }
            catch
            {
                ecErrorCode = ErrorCode.ecDBConnection;
            }
        }

        public static int PortNumber
        {
            get
            {
                return (intPortNumber);
            }
        }

        public static string ServerIPAddress
        {
            get
            {
                return (strServerIPAddress);
            }
        }

        public static string ReportServerUrl
        {
            get
            {
                return (strReportServerUrl);
            }
        }

        public static ErrorCode Status
        {
            get
            {
                return (ecErrorCode);
            }
        }
    }
}
