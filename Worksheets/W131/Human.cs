using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W131
{
    internal class Human : Animal
    {
        private string name;
        public Human(string name) : base()
        {
            this.name = name;
        }
        public override void talk()
        {
            Console.WriteLine($"Hello, my name is {name}");
        }
    }
}
