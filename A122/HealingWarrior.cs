using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
    internal class HealingWarrior : Warrior
    {
        private bool haveHealed;
        public HealingWarrior(string myName) : base(myName)
        {
            maxHealth = 150;
            currentHealth = maxHealth;
            attackDamage = 6;
            haveHealed = false;
        }
        public bool getHaveHealed() => haveHealed;
        public void heal()
        {
            if (haveHealed == false) 
            { 
                currentHealth = maxHealth; 
                haveHealed = true;
            }
        }
    }
}
