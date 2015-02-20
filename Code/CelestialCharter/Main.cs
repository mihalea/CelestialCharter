//-----------------------------------------------------------------------

// Copyright (c) 2014 Mihalea Mircea. All rights reserved.

// Celestial Charter is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Celestial Charter is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Celestial Charter.  If not, see <http://www.gnu.org/licenses/>.

//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HtmlAgilityPack;
using CelestialCharter.Properties;

namespace CelestialCharter
{
    public partial class Main : Form
    {
        private String url = "http://" + "bitinfocharts.com/dogecoin/address/"; // + address

        private List<Transaction> transactions = new List<Transaction>();
        private List<Transaction> stacked = new List<Transaction>();

        private DateTime minDate, maxDate;

        private BindingList<Address> addresses = new BindingList<Address>();
        private BindingSource source = new BindingSource();
        private const String ALL_ADDRESSES = "ALL_ADDRESSES";

        private Chart ghostChart;

        private bool hasData = false;

        public Main()
        {
            InitializeComponent();
            LinkDataToTable();
            LayoutTable();
        }

        private void LinkDataToTable(){
            source.DataSource = null;
            source.DataSource = addresses;
            dataGridView.DataSource = source;
        }

        private void LayoutTable()
        {
            dataGridView.Columns[0].HeaderText = "Name";
            dataGridView.Columns[1].HeaderText = "Address";

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].Width = 100;

            cbx_addresses.Items.Add(new Address("All addresses", ALL_ADDRESSES));
            cbx_addresses.SelectedIndex = 0;


            cbx_minDate.Items.Add(new DateTime(2000, 01, 01));
            cbx_maxDate.Items.Add(new DateTime(2099, 12, 31));

            cbx_minDate.SelectedIndex = 0;
            cbx_maxDate.SelectedIndex = 0;
        }

        private void updateFilter()
        {
            cbx_addresses.Items.Clear();
            cbx_addresses.Items.Add(new Address("All addresses", ALL_ADDRESSES));
            foreach (Address address in addresses)
                cbx_addresses.Items.Add(address);
            if(cbx_addresses.SelectedIndex < 0)
                cbx_addresses.SelectedIndex = 0;
        }

        private void sortAndStack()
        {
            transactions = transactions.OrderBy(x => x.date).ToList();

            double sum = 0d;
            DateTime date = DateTime.MinValue;
            Address selectedAddress = (Address) cbx_addresses.SelectedItem;

            if (hasData == false)
            {
                cbx_minDate.Items.Clear();
                cbx_maxDate.Items.Clear();
            }
            stacked.Clear();
            
            foreach (Transaction tx in transactions)
            {
                if (selectedAddress.address.Equals(ALL_ADDRESSES) == false &&
                    selectedAddress.address.Equals(tx.address) == false)
                    continue;

                if(date.ToShortDateString().Equals(tx.date.ToShortDateString()) == false)
                {
                    stacked.Add(new Transaction(tx.address, sum += tx.amount, tx.date));
                    
                    date = tx.date;

                    if (hasData == false)
                    {
                        cbx_minDate.Items.Add(date);
                        cbx_maxDate.Items.Add(date);
                    }
                }
                else
                {
                    sum += tx.amount;
                    stacked.ElementAt(stacked.Count - 1).amount += tx.amount;
                }
            }

            if (hasData == false)
            {
                cbx_minDate.SelectedIndex = 0;
                cbx_maxDate.SelectedIndex = cbx_maxDate.Items.Count - 1;
            }

            Console.WriteLine("Sorted and stacked according to filters");

            updateChart();
        }

        private void updateChart()
        {
            //updateFilter();

            Series s = new Series();
            s.ChartType = SeriesChartType.Line;
            
            s.XValueType = ChartValueType.DateTime;
            s.ToolTip = "#VAL Doge at #VALX";

            s.MarkerSize = 3;
            s.MarkerColor = Color.Red;
            s.MarkerStyle = MarkerStyle.Circle;

            foreach (Transaction tx in stacked)
            {
                if(tx.date >= (DateTime) cbx_minDate.SelectedItem && tx.date <= (DateTime) cbx_maxDate.SelectedItem)
                    s.Points.AddXY(tx.date, tx.amount);
            }

            chart.Series.Clear();
            chart.Series.Add(s);

            chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            //chart.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            //chart.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            Console.WriteLine("Updated chart");
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            try
            {
                //if (MessageBox.Show(this, "Are you sure you want to overwrite the current addresses?", "Overwrite", MessageBoxButtons.YesNo) == DialogResult.No)
                //    return;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Wallet export (*.csv)|*.csv";
                    if (DialogResult.Cancel == openFileDialog.ShowDialog())
                        return;

                    if (openFileDialog.CheckFileExists == false)
                        return;

                    String path = openFileDialog.FileName;
                    String[] lines = System.IO.File.ReadAllLines(path);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        String[] split = lines[i].Split(',');
                        split[0] = split[0].Substring(1, split[0].Length - 2);
                        split[1] = split[1].Substring(1, split[1].Length - 2);
                        addresses.Add(new Address(split[0], split[1]));
                    }

                    Console.WriteLine("Imported " + lines.Length + " addresses");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            Address address = add.address;

            if (address != null)
                addresses.Add(address);
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0)
                return;

