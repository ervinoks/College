using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W131
{
    internal class Animal
    {
        public virtual void sit()
        {
            Console.WriteLine("*sits on the floor*");
        }
        public virtual void talk()
        {
            Console.WriteLine("*generic animal noise*");
        }
    }
}
