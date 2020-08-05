namespace AtsamClient.Security
{
    partial class frmPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordChange));
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.picSecurity = new System.Windows.Forms.PictureBox();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pbCaption = new System.Windows.Forms.PictureBox();
            this.gbButton.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Magenta;
            this.imgMain.Images.SetKeyName(0, "Ok.bmp");
            this.imgMain.Images.SetKeyName(1, "Cancel.bmp");
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnOk);
            this.gbButton.Controls.Add(this.btnCancel);
            this.gbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbButton.Location = new System.Drawing.Point(2, 150);
            this.gbButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbButton.Size = new System.Drawing.Size(292, 67);
            this.gbButton.TabIndex = 3;
            this.gbButton.TabStop = false;
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
            this.gbDetail.Controls.Add(this.txtPasswordConfirmation);
            this.gbDetail.Controls.Add(this.lblPasswordConfirmation);
            this.gbDetail.Controls.Add(this.txtNewPassword);
            this.gbDetail.Controls.Add(this.lblNewPassword);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetail.Location = new System.Drawing.Point(2, 44);
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
            this.picSecurity.TabIndex = 5;
            this.picSecurity.TabStop = false;
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(72, 63);
            this.txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordConfirmation.MaxLength = 6;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(100, 23);
            this.txtPasswordConfirmation.TabIndex = 3;
            this.txtPasswordConfirmation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordConfirmation_KeyPress);
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPasswordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPasswordConfirmation.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(180, 63);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(100, 23);
            this.lblPasswordConfirmation.TabIndex = 2;
            this.lblPasswordConfirmation.Text = "تأييد رمز";
            this.lblPasswordConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(72, 30);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.MaxLength = 6;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(100, 23);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassword_KeyPress);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblNewPassword.Location = new System.Drawing.Point(180, 30);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNewPassword.Size = new System.Drawing.Size(100, 23);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "رمز عبور جديد";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCaption
            // 
            this.pbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCaption.ErrorImage = null;
            this.pbCaption.InitialImage = null;
            this.pbCaption.Location = new System.Drawing.Point(2, 2);
            this.pbCaption.Name = "pbCaption";
            this.pbCaption.Size = new System.Drawing.Size(292, 42);
            this.pbCaption.TabIndex = 14;
            this.pbCaption.TabStop = false;
            // 
            // frmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 225);
            this.ControlBox = false;
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.pbCaption);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasswordChange";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPasswordChange_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPasswordChange_KeyPress);
            this.gbButton.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.PictureBox picSecurity;
        private System.Windows.Forms.PictureBox pbCaption;
    }
}