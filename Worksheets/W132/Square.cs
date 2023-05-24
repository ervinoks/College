using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class Square : Drawable
    {
        private int side;
        public Square(int side)
        {
             this.side = side;
        }
        public override void draw()
        {
            for (int y = 0; y < side; y++)
            {
                for (int x = 0; x < side; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
