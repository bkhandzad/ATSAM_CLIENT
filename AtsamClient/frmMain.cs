﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;
using AtsamClient.Security;

namespace AtsamClient
{
    public partial class frmMain : Form
    {
        private CCL pCCL = new CCL();
        private ABFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            sUserChange();
            if (User.Status == ErrorCode.ecNone)
            {
                Application.DoEvents();
                tsslUserName.Text = User.UserName;
                tsslDate.Text = pBFL.GetSolarDate('/');
                tsslDayOfWeek.Text = pBFL.GetSolarDayOfWeek();
                this.Text = User.WorkStation;
                this.tsslTime.Text = pBFL.GetSolarTime(':');
                //this.BackgroundImage = MAP_PBG_Client.Properties.Resources.BackgroundImage;
                this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
                this.Visible = tmrTimer.Enabled = true;
            }
            else
            {
                this.Close();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            pBFL.Logging(User.UserCode, User.WorkStationCode, Macro.Action.aLogOut, User.IP);
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan tsTimeSpan = new TimeSpan(Convert.ToInt32(tsslTime.Text.Substring(0, 2)), Convert.ToInt32(tsslTime.Text.Substring(3, 2)), Convert.ToInt32(tsslTime.Text.Substring(6, 2)) + 1);
            tsslTime.Text = tsTimeSpan.ToString();
        }

        private void sPasswordChange()
        {
            if (User.CurrentUserType == UserType.utLocal)
            {
                User.IsPasswordChanged = true;
                frmUserChange frmUC = new frmUserChange();
                if (frmUC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    if (User.IsUserChanged == false)
                    {
                        frmPasswordChange frmPC = new frmPasswordChange();
                        frmPC.ShowDialog();
                        return;
                    }
            }
        }

        private void sUserChange()
        {
            User.IsPasswordChanged = false;
            frmUserChange frm = new frmUserChange();
            frm.ShowDialog();
            Application.DoEvents();
            if (User.IsUserChanged == true)
            {
                tsslUserName.Text = User.UserName;
                SetMenuStrip(msMenuStrip, User.WorkStationCode, true);
            }
        }

        private void tsmiToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            _Table __Table = (_Table)tsmi.Tag;
            Application.DoEvents();
            this.Cursor = Cursors.WaitCursor;
            switch (__Table.TableName)
            {
                case "o_UserInterChange": sUserChange(); break;
                case "o_PasswordChange": sPasswordChange(); break;
                case "o_Quit": this.Close(); break;
                default:
                    {

                        if ((TableType)__Table.FK_TableTypeCode == TableType.ttReport)
                        {
                            frmReport frm = new frmReport(__Table.LinkPage);
                            frm.ShowDialog();
                        }
                        else if (__Table.LinkPage.Trim() != string.Empty)
                        {
                            try
                            {
                                Form frm = __Table.LinkPageForm();
                                frm.Tag = tsmi.Tag;
                                frm.ShowDialog();
                            }
                            catch (Exception eException)
                            {
                                System.Windows.Forms.MessageBox.Show(eException.Message);
                            }
                        }
                    }
                    break;
            }
            this.Cursor = Cursors.Default;
        }

        private void SetMenuStrip(MenuStrip msMenuStrip, int intTableCode, Boolean HasSubMenu)
        {
            DataTable dtDataTable = new DataTable();
            try
            {
                SqlException eSqlException = pBFL.GetDataTable(ref dtDataTable, "_Table");
                if (eSqlException != null)
                {
                    System.Windows.Forms.MessageBox.Show(eSqlException.Message);
                    return;
                }
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
                return;
            }
            msMenuStrip.Items.Clear();
            CreateMenuStrip(msMenuStrip, null, dtDataTable, intTableCode, HasSubMenu);
        }

        private void CreateMenuStrip(MenuStrip msMenuStrip, ToolStripMenuItem tsmiToolStripItem, DataTable dtDataTable, int intTableCode, Boolean HasSubMenu)
        {
            DataRow[] drDataRow = dtDataTable.Select("Visible = 1 AND FK_ParentTableCode = " + intTableCode.ToString() + " AND (FK_TableTypeCode NOT IN (" + Convert.ToInt16(TableType.ttRelation).ToString() + ", " + Convert.ToInt16(TableType.ttSubTable).ToString() + ", " + Convert.ToInt16(TableType.ttButton).ToString() + "))", "Rank ASC");
            ToolStripMenuItem tsmi = null;
            Boolean IsVisibleSeperator = false;

            for (int RootIndex = 0; (RootIndex < drDataRow.Length); RootIndex++)
            {
                _Table __Table = new _Table(drDataRow[RootIndex]);
                if (tsmiToolStripItem == null)
                {
                    if (__Table.getPermission(Macro.Action.aSelect) == true)
                    {
                        tsmi = (ToolStripMenuItem)msMenuStrip.Items.Add(drDataRow[RootIndex]["Description"].ToString(), null, tsmiToolStripMenuItem_Click);
                        tsmi.Tag = __Table;
                    }
                }
                else
                    if ((TableType)Convert.ToInt16(drDataRow[RootIndex]["FK_TableTypeCode"]) == TableType.ttSeperator)
                {
                    if ((tsmiToolStripItem.DropDownItems.Count > 0) && (!(tsmiToolStripItem.DropDownItems[tsmiToolStripItem.DropDownItems.Count - 1] is ToolStripSeparator)))
                        IsVisibleSeperator = true;
                }
                else
                        if (__Table.getPermission(Macro.Action.aSelect) == true)
                {
                    if (IsVisibleSeperator == true)
                    {
                        tsmiToolStripItem.DropDownItems.Add(new ToolStripSeparator());
                        IsVisibleSeperator = false;
                    }
                    tsmi = (ToolStripMenuItem)tsmiToolStripItem.DropDownItems.Add(drDataRow[RootIndex]["Description"].ToString(), null, tsmiToolStripMenuItem_Click);
                    tsmi.Tag = __Table;
                }
                if (HasSubMenu == true)
                    CreateMenuStrip(msMenuStrip, tsmi, dtDataTable, Convert.ToInt16(drDataRow[RootIndex]["PK_TableCode"]), true);
            }
            return;
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                    ctl.BackColor = System.Drawing.Color.LightSlateGray;
            }
        }
    }
}
