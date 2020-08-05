using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtsamClient
{
    public partial class frmReport : Form
    {
        string strReportPath = string.Empty;

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(string ReportPath)
        {
            InitializeComponent();
            strReportPath = ReportPath;
            //this.rvReportViewer.ServerReport.ReportServerUrl = new Uri("http://192.168.1.3:8080/ReportServer_MAP");
            //this.rvReportViewer.ServerReport.ReportServerUrl = new Uri("http://localhost/ReportServer");
            //rvReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
        }
    }
}
