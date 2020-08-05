using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


using ClientCommonLayer;
using Atsam;

namespace AtsamClient.Security
{
    public partial class frmVersion : Form
    {
        private CCL pCCL = new CCL();
        private IBFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }
        private _Table __Table;

        DataTable dtDataTable = new DataTable();


        public frmVersion()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmVersion_Load(object sender, EventArgs e)
        {
            __Table = (_Table)this.Tag;
            lblCaption.Text = __Table.Description;
            __Table.SetField();
            pCCL.SetDataPanelView(gbDetails, ttToolTip, __Table);
            pCCL.SetDataPanelView(gbCompany, ttToolTip, __Table);
            if (pBFL.GetDataTable(ref dtDataTable, __Table.Alias, __Table.Filter, __Table.Order) == null)
            {
                pCCL.SetGroupBox(gbDetails, __Table, dtDataTable.Rows[0]);
                pCCL.SetGroupBox(gbCompany, __Table, dtDataTable.Rows[0]);
            }
            else
                this.Close();
            lblWorkStationValue.Text = User.WorkStation;
        }

        private void llWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(llWebsite.Text);
        }

        private void frmVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
