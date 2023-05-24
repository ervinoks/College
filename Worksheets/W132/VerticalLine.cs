using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class VerticalLine : Drawable
    {
        private int length;
        public VerticalLine(int l)
        {
            length = l;
        }
        public override void draw()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }
}
