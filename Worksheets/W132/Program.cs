using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Drawable> drawables = new List<Drawable>();
            drawables.Add(new Square(3));
            drawables.Add(new Square(5));
            drawables.Add(new VerticalLine(3));
            drawables.Add(new VerticalLine(5));
            drawables.Add(new HorizontalLine(3));
            drawables.Add(new HorizontalLine(5));
            drawables.Add(new Pyramid(5));
            drawables.Add(new Pyramid(2));

            foreach (Drawable d in drawables)
            {
                d.draw();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
