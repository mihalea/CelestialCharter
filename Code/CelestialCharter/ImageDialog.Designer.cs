namespace CelestialCharter
{
    partial class ImageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDialog));
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.lb_width = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.lb_height = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(47, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(32, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Path:";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(85, 27);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(184, 20);
            this.tb_path.TabIndex = 1;
            this.tb_path.Validating += new System.ComponentModel.CancelEventHandler(this.tb_path_Validating);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(111, 114);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(85, 53);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(265, 20);
            this.tb_width.TabIndex = 4;
            this.tb_width.Validating += new System.ComponentModel.CancelEventHandler(this.tb_width_Validating);
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(41, 56);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(38, 13);
            this.lb_width.TabIndex = 3;
            this.lb_width.Text = "Width:";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(85, 79);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(265, 20);
            this.tb_height.TabIndex = 6;
            this.tb_height.Validating += new System.ComponentModel.CancelEventHandler(this.tb_height_Validating);
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(41, 82);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(41, 13);
            this.lb_height.TabIndex = 5;
            this.lb_height.Text = "Height:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.CausesValidation = false;
            this.bt_cancel.Location = new System.Drawing.Point(192, 114);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(275, 25);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(75, 23);
            this.bt_browse.TabIndex = 8;
            this.bt_browse.Text = "Browse...";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // ImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.lb_height);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.lb_width);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save as image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_browse;
    }
}