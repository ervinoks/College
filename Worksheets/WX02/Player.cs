using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    internal class Player : Character
    {
        protected string name;
        public Player(int score, string name) : base(score)
        {
            this.name = name;
        }
        public override string GetName() => name;
        public override void Print()
        {
            Console.Write("ME");
        }
    }
}
