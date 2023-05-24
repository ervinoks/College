using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class Pyramid : Drawable
    {
        private int height;
        public Pyramid(int h)
        {
            height = h;
        }
        public override void draw()
        {
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((i - 1) * 2 + 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
