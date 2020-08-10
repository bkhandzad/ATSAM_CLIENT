namespace AtsamClient.Main
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.iImageList = new System.Windows.Forms.ImageList(this.components);
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.ntbPK_ProductCode = new NumericTextBox();
            this.btnb_YarnType = new System.Windows.Forms.Button();
            this.cbFK_YarnTypeCode = new System.Windows.Forms.ComboBox();
            this.ntbFK_YarnTypeCode = new NumericTextBox();
            this.lblFK_YarnTypeCode = new System.Windows.Forms.Label();
            this.lblPK_ProductCode = new System.Windows.Forms.Label();
            this.btnb_YarnKind = new System.Windows.Forms.Button();
            this.cbFK_YarnKindCode = new System.Windows.Forms.ComboBox();
            this.ntbFK_YarnKindCode = new NumericTextBox();
            this.lblFK_YarnKindCode = new System.Windows.Forms.Label();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTableStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRecordNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDBPost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDBCancel = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbDataPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.gbDetails.SuspendLayout();
            this.ssStatusStrip.SuspendLayout();
            this.msMenuStrip.SuspendLayout();
            this.tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbProduct);
            this.gbDetails.Controls.Add(this.lblProduct);
            this.gbDetails.Controls.Add(this.ntbPK_ProductCode);
            this.gbDetails.Controls.Add(this.btnb_YarnType);
            this.gbDetails.Controls.Add(this.cbFK_YarnTypeCode);
            this.gbDetails.Controls.Add(this.ntbFK_YarnTypeCode);
            this.gbDetails.Controls.Add(this.lblFK_YarnTypeCode);
            this.gbDetails.Controls.Add(this.lblPK_ProductCode);
            this.gbDetails.Controls.Add(this.btnb_YarnKind);
            this.gbDetails.Controls.Add(this.cbFK_YarnKindCode);
            this.gbDetails.Controls.Add(this.ntbFK_YarnKindCode);
            this.gbDetails.Controls.Add(this.lblFK_YarnKindCode);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 103);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(740, 87);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            // 
            // iImageList
            // 
            this.iImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iImageList.ImageStream")));
            this.iImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.iImageList.Images.SetKeyName(0, "Bullets.bmp");
            this.iImageList.Images.SetKeyName(1, "Calculator-Edit-32.png");
            this.iImageList.Images.SetKeyName(2, "Calendar_scheduleHS.png");
            this.iImageList.Images.SetKeyName(3, "Check.png");
            this.iImageList.Images.SetKeyName(4, "padlock.jpg");
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(372, 51);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(225, 23);
            this.tbProduct.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(600, 51);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProduct.Size = new System.Drawing.Size(130, 23);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ntbPK_ProductCode
            // 
            this.ntbPK_ProductCode.AllowDecimalSeparator = false;
            this.ntbPK_ProductCode.AllowGroupSeparator = false;
            this.ntbPK_ProductCode.AllowNegativeSign = false;
            this.ntbPK_ProductCode.AllowSpace = false;
            this.ntbPK_ProductCode.BackColor = System.Drawing.Color.White;
            this.ntbPK_ProductCode.DecimalLength = 0;
            this.ntbPK_ProductCode.Location = new System.Drawing.Point(372, 19);
            this.ntbPK_ProductCode.Name = "ntbPK_ProductCode";
            this.ntbPK_ProductCode.Size = new System.Drawing.Size(225, 23);
            this.ntbPK_ProductCode.TabIndex = 1;
            this.ntbPK_ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbPK_ProductCode.ValidationChecked = true;
            // 
            // btnb_YarnType
            // 
            this.btnb_YarnType.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnb_YarnType.ImageIndex = 0;
            this.btnb_YarnType.ImageList = this.iImageList;
            this.btnb_YarnType.Location = new System.Drawing.Point(8, 18);
            this.btnb_YarnType.Name = "btnb_YarnType";
            this.btnb_YarnType.Size = new System.Drawing.Size(28, 23);
            this.btnb_YarnType.TabIndex = 7;
            this.btnb_YarnType.UseVisualStyleBackColor = true;
            // 
            // cbFK_YarnTypeCode
            // 
            this.cbFK_YarnTypeCode.BackColor = System.Drawing.Color.White;
            this.cbFK_YarnTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFK_YarnTypeCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFK_YarnTypeCode.FormattingEnabled = true;
            this.cbFK_YarnTypeCode.Location = new System.Drawing.Point(37, 18);
            this.cbFK_YarnTypeCode.Name = "cbFK_YarnTypeCode";
            this.cbFK_YarnTypeCode.Size = new System.Drawing.Size(144, 24);
            this.cbFK_YarnTypeCode.TabIndex = 6;
            // 
            // ntbFK_YarnTypeCode
            // 
            this.ntbFK_YarnTypeCode.AllowDecimalSeparator = false;
            this.ntbFK_YarnTypeCode.AllowGroupSeparator = false;
            this.ntbFK_YarnTypeCode.AllowNegativeSign = false;
            this.ntbFK_YarnTypeCode.AllowSpace = false;
            this.ntbFK_YarnTypeCode.BackColor = System.Drawing.Color.White;
            this.ntbFK_YarnTypeCode.DecimalLength = 0;
            this.ntbFK_YarnTypeCode.Location = new System.Drawing.Point(183, 18);
            this.ntbFK_YarnTypeCode.Name = "ntbFK_YarnTypeCode";
            this.ntbFK_YarnTypeCode.Size = new System.Drawing.Size(50, 23);
            this.ntbFK_YarnTypeCode.TabIndex = 5;
            this.ntbFK_YarnTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbFK_YarnTypeCode.ValidationChecked = true;
            // 
            // lblFK_YarnTypeCode
            // 
            this.lblFK_YarnTypeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFK_YarnTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFK_YarnTypeCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFK_YarnTypeCode.ForeColor = System.Drawing.Color.Black;
            this.lblFK_YarnTypeCode.Location = new System.Drawing.Point(236, 18);
            this.lblFK_YarnTypeCode.Name = "lblFK_YarnTypeCode";
            this.lblFK_YarnTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFK_YarnTypeCode.Size = new System.Drawing.Size(130, 23);
            this.lblFK_YarnTypeCode.TabIndex = 4;
            this.lblFK_YarnTypeCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPK_ProductCode
            // 
            this.lblPK_ProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPK_ProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPK_ProductCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPK_ProductCode.ForeColor = System.Drawing.Color.Black;
            this.lblPK_ProductCode.Location = new System.Drawing.Point(600, 19);
            this.lblPK_ProductCode.Name = "lblPK_ProductCode";
            this.lblPK_ProductCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPK_ProductCode.Size = new System.Drawing.Size(130, 23);
            this.lblPK_ProductCode.TabIndex = 0;
            this.lblPK_ProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnb_YarnKind
            // 
            this.btnb_YarnKind.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnb_YarnKind.ImageIndex = 0;
            this.btnb_YarnKind.ImageList = this.iImageList;
            this.btnb_YarnKind.Location = new System.Drawing.Point(8, 53);
            this.btnb_YarnKind.Name = "btnb_YarnKind";
            this.btnb_YarnKind.Size = new System.Drawing.Size(28, 23);
            this.btnb_YarnKind.TabIndex = 11;
            this.btnb_YarnKind.UseVisualStyleBackColor = true;
            // 
            // cbFK_YarnKindCode
            // 
            this.cbFK_YarnKindCode.BackColor = System.Drawing.Color.White;
            this.cbFK_YarnKindCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFK_YarnKindCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFK_YarnKindCode.FormattingEnabled = true;
            this.cbFK_YarnKindCode.Location = new System.Drawing.Point(37, 53);
            this.cbFK_YarnKindCode.Name = "cbFK_YarnKindCode";
            this.cbFK_YarnKindCode.Size = new System.Drawing.Size(144, 24);
            this.cbFK_YarnKindCode.TabIndex = 10;
            // 
            // ntbFK_YarnKindCode
            // 
            this.ntbFK_YarnKindCode.AllowDecimalSeparator = false;
            this.ntbFK_YarnKindCode.AllowGroupSeparator = false;
            this.ntbFK_YarnKindCode.AllowNegativeSign = false;
            this.ntbFK_YarnKindCode.AllowSpace = false;
            this.ntbFK_YarnKindCode.BackColor = System.Drawing.Color.White;
            this.ntbFK_YarnKindCode.DecimalLength = 0;
            this.ntbFK_YarnKindCode.Location = new System.Drawing.Point(183, 53);
            this.ntbFK_YarnKindCode.Name = "ntbFK_YarnKindCode";
            this.ntbFK_YarnKindCode.Size = new System.Drawing.Size(50, 23);
            this.ntbFK_YarnKindCode.TabIndex = 9;
            this.ntbFK_YarnKindCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbFK_YarnKindCode.ValidationChecked = true;
            // 
            // lblFK_YarnKindCode
            // 
            this.lblFK_YarnKindCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFK_YarnKindCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFK_YarnKindCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFK_YarnKindCode.ForeColor = System.Drawing.Color.Black;
            this.lblFK_YarnKindCode.Location = new System.Drawing.Point(236, 53);
            this.lblFK_YarnKindCode.Name = "lblFK_YarnKindCode";
            this.lblFK_YarnKindCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFK_YarnKindCode.Size = new System.Drawing.Size(130, 23);
            this.lblFK_YarnKindCode.TabIndex = 8;
            this.lblFK_YarnKindCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserName,
            this.tsslTableStatus,
            this.tsslRecordNumber});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 569);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(740, 25);
            this.ssStatusStrip.SizingGrip = false;
            this.ssStatusStrip.TabIndex = 5;
            this.ssStatusStrip.Text = "ssStatusbar";
            // 
            // tsslUserName
            // 
            this.tsslUserName.AutoSize = false;
            this.tsslUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslUserName.ForeColor = System.Drawing.Color.Maroon;
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(200, 20);
            this.tsslUserName.Text = "نام کاربر";
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
            this.tsslTableStatus.Size = new System.Drawing.Size(465, 20);
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
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(740, 40);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdition,
            this.tsmiPrint,
            this.tsmiQuit});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 40);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenuStrip.Size = new System.Drawing.Size(740, 24);
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
            this.tsmiClose.Size = new System.Drawing.Size(147, 22);
            this.tsmiClose.Text = "خروج";
            this.tsmiClose.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // ttToolTip
            // 
            this.ttToolTip.IsBalloon = true;
            this.ttToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttToolTip.ToolTipTitle = "راهنما";
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
            this.tsbPrintPreview,
            this.tsbDataPrint,
            this.tsbExportToExcel,
            this.tssSeparator5,
            this.tsbQuit});
            this.tsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsToolStrip.Location = new System.Drawing.Point(0, 64);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(740, 39);
            this.tsToolStrip.TabIndex = 2;
            // 
            // tsbDBInsert
            // 
            this.tsbDBInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbDBInsert.Image")));
            this.tsbDBInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.tsbDBEdit.Tag = "";
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
            this.tsbDBDelete.Tag = "";
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
            // tsbPrintPreview
            // 
            this.tsbPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintPreview.Image")));
            this.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreview.Name = "tsbPrintPreview";
            this.tsbPrintPreview.Size = new System.Drawing.Size(79, 36);
            this.tsbPrintPreview.Text = "پیش نمایش";
            this.tsbPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrintPreview.ToolTipText = "پیش نمایش چاپ";
            this.tsbPrintPreview.Click += new System.EventHandler(this.tsbPrintPreview_Click);
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
            this.tsbDataPrint.Visible = false;
            // 
            // tsbExportToExcel
            // 
            this.tsbExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportToExcel.Image")));
            this.tsbExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportToExcel.Name = "tsbExportToExcel";
            this.tsbExportToExcel.Size = new System.Drawing.Size(94, 36);
            this.tsbExportToExcel.Text = "انتقال به اکسل";
            this.tsbExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExportToExcel.ToolTipText = "انتقال اطلاعات جاری به اکسل";
            this.tsbExportToExcel.Click += new System.EventHandler(this.tsbExportToExcel_Click);
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
            // dgvDataGridView
            // 
            this.dgvDataGridView.AllowUserToAddRows = false;
            this.dgvDataGridView.AllowUserToDeleteRows = false;
            this.dgvDataGridView.AllowUserToResizeRows = false;
            this.dgvDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataGridView.Location = new System.Drawing.Point(0, 190);
            this.dgvDataGridView.Name = "dgvDataGridView";
            this.dgvDataGridView.ReadOnly = true;
            this.dgvDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataGridView.ShowCellErrors = false;
            this.dgvDataGridView.ShowRowErrors = false;
            this.dgvDataGridView.Size = new System.Drawing.Size(740, 379);
            this.dgvDataGridView.TabIndex = 4;
            this.dgvDataGridView.DataSourceChanged += new System.EventHandler(this.dgvDataGridView_DataSourceChanged);
            this.dgvDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataGridView_ColumnHeaderMouseClick);
            this.dgvDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDataGridView_KeyPress);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 594);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDataGridView);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.msMenuStrip);
            this.Controls.Add(this.lblCaption);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProduct_KeyPress);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslTableStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordNumber;
        private System.Windows.Forms.Label lblCaption;
        internal System.Windows.Forms.MenuStrip msMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem tsmiEdition;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBInsert;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBEdit;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBDelete;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBPost;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDBCancel;
        internal System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        internal System.Windows.Forms.ToolStripMenuItem tsmiPrintPreview;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDataPrint;
        internal System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.Label lblPK_ProductCode;
        private System.Windows.Forms.Button btnb_YarnKind;
        private System.Windows.Forms.ComboBox cbFK_YarnKindCode;
        internal NumericTextBox ntbFK_YarnKindCode;
        private System.Windows.Forms.Label lblFK_YarnKindCode;
        internal System.Windows.Forms.ToolStrip tsToolStrip;
        internal System.Windows.Forms.ToolStripButton tsbDBInsert;
        internal System.Windows.Forms.ToolStripButton tsbDBEdit;
        internal System.Windows.Forms.ToolStripButton tsbDBDelete;
        internal System.Windows.Forms.ToolStripButton tsbDBPost;
        internal System.Windows.Forms.ToolStripButton tsbDBCancel;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbPrintPreview;
        internal System.Windows.Forms.ToolStripButton tsbDataPrint;
        private System.Windows.Forms.ToolStripButton tsbExportToExcel;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator5;
        internal System.Windows.Forms.ToolStripButton tsbQuit;
        private System.Windows.Forms.ImageList iImageList;
        private System.Windows.Forms.Button btnb_YarnType;
        private System.Windows.Forms.ComboBox cbFK_YarnTypeCode;
        internal NumericTextBox ntbFK_YarnTypeCode;
        private System.Windows.Forms.Label lblFK_YarnTypeCode;
        internal NumericTextBox ntbPK_ProductCode;
        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label lblProduct;
    }
}