            if (MessageBox.Show(this, "Are you sure you want to delete the selected addresses?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                addresses.Remove((Address) row.DataBoundItem);
                //dataGridView.Rows.Remove(row);
            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateFilter();
            hasData = false;
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateFilter();
            hasData = false;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                transactions.Clear();
                HtmlWeb web = new HtmlWeb();
                web.UserAgent = @"Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0";

                String temp; //used for parsing

                double amount;
                DateTime date;

                minDate = DateTime.MaxValue;
                maxDate = DateTime.MinValue;

                List<DateTime> dates = new List<DateTime>();
                List<double> amounts = new List<double>();

                int index = 0;
                foreach (Address address in addresses)
                {
                    worker.ReportProgress((index++ * 100) / addresses.Count);

                    HtmlAgilityPack.HtmlDocument document = web.Load(url + address.address);

                    Console.WriteLine(address.name + " " + address.address);
                    dates.Clear();

                    if (document.DocumentNode.InnerHtml.Contains("Dogecoin Explorer."))
                    {
                        Console.WriteLine("Skipping address");
                        continue;
                    }
                    
                    foreach (HtmlNode node in document.DocumentNode.SelectNodes("//td[@class='utc']"))
                    {
                        temp = node.FirstChild.InnerText;
                        String[] tokens = temp.Split(' '); //Isolates the date

                        String[] split_date = tokens[0].Split('-');
                        String[] split_time = tokens[1].Split(':');
                        date = new DateTime(Convert.ToInt16(split_date[0]), Convert.ToInt16(split_date[1]), Convert.ToInt16(split_date[2]),
                            Convert.ToInt16(split_time[0]), Convert.ToInt16(split_time[1]), Convert.ToInt16(split_time[2]));
                        dates.Add(date);

                        if (date < minDate)
                            minDate = date;
                        if (date > maxDate)
                            maxDate = date;
                    }

                    amounts.Clear();
                    foreach (HtmlNode node in document.DocumentNode.SelectNodes("//table[@id='table_maina']//td//p"))
                    {
                        temp = node.FirstChild.InnerText;
                        temp = temp.Split(' ')[0];

                        amount = Convert.ToDouble(temp);
                        amounts.Add(amount);
                    }

                    if (dates.Count != amounts.Count)
                        throw new Exception("Parsed an incorrect amount of data");

                    for (int i = 0; i < dates.Count; i++)
                        transactions.Add(new Transaction(address.address, amounts[i], dates[i]));

                    //System.Threading.Thread.Sleep(5000);
                }

                Console.WriteLine("Parsed transactions: " + transactions.Count);
                //Console.WriteLine("min: " + minDate);
                //Console.WriteLine("max: " + maxDate);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lb_status.Text = "Status: " + e.ProgressPercentage + "%";
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lb_status.Text = "Status: idle";
            sortAndStack();
            hasData = true;
        }

        private void bt_analyze_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy || addresses.Count <= 0)
                return;

            if (hasData)
            {
                sortAndStack();
                return;
            }

            lb_status.Text = "Status: working";
            worker.RunWorkerAsync();
        }

        private void clearAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete all the addresses?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            addresses.Clear();
            Console.WriteLine("Cleared all addresses");
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactions.Count <= 0)
                    return;

                ImageDialog imageDialog = new ImageDialog();
                imageDialog.ShowDialog();

                if (imageDialog.ok == false)
                    return;

                if (ghostChart == null)
                {
                    ghostChart = new Chart();
                    ghostChart.Visible = false;
                    ghostChart.ChartAreas.Add(new ChartArea());
                    ghostChart.Titles.Add(Resources.AppName);
                    ghostChart.Palette = ChartColorPalette.BrightPastel;
                }

                ghostChart.Width = imageDialog.width;
                ghostChart.Height = imageDialog.height;

                ghostChart.Series.Clear();
                ghostChart.Series.Add(chart.Series[0]);

                ghostChart.SaveImage(imageDialog.path, ChartImageFormat.Png);
                //chart.SaveImage(@"D:/Temp/original.png", ChartImageFormat.Png);
                Console.WriteLine("Saved image:");
                Console.WriteLine("---Size: " + imageDialog.width + "x" + imageDialog.height);
                Console.WriteLine("---Path: " + imageDialog.path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transactions.Count <= 0)
                return;

            TextDialog textDialog = new TextDialog();
            textDialog.ShowDialog();

            if (textDialog.ok == false)
                return;

            List<String> lines = new List<String>();

            double sum = 0;
            foreach (Transaction tx in transactions)
            {
                if (tx.date < (DateTime) cbx_minDate.SelectedItem || tx.date > (DateTime) cbx_maxDate.SelectedItem)
                    continue;
                Address address = (Address)cbx_addresses.SelectedItem;
                if (address.address.Equals(ALL_ADDRESSES) == false &&
                    address.address.Equals(tx.address) == false)
                    continue;

                sum += tx.amount;
                lines.Add("[" + tx.date.ToShortDateString() + " " + tx.date.ToShortTimeString() + "]" +
                    "Address: " + tx.address + " | Amount: " + tx.amount + " | Total: " + sum);
            }

            System.IO.File.WriteAllLines(textDialog.path, lines);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
