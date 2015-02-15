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
    public partial class Add : Form
    {
        public Address address;
        private bool ok = false;

        public Add()
        {
            InitializeComponent();
        }

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            String name = ((TextBox)sender).Text;
            if (String.IsNullOrWhiteSpace(name) || name.Length <= 0) {
                e.Cancel = true;
                ok = false;
            }
            ok = true;
        }

        private void tb_address_Validating(object sender, CancelEventArgs e)
        {
            String address = ((TextBox)sender).Text;
            Console.WriteLine(address);
            if (String.IsNullOrWhiteSpace(address) ||
                    address.ToCharArray()[0] != 'D' ||
                    address.Length != 34)
            {
                e.Cancel = true;
                ok = false;
            }
            ok = true;
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ok)
                address = new Address(tb_name.Text, tb_address.Text);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}
