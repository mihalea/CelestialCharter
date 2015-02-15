namespace CelestialCharter
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bt_import = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_graph = new System.Windows.Forms.GroupBox();
            this.cbx_addresses = new System.Windows.Forms.ComboBox();
            this.lb_adresses = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_maxDate = new System.Windows.Forms.ComboBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.cbx_minDate = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_addresses = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.gb_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gb_filter.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gb_addresses.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_import
            // 
            this.bt_import.Location = new System.Drawing.Point(6, 19);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(238, 23);
            this.bt_import.TabIndex = 1;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_add.Location = new System.Drawing.Point(250, 19);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(23, 23);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "+";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_del
            // 
            this.bt_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_del.Location = new System.Drawing.Point(279, 19);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(23, 23);
            this.bt_del.TabIndex = 3;
            this.bt_del.Text = "-";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(6, 26);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(528, 374);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // gb_graph
            // 
            this.gb_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_graph.AutoSize = true;
            this.gb_graph.Controls.Add(this.chart);
            this.gb_graph.Location = new System.Drawing.Point(326, 27);
            this.gb_graph.Name = "gb_graph";
            this.gb_graph.Size = new System.Drawing.Size(540, 406);
            this.gb_graph.TabIndex = 5;
            this.gb_graph.TabStop = false;
            this.gb_graph.Text = "Data";
            // 
            // cbx_addresses
            // 
            this.cbx_addresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_addresses.FormattingEnabled = true;
            this.cbx_addresses.Location = new System.Drawing.Point(71, 19);
            this.cbx_addresses.Name = "cbx_addresses";
            this.cbx_addresses.Size = new System.Drawing.Size(231, 21);
            this.cbx_addresses.TabIndex = 5;
            // 
            // lb_adresses
            // 
            this.lb_adresses.AutoSize = true;
            this.lb_adresses.Location = new System.Drawing.Point(17, 22);
            this.lb_adresses.Name = "lb_adresses";
            this.lb_adresses.Size = new System.Drawing.Size(48, 13);
            this.lb_adresses.TabIndex = 6;
            this.lb_adresses.Text = "Address:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(296, 229);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.cbx_maxDate);
            this.gb_filter.Controls.Add(this.lb_date);
            this.gb_filter.Controls.Add(this.cbx_minDate);
            this.gb_filter.Controls.Add(this.lb_adresses);
            this.gb_filter.Controls.Add(this.cbx_addresses);
            this.gb_filter.Location = new System.Drawing.Point(12, 72);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(308, 75);
            this.gb_filter.TabIndex = 7;
            this.gb_filter.TabStop = false;
            this.gb_filter.Text = "Filter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "to";
            // 
            // cbx_maxDate
            // 
            this.cbx_maxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_maxDate.FormattingEnabled = true;
            this.cbx_maxDate.Location = new System.Drawing.Point(200, 46);
            this.cbx_maxDate.Name = "cbx_maxDate";
            this.cbx_maxDate.Size = new System.Drawing.Size(102, 21);
            this.cbx_maxDate.TabIndex = 9;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(32, 49);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(33, 13);
            this.lb_date.TabIndex = 8;
            this.lb_date.Text = "Date:";
            // 
            // cbx_minDate
            // 
            this.cbx_minDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_minDate.FormattingEnabled = true;
            this.cbx_minDate.Location = new System.Drawing.Point(71, 46);
            this.cbx_minDate.Name = "cbx_minDate";
            this.cbx_minDate.Size = new System.Drawing.Size(102, 21);
            this.cbx_minDate.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(64, 17);
            this.lb_status.Text = "Status: idle";
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_analyze_Click);
            // 
            // gb_addresses
            // 
            this.gb_addresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_addresses.Controls.Add(this.bt_import);
            this.gb_addresses.Controls.Add(this.bt_add);
            this.gb_addresses.Controls.Add(this.bt_del);
            this.gb_addresses.Controls.Add(this.dataGridView);
            this.gb_addresses.Location = new System.Drawing.Point(12, 153);
            this.gb_addresses.Name = "gb_addresses";
            this.gb_addresses.Size = new System.Drawing.Size(308, 283);
            this.gb_addresses.TabIndex = 11;
            this.gb_addresses.TabStop = false;
            this.gb_addresses.Text = "Addresses:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAddressesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearAddressesToolStripMenuItem
            // 
            this.clearAddressesToolStripMenuItem.Name = "clearAddressesToolStripMenuItem";
            this.clearAddressesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.clearAddressesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.clearAddressesToolStripMenuItem.Text = "Clear addresses";
            this.clearAddressesToolStripMenuItem.Click += new System.EventHandler(this.clearAddressesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.saveAsTextFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // saveAsTextFileToolStripMenuItem
            // 
            this.saveAsTextFileToolStripMenuItem.Name = "saveAsTextFileToolStripMenuItem";
            this.saveAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsTextFileToolStripMenuItem.Text = "Save as text file";
            this.saveAsTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.gb_addresses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.gb_graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celestial Charter";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.gb_graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gb_addresses.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox gb_graph;
        private System.Windows.Forms.Label lb_adresses;
        private System.Windows.Forms.ComboBox cbx_addresses;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_maxDate;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox cbx_minDate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_addresses;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}