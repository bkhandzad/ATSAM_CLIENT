namespace AtsamClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDayOfWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ssStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsslUserName
            // 
            this.tsslUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tsslUserName.AutoSize = false;
            this.tsslUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslUserName.ForeColor = System.Drawing.Color.Maroon;
            this.tsslUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(508, 25);
            this.tsslUserName.Spring = true;
            this.tsslUserName.Text = "نام کاربر";
            this.tsslUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslDayOfWeek
            // 
            this.tsslDayOfWeek.AutoSize = false;
            this.tsslDayOfWeek.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslDayOfWeek.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslDayOfWeek.ForeColor = System.Drawing.Color.Maroon;
            this.tsslDayOfWeek.Name = "tsslDayOfWeek";
            this.tsslDayOfWeek.Size = new System.Drawing.Size(100, 25);
            this.tsslDayOfWeek.Text = "روز هفته";
            // 
            // tsslDate
            // 
            this.tsslDate.AutoSize = false;
            this.tsslDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslDate.ForeColor = System.Drawing.Color.Maroon;
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(80, 25);
            this.tsslDate.Text = "تاريخ";
            // 
            // tsslTime
            // 
            this.tsslTime.AutoSize = false;
            this.tsslTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsslTime.ForeColor = System.Drawing.Color.Maroon;
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(80, 25);
            this.tsslTime.Text = "ساعت";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenuStrip.Size = new System.Drawing.Size(785, 24);
            this.msMenuStrip.TabIndex = 6;
            this.msMenuStrip.Text = "msMain";
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserName,
            this.tsslDate,
            this.tsslDayOfWeek,
            this.tsslTime});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 480);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this.ssStatusStrip.Size = new System.Drawing.Size(785, 30);
            this.ssStatusStrip.TabIndex = 9;
            this.ssStatusStrip.Text = "ssMain";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.msMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslDayOfWeek;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        internal System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.MenuStrip msMenuStrip;
    }
}