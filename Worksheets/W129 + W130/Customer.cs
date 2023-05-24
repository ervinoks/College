using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W129andW130
{
    public class Customer
    {
        private string name;
        private bool premium;
        public Customer(string name, bool premium)
        {
            this.name = name;
            this.premium = premium;
        }

        public string getName() => name;

        public bool isPremium() => premium;
    }
}
