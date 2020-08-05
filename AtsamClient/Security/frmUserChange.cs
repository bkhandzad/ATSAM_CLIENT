using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using ClientCommonLayer;
using Atsam;

namespace AtsamClient.Security
{
    public partial class frmUserChange : Form
    {
        public frmUserChange()
        {
            InitializeComponent();
            this.lblCaption.Text = new CCL().GetResourceString("strUserChange");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtUserID.Text.Trim() == string.Empty) || (txtUserPassword.Text.Trim() == string.Empty))
            {
                txtUserID.Focus();
                return;
            }
            User u = new User(txtUserID.Text.Trim(), txtUserPassword.Text.Trim());
            switch (User.Status)
            {
                case Atsam.ErrorCode.ecNone:
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    }
                default:
                    {
                        txtUserID.Text = String.Empty;
                        txtUserPassword.Text = String.Empty;
                        txtUserID.Focus();
                        break;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtUserPassword.Text.Trim() == String.Empty)
                    txtUserPassword.Focus();
                else
                    btnOk_Click(this, null);
            }
        }

        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtUserID.Text.Trim() == String.Empty)
                    txtUserID.Focus();
                else
                    btnOk_Click(this, null);
            }
        }

        private void frmUserChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
