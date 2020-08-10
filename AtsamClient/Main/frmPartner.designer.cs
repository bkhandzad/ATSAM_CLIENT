namespace AtsamClient.Main
{
    partial class frmPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartner));
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ppdprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTableStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRecordNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPartner = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPartner = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPK_PartnerCode = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblPK_PartnerCode = new System.Windows.Forms.Label();
            this.tsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbDBInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbDBEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDBDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbDBPost = new System.Windows.Forms.ToolStripButton();
            this.tsbDBCancel = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDBFind = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFindNext = new System.Windows.Forms.ToolStripButton();
            this.tsbDBFilter = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbDataPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.ssStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.tsToolStrip.SuspendLayout();
            this.msMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.ilImageList.Images.SetKeyName(0, "Bullets.bmp");
            // 
            // ttToolTip
            // 
            this.ttToolTip.IsBalloon = true;
            this.ttToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttToolTip.ToolTipTitle = "راهنما";
            // 
            // ppdprintPreviewDialog
            // 
            this.ppdprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdprintPreviewDialog.Enabled = true;
            this.ppdprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdprintPreviewDialog.Icon")));
            this.ppdprintPreviewDialog.Name = "printPreviewDialog1";
            this.ppdprintPreviewDialog.Visible = false;
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.AutoSize = false;
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserName,
            this.tsslTableStatus,
            this.tsslRecordNumber});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 470);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(1120, 24);
            this.ssStatusStrip.SizingGrip = false;
            this.ssStatusStrip.TabIndex = 5;
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
            this.tsslUserName.Size = new System.Drawing.Size(200, 19);
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
            this.tsslTableStatus.Size = new System.Drawing.Size(845, 19);
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
            this.tsslRecordNumber.Size = new System.Drawing.Size(60, 19);
            this.tsslRecordNumber.Text = "تعداد رکورد";
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
            this.dgvDataGridView.Location = new System.Drawing.Point(0, 220);
            this.dgvDataGridView.MultiSelect = false;
            this.dgvDataGridView.Name = "dgvDataGridView";
            this.dgvDataGridView.ReadOnly = true;
            this.dgvDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataGridView.ShowCellErrors = false;
            this.dgvDataGridView.ShowRowErrors = false;
            this.dgvDataGridView.Size = new System.Drawing.Size(1120, 250);
            this.dgvDataGridView.TabIndex = 4;
            this.dgvDataGridView.DataSourceChanged += new System.EventHandler(this.dgvDataGridView_DataSourceChanged);
            this.dgvDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataGridView_ColumnHeaderMouseClick);
            this.dgvDataGridView.DoubleClick += new System.EventHandler(this.dgvDataGridView_DoubleClick);
            this.dgvDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDataGridView_KeyPress);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbAccountNumber);
            this.gbDetails.Controls.Add(this.tbCellPhone);
            this.gbDetails.Controls.Add(this.tbPostalCode);
            this.gbDetails.Controls.Add(this.tbPhone);
            this.gbDetails.Controls.Add(this.tbDescription);
            this.gbDetails.Controls.Add(this.tbAddress);
            this.gbDetails.Controls.Add(this.tbPartner);
            this.gbDetails.Controls.Add(this.lblPostalCode);
            this.gbDetails.Controls.Add(this.lblPartner);
            this.gbDetails.Controls.Add(this.lblPhone);
            this.gbDetails.Controls.Add(this.tbPK_PartnerCode);
            this.gbDetails.Controls.Add(this.lblAddress);
            this.gbDetails.Controls.Add(this.lblAccountNumber);
            this.gbDetails.Controls.Add(this.lblDescription);
            this.gbDetails.Controls.Add(this.lblCellPhone);
            this.gbDetails.Controls.Add(this.lblPK_PartnerCode);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 103);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(1120, 111);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.BackColor = System.Drawing.Color.White;
            this.tbAccountNumber.Location = new System.Drawing.Point(377, 48);
            this.tbAccountNumber.MaxLength = 0;
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(225, 23);
            this.tbAccountNumber.TabIndex = 11;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.BackColor = System.Drawing.Color.White;
            this.tbCellPhone.Location = new System.Drawing.Point(377, 15);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(225, 23);
            this.tbCellPhone.TabIndex = 19;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.BackColor = System.Drawing.Color.White;
            this.tbPostalCode.Location = new System.Drawing.Point(7, 15);
            this.tbPostalCode.MaxLength = 0;
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(225, 23);
            this.tbPostalCode.TabIndex = 9;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(747, 81);
            this.tbPhone.MaxLength = 0;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(225, 23);
            this.tbPhone.TabIndex = 13;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(7, 48);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(225, 23);
            this.tbDescription.TabIndex = 21;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.Location = new System.Drawing.Point(7, 81);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(595, 23);
            this.tbAddress.TabIndex = 15;
            // 
            // tbPartner
            // 
            this.tbPartner.BackColor = System.Drawing.Color.White;
            this.tbPartner.Location = new System.Drawing.Point(747, 48);
            this.tbPartner.Name = "tbPartner";
            this.tbPartner.Size = new System.Drawing.Size(225, 23);
            this.tbPartner.TabIndex = 3;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPostalCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPostalCode.ForeColor = System.Drawing.Color.Black;
            this.lblPostalCode.Location = new System.Drawing.Point(237, 15);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPostalCode.Size = new System.Drawing.Size(130, 23);
            this.lblPostalCode.TabIndex = 8;
            this.lblPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartner
            // 
            this.lblPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPartner.ForeColor = System.Drawing.Color.Black;
            this.lblPartner.Location = new System.Drawing.Point(977, 48);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPartner.Size = new System.Drawing.Size(130, 23);
            this.lblPartner.TabIndex = 2;
            this.lblPartner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(977, 81);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(130, 23);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPK_PartnerCode
            // 
            this.tbPK_PartnerCode.BackColor = System.Drawing.Color.White;
            this.tbPK_PartnerCode.Location = new System.Drawing.Point(747, 15);
            this.tbPK_PartnerCode.Name = "tbPK_PartnerCode";
            this.tbPK_PartnerCode.Size = new System.Drawing.Size(225, 23);
            this.tbPK_PartnerCode.TabIndex = 1;
            this.tbPK_PartnerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(607, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(130, 23);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNumber.Location = new System.Drawing.Point(607, 48);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAccountNumber.Size = new System.Drawing.Size(130, 23);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(237, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(130, 23);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCellPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCellPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCellPhone.Location = new System.Drawing.Point(607, 15);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCellPhone.Size = new System.Drawing.Size(130, 23);
            this.lblCellPhone.TabIndex = 18;
            this.lblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPK_PartnerCode
            // 
            this.lblPK_PartnerCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPK_PartnerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPK_PartnerCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPK_PartnerCode.ForeColor = System.Drawing.Color.Black;
            this.lblPK_PartnerCode.Location = new System.Drawing.Point(977, 15);
            this.lblPK_PartnerCode.Name = "lblPK_PartnerCode";
            this.lblPK_PartnerCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPK_PartnerCode.Size = new System.Drawing.Size(130, 23);
            this.lblPK_PartnerCode.TabIndex = 0;
            this.lblPK_PartnerCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tssSeparator2,
            this.tsbDBFind,
            this.tsbDBFindNext,
            this.tsbDBFilter,
            this.tssSeparator4,
            this.tsbPrintPreview,
            this.tsbDataPrint,
            this.tsbExportToExcel,
            this.tssSeparator3,
            this.tsbQuit});
            this.tsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsToolStrip.Location = new System.Drawing.Point(0, 64);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(1120, 39);
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
            // tssSeparator2
            // 
            this.tssSeparator2.Name = "tssSeparator2";
            this.tssSeparator2.Size = new System.Drawing.Size(6, 39);
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
            // tssSeparator3
            // 
            this.tssSeparator3.Name = "tssSeparator3";
            this.tssSeparator3.Size = new System.Drawing.Size(6, 39);
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
            this.msMenuStrip.Size = new System.Drawing.Size(1120, 24);
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
            // 
            // tsmiDBEdit
            // 
            this.tsmiDBEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBEdit.Image")));
            this.tsmiDBEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBEdit.Name = "tsmiDBEdit";
            this.tsmiDBEdit.ShortcutKeyDisplayString = "";
            this.tsmiDBEdit.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBEdit.Text = "ویرایش";
            // 
            // tsmiDBDelete
            // 
            this.tsmiDBDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBDelete.Image")));
            this.tsmiDBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBDelete.Name = "tsmiDBDelete";
            this.tsmiDBDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiDBDelete.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBDelete.Text = "حذف";
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
            // 
            // tsmiDBCancel
            // 
            this.tsmiDBCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDBCancel.Image")));
            this.tsmiDBCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDBCancel.Name = "tsmiDBCancel";
            this.tsmiDBCancel.Size = new System.Drawing.Size(157, 22);
            this.tsmiDBCancel.Text = "انصراف";
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
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(1120, 40);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1120, 494);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDataGridView);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.msMenuStrip);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.ssStatusStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPartner";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTree_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCustomer_KeyPress);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.PrintPreviewDialog ppdprintPreviewDialog;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslTableStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordNumber;
        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.GroupBox gbDetails;
        internal System.Windows.Forms.ToolStrip tsToolStrip;
        internal System.Windows.Forms.ToolStripButton tsbDBInsert;
        internal System.Windows.Forms.ToolStripButton tsbDBEdit;
        internal System.Windows.Forms.ToolStripButton tsbDBDelete;
        internal System.Windows.Forms.ToolStripButton tsbDBPost;
        internal System.Windows.Forms.ToolStripButton tsbDBCancel;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator2;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator4;
        internal System.Windows.Forms.ToolStripButton tsbPrintPreview;
        internal System.Windows.Forms.ToolStripButton tsbDataPrint;
        private System.Windows.Forms.ToolStripButton tsbExportToExcel;
        internal System.Windows.Forms.ToolStripSeparator tssSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbQuit;
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
        private System.Windows.Forms.Label lblCaption;
        internal System.Windows.Forms.ToolStripButton tsbDBFind;
        internal System.Windows.Forms.ToolStripButton tsbDBFindNext;
        internal System.Windows.Forms.ToolStripButton tsbDBFilter;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPartner;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.TextBox tbPK_PartnerCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblPK_PartnerCode;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.TextBox tbCellPhone;
    }
}