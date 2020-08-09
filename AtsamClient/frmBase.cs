using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;

namespace AtsamClient
{
    public partial class frmBase : Form
    {
        private ABFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }
        private CCL pCCL = new CCL();
        private _Table __Table;

        private CurrencyManager cmCurrencyManager;
        private DataTable dtDataTable = new DataTable();
        private int intPageNumber;

        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            __Table = (_Table)this.Tag;
            lblCaption.Text = __Table.Description;
            tsbPermission.Visible = (__Table.TableName == "_WorkGroup") ? true : false;
            __Table.SetField();
            pCCL.SetButton(gbDetails, ttToolTip);
            pCCL.SetButton(this.tsToolStrip,__Table);
            pCCL.SetDataPanelView(gbDetails, ttToolTip, __Table);
            pCCL.SetControlEvent(gbDetails);
            SetDataSource();
            pCCL.SetDataGridView(dgvDataGridView, __Table);
        }

        private void frmBase_KeyPress(object sender, KeyPressEventArgs e)
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
                    case TableStatus.tsEmpty: pCCL.SetGroupBox(gbDetails, false, true); break;
                    case TableStatus.tsInsert: pCCL.SetGroupBox(gbDetails, true, true); break;
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

        private void dgvDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (__Table.FormStatus == FormStatus.fsBase)
            {
                if (__Table.TableStatus == TableStatus.tsBrowse)
                {
                    __Table.ReturnValue = dtDataTable.Rows[cmCurrencyManager.Position][0].ToString();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void dgvDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                dgvDataGridView_DoubleClick(this, null);
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

        private void ntbBaseCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (ntbBaseCode.Text.Trim() != String.Empty)
                {
                    if (IsDuplicateCode() == true)
                    {
                        CCL.pMB.Show(lblBaseCode.Text + " " + pBFL.GetResourceString("ecDuplicate"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Warning, MessageBoxButtons.OK);
                        ntbBaseCode.SelectAll();
                        return;
                    }
                }
                else
                {
                    DataTable dtTemp = new DataTable();
                    string str = string.Format("(SELECT MAX({0}) + 1 AS MaxRecord FROM {1}) AS TempTable", dtDataTable.Columns[0].ColumnName.ToString(), __Table.TableName);
                    if ((pBFL.GetDataTable(ref dtTemp, str) == null) && (dtTemp.Rows.Count > 0))
                    {
                        ntbBaseCode.Text = dtTemp.Rows[0]["MaxRecord"].ToString();
                    }
                }
            }
        }

        private void txtBaseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtBaseName.Text.Trim() != String.Empty)
                {
                    if (IsDuplicateName() == true)
                    {
                        CCL.pMB.Show(lblBaseName.Text + " " + pBFL.GetResourceString("ecDuplicate"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Warning, MessageBoxButtons.OK);
                        txtBaseName.SelectAll();
                        return;
                    }
                }
            }
        }

        private Boolean IsDuplicateCode()
        {
            string[] strFieldName = { dtDataTable.Columns[0].ColumnName };
            string[] strTextValue = { ntbBaseCode.Text.Trim() };
            string[] strFieldValue = null;
            if (__Table.TableStatus == TableStatus.tsEdit)
            {
                strFieldValue = new string[1];
                strFieldValue[0] = dtDataTable.Rows[cmCurrencyManager.Position][strFieldName[0]].ToString();
            }
            return (pBFL.IsDuplicate(__Table.TableName, strFieldName, strFieldValue, strTextValue, __Table.TableStatus));
        }

        private Boolean IsDuplicateName()
        {
            string[] strFieldName = { dtDataTable.Columns[1].ColumnName };
            string[] strTextValue = { "N'" + txtBaseName.Text.Trim() + "'" };
            string[] strFieldValue = null;
            if (__Table.TableStatus == TableStatus.tsEdit)
            {
                strFieldValue = new string[1];
                strFieldValue[0] = "N'" + dtDataTable.Rows[cmCurrencyManager.Position][strFieldName[0]].ToString().Trim() + "'";
            }
            return (pBFL.IsDuplicate(__Table.TableName, strFieldName, strFieldValue, strTextValue, __Table.TableStatus));
        }

        private Boolean IsValidData()
        {
            object obj = null;
            string strMessage = string.Empty;
            if (ntbBaseCode.Text.Trim() == String.Empty)
            {
                obj = ntbBaseCode;
                strMessage = lblBaseCode.Text + " " + pBFL.GetResourceString("ecIncompelete");
            }
            else if (ntbBaseCode.Text.Trim() == "0")
            {
                obj = ntbBaseCode;
                strMessage = lblBaseCode.Text + " " + pBFL.GetResourceString("ecInvalid");
            }
            else if (IsDuplicateCode())
            {
                obj = ntbBaseCode;
                strMessage = lblBaseCode.Text + " " + pBFL.GetResourceString("ecDuplicate");
            }
            else if (txtBaseName.Text.Trim() == String.Empty)
            {
                obj = txtBaseName;
                strMessage = lblBaseName.Text + " " + pBFL.GetResourceString("ecIncompelete");
            }
            else if (IsDuplicateName())
            {
                obj = txtBaseName;
                strMessage = lblBaseName.Text + " " + pBFL.GetResourceString("ecDuplicate");
            }
            if (obj != null)
            {
                CCL.pMB.Show(strMessage, pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Warning, MessageBoxButtons.OK);
                (obj as Control).Focus();
            }
            return (obj == null);
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
            ntbBaseCode.Focus();
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
                                drDataRow[0] = ntbBaseCode.Text.Trim();
                                drDataRow[1] = txtBaseName.Text.Trim();
                                if ((dtDataTable.Columns.Count == 3) && (dtDataTable.Columns[2].ColumnName == "FK_WorkStationCode"))
                                    drDataRow[2] = User.WorkStationCode.ToString();
                                //switch (__Table.Alias)
                                //{
                                //    case "_WorkGroup":
                                //    case "b_BreakType":
                                //        {
                                //            drDataRow[2] = User.WorkStationCode.ToString();
                                //            break;
                                //        }

                                //}
                                dtDataTable.Rows.Add(drDataRow);
                                NewRowIndex = dtDataTable.Rows.IndexOf(drDataRow);
                                break;
                            }
                        case TableStatus.tsEdit:
                            {
                                dtDataTable.Rows[cmCurrencyManager.Position][0] = ntbBaseCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position][1] = txtBaseName.Text.Trim();
                                break;
                            };
                    }
                    SqlException eSqlException = pBFL.SetDataTable(dtDataTable, __Table.TableName);
                    if (eSqlException == null)
                    {
                        dtDataTable.AcceptChanges();
                        if (NewRowIndex >= 0) cmCurrencyManager.Position = NewRowIndex;
                        if (__Table.TableStatus == TableStatus.tsInsert)
                        {
                            pBFL.Logging(User.UserCode, __Table.PK_TableCode, Macro.Action.aInsert, User.IP);
                            pCCL.SetGroupBox(gbDetails, true, true);
                            ntbBaseCode.Focus();
                        }
                        else
                            pBFL.Logging(User.UserCode, __Table.PK_TableCode, Macro.Action.aUpdate, User.IP);
                    }
                    else
                    {
                        dtDataTable.RejectChanges();
                        CCL.pMB.Show(pBFL.GetErrorMessage(eSqlException, __Table.TableStatus), pBFL.GetResourceString("strErrorTitle"), MessageBoxIcon.Error, MessageBoxButtons.OK);
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
            switch (CCL.pMB.Show(pBFL.GetResourceString("strPostWarning"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel))
            {
                case System.Windows.Forms.DialogResult.Yes: tsbDBPost_Click(tsbDBPost, null); break;
                case System.Windows.Forms.DialogResult.No: break;
                case System.Windows.Forms.DialogResult.Cancel:
                    {
                        __Table.IsCancelled = false;
                        return;
                    }
            }
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

        private void tsbPermission_Click(object sender, EventArgs e)
        {
            Security.frmPermission frm = new Security.frmPermission();
            frm.intWorkGroupCode = Convert.ToInt16(dtDataTable.Rows[cmCurrencyManager.Position]["PK_WorkGroupCode"]);
            frm.Text = frm.Text + " " + dtDataTable.Rows[cmCurrencyManager.Position]["WorkGroup"].ToString();
            frm.ShowDialog();
            Application.DoEvents();
        }

        private void tsmiToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Application.DoEvents();
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
        }

        private void pdprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            e.PageSettings.Margins.Left = 10;
            e.PageSettings.Margins.Right = 10;
            e.PageSettings.Margins.Bottom = 10;
            e.PageSettings.Margins.Top = 10;
            Font xFont = new Font("Mitra", 14, (FontStyle.Bold | FontStyle.Italic));
            string xText = this.Text.Replace("ثبت اطلاعات ", string.Empty);
            SizeF xSizeF = e.Graphics.MeasureString(xText, xFont);
            Pen xPen = new Pen(Brushes.Black, 0.2F);
            e.Graphics.DrawLine(xPen, 10, 15, 200, 15);
            e.Graphics.DrawLine(xPen, 10, 25, 200, 25);
            e.Graphics.DrawString(xText, xFont, Brushes.Black, (float)(200 - xSizeF.Width), (float)(15 + (10 - xSizeF.Height) / 2));
            xText = pBFL.DLToDF(intPageNumber.ToString().PadRight(4, ' ') + "صفحه");
            xSizeF = e.Graphics.MeasureString(xText, xFont);
            e.Graphics.DrawString(xText, xFont, Brushes.Black, (float)10, (float)(15 + (10 - xSizeF.Height) / 2));

            e.Graphics.DrawRectangle(xPen, 20, 30, 170, 250);
            e.Graphics.DrawLine(xPen, 20, 40, 190, 40);
            e.Graphics.DrawLine(xPen, 150, 30, 150, 280);
            xFont = new Font("Mitra", 14, FontStyle.Bold);

            xText = dgvDataGridView.Columns[0].HeaderText;
            xSizeF = e.Graphics.MeasureString(xText, xFont);
            e.Graphics.DrawString(xText, xFont, Brushes.Maroon, (float)(150 + (40 - xSizeF.Width) / 2), (float)(30 + (10 - xSizeF.Height) / 2));

            xText = dgvDataGridView.Columns[1].HeaderText;
            xSizeF = e.Graphics.MeasureString(xText, xFont);
            e.Graphics.DrawString(xText, xFont, Brushes.Maroon, (float)(20 + (130 - xSizeF.Width) / 2), (float)(30 + (10 - xSizeF.Height) / 2));

            xFont = new Font("Mitra", 10, FontStyle.Bold);
            xPen = new Pen(Brushes.Black, 0.1F);
            int j = ((intPageNumber - 1) * 48);
            for (int i = 0; i < 48; i++)
            {
                if ((j + i) < dtDataTable.Rows.Count)
                {
                    xText = pBFL.DLToDF(dtDataTable.Rows[j + i][0].ToString());
                    xSizeF = e.Graphics.MeasureString(xText, xFont);
                    e.Graphics.DrawString(xText, xFont, Brushes.Black, (float)(150 + 1), (float)(40 + i * 5 + (5 - xSizeF.Height) / 2));
                    xText = pBFL.DLToDF(dtDataTable.Rows[j + i][1].ToString());
                    xSizeF = e.Graphics.MeasureString(xText, xFont);
                    e.Graphics.DrawString(xText, xFont, Brushes.Black, (float)(150 - 1 - xSizeF.Width), (float)(40 + i * 5 + (5 - xSizeF.Height) / 2));
                }
                e.Graphics.DrawLine(xPen, 20, 40 + i * 5, 190, 40 + i * 5);
            }
            if ((intPageNumber * 48) < dtDataTable.Rows.Count)
            {
                e.HasMorePages = true;
                intPageNumber++;
            }
            else
                e.HasMorePages = false;
        }

        private void tsbPrintPreview_Click(object sender, EventArgs e)
        {
            ppdprintPreviewDialog.ShowDialog();
        }

        private void tsbDataPrint_Click(object sender, EventArgs e)
        {
            pdprintDocument.Print();
        }

        private void pdprintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            intPageNumber = 1;
        }

        private void tsbExportToExcel_Click(object sender, EventArgs e)
        {
            //pCCL.ExportToExcel(this, dgvDataGridView, lblCaption.Text.Trim());
        }

        private void dgvDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            __Table.TableStatus = TableStatus.tsNone;
            cmCurrencyManager_PositionChanged(this, null);
        }
    }
}
