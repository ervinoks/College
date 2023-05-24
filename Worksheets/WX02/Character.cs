using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    internal abstract class Character : IPrintable
    {
        protected int score;
        public Character(int score)
        {
            this.score = score;
        }
        public abstract string GetName();
        public abstract void Print();
        public void ChangeScore(int increment)
        {
            score += increment;
        }
        public int GetScore() => score;
    }
}
