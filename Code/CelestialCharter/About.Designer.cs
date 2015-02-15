namespace CelestialCharter
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_copy = new System.Windows.Forms.Label();
            this.lb_license = new System.Windows.Forms.Label();
            this.lb_credit = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CelestialCharter.Properties.Resources.DogecoinGold;
            this.pictureBox1.Location = new System.Drawing.Point(156, -57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_name.Location = new System.Drawing.Point(8, 81);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(143, 20);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Celestial Charter";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_version.Location = new System.Drawing.Point(12, 99);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(44, 13);
            this.lb_version.TabIndex = 2;
            this.lb_version.Text = "version ";
            // 
            // lb_copy
            // 
            this.lb_copy.AutoSize = true;
            this.lb_copy.Location = new System.Drawing.Point(12, 140);
            this.lb_copy.Name = "lb_copy";
            this.lb_copy.Size = new System.Drawing.Size(121, 13);
            this.lb_copy.TabIndex = 3;
            this.lb_copy.Text = "© 2014 Mihalea Mircea ";
            // 
            // lb_license
            // 
            this.lb_license.Location = new System.Drawing.Point(12, 221);
            this.lb_license.Name = "lb_license";
            this.lb_license.Size = new System.Drawing.Size(260, 68);
            this.lb_license.TabIndex = 4;
            this.lb_license.Text = "Celestial Charter is distributed under the GNU General Public License, Version 3." +
    " \r\nFor more details see the acompanying file, or visit http://www.gnu.org/licens" +
    "es";
            // 
            // lb_credit
            // 
            this.lb_credit.Location = new System.Drawing.Point(12, 166);
            this.lb_credit.Name = "lb_credit";
            this.lb_credit.Size = new System.Drawing.Size(260, 46);
            this.lb_credit.TabIndex = 5;
            this.lb_credit.Text = "This product uses software developed by Simon Mourrier and Jeff Klawiter for use " +
    "in HtmlAgilityPack.\r\nIt also includes artwork by Alforata.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(129, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://mihalea.ro";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_credit);
            this.Controls.Add(this.lb_license);
            this.Controls.Add(this.lb_copy);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_copy;
        private System.Windows.Forms.Label lb_license;
        private System.Windows.Forms.Label lb_credit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}