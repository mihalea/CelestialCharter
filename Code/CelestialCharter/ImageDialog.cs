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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialCharter
{
    public partial class ImageDialog : Form
    {
        public String path;
        public int width, height;
        public bool ok = false;
        public ImageDialog()
        {
            InitializeComponent();
        }

        private void tb_path_Validating(object sender, CancelEventArgs e)
        {
            String text = tb_path.Text;
            path = text;

            try
            {
                if (String.IsNullOrWhiteSpace(text) || System.IO.File.Exists(text) == false)
                    e.Cancel = true;
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void tb_width_Validating(object sender, CancelEventArgs e)
        {
            String text = tb_width.Text;

            try
            {
                if (String.IsNullOrWhiteSpace(text))
                    e.Cancel = true;
                width = Convert.ToInt16(text);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void tb_height_Validating(object sender, CancelEventArgs e)
        {
            String text = tb_height.Text;

            try
            {
                if (String.IsNullOrWhiteSpace(text))
                    e.Cancel = true;
                height = Convert.ToInt16(text);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG | *.png";
            sfd.DefaultExt = "png";
            if (DialogResult.OK != sfd.ShowDialog())
                return;

            String fileName = sfd.FileName;
            if(fileName.ToLower().EndsWith(".png") == false)
                fileName = fileName + ".png";

            tb_path.Text = fileName;
            path = fileName;
        }
    }
}
