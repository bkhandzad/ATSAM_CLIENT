using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;

namespace AtsamClient
{
    public partial class frmReport : Form
    {
        string ReportPath = string.Empty;
        private CCL pCCL = new CCL();
        private _Table __Table;

        public frmReport(string ReportPath)
        {
            InitializeComponent();
            __Table = (_Table)this.Tag;
            this.Text = __Table.Description;
            this.ReportPath = ReportPath;
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            if (this.rvReportViewer.ServerReport.ReportPath == string.Empty)
            {
                this.rvReportViewer.ServerReport.ReportServerUrl = new Uri(CA.ReportServerUrl);
                this.rvReportViewer.ServerReport.ReportPath = this.ReportPath;
                this.rvReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
                this.rvReportViewer.RefreshReport();
            }
        }

        public void SetParam(List<Microsoft.Reporting.WinForms.ReportParameter> sptParameters)
        {
            this.rvReportViewer.ServerReport.ReportServerUrl = new Uri(CA.ReportServerUrl);
            this.rvReportViewer.ServerReport.ReportPath = this.ReportPath;
            this.rvReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            try
            {
                for (int iLenght = 0; iLenght < sptParameters.Count; iLenght++)
                    this.rvReportViewer.ServerReport.SetParameters(sptParameters[iLenght]);
            }
            catch (Exception e)
            {
                string str = e.Message;
            }

            rvReportViewer.ShowParameterPrompts = false;

            rvReportViewer.ShowPromptAreaButton = false;
        }
    }
}
