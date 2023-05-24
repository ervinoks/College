using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class Circle : Drawable
    {
        private int diameter;
        public Circle(int diameter)
        {
             this.diameter = diameter;
        }
        public override void draw()
        {
            for (int y = 0; y < diameter; y++)
            {
                for (int x = 0; x < diameter; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
