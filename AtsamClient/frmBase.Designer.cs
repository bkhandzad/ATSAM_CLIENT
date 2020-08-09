namespace AtsamClient
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.lblCaption = new System.Windows.Forms.Label();
            this.tsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tssSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tssSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTableStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRecordNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.ntbBaseCode = new NumericTextBox();
            this.txtBaseName = new System.Windows.Forms.TextBox();
            this.lblBaseName = new System.Windows.Forms.Label();
            this.lblBaseCode = new System.Windows.Forms.Label();
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.ppdprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdprintDocument = new System.Drawing.Printing.PrintDocument();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsbDBInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbDBEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDBDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbDBPost = new System.Windows.Forms.ToolStripButton();
            this.tsbDBCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFind = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFindNext = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFilter = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbDataPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.tsbPermission = new System.Windows.Forms.ToolStripButton();
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
            this.tsToolStrip.SuspendLayout();
            this.msMenuStrip.SuspendLayout();
            this.ssStatusStrip.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.Black;
            //this.lblCaption.Image = global::MAP_LGC_Client.Properties.Resources.Banner2;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(744, 40);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.UseCompatibleTextRendering = true;
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
            this.tsbExportToExcel,
            this.tssSeparator5,
            this.tsbQuit,
            this.tsbPermission});
            this.tsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsToolStrip.Location = new System.Drawing.Point(0, 64);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(744, 39);
            this.tsToolStrip.TabIndex = 2;
            // 
            // tssSeparator3
            // 
            this.tssSeparator3.Name = "tssSeparator3";
            this.tssSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tssSeparator4
            // 
            this.tssSeparator4.Name = "tssSeparator4";
            this.tssSeparator4.Size = new System.Drawing.Size(6, 39);
            this.tssSeparator4.Visible = false;
            // 
            // tssSeparator5
            // 
            this.tssSeparator5.Name = "tssSeparator5";
            this.tssSeparator5.Size = new System.Drawing.Size(6, 39);
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
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTableStatus,
            this.tsslRecordNumber});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 361);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(744, 25);
            this.ssStatusStrip.SizingGrip = false;
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
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.ntbBaseCode);
            this.gbDetails.Controls.Add(this.txtBaseName);
            this.gbDetails.Controls.Add(this.lblBaseName);
            this.gbDetails.Controls.Add(this.lblBaseCode);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 103);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(744, 53);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            // 
            // ntbBaseCode
            // 
            this.ntbBaseCode.AllowDecimalSeparator = false;
            this.ntbBaseCode.AllowGroupSeparator = false;
            this.ntbBaseCode.AllowNegativeSign = false;
            this.ntbBaseCode.AllowSpace = false;
            this.ntbBaseCode.BackColor = System.Drawing.Color.White;
            this.ntbBaseCode.CausesValidation = false;
            this.ntbBaseCode.DecimalLength = 0;
            this.ntbBaseCode.Location = new System.Drawing.Point(377, 20);
            this.ntbBaseCode.Name = "ntbBaseCode";
            this.ntbBaseCode.Size = new System.Drawing.Size(225, 23);
            this.ntbBaseCode.TabIndex = 1;
            this.ntbBaseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbBaseCode.ValidationChecked = false;
            this.ntbBaseCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseCode_KeyPress);
            // 
            // txtBaseName
            // 
            this.txtBaseName.BackColor = System.Drawing.Color.White;
            this.txtBaseName.Location = new System.Drawing.Point(10, 20);
            this.txtBaseName.MaxLength = 0;
            this.txtBaseName.Name = "txtBaseName";
            this.txtBaseName.Size = new System.Drawing.Size(225, 23);
            this.txtBaseName.TabIndex = 3;
            this.txtBaseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaseName_KeyPress);
            // 
            // lblBaseName
            // 
            this.lblBaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaseName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBaseName.ForeColor = System.Drawing.Color.Black;
            this.lblBaseName.Location = new System.Drawing.Point(237, 20);
            this.lblBaseName.Name = "lblBaseName";
            this.lblBaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBaseName.Size = new System.Drawing.Size(130, 23);
            this.lblBaseName.TabIndex = 2;
            this.lblBaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBaseCode
            // 
            this.lblBaseCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBaseCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaseCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBaseCode.ForeColor = System.Drawing.Color.Black;
            this.lblBaseCode.Location = new System.Drawing.Point(604, 20);
            this.lblBaseCode.Name = "lblBaseCode";
            this.lblBaseCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBaseCode.Size = new System.Drawing.Size(130, 23);
            this.lblBaseCode.TabIndex = 0;
            this.lblBaseCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.ilImageList.Images.SetKeyName(0, "Bullets.bmp");
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
            this.dgvDataGridView.Location = new System.Drawing.Point(0, 161);
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
            this.dgvDataGridView.DoubleClick += new System.EventHandler(this.dgvDataGridView_DoubleClick);
            this.dgvDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDataGridView_KeyPress);
            // 
            // ppdprintPreviewDialog
            // 
            this.ppdprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdprintPreviewDialog.Document = this.pdprintDocument;
            this.ppdprintPreviewDialog.Enabled = true;
            this.ppdprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdprintPreviewDialog.Icon")));
            this.ppdprintPreviewDialog.Name = "printPreviewDialog1";
            this.ppdprintPreviewDialog.Visible = false;
            // 
            // pdprintDocument
            // 
            this.pdprintDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.pdprintDocument_BeginPrint);
            this.pdprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdprintDocument_PrintPage);
            // 
            // ttToolTip
            // 
            this.ttToolTip.IsBalloon = true;
            this.ttToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
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
            this.tsbDataPrint.Click += new System.EventHandler(this.tsbDataPrint_Click);
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
            // tsbPermission
            // 
            this.tsbPermission.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbPermission.Image = ((System.Drawing.Image)(resources.GetObject("tsbPermission.Image")));
            this.tsbPermission.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPermission.Name = "tsbPermission";
            this.tsbPermission.Size = new System.Drawing.Size(102, 36);
            this.tsbPermission.Text = "سطح دسترسي";
            this.tsbPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPermission.ToolTipText = "تعيين سطوح دسترسي";
            this.tsbPermission.Visible = false;
            this.tsbPermission.Click += new System.EventHandler(this.tsbPermission_Click);
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
            this.tsmiDBEdit.Text = "اصلاح";
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
            this.tsmiDBFilter.Text = "فیلتر";
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
            this.tsmiPrintPreview.Click += new System.EventHandler(this.tsbPrintPreview_Click);
            // 
            // tsmiDataPrint
            // 
            this.tsmiDataPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDataPrint.Image")));
            this.tsmiDataPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDataPrint.Name = "tsmiDataPrint";
            this.tsmiDataPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiDataPrint.Size = new System.Drawing.Size(143, 22);
            this.tsmiDataPrint.Text = "چاپ";
            this.tsmiDataPrint.Click += new System.EventHandler(this.tsbDataPrint_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.tsmiQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuit.Image")));
            this.tsmiQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.ShortcutKeyDisplayString = "";
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
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 386);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDataGridView);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.msMenuStrip);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.lblCaption);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBase_KeyPress);
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
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
        internal System.Windows.Forms.ToolStripButton tsbPermission;
        internal System.Windows.Forms.ToolStripButton tsbQuit;
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
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTableStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordNumber;
        private System.Windows.Forms.GroupBox gbDetails;
        internal NumericTextBox ntbBaseCode;
        private System.Windows.Forms.TextBox txtBaseName;
        private System.Windows.Forms.Label lblBaseName;
        private System.Windows.Forms.Label lblBaseCode;
        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.PrintPreviewDialog ppdprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument pdprintDocument;
        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.ToolStripButton tsbExportToExcel;
    }
}