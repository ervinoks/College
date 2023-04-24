using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
	internal class Warrior
	{
		protected string name;
		protected int currentHealth, maxHealth, attackDamage;
		protected bool defensive;
		public Warrior(string myName, bool defensive)
		{
			name = myName;
			maxHealth = 100;
			currentHealth = maxHealth;
			attackDamage = defensive ? 6 : 10;
			this.defensive = defensive;
		}
		public int GetHealth() => currentHealth;
		public int GetMaxHealth() => maxHealth;
		public string GetName() => name;
		public bool IsAlive() => currentHealth > 0;
		public virtual void Attack(Warrior enemy, int diceRoll)
		{
			enemy.Attacked(attackDamage, diceRoll);
		}
		public void Attacked(int attackedDamage, int diceRoll)
		{
			attackedDamage = (int)Math.Ceiling(defensive ?
				attackedDamage * 0.7 : attackedDamage);
			currentHealth -= diceRoll * attackedDamage;
			if (currentHealth < 0) { currentHealth = 0; }
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine($"DMG: {diceRoll * attackedDamage}");
		}
	}
}
