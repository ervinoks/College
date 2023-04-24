using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
	internal class MageWarrior : Warrior
	{
		private int mana, maxMana, magicDamage;
		public MageWarrior(string myName, int maxMana, int magicDamage, 
			bool defensive) : base(myName, defensive)
		{
			maxHealth = 100;
			currentHealth = maxHealth;
			attackDamage = defensive ? 6 : 8;
			this.maxMana = maxMana;
			mana = maxMana;
			this.magicDamage = (int)Math.Ceiling(defensive ? 
				magicDamage * 0.8 : magicDamage);
		}
		public int getMana() => mana;
		public int getMaxMana() => maxMana;
		public override void Attack(Warrior enemy, int diceRoll)
		{
			if (mana < maxMana) 
			{ 
				if (mana + 10 > maxMana) { mana = maxMana; }                
				else { mana += 10; }
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine($"MANA: {mana}");
				base.Attack(enemy, diceRoll);
			}
			else 
			{ 
				Console.ForegroundColor = ConsoleColor.DarkMagenta; 
				enemy.Attacked(magicDamage, diceRoll);
				mana = 0;
			}
			Console.ResetColor();
		}
	}
}
