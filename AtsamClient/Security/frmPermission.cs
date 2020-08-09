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
    public partial class frmPermission : Form
    {
        private class TablePermission
        {
            public TableType ttTableType;
            public int intTableCode;
            public Boolean blnInsert;
            public Boolean blnEdit;
            public Boolean blnDelete;
            public Boolean blnFind;
            public Boolean blnFilter;
            public Boolean blnPrintPreview;
            public Boolean blnPrint;
            public Boolean blnSelect;
        }

        private CCL pCCL = new CCL();
        private ABFL pBFL
        {
            get
            {
                return ServerSupplier.BFL;
            }
        }
        private DataTable dtPermission = new DataTable();
        public int intWorkGroupCode;
        public Boolean blnIsUpdate = false;

        public frmPermission()
        {
            InitializeComponent();
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            try
            {
                SqlException eSqlException = pBFL.GetDataTable(ref dtPermission, "_Permission", "pk_FKWorkGroupCode = " + intWorkGroupCode.ToString());
                if (eSqlException != null)
                {
                    System.Windows.Forms.MessageBox.Show(eSqlException.Message);
                    this.Close();
                }
                SetTreeView(tvTable, User.WorkStationCode);
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
                this.Close();
            }
            for (int intIndex = 0; (intIndex < dtPermission.Rows.Count); intIndex++)
                dtPermission.Rows[intIndex].Delete();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (blnIsUpdate == true)
            {
                SetTablePermission(tvTable.Nodes);
                try
                {
                    SqlException eSqlException = pBFL.SetDataTable(dtPermission, "_Permission");
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
                pBFL.Logging(User.UserCode, (int)SystemTable.stPermission, Macro.Action.aCascadeUpdate, User.IP);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tvTable_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TablePermission tp = (TablePermission)e.Node.Tag;
            switch (e.Action)
            {
                case TreeViewAction.ByKeyboard:
                case TreeViewAction.ByMouse:
                    {
                        tvTable.SelectedNode = e.Node;
                        switch (tp.ttTableType)
                        {
                            case TableType.ttBase:
                            case TableType.ttExtraBase:
                            case TableType.ttStaticBase:
                            case TableType.ttMain:
                            case TableType.ttExtraMain:
                            case TableType.ttRelation:
                            case TableType.ttSubTable:
                            case TableType.ttSystem:
                            case TableType.ttViewMain:
                            case TableType.ttViewBase:
                                {
                                    chkDBInsert.Checked = tp.blnInsert = e.Node.Checked;
                                    chkDBEdit.Checked = tp.blnEdit = e.Node.Checked;
                                    chkDBDelete.Checked = tp.blnDelete = e.Node.Checked;
                                    chkDBFind.Checked = tp.blnFind = e.Node.Checked;
                                    chkDBFindNext.Checked = e.Node.Checked;
                                    chkDBFilter.Checked = tp.blnFilter = e.Node.Checked;
                                    chkPrintPreview.Checked = tp.blnPrintPreview = e.Node.Checked;
                                    chkDataPrint.Checked = tp.blnPrint = e.Node.Checked;
                                    break;
                                }
                        }
                        tp.blnSelect = e.Node.Checked;
                        e.Node.Tag = tp;
                        blnIsUpdate = true;
                    }
                    break;
            }
        }

        private TablePermission SetTreeTablePermission(int intTableCode)
        {
            DataRow[] drDataRow = dtPermission.Select("pk_FKTableCode = " + intTableCode.ToString());
            TablePermission tp = new TablePermission();
            tp.intTableCode = intTableCode;
            tp.blnInsert = false;
            tp.blnEdit = false;
            tp.blnDelete = false;
            tp.blnFind = false;
            tp.blnFilter = false;
            tp.blnPrintPreview = false;
            tp.blnPrint = false;
            tp.blnSelect = false;
            for (int RowIndex = 0; (RowIndex < drDataRow.Length); RowIndex++)
            {
                switch ((Macro.Action)Convert.ToInt16(drDataRow[RowIndex]["pk_FKActionCode"].ToString()))
                {
                    case Macro.Action.aInsert:
                        tp.blnInsert = true;
                        break;
                    case Macro.Action.aUpdate:
                        tp.blnEdit = true;
                        break;
                    case Macro.Action.aDelete:
                        tp.blnDelete = true;
                        break;
                    case Macro.Action.aFind:
                        tp.blnFind = true;
                        break;
                    case Macro.Action.aFilter:
                        tp.blnFilter = true;
                        break;
                    case Macro.Action.aPrintPreview:
                        tp.blnPrintPreview = true;
                        break;
                    case Macro.Action.aPrint:
                        tp.blnPrint = true;
                        break;
                    case Macro.Action.aSelect:
                        tp.blnSelect = true;
                        break;
                }
            }
            return (tp);
        }

        private void tvTable_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TablePermission tp = (TablePermission)e.Node.Tag;
            switch (tp.ttTableType)
            {
                case TableType.ttBase:
                case TableType.ttExtraBase:
                case TableType.ttStaticBase:
                case TableType.ttMain:
                case TableType.ttExtraMain:
                case TableType.ttRelation:
                case TableType.ttSubTable:
                case TableType.ttSystem:
                case TableType.ttViewMain:
                case TableType.ttViewBase:
                    {
                        chkDBInsert.Checked = tp.blnInsert;
                        chkDBInsert.Enabled = true;
                        chkDBEdit.Checked = tp.blnEdit;
                        chkDBEdit.Enabled = true;
                        chkDBDelete.Checked = tp.blnDelete;
                        chkDBDelete.Enabled = true;
                        chkDBPost.Checked = true;
                        chkDBPost.Enabled = false;
                        chkDBCancel.Checked = true;
                        chkDBCancel.Enabled = false;
                        chkDBFind.Checked = tp.blnFind;
                        chkDBFind.Enabled = true;
                        chkDBFindNext.Checked = chkDBFind.Checked;
                        chkDBFindNext.Enabled = false;
                        chkDBFilter.Checked = tp.blnFilter;
                        chkDBFilter.Enabled = true;
                        chkPrintPreview.Checked = tp.blnPrintPreview;
                        chkPrintPreview.Enabled = true;
                        chkDataPrint.Checked = tp.blnPrint;
                        chkDataPrint.Enabled = true;
                        chkQuit.Checked = true;
                        chkQuit.Enabled = false;
                        break;
                    }
                default:
                    {
                        chkDBInsert.Checked = chkDBInsert.Enabled = false;
                        chkDBEdit.Checked = chkDBEdit.Enabled = false;
                        chkDBDelete.Checked = chkDBDelete.Enabled = false;
                        chkDBPost.Checked = chkDBPost.Enabled = false;
                        chkDBCancel.Checked = chkDBCancel.Enabled = false;
                        chkDBFind.Checked = chkDBFind.Enabled = false;
                        chkDBFindNext.Checked = chkDBFindNext.Enabled = false;
                        chkDBFilter.Checked = chkDBFilter.Enabled = false;
                        chkPrintPreview.Checked = chkPrintPreview.Enabled = false;
                        chkDataPrint.Checked = chkDataPrint.Enabled = false;
                        chkQuit.Checked = chkQuit.Enabled = false;
                        break;
                    }
            }
        }

        private void SetTablePermission(TreeNodeCollection tnTreeNode)
        {
            TablePermission tp;
            DataRow drPermission;
            foreach (TreeNode tn in tnTreeNode)
            {
                tp = (TablePermission)tn.Tag;
                if (tn.Nodes.Count > 0)
                    SetTablePermission(tn.Nodes);
                if (tp.blnSelect == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aSelect;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnInsert == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aInsert;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnEdit == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aUpdate;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnDelete == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aDelete;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnFind == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aFind;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnFilter == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aFilter;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnPrintPreview == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aPrintPreview;
                    dtPermission.Rows.Add(drPermission);
                }
                if (tp.blnPrint == true)
                {
                    drPermission = dtPermission.NewRow();
                    drPermission["pk_FKTableCode"] = tp.intTableCode;
                    drPermission["pk_FKWorkGroupCode"] = intWorkGroupCode;
                    drPermission["pk_FKActionCode"] = Macro.Action.aPrint;
                    dtPermission.Rows.Add(drPermission);
                }
            }
        }

        private void SetTreeView(TreeView tvTreeView, int intTableCode)
        {
            DataTable dtDataTable = new DataTable();
            try
            {
                SqlException eSqlException = pBFL.GetDataTable(ref dtDataTable, "_Table");
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
            CreateTreeView(tvTreeView, null, dtDataTable, intTableCode);
        }

        private void CreateTreeView(TreeView tvTreeView, TreeNode tvNode, DataTable dtDataTable, int intTableCode)
        {
            TablePermission tpTablePermission;
            DataRow[] drDataRow = dtDataTable.Select("Visible = 1 AND PK_TableCode <> FK_ParentTableCode AND FK_ParentTableCode = " + intTableCode.ToString() + " AND FK_TableTypeCode <> " + Convert.ToInt16(TableType.ttSeperator).ToString(), "Rank");
            TreeNode tvChildNode = null;
            int RootIndex = 0;
            while (RootIndex < drDataRow.Length)
            {
                if (tvNode == null)
                    tvChildNode = tvTreeView.Nodes.Add(drDataRow[RootIndex]["TableName"].ToString(), drDataRow[RootIndex]["Description"].ToString());
                else
                    tvChildNode = tvNode.Nodes.Add(drDataRow[RootIndex]["TableName"].ToString(), drDataRow[RootIndex]["Description"].ToString());
                tpTablePermission = SetTreeTablePermission(Convert.ToInt16(drDataRow[RootIndex]["PK_TableCode"].ToString()));
                tpTablePermission.ttTableType = (TableType)Convert.ToInt16(drDataRow[RootIndex]["FK_TableTypeCode"].ToString());
                switch (tpTablePermission.ttTableType)
                {
                    case TableType.ttDatabaseServer:
                        tvChildNode.ImageIndex = 2;
                        tvChildNode.SelectedImageIndex = 2;
                        break;
                    case TableType.ttWindowsProject:
                        tvChildNode.ImageIndex = 3;
                        tvChildNode.SelectedImageIndex = 3;
                        break;
                    case TableType.ttWebProject:
                        tvChildNode.ImageIndex = 4;
                        tvChildNode.SelectedImageIndex = 4;
                        break;
                    case TableType.ttObject:
                        tvChildNode.ImageIndex = 5;
                        tvChildNode.SelectedImageIndex = 5;
                        break;
                    case TableType.ttReport:
                        tvChildNode.ImageIndex = 18;
                        tvChildNode.SelectedImageIndex = 18;
                        break;
                    default:
                        tvChildNode.ImageIndex = 6;
                        tvChildNode.SelectedImageIndex = 6;
                        break;
                }
                tvChildNode.Checked = tpTablePermission.blnSelect;
                tvChildNode.Tag = tpTablePermission;
                CreateTreeView(tvTreeView, tvChildNode, dtDataTable, Convert.ToInt16(drDataRow[RootIndex]["PK_TableCode"].ToString()));
                RootIndex++;
            }
            return;
        }

        private void chkDBInsert_Click(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            TablePermission tp = (TablePermission)tvTable.SelectedNode.Tag;
            switch (chk.Name)
            {
                case "chkDBInsert":
                    tp.blnInsert = chk.Checked;
                    break;
                case "chkDBEdit":
                    tp.blnEdit = chk.Checked;
                    break;
                case "chkDBDelete":
                    tp.blnDelete = chk.Checked;
                    break;
                case "chkDBFind":
                    tp.blnFind = chkDBFindNext.Checked = chk.Checked;
                    break;
                case "chkDBFilter":
                    tp.blnFilter = chk.Checked;
                    break;
                case "chkPrintPreview":
                    tp.blnPrintPreview = chk.Checked;
                    break;
                case "chkDataPrint":
                    tp.blnPrint = chk.Checked;
                    break;
            }
            tvTable.SelectedNode.Tag = tp;
            blnIsUpdate = true;
        }
    }
}
