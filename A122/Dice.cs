using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
    internal class Dice
    {
        private int sidesCount;
        private Random random = new Random();
        public Dice()
        {
            sidesCount = 6;
        }
        public Dice(int sides)
        {
            sidesCount = sides;
        }
        public int GetSidesCounts()
        {
            return sidesCount;
        }
        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
    }
}
