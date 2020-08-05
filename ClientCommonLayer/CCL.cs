using Atsam;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Data.SqlClient;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace ClientCommonLayer
{
    public class CCL
    {
        public const int MAX_LENGTH = 2147483647;

        public static MessageBox.MessageBox pMB = new MessageBox.MessageBox();

        public string GetResourceString(string strString)
        {
            ResourceManager rmResourceManager = new ResourceManager("ClientCommonLayer.ClientMessages", Assembly.GetExecutingAssembly(), null);
            return (rmResourceManager.GetString(strString));
        }

        public Bitmap GetResourceImage(string strImageName)
        {
            try
            {
                string strProjectName = GetType().Assembly.ManifestModule.ToString();
                strProjectName = strProjectName.Substring(0, strProjectName.Length - 4);
                Bitmap bBitmap = new Bitmap(GetType().Assembly.GetManifestResourceStream(strProjectName + ".Resources." + strImageName));
                return (bBitmap);
            }
            catch
            {
                return (null);
            }
        }

        public FontFamily GetResourceFont(string strFontName)
        {
            try
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
            catch
            {
                return (new FontFamily("Tahoma"));
            }
        }

        //public string GetKeyValue(string strSection, string strKey, string strFileName)
        //{
        //    IniFile ifIniFile = new IniFile(strFileName);
        //    return (ifIniFile.GetKeyValue(strSection, strKey));
        //}

        //public void SetKeyValue(string strSection, string strKey, string strValue, string strFileName)
        //{
        //    IniFile ifIniFile = new IniFile(strFileName);
        //    ifIniFile.SetKeyValue(strSection, strKey, strValue);
        //}

        //Open file in to a filestream and read data in a byte array.
        public byte[] ReadImageFile(string strPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(strPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(strPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        public static int GetSolarDayOfYear()
        {
            DateTime dt = DateTime.Today;
            return (GetSolarDayOfYear(dt));
        }

        public static int GetSolarDayOfYear(DateTime dtDateTime)
        {
            System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
            return (ps.GetDayOfYear(dtDateTime));
        }

        public void SetLanguage(InputLanguageList illInputLanguageList)
        {
            string strInputLanguage = "ec-US";
            switch (illInputLanguageList)
            {
                case InputLanguageList.illEnglish: strInputLanguage = "ec-US"; break;
                case InputLanguageList.illFarsi: strInputLanguage = "fa-IR"; break;
            }
            foreach (InputLanguage IL in InputLanguage.InstalledInputLanguages)
                if (IL.Culture.Name.Equals(strInputLanguage))
                    InputLanguage.CurrentInputLanguage = IL;
        }

        public void SetToolStrip(ToolStrip tsToolStrip, _Table __Table)
        {
            switch (__Table.TableStatus)
            {
                case TableStatus.tsInsert:
                case TableStatus.tsEdit:
                    {
                        foreach (ToolStripItem tsbToolStripButton in tsToolStrip.Items)
                        {
                            if (tsbToolStripButton is ToolStripButton)
                                switch (tsbToolStripButton.Name)
                                {
                                    case "tsbCalendar":
                                    case "tsbQuit":
                                    case "tsbBarcodePrint":
                                    case "tsbDBPost":
                                    case "tsbDBCancel": tsbToolStripButton.Enabled = true; break;
                                    default: tsbToolStripButton.Enabled = false; break;
                                }
                            else if (tsbToolStripButton is ToolStripDropDownButton) tsbToolStripButton.Enabled = false;
                        }
                        break;
                    }
                case TableStatus.tsBrowse:
                    {
                        foreach (ToolStripItem tsbToolStripButton in tsToolStrip.Items)
                        {
                            if (tsbToolStripButton is ToolStripButton)
                                switch (tsbToolStripButton.Name)
                                {
                                    case "tsbDBInsert": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aInsert); break;
                                    case "tsbDBEdit": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aUpdate); break;
                                    case "tsbDBDelete": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aDelete); break;
                                    case "tsbDBPost": tsbToolStripButton.Enabled = false; break;
                                    case "tsbDBCancel": tsbToolStripButton.Enabled = false; break;
                                    case "tsbDBFind": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aFind); break;
                                    case "tsbDBFindNext": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aFind); break;
                                    case "tsbDBFilter": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aFilter); break;
                                    case "tsbPrintPreview": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aPrintPreview); break;
                                    case "tsbDataPrint": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aPrint); break;
                                    case "tsbPDA": tsbToolStripButton.Enabled = true; break;
                                    default:
                                        {
                                            if (tsbToolStripButton.Tag == null)
                                                tsbToolStripButton.Enabled = true;
                                            else
                                                tsbToolStripButton.Enabled = ((_Table)tsbToolStripButton.Tag).getPermission(Atsam.Action.aSelect);
                                            break;
                                        }
                                }
                            else if (tsbToolStripButton is ToolStripDropDownButton)
                            {
                                tsbToolStripButton.Enabled = true;
                                foreach (ToolStripItem tsiToolStripItem in (tsbToolStripButton as ToolStripDropDownButton).DropDownItems)
                                    tsiToolStripItem.Enabled = ((_Table)tsiToolStripItem.Tag).getPermission(Atsam.Action.aSelect);
                            }
                        }
                        break;
                    }
                case TableStatus.tsEmpty:
                    {
                        foreach (ToolStripItem tsbToolStripButton in tsToolStrip.Items)
                        {
                            if ((tsbToolStripButton is ToolStripButton) || (tsbToolStripButton is ToolStripDropDownButton))
                                switch (tsbToolStripButton.Name)
                                {
                                    case "tsbPDA": tsbToolStripButton.Enabled = true; break;
                                    case "tsbDBInsert": tsbToolStripButton.Enabled = __Table.getPermission(Atsam.Action.aInsert); break;
                                    case "tsbDBFilter":
                                    case "tsbDBFind":
                                    case "tsbCalendar":
                                    case "tsbQuit": tsbToolStripButton.Enabled = true; break;
                                    default: tsbToolStripButton.Enabled = false; break;
                                }
                        }
                        break;
                    }
            }
        }

        public void SetField(_Table __Table, ref DataRow drDataRow)
        {
            __Table.SetField();
            for (int index = 0; index < __Table._Field.FieldTable.Rows.Count; index++)
            {
                if (__Table._Field.FieldTable.Rows[index]["DefaultValue"].ToString() != string.Empty)
                    drDataRow[__Table._Field.FieldTable.Rows[index]["FieldName"].ToString()] = __Table._Field.FieldTable.Rows[index]["DefaultValue"].ToString();
            }
        }



        public void SetMenuStrip(ToolStripMenuItem tsmiToolStripMenuItem, _Table __Table)
        {
            switch (__Table.TableStatus)
            {
                case TableStatus.tsInsert:
                case TableStatus.tsEdit:
                    {
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"].Enabled = true;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"].Enabled = true;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiClose"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiClose"].Enabled = false;
                        break;
                    }
                case TableStatus.tsBrowse:
                    {
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"].Enabled = __Table.getPermission(Atsam.Action.aInsert);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"].Enabled = __Table.getPermission(Atsam.Action.aUpdate);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"].Enabled = __Table.getPermission(Atsam.Action.aDelete);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"].Enabled = __Table.getPermission(Atsam.Action.aFind);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"].Enabled = __Table.getPermission(Atsam.Action.aFind);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"].Enabled = __Table.getPermission(Atsam.Action.aFilter);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"].Enabled = __Table.getPermission(Atsam.Action.aPrintPreview);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"].Enabled = __Table.getPermission(Atsam.Action.aPrint);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiClose"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiClose"].Enabled = true;
                        break;
                    }
                case TableStatus.tsEmpty:
                    {
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBInsert"].Enabled = __Table.getPermission(Atsam.Action.aInsert);
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBEdit"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBDelete"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBPost"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBCancel"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFind"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFindNext"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDBFilter"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiPrintPreview"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiDataPrint"].Enabled = false;
                        if (tsmiToolStripMenuItem.DropDownItems["tsmiClose"] != null) tsmiToolStripMenuItem.DropDownItems["tsmiClose"].Enabled = true;
                        break;
                    }
            }
            Boolean tsmiEnabledStatus = false;
            for (int intIndex = 0; (intIndex < tsmiToolStripMenuItem.DropDownItems.Count); intIndex++)
                tsmiEnabledStatus = (tsmiEnabledStatus || (tsmiToolStripMenuItem.DropDownItems[intIndex].Enabled && (tsmiToolStripMenuItem.DropDownItems[intIndex] is ToolStripMenuItem)));
            tsmiToolStripMenuItem.Enabled = tsmiEnabledStatus;
        }

        public void SetStatusStrip(StatusStrip ssStatusStrip, TableStatus tsTableStatus, CurrencyManager cmCurrencyManager)
        {
            int RN = cmCurrencyManager.Position + 1;
            int RC = cmCurrencyManager.Count;
            if (ssStatusStrip.Items["tsslUserName"] != null)
                ssStatusStrip.Items["tsslUserName"].Text = User.UserName;
            ssStatusStrip.Items["tsslRecordNumber"].Text = RN.ToString() + ":" + RC.ToString();
            switch (tsTableStatus)
            {
                case TableStatus.tsInsert: ssStatusStrip.Items["tsslTableStatus"].Text = ServerSupplier.BFL.GetResourceString("tsInsert"); break;
                case TableStatus.tsEdit: ssStatusStrip.Items["tsslTableStatus"].Text = ServerSupplier.BFL.GetResourceString("tsEdit"); break;
                case TableStatus.tsBrowse:
                case TableStatus.tsEmpty: ssStatusStrip.Items["tsslTableStatus"].Text = ServerSupplier.BFL.GetResourceString("tsBrowse"); break;
            }
        }

        public void SetGroupBox(GroupBox gbGroupBox, Boolean EnabledStatus, Boolean EmptyStatus)
        {
            foreach (Control cControl in gbGroupBox.Controls)
            {
                if (cControl is TextBox)
                {
                    if ((cControl.Tag == null) || (cControl.Tag.ToString() == string.Empty))
                        cControl.Enabled = EnabledStatus;
                    else
                        switch (Convert.ToInt16(cControl.Tag.ToString()))
                        {
                            case 1:
                            case 100: cControl.Enabled = false; break;

                        }
                    if ((EmptyStatus == true) && ((cControl.Tag == null) || (cControl.Tag.ToString() == string.Empty) || (cControl.Tag.ToString() == "100")))
                        cControl.Text = String.Empty;
                }
                else if (cControl is ComboBox)
                {
                    if (cControl.Tag == null)
                        cControl.Enabled = EnabledStatus;
                    else
                        switch (Convert.ToInt16(cControl.Tag.ToString()))
                        {
                            case 1:
                            case 100: cControl.Enabled = false; break;
                        }
                    if ((EmptyStatus == true) && ((cControl.Tag == null) || (cControl.Tag.ToString() == string.Empty) || (cControl.Tag.ToString() == "100")))
                    {
                        (cControl as ComboBox).SelectedIndex = -1;
                        (cControl as ComboBox).Text = string.Empty;
                    }

                }
                else if (cControl is Button)
                {
                    if (cControl.Tag == null)
                        cControl.Enabled = EnabledStatus;
                    else
                    {
                        _Table __Table = (_Table)cControl.Tag;
                        cControl.Enabled = __Table.getPermission(Atsam.Action.aSelect) && EnabledStatus;
                    }
                }
                else if (cControl is CheckBox)
                {
                    cControl.Enabled = EnabledStatus;
                    if ((EmptyStatus == true) && (cControl.Tag == null)) (cControl as CheckBox).Checked = false;
                }
                else if (cControl is Label)
                {
                    if ((EmptyStatus == true) && (cControl.Tag != null))
                        if (cControl.Tag.ToString() != string.Empty)
                        {
                            switch (Convert.ToInt16(cControl.Tag.ToString()))
                            {
                                case 0: cControl.Text = string.Empty; break;
                                case 1: cControl.BackColor = Color.LightGray; break;
                            }
                        }
                }
                else if (cControl is PictureBox)
                {
                    if ((EmptyStatus == true) && (cControl.Tag == null)) (cControl as PictureBox).Image = null;
                }
                else if (cControl is DateTimePicker)// || cControl is FarsiCalendarComponent.FarsiDatePicker)
                {
                    cControl.Enabled = EnabledStatus;
                    //if (EmptyStatus == true)                    
                    //  cControl.Text="";
                }
                else if (cControl is Panel)
                {
                    (cControl as Panel).Enabled = EnabledStatus;
                }
            }
        }

        public void SetCheckListBox(CheckedListBox clbCheckedListBox, string strLookupSQL, string strFilter = "", string strOrder = "LookupText")
        {
            DataTable dtDataTable = new DataTable();
            SqlException eSqlException = ServerSupplier.BFL.GetDataTable(ref dtDataTable, strLookupSQL.Trim(), strFilter, strOrder);
            if (eSqlException == null)
            {
                clbCheckedListBox.CheckOnClick = true;
                clbCheckedListBox.DataSource = dtDataTable;
                clbCheckedListBox.ValueMember = dtDataTable.Columns["LookupValue"].ToString();
                clbCheckedListBox.DisplayMember = dtDataTable.Columns["LookupText"].ToString();
                clbCheckedListBox.SelectedIndex = -1;
            }
            else
                System.Windows.Forms.MessageBox.Show(eSqlException.Message);
        }

        public void SetComboBox(ComboBox cbComboBox, string strLookupSQL, string strFilter = "", string strOrder = "LookupText")
        {
            DataTable dtDataTable = new DataTable();
            SqlException eSqlException = ServerSupplier.BFL.GetDataTable(ref dtDataTable, strLookupSQL.Trim(), strFilter, strOrder);
            if (eSqlException == null)
            {
                cbComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbComboBox.DataSource = dtDataTable;
                cbComboBox.ValueMember = dtDataTable.Columns["LookupValue"].ToString();
                cbComboBox.DisplayMember = dtDataTable.Columns["LookupText"].ToString();
                cbComboBox.SelectedIndex = -1;
                UpdateDropDownWidth(cbComboBox);
            }
            else
                System.Windows.Forms.MessageBox.Show(eSqlException.Message);
        }

        private void FindWidthForDropDown(ComboBox cbComboBox)
        {
            Graphics g = cbComboBox.CreateGraphics();
            Boolean IsDatabound = ((cbComboBox.DataSource != null) && (cbComboBox.DisplayMember != String.Empty));
            int WidestWidth = cbComboBox.DropDownWidth;
            g.PageUnit = GraphicsUnit.Pixel;
            string ValueToMeasure;
            int CurrentWidth;
            for (int i = 0; (i < cbComboBox.Items.Count); i++)
            {
                // if (IsDatabound)
                //              ValueToMeasure = (string)Convert.ChangeType(cbComboBox.DisplayMember, typeof(string));
                //         else
                // ValueToMeasure = (string)Convert.ChangeType(cbComboBox.Items[i], typeof(string));
                ValueToMeasure = cbComboBox.Items[i].ToString();
                CurrentWidth = Convert.ToInt16(g.MeasureString(ValueToMeasure, cbComboBox.Font).Width);
                if (CurrentWidth > WidestWidth)
                    WidestWidth = CurrentWidth + 20;
            }
            cbComboBox.DropDownWidth = WidestWidth;
            g.Dispose();
        }

        private void AdjustWidthDropDown(ComboBox cbComboBox)
        {
            cbComboBox.IntegralHeight = false;

            int width = cbComboBox.DropDownWidth;
            Graphics g = cbComboBox.CreateGraphics();
            g.PageUnit = GraphicsUnit.Pixel;
            Font font = cbComboBox.Font;
            int vertScrollBarWidth =
                (cbComboBox.Items.Count > cbComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (object s in cbComboBox.Items)
            {
                newWidth = (int)g.MeasureString(s.ToString().Trim(), font).Width + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            cbComboBox.DropDownWidth = width;
        }

        private void UpdateDropDownWidth(ComboBox cbComboBox)
        {
            cbComboBox.IntegralHeight = false;
            //Create a GDI+ drawing surface to measure string widths
            System.Drawing.Graphics ds = cbComboBox.CreateGraphics();
            int initialDropDownWidth = cbComboBox.DropDownWidth;
            //Float to hold largest single item width
            float maxWidth = 0;

            //Iterate over each item, measuring the maximum width
            //of the DisplayMember strings
            foreach (object item in cbComboBox.Items)
            {
                maxWidth = Math.Max(maxWidth, ds.MeasureString(item.ToString().Trim(), cbComboBox.Font).Width);
            }

            //Add a buffer for some white space
            //around the text
            maxWidth += 30;

            //round maxWidth and cast to an int
            int newWidth = (int)Decimal.Round((decimal)maxWidth, 0);

            //If the width is bigger than the screen, ensure
            //we stay within the bounds of the screen
            if (newWidth > Screen.GetWorkingArea(cbComboBox).Width)
            {
                newWidth = Screen.GetWorkingArea(cbComboBox).Width;
            }

            //Only change the default width if it's smaller
            //than the newly calculated width
            if (newWidth > initialDropDownWidth)
            {
                cbComboBox.DropDownWidth = newWidth;
            }

            //Clean up the drawing surface
            ds.Dispose();
        }

        public void SetDataPanelView(GroupBox gbGroupBox, ToolTip ttToolTip, _Table __Table)
        {
            if (__Table._Field.Active == true)
            {
                switch ((TableType)__Table.FK_TableTypeCode)
                {
                    case TableType.ttBase:
                    case TableType.ttViewBase:
                    case TableType.ttSystem:
                        {
                            if (gbGroupBox.Controls["lblBaseCode"] != null)
                                gbGroupBox.Controls["lblBaseCode"].Name = "lbl" + __Table._Field.FieldTable.Rows[0]["FieldName"].ToString().Trim();
                            if (gbGroupBox.Controls["ntbBaseCode"] != null)
                                gbGroupBox.Controls["ntbBaseCode"].Name = "ntb" + __Table._Field.FieldTable.Rows[0]["FieldName"].ToString().Trim();
                            if (gbGroupBox.Controls["lblBaseName"] != null)
                                gbGroupBox.Controls["lblBaseName"].Name = "lbl" + __Table._Field.FieldTable.Rows[1]["FieldName"].ToString().Trim();
                            if (gbGroupBox.Controls["txtBaseName"] != null)
                                gbGroupBox.Controls["txtBaseName"].Name = "tb" + __Table._Field.FieldTable.Rows[1]["FieldName"].ToString().Trim();
                        }
                        break;
                }
                for (int intIndex = 0; (intIndex < __Table._Field.FieldTable.Rows.Count); intIndex++)
                {
                    string strFieldName = __Table._Field.FieldTable.Rows[intIndex]["FieldName"].ToString().Trim();
                    if (gbGroupBox.Controls["lbl" + strFieldName] != null)
                    {
                        gbGroupBox.Controls["lbl" + strFieldName].Text = __Table._Field.FieldTable.Rows[intIndex]["Caption"].ToString().Trim();
                        ttToolTip.SetToolTip(gbGroupBox.Controls["lbl" + strFieldName], __Table._Field.FieldTable.Rows[intIndex]["Description"].ToString().Trim());
                    }
                    if (gbGroupBox.Controls["chb" + strFieldName] != null)
                    {
                        gbGroupBox.Controls["chb" + strFieldName].Text = __Table._Field.FieldTable.Rows[intIndex]["Caption"].ToString().Trim();
                        ttToolTip.SetToolTip(gbGroupBox.Controls["chb" + strFieldName], __Table._Field.FieldTable.Rows[intIndex]["Description"].ToString().Trim());
                    }
                    if (gbGroupBox.Controls["tb" + strFieldName] != null)
                    {
                        switch ((FieldType)Convert.ToInt16(__Table._Field.FieldTable.Rows[intIndex]["FK_FieldTypeCode"]))
                        {
                            case FieldType.ftChar:
                            case FieldType.ftNChar:
                            case FieldType.ftVarChar:
                            case FieldType.ftNVarChar:
                            case FieldType.ftText:
                            case FieldType.ftNText:
                                {

                                    int FieldLength = Convert.ToInt32(__Table._Field.FieldTable.Rows[intIndex]["FieldLength"]);
                                    (gbGroupBox.Controls["tb" + strFieldName] as TextBox).MaxLength = FieldLength != -1 ? FieldLength : MAX_LENGTH;
                                    break;
                                }
                        }
                    }
                    if (gbGroupBox.Controls["ntb" + strFieldName] != null)
                    {
                        switch ((FieldType)Convert.ToInt16(__Table._Field.FieldTable.Rows[intIndex]["FK_FieldTypeCode"]))
                        {
                            case FieldType.ftDecimal:
                            case FieldType.ftNumeric:
                                {
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).AllowDecimalSeparator = true;
                                    int ML = Convert.ToInt32(__Table._Field.FieldTable.Rows[intIndex]["FieldLength"].ToString().Split('.').GetValue(0));
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).MaxLength = ML;
                                    int DL = Convert.ToInt32(__Table._Field.FieldTable.Rows[intIndex]["FieldLength"].ToString().Trim().Split('.').GetValue(1));
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).DecimalLength = DL;
                                    break;
                                }
                            case FieldType.ftBigInt:
                            case FieldType.ftInt:
                            case FieldType.ftSmallInt:
                            case FieldType.ftTinyInt:
                                {
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).AllowDecimalSeparator = false;
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).MaxLength = Convert.ToInt32(__Table._Field.FieldTable.Rows[intIndex]["FieldLength"]);
                                    (gbGroupBox.Controls["ntb" + strFieldName] as NumericTextBox).DecimalLength = 0;
                                    break;
                                }
                        }
                    }
                    if ((gbGroupBox.Controls["cb" + strFieldName] != null) && (__Table._Field.FieldTable.Rows[intIndex]["LookupSQL"].ToString().Trim() != string.Empty))
                        SetComboBox(gbGroupBox.Controls["cb" + strFieldName] as ComboBox, __Table._Field.FieldTable.Rows[intIndex]["LookupSQL"].ToString().Trim());
                    if (gbGroupBox.Controls["clb" + strFieldName] != null)
                        SetCheckListBox(gbGroupBox.Controls["clb" + strFieldName] as CheckedListBox, __Table._Field.FieldTable.Rows[intIndex]["LookupSQL"].ToString().Trim());
                }
            }
            gbGroupBox.Tag = __Table;
        }

        public void SetDataGridView(DataGridView dgvDataGridView, _Table __Table)
        {
            if (__Table._Field.Active == true)
            {
                DataTable dtDataTable = __Table._Field.FieldTable;
                DataTable dtSource = dgvDataGridView.DataSource as DataTable;
                if (dtSource == null) dtSource = (dgvDataGridView.DataSource as BindingSource).DataSource as DataTable;
                for (int intIndex = 0; (intIndex < dtDataTable.Rows.Count); intIndex++)
                {
                    string strFieldName = dtDataTable.Rows[intIndex]["FieldName"].ToString().Trim();
                    if (dtSource.Columns[strFieldName] != null)
                    {
                        dgvDataGridView.Columns[strFieldName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvDataGridView.Columns[strFieldName].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
                        dgvDataGridView.Columns[strFieldName].HeaderText = dtDataTable.Rows[intIndex]["Caption"].ToString();
                        dgvDataGridView.Columns[strFieldName].Visible = Convert.ToBoolean(dtDataTable.Rows[intIndex]["Visible"].ToString());
                        dgvDataGridView.Columns[strFieldName].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvDataGridView.Columns[strFieldName].SortMode = DataGridViewColumnSortMode.Programmatic;
                    }
                }
                for (int intIndex = dgvDataGridView.Columns.Count - 1; (intIndex >= 0); intIndex--)
                {
                    if (dgvDataGridView.Columns[intIndex].Visible == true)
                    {
                        string str = dgvDataGridView.Columns[intIndex].Name;
                        if (str.Length > 0)
                            dgvDataGridView.Columns[str].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvDataGridView.Columns[intIndex].Tag = "DESC";
                    }
                }
            }
        }


        public void DataRowDelete(DataTable dtDataTable, CurrencyManager cmCurrencyManager, _Table __Table)
        {
            __Table.TableStatus = TableStatus.tsOnProcess;
            try
            {
                if (CCL.pMB.Show(ServerSupplier.BFL.GetResourceString("strDeleteWarning"), ServerSupplier.BFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Question, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.DoEvents();
                    int RowIndex = cmCurrencyManager.Position;
                    dtDataTable.Rows[RowIndex].Delete();
                    SqlException eSqlException = ServerSupplier.BFL.SetDataTable(dtDataTable, __Table.TableName);
                    if (eSqlException != null)
                    {
                        dtDataTable.RejectChanges();
                        cmCurrencyManager.Position = RowIndex;
                        CCL.pMB.Show(ServerSupplier.BFL.GetResourceString("ecDelete"), ServerSupplier.BFL.GetResourceString("strErrorTitle"), MessageBoxIcon.Error, MessageBoxButtons.OK);
                    }
                    else
                    {
                        dtDataTable.AcceptChanges();
                        ServerSupplier.BFL.Logging(User.UserCode, __Table.PK_TableCode, Atsam.Action.aDelete, User.IP);
                    }
                }
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
            }
            __Table.TableStatus = TableStatus.tsNone;
        }

        public void DataRowDelete(DataTable dtDataTable, int Position, _Table __Table)
        {
            __Table.TableStatus = TableStatus.tsOnProcess;
            try
            {
                if (CCL.pMB.Show(ServerSupplier.BFL.GetResourceString("strDeleteWarning"), ServerSupplier.BFL.GetResourceString("strWarningTitle"), MessageBoxIcon.Question, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.DoEvents();
                    int RowIndex = Position;
                    dtDataTable.Rows[RowIndex].Delete();
                    SqlException eSqlException = ServerSupplier.BFL.SetDataTable(dtDataTable, __Table.TableName);
                    if (eSqlException != null)
                    {
                        dtDataTable.RejectChanges();
                        CCL.pMB.Show(ServerSupplier.BFL.GetResourceString("ecDelete"), ServerSupplier.BFL.GetResourceString("strErrorTitle"), MessageBoxIcon.Error, MessageBoxButtons.OK);
                    }
                    else
                    {
                        dtDataTable.AcceptChanges();
                        ServerSupplier.BFL.Logging(User.UserCode, __Table.PK_TableCode, Atsam.Action.aDelete, User.IP);
                    }
                }
            }
            catch (Exception eException)
            {
                System.Windows.Forms.MessageBox.Show(eException.Message);
            }
            __Table.TableStatus = TableStatus.tsNone;
        }

        public void SetTextBox(object sender, Color cBackColor, InputLanguageList illInputLanguageList = InputLanguageList.illFarsi, Boolean IsSelectAll = true)
        {
            TextBox txt = sender as TextBox;
            SetLanguage(illInputLanguageList);
            if ((IsSelectAll == true) && (txt.Text.Trim() != string.Empty)) txt.SelectAll();
            txt.BackColor = cBackColor;
        }

        public void SetButton(GroupBox gbGroupBox, ToolTip ttToolTip)
        {
            foreach (Control cControl in gbGroupBox.Controls)
            {
                if (cControl is Button)
                {
                    string strAlias = (cControl as Button).Name.Substring(3).Trim();
                    DataTable dtDataTable = new DataTable();
                    ServerSupplier.BFL.GetDataTable(ref dtDataTable, "_Table", "Alias = '" + strAlias + "'");
                    if (dtDataTable.Rows.Count > 0)
                    {
                        FormStatus fsFormStatus;
                        switch ((TableType)Convert.ToInt16(dtDataTable.Rows[0]["FK_TableTypeCode"]))
                        {
                            case TableType.ttSubTable: fsFormStatus = FormStatus.fsSubform; break;
                            default: fsFormStatus = FormStatus.fsBase; break;
                        }
                        _Table __Table = new _Table(dtDataTable.Rows[0], fsFormStatus);
                        cControl.Tag = __Table;
                        ttToolTip.SetToolTip(cControl, __Table.Description.Trim());
                    }
                }
            }
        }

        public void SetButton(ToolStrip tsToolStrip, _Table __Table)
        {
            DataTable dtDataTable = new DataTable();
            ServerSupplier.BFL.GetDataTable(ref dtDataTable, "_Table", "FK_ParentTableCode = " + __Table.PK_TableCode);
            foreach (DataRow drDataRow in dtDataTable.Rows)
            {
                for (int i = 0; i < tsToolStrip.Items.Count; i++)
                    if ((tsToolStrip.Items[i].Name.Substring(3).Trim() == drDataRow["Alias"].ToString()) && ((TableType)Convert.ToInt16(dtDataTable.Rows[0]["FK_TableTypeCode"]) == TableType.ttSubTable))
                    {
                        _Table Table = new _Table(drDataRow, FormStatus.fsSubform);
                        tsToolStrip.Items[i].Tag = Table;
                        tsToolStrip.Items[i].ToolTipText = Table.Description.Trim();
                    }
            }
        }

        public void SetButton(ToolStrip tsToolStrip, int PK_TableCode)
        {
            foreach (ToolStripItem tsbToolStripButton in tsToolStrip.Items)
            {
                if ((tsbToolStripButton is ToolStripButton) && (tsbToolStripButton.Name.Substring(4, 1).Trim() == "_"))
                {
                    string strTableName = tsbToolStripButton.Name.Substring(3).Trim();
                    DataTable dtDataTable = new DataTable();
                    ServerSupplier.BFL.GetDataTable(ref dtDataTable, "_Table", "Alias = '" + strTableName + "' AND FK_ParentTableCode = " + PK_TableCode.ToString());
                    if (dtDataTable.Rows.Count > 0)
                    {
                        FormStatus fsFormStatus;
                        switch ((TableType)Convert.ToInt16(dtDataTable.Rows[0]["FK_TableTypeCode"]))
                        {
                            case TableType.ttSubTable: fsFormStatus = FormStatus.fsSubform; break;
                            default: fsFormStatus = FormStatus.fsBase; break;
                        }
                        _Table __Table = new _Table(dtDataTable.Rows[0], fsFormStatus);
                        tsbToolStripButton.Tag = __Table;
                        tsbToolStripButton.ToolTipText = __Table.Description.Trim();
                    }
                }
            }
        }

        public void SetButton(Button btnButton)
        {
            string strTableName = btnButton.Name.Substring(3).Trim();
            DataTable dtDataTable = new DataTable();
            ServerSupplier.BFL.GetDataTable(ref dtDataTable, "_Table", "Alias = '" + strTableName + "'");
            if (dtDataTable.Rows.Count > 0)
            {
                FormStatus fsFormStatus;
                switch ((TableType)Convert.ToInt16(dtDataTable.Rows[0]["FK_TableTypeCode"]))
                {
                    case TableType.ttSubTable: fsFormStatus = FormStatus.fsSubform; break;
                    default: fsFormStatus = FormStatus.fsBase; break;
                }
                _Table __Table = new _Table(dtDataTable.Rows[0], fsFormStatus);
                btnButton.Tag = __Table;
            }
        }

        public void SetButton(Button btnButton, GroupBox gbGroupBox, _Table __Table)
        {
            if (((_Table)(btnButton.Tag)).LinkPage.Trim() != string.Empty)
            {
                Form frm = ((_Table)(btnButton.Tag)).LinkPageForm();
                frm.Tag = btnButton.Tag;

                string strFieldName = "FK_" + ((_Table)btnButton.Tag).TableName.Substring(2) + "Code";
                if ((gbGroupBox.Controls["cb" + strFieldName] == null) && (gbGroupBox.Controls["clb" + strFieldName] == null))
                    strFieldName = "PK_FK" + ((_Table)btnButton.Tag).TableName.Substring(2) + "Code";

                if (gbGroupBox.Controls["ntb" + strFieldName] != null)
                    ((_Table)frm.Tag).ReturnValue = gbGroupBox.Controls["ntb" + strFieldName].Text;
                else if (gbGroupBox.Controls["tb" + strFieldName] != null)
                    ((_Table)frm.Tag).ReturnValue = gbGroupBox.Controls["tb" + strFieldName].Text;
                else if ((gbGroupBox.Controls["cb" + strFieldName] != null) && (((ComboBox)gbGroupBox.Controls["cb" + strFieldName]).SelectedValue != null))
                    ((_Table)frm.Tag).ReturnValue = ((ComboBox)gbGroupBox.Controls["cb" + strFieldName]).SelectedValue.ToString();
                else if (gbGroupBox.Controls["clb" + strFieldName] != null)
                    if (((CheckedListBox)gbGroupBox.Controls["clb" + strFieldName]).SelectedIndex >= 0)
                        ((_Table)frm.Tag).ReturnValue = ((CheckedListBox)gbGroupBox.Controls["clb" + strFieldName]).SelectedValue.ToString();

                frm.ShowDialog();
                btnButton.Tag = frm.Tag;

                if (gbGroupBox.Controls["cb" + strFieldName] != null)
                {
                    __Table._Field.SetDataField(strFieldName);
                    SetComboBox(gbGroupBox.Controls["cb" + strFieldName] as ComboBox, __Table._Field.LookupSQL);
                }
                else if (gbGroupBox.Controls["clb" + strFieldName] != null)
                {
                    __Table._Field.SetDataField(strFieldName);
                    SetCheckListBox(gbGroupBox.Controls["clb" + strFieldName] as CheckedListBox, __Table._Field.LookupSQL);
                }

                if (((_Table)frm.Tag).ReturnValue.ToString() != string.Empty)
                {
                    if (gbGroupBox.Controls["cb" + strFieldName] != null)
                        ((ComboBox)gbGroupBox.Controls["cb" + strFieldName]).SelectedValue = ((_Table)frm.Tag).ReturnValue;
                    if (gbGroupBox.Controls["ntb" + strFieldName] != null)
                        gbGroupBox.Controls["ntb" + strFieldName].Text = ((_Table)frm.Tag).ReturnValue;
                    if (gbGroupBox.Controls["tb" + strFieldName] != null)
                        gbGroupBox.Controls["tb" + strFieldName].Text = ((_Table)frm.Tag).ReturnValue;
                    if (gbGroupBox.Controls["clb" + strFieldName] != null)
                    {
                        ((CheckedListBox)gbGroupBox.Controls["clb" + strFieldName]).SelectedValue = ((_Table)frm.Tag).ReturnValue;
                        ((CheckedListBox)gbGroupBox.Controls["clb" + strFieldName]).SetItemChecked(((CheckedListBox)gbGroupBox.Controls["clb" + strFieldName]).SelectedIndex, true);
                    }
                }
            }
        }

        public void SetGroupBox(GroupBox gbGroupBox, _Table __Table, DataRow drDataRow)
        {
            for (int intIndex = 0; intIndex < __Table._Field.FieldTable.Rows.Count; intIndex++)
            {
                if (!(Convert.ToBoolean(__Table._Field.FieldTable.Rows[intIndex]["Enabled"]) || Convert.ToBoolean(__Table._Field.FieldTable.Rows[intIndex]["Visible"])))
                    continue;
                string strFieldName = __Table._Field.FieldTable.Rows[intIndex]["FieldName"].ToString().Trim();
                if (gbGroupBox.Controls["ntb" + strFieldName] != null)
                    ((NumericTextBox)gbGroupBox.Controls["ntb" + strFieldName]).Text = drDataRow[strFieldName].ToString().Trim();
                else if (gbGroupBox.Controls["tb" + strFieldName] != null)
                    ((TextBox)gbGroupBox.Controls["tb" + strFieldName]).Text = drDataRow[strFieldName].ToString().Trim();
                else if (gbGroupBox.Controls["pb" + strFieldName] != null)
                {
                    if (drDataRow[strFieldName] != DBNull.Value)
                    {
                        byte[] bLogo = (byte[])drDataRow[strFieldName];
                        MemoryStream msMemoryStream = new MemoryStream(bLogo);
                        Bitmap bmpBitmap = new Bitmap(Image.FromStream(msMemoryStream), (gbGroupBox.Controls["pb" + strFieldName].Size.Width), (gbGroupBox.Controls["pb" + strFieldName].Size.Height));
                        msMemoryStream.Close();
                        ((PictureBox)gbGroupBox.Controls["pb" + strFieldName]).Image = bmpBitmap;
                    }
                    else
                        ((PictureBox)gbGroupBox.Controls["pb" + strFieldName]).Image = null;
                }
                else if (gbGroupBox.Controls["dtp" + strFieldName] != null)
                {
                    if (drDataRow[strFieldName] != DBNull.Value)
                    {
                        ((DateTimePicker)gbGroupBox.Controls["dtp" + strFieldName]).Value = Convert.ToDateTime(drDataRow[strFieldName].ToString());
                    }
                    else
                        ((DateTimePicker)gbGroupBox.Controls["dtp" + strFieldName]).Text = string.Empty;
                }
                else if (gbGroupBox.Controls["chb" + strFieldName] != null)
                    ((CheckBox)gbGroupBox.Controls["chb" + strFieldName]).Checked = Convert.ToBoolean(drDataRow[strFieldName]);
                else if (gbGroupBox.Controls["lbl" + strFieldName + "Value"] != null)
                    ((Label)gbGroupBox.Controls["lbl" + strFieldName + "Value"]).Text = drDataRow[strFieldName].ToString().Trim();
                else if (gbGroupBox.Controls["cb" + strFieldName] != null)
                    ((ComboBox)gbGroupBox.Controls["cb" + strFieldName]).SelectedValue = drDataRow[strFieldName].ToString().Trim();
            }
        }

        public void SetComboBox(ComboBox cbMaster, ComboBox cbSlave, _Table __Table)
        {
            string strFieldName = cbSlave.Name.Substring(2);
            __Table._Field.SetDataField(strFieldName);
            if (__Table._Field.LookupSQL.Trim().Length > 0)
            {
                if ((__Table.TableStatus == TableStatus.tsInsert) || (__Table.TableStatus == TableStatus.tsEdit))
                {
                    string strCriteria = __Table._Field.MasterReferenceField + " = " + cbMaster.SelectedValue.ToString();
                    string LookupSQL = (__Table._Field.LookupSQL.Contains(")")) ? ((__Table._Field.LookupSQL.Contains("WHERE") ? __Table._Field.LookupSQL.Insert(__Table._Field.LookupSQL.IndexOf(')', 0), " AND " + strCriteria) : __Table._Field.LookupSQL.Insert(__Table._Field.LookupSQL.IndexOf(')', 0), " WHERE " + strCriteria))) : ((__Table._Field.LookupSQL.Contains("WHERE") ? " AND " + strCriteria : " WHERE " + strCriteria));
                    SetComboBox(cbSlave, LookupSQL);
                }
                else
                    SetComboBox(cbSlave, __Table._Field.LookupSQL);
            }
        }

        public void SetControlEvent(Control ControlParent)
        {
            foreach (Control ctrl in ControlParent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enter += new EventHandler(TextBox_Enter);
                    ctrl.Leave += new EventHandler(TextBox_Leave);
                    ctrl.TextChanged += new EventHandler(TextBox_TextChanged);
                    ctrl.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                    (ctrl as ComboBox).SelectionChangeCommitted += new EventHandler(ComboBox_SelectionChangeCommitted);
                    ctrl.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                }
                else if (ctrl is Button)
                    ctrl.Click += new EventHandler(Button_Click);
                else if (ctrl is DateTimePicker)
                    ctrl.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btnButton = sender as Button;
            if ((_Table)btnButton.Tag != null)
                SetButton(btnButton, (sender as Control).Parent as GroupBox, (_Table)((sender as Control).Parent as GroupBox).Tag);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    Control ctrl = (sender as Control).Parent.GetNextControl(sender as Control, true);
                    if (ctrl == null)
                        ctrl = GetControlByTab((sender as Control).Parent, 1);
                    while (ctrl != null)
                    {
                        if ((ctrl.Enabled) && (((ctrl is TextBox) && (ctrl as TextBox).Visible && (!(ctrl as TextBox).ReadOnly))) || ((ctrl is ComboBox) && ((ctrl as ComboBox).SelectedIndex == -1)) || ((ctrl is DateTimePicker) && (ctrl.Enabled)))
                        {
                            ctrl.Focus();
                            break;
                        }
                        ctrl = ctrl.Parent.GetNextControl(ctrl, true);
                        if (ctrl == null)
                            ctrl = GetControlByTab((sender as Control).Parent, 1);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public Control GetControlByTab(Control GropBox, int iTabIndex)
        {
            foreach (Control ctrl in GropBox.Controls)
                if (ctrl.TabIndex == iTabIndex) return (ctrl);
            return (GetControlByTab(GropBox, 0));
        }


        public Control Control_KeyPress(Control ControlParent, int intTabIndex)
        {
            int MaxTabIndex = 0;
            intTabIndex++;
            foreach (Control cControl in ControlParent.Controls)
            {
                if (cControl.TabIndex == intTabIndex)
                {
                    if (cControl is TextBox)
                    {
                        if ((cControl.Enabled) && (cControl.Visible) && (!(cControl as TextBox).ReadOnly))
                            return cControl;
                        else
                            continue;
                    }
                    if (cControl is ComboBox)
                    {
                        if (((cControl as ComboBox).SelectedIndex == -1) && (cControl.Enabled) && (cControl.Visible))
                            return cControl;
                        else
                            continue;
                    }
                }
                if (cControl.TabIndex > MaxTabIndex)
                    MaxTabIndex = cControl.TabIndex;
            }
            if (intTabIndex >= MaxTabIndex)
                return Control_KeyPress(ControlParent, 0);
            return Control_KeyPress(ControlParent, intTabIndex);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            SetTextBox(sender, Color.LightYellow);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            SetTextBox(sender, Color.White);
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            NumericTextBox ntbNumericTextBox = sender as NumericTextBox;
            if ((ntbNumericTextBox != null) && ((sender as Control).Parent.Controls["cb" + ntbNumericTextBox.Name.Substring(3).Trim()] != null))
            {
                ComboBox cbComboBox = (sender as Control).Parent.Controls["cb" + ntbNumericTextBox.Name.Substring(3).Trim()] as ComboBox;
                if (ntbNumericTextBox.Text.Trim() == string.Empty)
                    cbComboBox.SelectedIndex = -1;
                else
                    cbComboBox.SelectedValue = ntbNumericTextBox.Text.Trim();
            }
        }

        public void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbComboBox = sender as ComboBox;
            if (((sender as Control).Parent.Controls["ntb" + cbComboBox.Name.Substring(2).Trim()] != null) && (cbComboBox.SelectedIndex != -1))
            {
                NumericTextBox ntbNumericTextBox = (sender as Control).Parent.Controls["ntb" + cbComboBox.Name.Substring(2).Trim()] as NumericTextBox;
                ntbNumericTextBox.Text = cbComboBox.SelectedValue.ToString();
            }
        }

        public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolTip ttToolTip = new ToolTip();
            ComboBox cbComboBox = sender as ComboBox;
            ttToolTip.SetToolTip(cbComboBox, cbComboBox.Text);
        }    

        public static string GetOrderCode()
        {
            System.Globalization.PersianCalendar pcPersianCalendar = new System.Globalization.PersianCalendar();
            DataTable dtDataTable = new DataTable();
            string strYear = pcPersianCalendar.GetYear(DateTime.Today).ToString().Substring(2, 2);
            string strSQL = "(SELECT MAX(SUBSTRING(PK_OrderCode, 5, 4)) AS OrderCode FROM m_Order WHERE (PK_OrderCode LIKE '" + strYear + "%')) AS m_Order";
            try
            {
                SqlException eSqlException = ServerSupplier.BFL.GetDataTable(ref dtDataTable, strSQL);
                if (eSqlException == null)
                {
                    int intOrderCode = ((dtDataTable.Rows[0].IsNull(0) == true) ? 0 : Convert.ToInt32(dtDataTable.Rows[0][0])) + 1;
                    string strOrderCode = intOrderCode.ToString().PadLeft(6, '0');
                    strOrderCode = strYear.ToString() + strOrderCode;
                    return (strOrderCode);
                }
                else
                {
                    // System.Windows.Forms.MessageBox.Show(eSqlException.Message);
                    return (string.Empty);
                }
            }
            catch
            {
                // System.Windows.Forms.MessageBox.Show(eException.Message);
                return (string.Empty);
            }
        }
    }
}
