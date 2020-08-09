using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;

namespace AtsamClient.Security
{
    public partial class frmPasswordChange : Form
    {
        private CCL pCCL = new CCL();
        private ABFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }

        private DataTable dtDataTable = new DataTable();
        public frmPasswordChange()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtPasswordConfirmation.Text.Trim() == String.Empty)
                    txtPasswordConfirmation.Focus();
                else
                    btnOk_Click(this, null);
            }
        }

        private void txtPasswordConfirmation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtNewPassword.Text.Trim() == String.Empty)
                    txtNewPassword.Focus();
                else
                    btnOk_Click(this, null);
            }
        }

        private void frmPasswordChange_Load(object sender, EventArgs e)
        {
            try
            {
                SqlException eSqlException = pBFL.GetDataTable(ref dtDataTable, "_User");
                if (eSqlException != null)
                {
                    System.Windows.Forms.MessageBox.Show(eSqlException.Message);
                    this.Close();
                }
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() != String.Empty)
            {
                if (txtNewPassword.Text.Trim() == txtPasswordConfirmation.Text.Trim())
                {
                    DataRow[] drDataRow = dtDataTable.Select("PK_UserID = " + User.UserCode.ToString());
                    if (drDataRow.Length > 0)
                    {
                        int RowIndex = dtDataTable.Rows.IndexOf(drDataRow[0]);
                        dtDataTable.Rows[RowIndex]["UserPassword"] = txtNewPassword.Text.Trim();
                        pBFL.SetDataTable(dtDataTable, "_User");
                        pBFL.Logging(User.UserCode, (int)SystemTable.stUser, Macro.Action.aUpdate, User.IP);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
            }
        }

        private void frmPasswordChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
