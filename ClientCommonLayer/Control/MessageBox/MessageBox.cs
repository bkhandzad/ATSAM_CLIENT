using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MessageBox
{
    public class MessageBox
    {
        public DialogResult Show(string strMessage, string strTitle, MessageBoxIcon mbiMessageBoxIcon, MessageBoxButtons mbbMessageBoxButtons)
        {
            frmMessageBox frm = new frmMessageBox();
            frm.strMessage = strMessage;
            frm.strTitle = strTitle;
            frm.mbiIcon = mbiMessageBoxIcon;
            frm.mbbButtons = mbbMessageBoxButtons;
            return(frm.ShowDialog());
        }
    }
}
