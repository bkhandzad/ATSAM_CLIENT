namespace AtsamClient.Security
{
    partial class frmPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermission));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.tvTable = new System.Windows.Forms.TreeView();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.chkQuit = new System.Windows.Forms.CheckBox();
            this.chkDataPrint = new System.Windows.Forms.CheckBox();
            this.chkPrintPreview = new System.Windows.Forms.CheckBox();
            this.chkDBFilter = new System.Windows.Forms.CheckBox();
            this.chkDBFindNext = new System.Windows.Forms.CheckBox();
            this.chkDBFind = new System.Windows.Forms.CheckBox();
            this.chkDBCancel = new System.Windows.Forms.CheckBox();
            this.chkDBPost = new System.Windows.Forms.CheckBox();
            this.chkDBDelete = new System.Windows.Forms.CheckBox();
            this.chkDBEdit = new System.Windows.Forms.CheckBox();
            this.chkDBInsert = new System.Windows.Forms.CheckBox();
            this.pnlButtons.SuspendLayout();
            this.gbTable.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnOk);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(10, 380);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(700, 46);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.ImageIndex = 0;
            this.btnOk.ImageList = this.ilImageList;
            this.btnOk.Location = new System.Drawing.Point(400, 6);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "قبول";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.ilImageList.Images.SetKeyName(0, "");
            this.ilImageList.Images.SetKeyName(1, "");
            this.ilImageList.Images.SetKeyName(2, "DatabaseServer.bmp");
            this.ilImageList.Images.SetKeyName(3, "WindowsProject.bmp");
            this.ilImageList.Images.SetKeyName(4, "WebProject.bmp");
            this.ilImageList.Images.SetKeyName(5, "Form.bmp");
            this.ilImageList.Images.SetKeyName(6, "Table.bmp");
            this.ilImageList.Images.SetKeyName(7, "tsmiDBInsert.Image.png");
            this.ilImageList.Images.SetKeyName(8, "tsbDBEdit.Image.png");
            this.ilImageList.Images.SetKeyName(9, "tsbDBDelete.Image.png");
            this.ilImageList.Images.SetKeyName(10, "tsbDBPost.Image.png");
            this.ilImageList.Images.SetKeyName(11, "tsbDBCancel.Image.png");
            this.ilImageList.Images.SetKeyName(12, "tsbDBFind.Image.png");
            this.ilImageList.Images.SetKeyName(13, "tsbDBFindNext.Image.png");
            this.ilImageList.Images.SetKeyName(14, "tsbDBFilter.Image.png");
            this.ilImageList.Images.SetKeyName(15, "tsbPrintPreview.Image.png");
            this.ilImageList.Images.SetKeyName(16, "tsbDataPrint.Image.png");
            this.ilImageList.Images.SetKeyName(17, "tsbQuit.Image.png");
            this.ilImageList.Images.SetKeyName(18, "book_reportHS.png");
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.ilImageList;
            this.btnCancel.Location = new System.Drawing.Point(200, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.tvTable);
            this.gbTable.ForeColor = System.Drawing.Color.Maroon;
            this.gbTable.Location = new System.Drawing.Point(160, 10);
            this.gbTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTable.Name = "gbTable";
            this.gbTable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTable.Size = new System.Drawing.Size(550, 360);
            this.gbTable.TabIndex = 3;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "درختواره سیستم";
            // 
            // tvTable
            // 
            this.tvTable.BackColor = System.Drawing.SystemColors.Control;
            this.tvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvTable.CheckBoxes = true;
            this.tvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tvTable.FullRowSelect = true;
            this.tvTable.HotTracking = true;
            this.tvTable.ImageIndex = 2;
            this.tvTable.ImageList = this.ilImageList;
            this.tvTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvTable.Location = new System.Drawing.Point(3, 20);
            this.tvTable.Name = "tvTable";
            this.tvTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvTable.RightToLeftLayout = true;
            this.tvTable.SelectedImageIndex = 2;
            this.tvTable.Size = new System.Drawing.Size(544, 336);
            this.tvTable.TabIndex = 2;
            this.tvTable.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvTable_AfterCheck);
            this.tvTable.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTable_AfterSelect);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.chkQuit);
            this.gbAction.Controls.Add(this.chkDataPrint);
            this.gbAction.Controls.Add(this.chkPrintPreview);
            this.gbAction.Controls.Add(this.chkDBFilter);
            this.gbAction.Controls.Add(this.chkDBFindNext);
            this.gbAction.Controls.Add(this.chkDBFind);
            this.gbAction.Controls.Add(this.chkDBCancel);
            this.gbAction.Controls.Add(this.chkDBPost);
            this.gbAction.Controls.Add(this.chkDBDelete);
            this.gbAction.Controls.Add(this.chkDBEdit);
            this.gbAction.Controls.Add(this.chkDBInsert);
            this.gbAction.ForeColor = System.Drawing.Color.Maroon;
            this.gbAction.Location = new System.Drawing.Point(10, 10);
            this.gbAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAction.Size = new System.Drawing.Size(144, 360);
            this.gbAction.TabIndex = 4;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "نوع مجوز";
            // 
            // chkQuit
            // 
            this.chkQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkQuit.ForeColor = System.Drawing.Color.Black;
            this.chkQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkQuit.ImageIndex = 17;
            this.chkQuit.ImageList = this.ilImageList;
            this.chkQuit.Location = new System.Drawing.Point(3, 320);
            this.chkQuit.Name = "chkQuit";
            this.chkQuit.Padding = new System.Windows.Forms.Padding(3);
            this.chkQuit.Size = new System.Drawing.Size(138, 30);
            this.chkQuit.TabIndex = 12;
            this.chkQuit.Text = "خروج";
            this.chkQuit.UseVisualStyleBackColor = true;
            this.chkQuit.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDataPrint
            // 
            this.chkDataPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDataPrint.ForeColor = System.Drawing.Color.Black;
            this.chkDataPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDataPrint.ImageIndex = 16;
            this.chkDataPrint.ImageList = this.ilImageList;
            this.chkDataPrint.Location = new System.Drawing.Point(3, 290);
            this.chkDataPrint.Name = "chkDataPrint";
            this.chkDataPrint.Padding = new System.Windows.Forms.Padding(3);
            this.chkDataPrint.Size = new System.Drawing.Size(138, 30);
            this.chkDataPrint.TabIndex = 11;
            this.chkDataPrint.Text = "چاپ";
            this.chkDataPrint.UseVisualStyleBackColor = true;
            this.chkDataPrint.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkPrintPreview
            // 
            this.chkPrintPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkPrintPreview.ForeColor = System.Drawing.Color.Black;
            this.chkPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPrintPreview.ImageIndex = 15;
            this.chkPrintPreview.ImageList = this.ilImageList;
            this.chkPrintPreview.Location = new System.Drawing.Point(3, 260);
            this.chkPrintPreview.Name = "chkPrintPreview";
            this.chkPrintPreview.Padding = new System.Windows.Forms.Padding(3);
            this.chkPrintPreview.Size = new System.Drawing.Size(138, 30);
            this.chkPrintPreview.TabIndex = 10;
            this.chkPrintPreview.Text = "پیش نمایش";
            this.chkPrintPreview.UseVisualStyleBackColor = true;
            this.chkPrintPreview.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBFilter
            // 
            this.chkDBFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBFilter.ForeColor = System.Drawing.Color.Black;
            this.chkDBFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBFilter.ImageIndex = 14;
            this.chkDBFilter.ImageList = this.ilImageList;
            this.chkDBFilter.Location = new System.Drawing.Point(3, 230);
            this.chkDBFilter.Name = "chkDBFilter";
            this.chkDBFilter.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBFilter.Size = new System.Drawing.Size(138, 30);
            this.chkDBFilter.TabIndex = 9;
            this.chkDBFilter.Text = "فیلتر";
            this.chkDBFilter.UseVisualStyleBackColor = true;
            this.chkDBFilter.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBFindNext
            // 
            this.chkDBFindNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBFindNext.ForeColor = System.Drawing.Color.Black;
            this.chkDBFindNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBFindNext.ImageIndex = 13;
            this.chkDBFindNext.ImageList = this.ilImageList;
            this.chkDBFindNext.Location = new System.Drawing.Point(3, 200);
            this.chkDBFindNext.Name = "chkDBFindNext";
            this.chkDBFindNext.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBFindNext.Size = new System.Drawing.Size(138, 30);
            this.chkDBFindNext.TabIndex = 8;
            this.chkDBFindNext.Text = "جستجو ...";
            this.chkDBFindNext.UseVisualStyleBackColor = true;
            this.chkDBFindNext.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBFind
            // 
            this.chkDBFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBFind.ForeColor = System.Drawing.Color.Black;
            this.chkDBFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBFind.ImageIndex = 12;
            this.chkDBFind.ImageList = this.ilImageList;
            this.chkDBFind.Location = new System.Drawing.Point(3, 170);
            this.chkDBFind.Name = "chkDBFind";
            this.chkDBFind.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBFind.Size = new System.Drawing.Size(138, 30);
            this.chkDBFind.TabIndex = 7;
            this.chkDBFind.Text = "جستجو";
            this.chkDBFind.UseVisualStyleBackColor = true;
            this.chkDBFind.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBCancel
            // 
            this.chkDBCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBCancel.ForeColor = System.Drawing.Color.Black;
            this.chkDBCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBCancel.ImageIndex = 11;
            this.chkDBCancel.ImageList = this.ilImageList;
            this.chkDBCancel.Location = new System.Drawing.Point(3, 140);
            this.chkDBCancel.Name = "chkDBCancel";
            this.chkDBCancel.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBCancel.Size = new System.Drawing.Size(138, 30);
            this.chkDBCancel.TabIndex = 6;
            this.chkDBCancel.Text = "انصراف";
            this.chkDBCancel.UseVisualStyleBackColor = true;
            this.chkDBCancel.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBPost
            // 
            this.chkDBPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBPost.ForeColor = System.Drawing.Color.Black;
            this.chkDBPost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBPost.ImageIndex = 10;
            this.chkDBPost.ImageList = this.ilImageList;
            this.chkDBPost.Location = new System.Drawing.Point(3, 110);
            this.chkDBPost.Name = "chkDBPost";
            this.chkDBPost.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBPost.Size = new System.Drawing.Size(138, 30);
            this.chkDBPost.TabIndex = 5;
            this.chkDBPost.Text = "ذخیره";
            this.chkDBPost.UseVisualStyleBackColor = true;
            this.chkDBPost.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBDelete
            // 
            this.chkDBDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBDelete.ForeColor = System.Drawing.Color.Black;
            this.chkDBDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBDelete.ImageIndex = 9;
            this.chkDBDelete.ImageList = this.ilImageList;
            this.chkDBDelete.Location = new System.Drawing.Point(3, 80);
            this.chkDBDelete.Name = "chkDBDelete";
            this.chkDBDelete.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBDelete.Size = new System.Drawing.Size(138, 30);
            this.chkDBDelete.TabIndex = 4;
            this.chkDBDelete.Text = "حذف";
            this.chkDBDelete.UseVisualStyleBackColor = true;
            this.chkDBDelete.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBEdit
            // 
            this.chkDBEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBEdit.ForeColor = System.Drawing.Color.Black;
            this.chkDBEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBEdit.ImageIndex = 8;
            this.chkDBEdit.ImageList = this.ilImageList;
            this.chkDBEdit.Location = new System.Drawing.Point(3, 50);
            this.chkDBEdit.Name = "chkDBEdit";
            this.chkDBEdit.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBEdit.Size = new System.Drawing.Size(138, 30);
            this.chkDBEdit.TabIndex = 3;
            this.chkDBEdit.Text = "ویرایش";
            this.chkDBEdit.UseVisualStyleBackColor = true;
            this.chkDBEdit.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // chkDBInsert
            // 
            this.chkDBInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDBInsert.ForeColor = System.Drawing.Color.Black;
            this.chkDBInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDBInsert.ImageIndex = 7;
            this.chkDBInsert.ImageList = this.ilImageList;
            this.chkDBInsert.Location = new System.Drawing.Point(3, 20);
            this.chkDBInsert.Name = "chkDBInsert";
            this.chkDBInsert.Padding = new System.Windows.Forms.Padding(3);
            this.chkDBInsert.Size = new System.Drawing.Size(138, 30);
            this.chkDBInsert.TabIndex = 2;
            this.chkDBInsert.Text = "جديد";
            this.chkDBInsert.UseVisualStyleBackColor = true;
            this.chkDBInsert.Click += new System.EventHandler(this.chkDBInsert_Click);
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.ControlBox = false;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.gbAction);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعيين سطوح دسترسي";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            this.pnlButtons.ResumeLayout(false);
            this.gbTable.ResumeLayout(false);
            this.gbAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.GroupBox gbTable;
        internal System.Windows.Forms.TreeView tvTable;
        internal System.Windows.Forms.GroupBox gbAction;
        internal System.Windows.Forms.CheckBox chkQuit;
        internal System.Windows.Forms.CheckBox chkDataPrint;
        internal System.Windows.Forms.CheckBox chkPrintPreview;
        internal System.Windows.Forms.CheckBox chkDBFilter;
        internal System.Windows.Forms.CheckBox chkDBFindNext;
        internal System.Windows.Forms.CheckBox chkDBFind;
        internal System.Windows.Forms.CheckBox chkDBCancel;
        internal System.Windows.Forms.CheckBox chkDBPost;
        internal System.Windows.Forms.CheckBox chkDBDelete;
        internal System.Windows.Forms.CheckBox chkDBEdit;
        internal System.Windows.Forms.CheckBox chkDBInsert;
    }
}