using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
//using System.Net;
using System.Runtime.InteropServices;
using System.IO;
//using System.Collections;
using System.Reflection;
//using System.Resources;

namespace MessageBox
{
    public partial class frmMessageBox : Form
    {
        public string strMessage = string.Empty;
        public string strTitle = string.Empty;
        public MessageBoxIcon mbiIcon = MessageBoxIcon.None;
        public MessageBoxButtons mbbButtons = MessageBoxButtons.OK;

        const int intButtonWidth = 0;
        const int intTextWidth = 0;
        const int intButtonTop = 70;
        const int intTextTop = 20;

        public frmMessageBox()
        {
            InitializeComponent();             
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Name)
            {
                case "btnOk": DialogResult = DialogResult.OK; break;
                case "btnCancel": DialogResult = DialogResult.Cancel; break;
                case "btnYes": DialogResult = DialogResult.Yes; break;
                case "btnNo": DialogResult = DialogResult.No; break;
            }            
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            lblMessage.Text = strMessage;
            pbIcon.Image = GetResourceImage(mbiIcon.ToString() + ".png");

            switch (mbbButtons)
            {
                case MessageBoxButtons.OK:
                    {
                        btnOk.Left = lblMessage.Location.X + (lblMessage.Width - btnOk.Width) / 2;
                        btnOk.Visible = true;
                        break;
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        btnCancel.Left = lblMessage.Location.X + (lblMessage.Width - btnCancel.Width * 2 - 20) / 2;
                        btnCancel.Visible = true;
                        btnOk.Left = btnCancel.Location.X + btnCancel.Size.Width + 10;
                        btnOk.Visible = true;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        btnNo.Left = lblMessage.Location.X + (lblMessage.Width - btnNo.Width * 2 - 20) / 2;
                        btnNo.Visible = true;
                        btnYes.Left = btnNo.Location.X + btnNo.Size.Width + 10;
                        btnYes.Visible = true;
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        btnCancel.Left = lblMessage.Location.X + (lblMessage.Width - btnCancel.Width * 3 - 20) / 2;
                        btnCancel.Visible = true;
                        btnNo.Left = btnCancel.Location.X + btnCancel.Size.Width + 10;
                        btnNo.Visible = true;
                        btnYes.Left = btnNo.Location.X + btnNo.Size.Width + 10;
                        btnYes.Visible = true;
                        break;
                    }
            }            
        }

        private FontFamily GetResourceFont(string strFontName)
        {
            PrivateFontCollection pfcPrivateFontCollection = new PrivateFontCollection();
            string strProjectName = GetType().Assembly.ManifestModule.ToString();
            strProjectName = strProjectName.Substring(0, strProjectName.Length - 4);
            // receive resource stream
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(strProjectName + ".Resources." + strFontName);
            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            // create a buffer to read in to
            byte[] fontdata = new byte[fontStream.Length];
            // read the font data from the resource
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
            // pass the font to the font collection
            pfcPrivateFontCollection.AddMemoryFont(data, (int)fontStream.Length);
            // close the resource stream
            fontStream.Close();
            // free the unsafe memory
            Marshal.FreeCoTaskMem(data);
            return (pfcPrivateFontCollection.Families[0]);
        }

        private Bitmap GetResourceImage(string strImageName)
        {
            string strProjectName = GetType().Assembly.ManifestModule.ToString();
            strProjectName = strProjectName.Substring(0, strProjectName.Length - 4);
            Bitmap bBitmap = new Bitmap(GetType().Assembly.GetManifestResourceStream(strProjectName + ".Resources." + strImageName));
            return (bBitmap);
        }
    }
}