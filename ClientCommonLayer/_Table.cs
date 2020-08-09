using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

using Atsam;
using Macro;

namespace ClientCommonLayer
{
    public class _Table : Table
    {
        public _Table(DataRow drDataRow, FormStatus fsFormStatus = FormStatus.fsMain) : base(drDataRow, fsFormStatus)
        {
            Permission = User._Permission.GetPermission(User.WorkGroupCode, PK_TableCode);
        }

        public override void SetField()
        {
            if (this._Field == null || this._Field.Active == false)
            {
                DataTable _DataTable = new DataTable();
                if (ServerSupplier.BFL.GetDataTable(ref _DataTable, "_Field", "pk_FKTableCode = " + FK_FieldsTableCode) == null)
                {
                    _Field = new Field(_DataTable);
                }
            }
        }

        public Form LinkPageForm()
        {
            try
            {
                Assembly aAssembly = Assembly.GetEntryAssembly();
                string strPath = aAssembly.GetName().ToString();
                string strForm = strPath.Substring(0, strPath.IndexOf(",")) + "." + LinkPage.Trim();
                Type tType = aAssembly.GetType(strForm);
                return ((Form)Activator.CreateInstance(tType));
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
                return (null);
            }
        }


        public void LinkPageForm(object tTag)
        {
            try
            {
                Assembly aAssembly = Assembly.GetEntryAssembly();
                string strPath = aAssembly.GetName().ToString();
                string strForm = strPath.Substring(0, strPath.IndexOf(",")) + "." + LinkPage.Trim();
                Type tType = aAssembly.GetType(strForm);
                Form frm = ((Form)Activator.CreateInstance(tType));
                frm.Tag = tTag;
                frm.ShowDialog();
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
            }
        }
    }
}
