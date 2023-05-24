using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    internal class Item : IPrintable, IScorable
    {
        public void Print()
        {
            Console.Write("[]");
        }
        public int GetScore() => 10;
        public void PrintDescription()
        {
            Console.Write("That's an item worth 10 points");
        }
    }
}
