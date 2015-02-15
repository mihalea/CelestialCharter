using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialCharter
{
    public class Transaction
    {
        public String address { get; set; }
        public double amount { get; set; }
        public DateTime date { get; set; }

        public Transaction(String address, double amount, DateTime date)
        {
            this.address = address;
            this.amount = amount;
            this.date = date;
        }
    }
}
