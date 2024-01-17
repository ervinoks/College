using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A214
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// PRACTICAL 1 | Basic Maths
			string test;
			Console.WriteLine($"{test = "8plus7minus9plus3"}: {Calc(test)}");
			Console.ReadKey(true);

			// PRACTICAL 2 | Survive the Attack
			string[] att, def;
			Console.WriteLine(
				$"\nattackers = [ {string.Join(", ", att = new string[] { "1", "1", "1", "1" })} ] | " +
				$"defenders = [ {string.Join(", ", def = new string[] { "2", "4" })} ]: " +
				$"{(attacked(att, def) ? "You survived the attack!!" : "You all perish")}\n");
			Console.WriteLine(
				$"attackers = [ {string.Join(", ", att = new string[] { "7", "5", "9" })} ] | " +
				$"defenders = [ {string.Join(", ", def = new string[] { "2", "4", "6", "8" })}]: " +
				$"{(attacked(att, def) ? "You survived the attack!!" : "You all perish")}\n");
			Console.ReadKey();
		}
		static int Calc(string input) // PRACTICAL 1 - completed in 10mins, 20secs.
		{
			string op1 = default, op2 = default;
			bool doOp1 = true, doPlus = default;
			foreach (var item in input) 
			{
				if (item == 'p' || item == 'm')
				{
					if (doOp1 == false)
					{
						op1 = doPlus ? 
							(int.Parse(op1) + int.Parse(op2)).ToString() : 
							(int.Parse(op1) - int.Parse(op2)).ToString();
						op2 = default;
					}
					doPlus = item == 'p';
					doOp1 = false;
				}
				else if (char.IsDigit(item))
				{
					if (doOp1) op1 += item;
					else op2 += item;
				}		
			}
			return doPlus ? int.Parse(op1) + int.Parse(op2) : int.Parse(op1) - int.Parse(op2);
		}	
		static bool attacked(string[] attackers, string[] defenders) // PRACTICAL 2
		{
			int lim = Math.Max(attackers.Length, defenders.Length), diff;
			for (int i = 0; i < lim; i++)
			{
				try { diff = string.Compare(defenders[i], attackers[i]); }
				catch (IndexOutOfRangeException) { continue; }
				
				if (diff > 0) attackers[i] = "0"; // defender soldier > attacker soldier
				else if (diff < 0) defenders[i] = "0"; // def < att
				else attackers[i] = "0"; defenders[i] = "0"; // def == att
			}
			int toInt(string s) => int.Parse(s);
			return defenders.Sum(toInt) >= attackers.Sum(toInt);
		}
	}
}

