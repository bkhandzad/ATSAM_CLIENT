using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

using Atsam;
using Macro;
using Atsam.Server;
using ClientCommonLayer;
namespace AtsamClient.Main
{
    public partial class frmProduct : Form
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

        public frmProduct()
        {
            InitializeComponent();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            __Table = (_Table)this.Tag;
            lblCaption.Text = __Table.Description;
            __Table.SetField();
            __Table._Field.SetDataField(2);
            pCCL.SetButton(gbDetails, ttToolTip);
            pCCL.SetButton(tsToolStrip,__Table);
            pCCL.SetDataPanelView(gbDetails, ttToolTip, __Table);
            gbDetails.Tag = __Table;
            pCCL.SetControlEvent(gbDetails);
            SetDataSource();
            pCCL.SetDataGridView(dgvDataGridView, __Table);
        }

        private void frmProduct_KeyPress(object sender, KeyPressEventArgs e)
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
                       // lblProductionDateValue.Text = tsbCalendar.Text;
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
                SqlException eSqlException = pBFL.GetDataTable(ref dtDataTable, __Table.Alias, __Table.Filter, __Table.Order);
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
            //pCCL.SetMenuStrip(tsmiQuit, __Table);
            pCCL.SetMenuStrip(tsmiEdition, __Table);
            pCCL.SetMenuStrip(tsmiQuit, __Table);
        }

        private Boolean IsDuplicateCode()
        {
            string[] strFieldName = { dtDataTable.Columns[0].ColumnName };
            string[] strTextValue = { ntbPK_ProductCode.Text.Trim() };
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
            string[] strTextValue = { "N'" + tbProduct.Text.Trim() + "'" };
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
            if (ntbPK_ProductCode.Text.Trim() == String.Empty)
            {
                obj = ntbPK_ProductCode;
                strMessage = lblPK_ProductCode.Text + " " + pBFL.GetResourceString("ecIncompelete");
            }
            else if (ntbPK_ProductCode.Text.Trim() == "0")
            {
                obj = ntbPK_ProductCode;
                strMessage = lblPK_ProductCode.Text + " " + pBFL.GetResourceString("ecInvalid");
            }
            else if (IsDuplicateCode())
            {
                obj = ntbPK_ProductCode;
                strMessage = lblPK_ProductCode.Text + " " + pBFL.GetResourceString("ecDuplicate");
            }
            else if (tbProduct.Text.Trim() == String.Empty)
            {
                obj = tbProduct;
                strMessage = lblProduct.Text + " " + pBFL.GetResourceString("ecIncompelete");
            }
            if ((ntbFK_FabricCode.Text == string.Empty) || (cbFK_FabricCode.SelectedIndex == -1))
            {
                obj = ntbFK_FabricCode;
                strMessage = lblFK_FabricCode.Text + " " + pBFL.GetResourceString("ecIncompelete");
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
            ntbPK_ProductCode.Focus();
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
                                drDataRow["PK_ProductCode"] = ntbPK_ProductCode.Text.Trim();
                                drDataRow["Product"] = tbProduct.Text.Trim();
                                drDataRow["FK_ProductTypeCode"] = ntbFK_ProductTypeCode.Text.Trim();
                                drDataRow["FK_FabricCode"] = ntbFK_FabricCode.Text.Trim();
                                drDataRow["ProductType"] = cbFK_ProductTypeCode.Text.Trim();
                                drDataRow["Fabric"] = cbFK_FabricCode.Text.Trim();
                                dtDataTable.Rows.Add(drDataRow);
                                NewRowIndex = dtDataTable.Rows.IndexOf(drDataRow);
                                break;
                            }
                        case TableStatus.tsEdit:
                            {
                                dtDataTable.Rows[cmCurrencyManager.Position]["PK_ProductCode"] = ntbPK_ProductCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["Product"] = tbProduct.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["FK_ProductTypeCode"] = ntbFK_ProductTypeCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["FK_FabricCode"] = ntbFK_FabricCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["ProductType"] = cbFK_ProductTypeCode.Text.Trim();
                                dtDataTable.Rows[cmCurrencyManager.Position]["Fabric"] = cbFK_FabricCode.Text.Trim();
                                break;
                            }
                    }
                    SqlException eSqlException = pBFL.SetDataTable(dtDataTable, __Table.TableName);
                    if (eSqlException == null)
                    {
                        dtDataTable.AcceptChanges();
                        if (NewRowIndex >= 0)
                        {
                            cmCurrencyManager.Position = NewRowIndex;
                        }
                        if (__Table.TableStatus == TableStatus.tsInsert)
                        {
                            pBFL.Logging(User.UserCode, __Table.PK_TableCode, Macro.Action.aInsert, User.IP);
                            pCCL.SetGroupBox(gbDetails, true, true);
                            pCCL.Control_KeyPress(gbDetails, 0);
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
            switch (CCL.pMB.Show(pBFL.GetResourceString("strPostWarning"), pBFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    tsbDBPost_Click(tsbDBPost, null);
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
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

        private void tsbExportToExcel_Click(object sender, EventArgs e)
        {
            //pCCL.ExportToExcel(this, dgvDataGridView, lblCaption.Text.Trim());
        }

        private void tsbPrintPreview_Click(object sender, EventArgs e)
        {
            //frmReport frm = new frmReport();
            //frm.Url = "/MAP_SNC_PTW/Rpt_Product";
            //frm.ShowDialog();
        }

        private void dgvDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            cmCurrencyManager_PositionChanged(this, null);
        }
    }
}
