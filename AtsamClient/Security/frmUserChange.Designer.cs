namespace AtsamClient.Security
{
    partial class frmUserChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserChange));
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.picSecurity = new System.Windows.Forms.PictureBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.gbButtons.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Magenta;
            this.imgMain.Images.SetKeyName(0, "Ok.bmp");
            this.imgMain.Images.SetKeyName(1, "Cancel.bmp");
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnOk);
            this.gbButtons.Controls.Add(this.btnCancel);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbButtons.Location = new System.Drawing.Point(2, 148);
            this.gbButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbButtons.Size = new System.Drawing.Size(292, 67);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.ImageIndex = 0;
            this.btnOk.ImageList = this.imgMain;
            this.btnOk.Location = new System.Drawing.Point(171, 23);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "تایید";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.imgMain;
            this.btnCancel.Location = new System.Drawing.Point(21, 23);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.picSecurity);
            this.gbDetail.Controls.Add(this.txtUserPassword);
            this.gbDetail.Controls.Add(this.lblUserPassword);
            this.gbDetail.Controls.Add(this.txtUserID);
            this.gbDetail.Controls.Add(this.lblUserID);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetail.Location = new System.Drawing.Point(2, 42);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetail.Size = new System.Drawing.Size(292, 106);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            // 
            // picSecurity
            // 
            this.picSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSecurity.Image = ((System.Drawing.Image)(resources.GetObject("picSecurity.Image")));
            this.picSecurity.Location = new System.Drawing.Point(12, 30);
            this.picSecurity.Name = "picSecurity";
            this.picSecurity.Size = new System.Drawing.Size(56, 56);
            this.picSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecurity.TabIndex = 4;
            this.picSecurity.TabStop = false;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(72, 63);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserPassword.MaxLength = 10;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(100, 23);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPassword_KeyPress);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserPassword.ForeColor = System.Drawing.Color.Black;
            this.lblUserPassword.Location = new System.Drawing.Point(180, 63);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserPassword.Size = new System.Drawing.Size(100, 23);
            this.lblUserPassword.TabIndex = 2;
            this.lblUserPassword.Text = "رمز عبور";
            this.lblUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(72, 30);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.MaxLength = 6;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 23);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(180, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserID.Size = new System.Drawing.Size(100, 23);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "شناسه کاربر";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.ForeColor = System.Drawing.Color.Black;
            //this.lblCaption.Image = global::MAP_PBG_Client.Properties.Resources.Banner1;
            this.lblCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(292, 40);
            this.lblCaption.TabIndex = 12;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.UseCompatibleTextRendering = true;
            // 
            // frmUserChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 217);
            this.ControlBox = false;
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.lblCaption);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserChange";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmUserChange_KeyPress);
            this.gbButtons.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox picSecurity;
        private System.Windows.Forms.Label lblCaption;
    }
}