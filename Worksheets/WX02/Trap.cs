using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    internal class Trap : IPrintable, IScorable
    {
        private int damage;
        public Trap(int damage)
        {
            this.damage = damage;
        }
        public void Print()
        {
            Console.Write("><");
        }
        public int GetScore() => damage;
        public void PrintDescription()
        {
            Console.Write($"The trap is worth {damage} points");
        }
    }
}
