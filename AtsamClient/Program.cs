using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

using Atsam.Server;
using Macro;
using ClientCommonLayer;

namespace AtsamClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strURI = "ATSAM";
            CA pCA = new CA(strURI);
            CCL pCCL = new CCL();
            //MAPCommonLayer.SA pSA = new MAPCommonLayer.SA(strURI);
            if (CA.Status == Macro.ErrorCode.ecNone)
            {
                RemotingConfiguration.RegisterWellKnownClientType(typeof(BusinessFacadeLayer.BFL), "http://" + CA.ServerIPAddress + ":" + CA.PortNumber + "/" + strURI + "URI");
                try
                {
                    ABFL pBFL = new BusinessFacadeLayer.BFL();
                    pBFL.InitializeLifetimeService();
                    ServerSupplier serverSupplier = new ServerSupplier(pBFL);
                }
                catch
                {
                    CCL.pMB.Show(pCCL.GetResourceString("ecServerConnection"), pCCL.GetResourceString("strErrorTitle"), MessageBoxIcon.Stop, MessageBoxButtons.OK);
                    Application.Exit();
                    return;
                }
            }
            else
            {
                CCL.pMB.Show(pCCL.GetResourceString("ecClientConnection"), pCCL.GetResourceString("strErrorTitle"), MessageBoxIcon.Stop, MessageBoxButtons.OK);
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
