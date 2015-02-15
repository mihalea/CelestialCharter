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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialCharter
{
    public class Address
    {
        public String name { get; set; }
        public String address { get; set; }

        public Address(String name, String address)
        {
            this.name = name;
            this.address = address;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
