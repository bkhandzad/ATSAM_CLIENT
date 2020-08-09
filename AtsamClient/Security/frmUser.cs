using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;

namespace AtsamClient.Security
{
    public partial class frmUser : Form
    {
        private CCL pCCL = new CCL();
        private ABFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }
        private _Table __Table;

        private CurrencyManager cmCurrencyManager;
        private DataTable dtDataTable = new DataTable();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            __Table = (_Table)this.Tag;
            lblCaption.Text = __Table.Description;
            __Table.SetField();
            pCCL.SetButton(tsToolStrip, __Table.PK_TableCode);
            pCCL.SetDataPanelView(gbDetails, ttToolTip, __Table);
            SetDataSource();
            pCCL.SetDataGridView(dgvDataGridView, __Table);
        }

        private void frmUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if ((__Table.TableStatus == TableStatus.tsInsert) || (__Table.TableStatus == TableStatus.tsEdit))
                    tsbDBCancel_Click(tsbDBCancel, null);
                else
                {
                    if (__Table.FormStatus == FormStatus.fsBase)
                        this.Close();
                }
            }
        }

        private void cmCurrencyManager_PositionChanged(Object sender, System.EventArgs e)
        {
            if (__Table.TableStatus != TableStatus.tsOnProcess)
            {
                if (__Table.TableStatus == TableStatus.tsNone)
                {
                    if (dtDataTable.Rows.Count > 0)
                        __Table.TableStatus = TableStatus.tsBrowse;
                    else
                        __Table.TableStatus = TableStatus.tsEmpty;
                }
                switch (__Table.TableStatus)
                {
                    case TableStatus.tsBrowse:
                        {
                            pCCL.SetGroupBox(gbDetails, __Table, dtDataTable.Rows[cmCurrencyManager.Position]);
                            pCCL.SetGroupBox(gbDetails, false, false);
                            break;
                        }
                    case TableStatus.tsEmpty:
                        pCCL.SetGroupBox(gbDetails, false, true);
                        break;
                    case TableStatus.tsInsert:
                        pCCL.SetGroupBox(gbDetails, true, true);
                        break;
                    case TableStatus.tsEdit:
                        {
                            pCCL.SetGroupBox(gbDetails, __Table, dtDataTable.Rows[cmCurrencyManager.Position]);
                            pCCL.SetGroupBox(gbDetails, true, false);
                            break;
                        }
                }
                pCCL.SetToolStrip(tsToolStrip, __Table);
                SetMenuStrip();
                pCCL.SetStatusStrip(ssStatusStrip, __Table.TableStatus, cmCurrencyManager);
            }
        }

        private void SetDataSource()
        {
            try
            {
                __Table.TableStatus = TableStatus.tsOnProcess;
                dtDataTable.Clear();
                __Table.TableStatus = TableStatus.tsNone;
                SqlException eSqlException = pBFL.GetDataTable(ref dtDataTable, __Table.TableName, __Table.Filter, __Table.Order);
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
            cmCurrencyManager = (CurrencyManager)this.BindingContext[dtDataTable];
            this.cmCurrencyManager.PositionChanged += new EventHandler(cmCurrencyManager_PositionChanged);
            dgvDataGridView.DataSource = dtDataTable;
        }

        private void dgvDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDataGridView.Columns[e.ColumnIndex].Tag = (((string)dgvDataGridView.Columns[e.ColumnIndex].Tag == "DESC") ? "ASC" : "DESC");
            __Table.Order = dtDataTable.Columns[e.ColumnIndex].ColumnName + " " + dgvDataGridView.Columns[e.ColumnIndex].Tag.ToString();
            SetDataSource();
        }

        private void SetMenuStrip()
        {
            pCCL.SetMenuStrip(tsmiEdition, __Table);
            pCCL.SetMenuStrip(tsmiQuit, __Table);
            pCCL.SetMenuStrip(tsmiEdition, __Table);
            pCCL.SetMenuStrip(tsmiQuit, __Table);
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            pCCL.SetTextBox(sender, Color.LightYellow);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                tbLastName.Focus();
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                ntbFK_WorkGroupCode.Focus();
        }

        private void ntbWorkGroupCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cbFK_WorkGroupCode.SelectedIndex == -1)
                    cbFK_WorkGroupCode.Focus();
                else
                    tbUserID.Focus();
            }
        }

        private void cboWorkGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                tbUserID.Focus();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (tbUserID.Text.Trim() != String.Empty)
                {
                    if (IsDuplicateUserID() == true)
                    {
                        CCL.pMB.Show(lblUserID.Text + " " + pBFL.GetResourceString("ecDuplicate"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Warning, MessageBoxButtons.OK);
                        tbUserID.SelectAll();
                        return;
                    }
                }
                tbUserPassword.Focus();
            }
        }

        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                tbFirstName.Focus();
        }

        private Boolean IsDuplicateUserID()
        {
            string[] strFieldName = { dtDataTable.Columns["UserID"].ColumnName };
            string[] strTextValue = { "N'" + tbUserID.Text.Trim() + "'" };
            string[] strFieldValue = null;
            if (__Table.TableStatus == TableStatus.tsEdit)
            {
                strFieldValue = new string[1];
                strFieldValue[0] = "N'" + dtDataTable.Rows[cmCurrencyManager.Position][strFieldName[0]].ToString().Trim() + "'";
            }
            return (pBFL.IsDuplicate( __Table.TableName, strFieldName, strFieldValue, strTextValue, __Table.TableStatus));
        }

        private Boolean IsValidData()
        {
            object obj = null;
            string strMessage = string.Empty;
            if (tbFirstName.Text.Trim() == String.Empty)
            {
                obj = tbFirstName;
                strMessage = lblFirstName.Text + " " + pBFL.GetResourceString("ecIncompelete");
            }
            else
                if (tbLastName.Text.Trim() == String.Empty)
                {
                    obj = tbLastName;
                    strMessage = lblLastName.Text + " " + pBFL.GetResourceString("ecIncompelete");
                }
                else
                    if (cbFK_WorkGroupCode.SelectedIndex == -1)
                    {
                        obj = ntbFK_WorkGroupCode;
                        strMessage = lblFK_WorkGroupCode.Text + " " + pBFL.GetResourceString("ecIncompelete");
                    }
                    else
                        if (tbUserID.Text.Trim() == String.Empty)
                        {
                            obj = tbUserID;
                            strMessage = lblUserID.Text + " " + pBFL.GetResourceString("ecIncompelete");
                        }
                        else
                            if (IsDuplicateUserID() == true)
                            {
                                obj = tbUserID;
                                strMessage = lblUserID.Text + " " + pBFL.GetResourceString("ecDuplicate");
                            }
                            else
                                if (tbUserPassword.Text.Trim() == String.Empty)
                                {
                                    obj = tbUserPassword;
                                    strMessage = lblUserPassword.Text + " " + pBFL.GetResourceString("ecIncompelete");
                                }
            if (obj != null)
            {
                CCL.pMB.Show(strMessage, pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Warning, MessageBoxButtons.OK);
                if (obj is TextBox)
                    (obj as TextBox).SelectAll();
                (obj as Control).Focus();
            }
            return (obj == null);
        }

        private void ntbWorkGroupCode_TextChanged(object sender, EventArgs e)
        {
            NumericTextBox ntbNumericTextBox = sender as NumericTextBox;
            ComboBox cbComboBox = gbDetails.Controls["cb" + ntbNumericTextBox.Name.Substring(3).Trim()] as ComboBox;
            if (ntbNumericTextBox.Text.Trim() == string.Empty)
                cbComboBox.SelectedIndex = -1;
            else
                cbComboBox.SelectedValue = ntbNumericTextBox.Text.Trim();
        }

        private void cboWorkGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbComboBox = sender as ComboBox;
            NumericTextBox ntbNumericTextBox = gbDetails.Controls["ntb" + cbComboBox.Name.Substring(2).Trim()] as NumericTextBox;
            ntbNumericTextBox.Text = cbComboBox.SelectedValue.ToString();
        }

        private void cboWorkGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbComboBox = sender as ComboBox;
            ttToolTip.SetToolTip(cbComboBox, cbComboBox.Text);
        }

        private void btnWorkGroup_Click(object sender, EventArgs e)
        {
            Button btnButton = sender as Button;
            pCCL.SetButton(btnButton, gbDetails, __Table);
        }

        private void tsbDBInsert_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = null;
            ToolStripMenuItem tsmi = null;
            if (sender is ToolStripButton)
            {
                tsb = sender as ToolStripButton;
                if (tsb.Name == "tsbDBInsert")
                {
                    __Table.TableStatus = TableStatus.tsInsert;
                    dgvDataGridView.Enabled = false;
                }
                else
                    __Table.TableStatus = TableStatus.tsEdit;
            }
            else
            {
                tsmi = sender as ToolStripMenuItem;
                if (tsmi.Name == "tsmiDBInsert")
                {
                    __Table.TableStatus = TableStatus.tsInsert;
                    dgvDataGridView.Enabled = false;
                }
                else
                    __Table.TableStatus = TableStatus.tsEdit;
            }
            cmCurrencyManager_PositionChanged(this, null);
            tbFirstName.Focus();
        }

        private void tsbDBDelete_Click(object sender, EventArgs e)
        {
            pCCL.DataRowDelete(dtDataTable, cmCurrencyManager, __Table);
            cmCurrencyManager_PositionChanged(this, null);
        }

        private void tsbDBPost_Click(object sender, EventArgs e)
        {
            int NewRowIndex = -1;
            try
            {
                if (IsValidData() == true)
                {
                    switch (__Table.TableStatus)
                    {
                        case TableStatus.tsInsert:
                            {
                                DataRow drDataRow = dtDataTable.NewRow();
                                //drDataRow["FK_UserID"] = pBFL.GetPrimaryKey( __Table.TableName);
                                drDataRow["FirstName"] = tbFirstName.Text.Trim();
                                drDataRow["LastName"] = tbLastName.Text.Trim();
                                drDataRow["FK_WorkGroupCode"] = ntbFK_WorkGroupCode.Text.Trim();
                                drDataRow["UserID"] = tbUserID.Text.Trim();
                                drDataRow["UserPassword"] = tbUserPassword.Text.Trim();
                                dtDataTable.Rows.Add(drDataRow);
                                NewRowIndex = dtDataTable.Rows.IndexOf(drDataRow);
                                break;
                            }
                        case TableStatus.tsEdit:
                            {
                                dtDataTable.Rows[cmCurrencyManager.Position]["FirstName"] = tbFirstName.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["LastName"] = tbLastName.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["FK_WorkGroupCode"] = ntbFK_WorkGroupCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["UserID"] = tbUserID.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["UserPassword"] = tbUserPassword.Text.Trim();
                                break;
                            }
                            ;
                    }
                    SqlException eSqlException = pBFL.SetDataTable(dtDataTable,  __Table.TableName);
                    if (eSqlException == null)
                    {
                        dtDataTable.AcceptChanges();
                        if (NewRowIndex >= 0)
                            cmCurrencyManager.Position = NewRowIndex;
                        if (__Table.TableStatus == TableStatus.tsInsert)
                        {
                            pBFL.Logging(User.UserCode, __Table.PK_TableCode, Macro.Action.aInsert, User.IP);
                            pCCL.SetGroupBox(gbDetails, true, true);
                            tbFirstName.Focus();
                        }
                        else
                            pBFL.Logging(User.UserCode, __Table.PK_TableCode, Macro.Action.aUpdate, User.IP);
                    }
                    else
                    {
                        dtDataTable.RejectChanges();
                        System.Windows.Forms.MessageBox.Show(eSqlException.Message);
                    }
                }
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
            }
        }

        private void tsbDBCancel_Click(object sender, EventArgs e)
        {
            __Table.IsCancelled = true;
            //switch (CCL.pMB.Show(pBFL.GetResourceString("strPostWarning"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel))
            //{
            //    case System.Windows.Forms.DialogResult.Yes:
            //        tsbDBPost_Click(tsbDBPost, null);
            //        break;
            //    case System.Windows.Forms.DialogResult.No:
            //        break;
            //    case System.Windows.Forms.DialogResult.Cancel:
            //        {
            //            __Table.IsCancelled = false;
            //            return;
            //        }
            //}
            if (__Table.IsCancelled == true)
            {
                __Table.TableStatus = TableStatus.tsNone;
                cmCurrencyManager_PositionChanged(this, null);
                dgvDataGridView.Enabled = true;
                dgvDataGridView.Focus();
                __Table.IsCancelled = false;
            }
        }

        private void tsbQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            cmCurrencyManager_PositionChanged(this, null);
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            pCCL.SetTextBox(sender, Color.White);
        }
    }
}
