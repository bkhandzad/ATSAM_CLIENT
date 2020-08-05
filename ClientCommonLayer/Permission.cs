using System;
using System.Data;
using System.Data.SqlClient;
using Atsam;

namespace ClientCommonLayer
{
    class Permission : APermission
    {
        private DataTable dtPermission = new DataTable();
        private SqlException eSqlException = null;

        public Permission()
        {
            try
            {
                ServerSupplier.BFL.GetDataTable(ref dtPermission, "_Permission");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public override Boolean[] GetPermission(int intWorkGroupCode, int intTableCode)
        {
            Boolean[] Permission = new Boolean[System.Enum.GetValues(typeof(Atsam.Action)).Length];
            switch (intWorkGroupCode)
            {
                case -1: break;
                case 0:
                    {
                        for (int Index = 0; (Index < Permission.Length); Index++)
                            Permission[Index] = true;
                    }
                    break;
                default:
                    {
                        string strSQL = "pk_FKWorkGroupCode = " + intWorkGroupCode.ToString() + " AND pk_FKTableCode = " + intTableCode.ToString();
                        DataRow[] drDataRow = dtPermission.Select(strSQL);
                        try
                        {
                            if (eSqlException != null)
                            {
                                //MessageBox.Show(eSqlException.Message);
                                return (null);
                            }

                        }
                        catch
                        {
                            // MessageBox.Show(eException.Message);
                            return (null);
                        }
                        for (int Index = 0; (Index < drDataRow.Length); Index++)
                            Permission[Convert.ToInt16(drDataRow[Index]["pk_FKActionCode"].ToString())] = true;
                    }
                    break;
            }
            return (Permission);
        }
    }
}
