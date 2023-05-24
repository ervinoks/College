using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    internal class Npc : Character
    {
        int NpcNumber;
        public Npc(int score, int num) : base(score)
        {
            NpcNumber = num;
        }
        public override string GetName() => $"Computer{NpcNumber}";
        public override void Print()
        {
            Console.Write("PC");
        }
    }
}
