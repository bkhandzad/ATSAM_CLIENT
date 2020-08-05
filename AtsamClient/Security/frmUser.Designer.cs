namespace AtsamClient.Security
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTableStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRecordNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.ntbFK_WorkGroupCode = new NumericTextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.btn_WorkGroup = new System.Windows.Forms.Button();
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.cbFK_WorkGroupCode = new System.Windows.Forms.ComboBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblFK_WorkGroupCode = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDBPost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDBFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbDBInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbDBEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDBDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbDBPost = new System.Windows.Forms.ToolStripButton();
            this.tsbDBCancel = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDBFind = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFindNext = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFilter = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbDataPrint = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.lblCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.ssStatusStrip.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.msMenuStrip.SuspendLayout();
            this.tsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDataGridView
            // 
            this.dgvDataGridView.AllowUserToAddRows = false;
            this.dgvDataGridView.AllowUserToDeleteRows = false;
            this.dgvDataGridView.AllowUserToResizeRows = false;
            this.dgvDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDataGridView.Location = new System.Drawing.Point(0, 228);
            this.dgvDataGridView.MultiSelect = false;
            this.dgvDataGridView.Name = "dgvDataGridView";
            this.dgvDataGridView.ReadOnly = true;
            this.dgvDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataGridView.ShowCellErrors = false;
            this.dgvDataGridView.ShowRowErrors = false;
            this.dgvDataGridView.Size = new System.Drawing.Size(744, 200);
            this.dgvDataGridView.TabIndex = 4;
            this.dgvDataGridView.DataSourceChanged += new System.EventHandler(this.dgvDataGridView_DataSourceChanged);
            this.dgvDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataGridView_ColumnHeaderMouseClick);
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTableStatus,
            this.tsslRecordNumber});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(744, 25);
            this.ssStatusStrip.TabIndex = 5;
            this.ssStatusStrip.Text = "ssStatusbar";
            // 
            // tsslTableStatus
            // 
            this.tsslTableStatus.AutoSize = false;
            this.tsslTableStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTableStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslTableStatus.ForeColor = System.Drawing.Color.Maroon;
            this.tsslTableStatus.Name = "tsslTableStatus";
            this.tsslTableStatus.Size = new System.Drawing.Size(669, 20);
            this.tsslTableStatus.Spring = true;
            this.tsslTableStatus.Text = "وضعيت جدول";
            this.tsslTableStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslRecordNumber
            // 
            this.tsslRecordNumber.AutoSize = false;
            this.tsslRecordNumber.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslRecordNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslRecordNumber.ForeColor = System.Drawing.Color.Maroon;
            this.tsslRecordNumber.Name = "tsslRecordNumber";
            this.tsslRecordNumber.Size = new System.Drawing.Size(60, 20);
            this.tsslRecordNumber.Text = "تعداد رکورد";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.ntbFK_WorkGroupCode);
            this.gbDetails.Controls.Add(this.tbLastName);
            this.gbDetails.Controls.Add(this.lblLastName);
            this.gbDetails.Controls.Add(this.tbFirstName);
            this.gbDetails.Controls.Add(this.lblFirstName);
            this.gbDetails.Controls.Add(this.tbUserPassword);
            this.gbDetails.Controls.Add(this.tbUserID);
            this.gbDetails.Controls.Add(this.btn_WorkGroup);
            this.gbDetails.Controls.Add(this.cbFK_WorkGroupCode);
            this.gbDetails.Controls.Add(this.lblUserPassword);
            this.gbDetails.Controls.Add(this.lblFK_WorkGroupCode);
            this.gbDetails.Controls.Add(this.lblUserID);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 103);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(744, 119);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            // 
            // ntbFK_WorkGroupCode
            // 
            this.ntbFK_WorkGroupCode.AllowDecimalSeparator = false;
            this.ntbFK_WorkGroupCode.AllowGroupSeparator = false;
            this.ntbFK_WorkGroupCode.AllowNegativeSign = false;
            this.ntbFK_WorkGroupCode.AllowSpace = false;
            this.ntbFK_WorkGroupCode.BackColor = System.Drawing.Color.White;
            this.ntbFK_WorkGroupCode.DecimalLength = 0;
            this.ntbFK_WorkGroupCode.Location = new System.Drawing.Point(564, 86);
            this.ntbFK_WorkGroupCode.Name = "ntbFK_WorkGroupCode";
            this.ntbFK_WorkGroupCode.Size = new System.Drawing.Size(38, 23);
            this.ntbFK_WorkGroupCode.TabIndex = 5;
            this.ntbFK_WorkGroupCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbFK_WorkGroupCode.ValidationChecked = true;
            this.ntbFK_WorkGroupCode.TextChanged += new System.EventHandler(this.ntbWorkGroupCode_TextChanged);
            this.ntbFK_WorkGroupCode.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.ntbFK_WorkGroupCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbWorkGroupCode_KeyPress);
            this.ntbFK_WorkGroupCode.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(377, 53);
            this.tbLastName.MaxLength = 0;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(225, 23);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.tbLastName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(604, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(130, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگي";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(377, 20);
            this.tbFirstName.MaxLength = 0;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(225, 23);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(604, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(130, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "نام";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.BackColor = System.Drawing.Color.White;
            this.tbUserPassword.Location = new System.Drawing.Point(10, 53);
            this.tbUserPassword.MaxLength = 0;
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '*';
            this.tbUserPassword.Size = new System.Drawing.Size(225, 23);
            this.tbUserPassword.TabIndex = 11;
            this.tbUserPassword.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.tbUserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPassword_KeyPress);
            this.tbUserPassword.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.White;
            this.tbUserID.Location = new System.Drawing.Point(10, 20);
            this.tbUserID.MaxLength = 0;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(225, 23);
            this.tbUserID.TabIndex = 9;
            this.tbUserID.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.tbUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            this.tbUserID.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // btn_WorkGroup
            // 
            this.btn_WorkGroup.ImageIndex = 0;
            this.btn_WorkGroup.ImageList = this.ilImageList;
            this.btn_WorkGroup.Location = new System.Drawing.Point(377, 86);
            this.btn_WorkGroup.Name = "btn_WorkGroup";
            this.btn_WorkGroup.Size = new System.Drawing.Size(28, 23);
            this.btn_WorkGroup.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btn_WorkGroup, "ثبت و انتخاب گروه کاري");
            this.btn_WorkGroup.UseVisualStyleBackColor = true;
            this.btn_WorkGroup.Click += new System.EventHandler(this.btnWorkGroup_Click);
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.ilImageList.Images.SetKeyName(0, "Bullets.bmp");
            // 
            // cbFK_WorkGroupCode
            // 
            this.cbFK_WorkGroupCode.BackColor = System.Drawing.Color.White;
            this.cbFK_WorkGroupCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFK_WorkGroupCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFK_WorkGroupCode.FormattingEnabled = true;
            this.cbFK_WorkGroupCode.Location = new System.Drawing.Point(407, 86);
            this.cbFK_WorkGroupCode.Name = "cbFK_WorkGroupCode";
            this.cbFK_WorkGroupCode.Size = new System.Drawing.Size(155, 24);
            this.cbFK_WorkGroupCode.TabIndex = 6;
            this.cbFK_WorkGroupCode.SelectedIndexChanged += new System.EventHandler(this.cboWorkGroup_SelectedIndexChanged);
            this.cbFK_WorkGroupCode.SelectionChangeCommitted += new System.EventHandler(this.cboWorkGroup_SelectionChangeCommitted);
            this.cbFK_WorkGroupCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWorkGroup_KeyPress);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserPassword.ForeColor = System.Drawing.Color.Black;
            this.lblUserPassword.Location = new System.Drawing.Point(237, 53);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserPassword.Size = new System.Drawing.Size(130, 23);
            this.lblUserPassword.TabIndex = 10;
            this.lblUserPassword.Text = "رمز عبور";
            this.lblUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFK_WorkGroupCode
            // 
            this.lblFK_WorkGroupCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFK_WorkGroupCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFK_WorkGroupCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFK_WorkGroupCode.ForeColor = System.Drawing.Color.Black;
            this.lblFK_WorkGroupCode.Location = new System.Drawing.Point(604, 86);
            this.lblFK_WorkGroupCode.Name = "lblFK_WorkGroupCode";
            this.lblFK_WorkGroupCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFK_WorkGroupCode.Size = new System.Drawing.Size(130, 23);
            this.lblFK_WorkGroupCode.TabIndex = 4;
            this.lblFK_WorkGroupCode.Text = "گروه کاري";
            this.lblFK_WorkGroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(237, 20);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserID.Size = new System.Drawing.Size(130, 23);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "شناسه کاربر";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdition,
            this.tsmiSearch,
            this.tsmiPrint,
            this.tsmiQuit});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 40);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenuStrip.Size = new System.Drawing.Size(744, 24);
            this.msMenuStrip.TabIndex = 1;
            // 
            // tsmiEdition
            // 
            this.tsmiEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDBInsert,
            this.tsmiDBEdit,
            this.tsmiDBDelete,
            this.tssSeparator1,
            this.tsmiDBPost,
            this.tsmiDBCancel});
            this.tsmiEdition.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdition.Image")));
            this.tsmiEdition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiEdition.Name = "tsmiEdition";
            this.tsmiEdition.ShortcutKeyDisplayString = "و";
            this.tsmiEdition.ShowShortcutKeys = false;
            this.tsmiEdition.Size = new System.Drawing.Size(74, 20);
            this.tsmiEdition.Text = "ویرایش";
            // 
            // tsmiDBInsert
            // 
            this.tsmiDBInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBInsert.Image")));
            this.tsmiDBInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBInsert.Name = "tsmiDBInsert";
            this.tsmiDBInsert.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.tsmiDBInsert.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBInsert.Text = "جدید";
            this.tsmiDBInsert.Click += new System.EventHandler(this.tsbDBInsert_Click);
            // 
            // tsmiDBEdit
            // 
            this.tsmiDBEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBEdit.Image")));
            this.tsmiDBEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBEdit.Name = "tsmiDBEdit";
            this.tsmiDBEdit.ShortcutKeyDisplayString = "";
            this.tsmiDBEdit.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBEdit.Text = "ویرایش";
            this.tsmiDBEdit.Click += new System.EventHandler(this.tsbDBInsert_Click);
            // 
            // tsmiDBDelete
            // 
            this.tsmiDBDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBDelete.Image")));
            this.tsmiDBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBDelete.Name = "tsmiDBDelete";
            this.tsmiDBDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiDBDelete.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBDelete.Text = "حذف";
            this.tsmiDBDelete.Click += new System.EventHandler(this.tsbDBDelete_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // tsmiDBPost
            // 
            this.tsmiDBPost.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBPost.Image")));
            this.tsmiDBPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBPost.Name = "tsmiDBPost";
            this.tsmiDBPost.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiDBPost.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBPost.Text = "ثبت";
            this.tsmiDBPost.Click += new System.EventHandler(this.tsbDBPost_Click);
            // 
            // tsmiDBCancel
            // 
            this.tsmiDBCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBCancel.Image")));
            this.tsmiDBCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBCancel.Name = "tsmiDBCancel";
            this.tsmiDBCancel.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBCancel.Text = "انصراف";
            this.tsmiDBCancel.Click += new System.EventHandler(this.tsbDBCancel_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDBFind,
            this.tsmiDBFindNext,
            this.tssSeparator2,
            this.tsmiDBFilter});
            this.tsmiSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSearch.Image")));
            this.tsmiSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(79, 20);
            this.tsmiSearch.Text = "جستجو";
            this.tsmiSearch.Visible = false;
            // 
            // tsmiDBFind
            // 
            this.tsmiDBFind.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBFind.Image")));
            this.tsmiDBFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBFind.Name = "tsmiDBFind";
            this.tsmiDBFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiDBFind.Size = new System.Drawing.Size(185, 22);
            this.tsmiDBFind.Text = "جستجو";
            // 
            // tsmiDBFindNext
            // 
            this.tsmiDBFindNext.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBFindNext.Image")));
            this.tsmiDBFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBFindNext.Name = "tsmiDBFindNext";
            this.tsmiDBFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiDBFindNext.Size = new System.Drawing.Size(185, 22);
            this.tsmiDBFindNext.Text = "جستجوی مجدد";
            // 
            // tssSeparator2
            // 
            this.tssSeparator2.Name = "tssSeparator2";
            this.tssSeparator2.Size = new System.Drawing.Size(182, 6);
            this.tssSeparator2.Visible = false;
            // 
            // tsmiDBFilter
            // 
            this.tsmiDBFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBFilter.Image")));
            this.tsmiDBFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBFilter.Name = "tsmiDBFilter";
            this.tsmiDBFilter.Size = new System.Drawing.Size(185, 22);
            this.tsmiDBFilter.Text = "فیلترسازی";
            this.tsmiDBFilter.Visible = false;
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrintPreview,
            this.tsmiDataPrint});
            this.tsmiPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPrint.Image")));
            this.tsmiPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(60, 20);
            this.tsmiPrint.Text = "چاپ";
            // 
            // tsmiPrintPreview
            // 
            this.tsmiPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPrintPreview.Image")));
            this.tsmiPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPrintPreview.Name = "tsmiPrintPreview";
            this.tsmiPrintPreview.Size = new System.Drawing.Size(143, 22);
            this.tsmiPrintPreview.Text = "پیش نمایش";
            // 
            // tsmiDataPrint
            // 
            this.tsmiDataPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDataPrint.Image")));
            this.tsmiDataPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDataPrint.Name = "tsmiDataPrint";
            this.tsmiDataPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiDataPrint.Size = new System.Drawing.Size(143, 22);
            this.tsmiDataPrint.Text = "چاپ";
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.tsmiQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuit.Image")));
            this.tsmiQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.ShortcutKeyDisplayString = "";
            this.tsmiQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiQuit.Size = new System.Drawing.Size(63, 20);
            this.tsmiQuit.Text = "خروج";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClose.Image")));
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiClose.Size = new System.Drawing.Size(153, 22);
            this.tsmiClose.Text = "بستن";
            this.tsmiClose.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // ttToolTip
            // 
            this.ttToolTip.IsBalloon = true;
            this.ttToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tsToolStrip
            // 
            this.tsToolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDBInsert,
            this.tsbDBEdit,
            this.tsbDBDelete,
            this.tsbDBPost,
            this.tsbDBCancel,
            this.tssSeparator3,
            this.tsbDBFind,
            this.tsbDBFindNext,
            this.tsbDBFilter,
            this.tssSeparator4,
            this.tsbPrintPreview,
            this.tsbDataPrint,
            this.tssSeparator5,
            this.tsbQuit});
            this.tsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsToolStrip.Location = new System.Drawing.Point(0, 64);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(744, 39);
            this.tsToolStrip.TabIndex = 2;
            // 
            // tsbDBInsert
            // 
            this.tsbDBInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBInsert.Image")));
            this.tsbDBInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBInsert.Name = "tsbDBInsert";
            this.tsbDBInsert.Size = new System.Drawing.Size(39, 36);
            this.tsbDBInsert.Text = "جدید";
            this.tsbDBInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBInsert.ToolTipText = "اضافه نمودن اطلاعات جدید";
            this.tsbDBInsert.Click += new System.EventHandler(this.tsbDBInsert_Click);
            // 
            // tsbDBEdit
            // 
            this.tsbDBEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBEdit.Image")));
            this.tsbDBEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBEdit.Name = "tsbDBEdit";
            this.tsbDBEdit.Size = new System.Drawing.Size(50, 36);
            this.tsbDBEdit.Text = "ویرایش";
            this.tsbDBEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBEdit.ToolTipText = "ویرایش اطلاعات جاری";
            this.tsbDBEdit.Click += new System.EventHandler(this.tsbDBInsert_Click);
            // 
            // tsbDBDelete
            // 
            this.tsbDBDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBDelete.Image")));
            this.tsbDBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBDelete.Name = "tsbDBDelete";
            this.tsbDBDelete.Size = new System.Drawing.Size(39, 36);
            this.tsbDBDelete.Text = "حذف";
            this.tsbDBDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBDelete.ToolTipText = "حذف اطلاعات جاری";
            this.tsbDBDelete.Click += new System.EventHandler(this.tsbDBDelete_Click);
            // 
            // tsbDBPost
            // 
            this.tsbDBPost.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBPost.Image")));
            this.tsbDBPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBPost.Name = "tsbDBPost";
            this.tsbDBPost.Size = new System.Drawing.Size(33, 36);
            this.tsbDBPost.Text = "ثبت";
            this.tsbDBPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBPost.ToolTipText = "ثبت اطلاعات جاری";
            this.tsbDBPost.Click += new System.EventHandler(this.tsbDBPost_Click);
            // 
            // tsbDBCancel
            // 
            this.tsbDBCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBCancel.Image")));
            this.tsbDBCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBCancel.Name = "tsbDBCancel";
            this.tsbDBCancel.Size = new System.Drawing.Size(48, 36);
            this.tsbDBCancel.Text = "انصراف";
            this.tsbDBCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBCancel.ToolTipText = "انصراف از ثبت اطلاعات جاری";
            this.tsbDBCancel.Click += new System.EventHandler(this.tsbDBCancel_Click);
            // 
            // tssSeparator3
            // 
            this.tssSeparator3.Name = "tssSeparator3";
            this.tssSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbDBFind
            // 
            this.tsbDBFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBFind.Image")));
            this.tsbDBFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBFind.Name = "tsbDBFind";
            this.tsbDBFind.Size = new System.Drawing.Size(55, 36);
            this.tsbDBFind.Text = "جستجو";
            this.tsbDBFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBFind.ToolTipText = "جستجوی اطلاعات";
            this.tsbDBFind.Visible = false;
            // 
            // tsbDBFindNext
            // 
            this.tsbDBFindNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBFindNext.Image")));
            this.tsbDBFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBFindNext.Name = "tsbDBFindNext";
            this.tsbDBFindNext.Size = new System.Drawing.Size(71, 36);
            this.tsbDBFindNext.Text = "جستجو ...";
            this.tsbDBFindNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBFindNext.ToolTipText = "جستجوی مجدد اطلاعات";
            this.tsbDBFindNext.Visible = false;
            // 
            // tsbDBFilter
            // 
            this.tsbDBFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBFilter.Image")));
            this.tsbDBFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDBFilter.Name = "tsbDBFilter";
            this.tsbDBFilter.Size = new System.Drawing.Size(37, 36);
            this.tsbDBFilter.Text = "فیلتر";
            this.tsbDBFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDBFilter.ToolTipText = "فیلتر کردن اطلاعات";
            this.tsbDBFilter.Visible = false;
            // 
            // tssSeparator4
            // 
            this.tssSeparator4.Name = "tssSeparator4";
            this.tssSeparator4.Size = new System.Drawing.Size(6, 39);
            this.tssSeparator4.Visible = false;
            // 
            // tsbPrintPreview
            // 
            this.tsbPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintPreview.Image")));
            this.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreview.Name = "tsbPrintPreview";
            this.tsbPrintPreview.Size = new System.Drawing.Size(79, 36);
            this.tsbPrintPreview.Text = "پیش نمایش";
            this.tsbPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrintPreview.ToolTipText = "پیش نمایش چاپ";
            // 
            // tsbDataPrint
            // 
            this.tsbDataPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbDataPrint.Image")));
            this.tsbDataPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDataPrint.Name = "tsbDataPrint";
            this.tsbDataPrint.Size = new System.Drawing.Size(36, 36);
            this.tsbDataPrint.Text = "چاپ";
            this.tsbDataPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDataPrint.ToolTipText = "چاپ اطلاعات";
            // 
            // tssSeparator5
            // 
            this.tssSeparator5.Name = "tssSeparator5";
            this.tssSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbQuit
            // 
            this.tsbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuit.Image")));
            this.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuit.Name = "tsbQuit";
            this.tsbQuit.Size = new System.Drawing.Size(39, 36);
            this.tsbQuit.Text = "خروج";
            this.tsbQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbQuit.ToolTipText = "بستن فرم جاری";
            this.tsbQuit.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.Black;
            //this.lblCaption.Image = global::MAP_PBG_Client.Properties.Resources.Banner2;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(744, 40);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.UseCompatibleTextRendering = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 453);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDataGridView);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.msMenuStrip);
            this.Controls.Add(this.lblCaption);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmUser_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTableStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordNumber;
        private System.Windows.Forms.GroupBox gbDetails;
        internal NumericTextBox ntbFK_WorkGroupCode;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Button btn_WorkGroup;
        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.ComboBox cbFK_WorkGroupCode;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblFK_WorkGroupCode;
        private System.Windows.Forms.Label lblUserID;
        internal System.Windows.Forms.MenuStrip msMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem tsmiEdition;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBInsert;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBEdit;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBDelete;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBPost;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBCancel;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBFind;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBFindNext;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBFilter;
        internal System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        internal System.Windows.Forms.ToolStripMenuItem tsmiPrintPreview;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDataPrint;
        internal System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        internal System.Windows.Forms.ToolStrip tsToolStrip;
        internal System.Windows.Forms.ToolStripButton tsbDBInsert;
        internal System.Windows.Forms.ToolStripButton tsbDBEdit;
        internal System.Windows.Forms.ToolStripButton tsbDBDelete;
        internal System.Windows.Forms.ToolStripButton tsbDBPost;
        internal System.Windows.Forms.ToolStripButton tsbDBCancel;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbDBFind;
        internal System.Windows.Forms.ToolStripButton tsbDBFindNext;
        internal System.Windows.Forms.ToolStripButton tsbDBFilter;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator4;
        internal System.Windows.Forms.ToolStripButton tsbPrintPreview;
        internal System.Windows.Forms.ToolStripButton tsbDataPrint;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator5;
        internal System.Windows.Forms.ToolStripButton tsbQuit;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}