using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the amount of sides on your dice: ");
            Dice mydice = new Dice(int.Parse(Console.ReadLine()));
            HealingWarrior hero = new HealingWarrior("Sub-Zero");
            Warrior enemy = new Warrior("Scorpion");
            Console.WriteLine($"You, {hero.GetName()} has {hero.GetHealth()}HP" +
                $"\nAnd {enemy.GetName()} has {enemy.GetHealth()}HP");
            Console.WriteLine("\nThe fight begins!");
            do
            {
                hero.Attack(enemy, mydice.Roll());
                Console.WriteLine($"{enemy.GetName()} now has {enemy.GetHealth()}HP");
                enemy.Attack(hero, mydice.Roll());
                Console.WriteLine($"{hero.GetName()} now has {hero.GetHealth()}HP");
                if (!hero.getHaveHealed() && hero.IsAlive() && enemy.IsAlive()) 
                {
                    Console.Write("Would you like to use your healing? (Y/N): ");
                    char ans = Char.ToUpper(Console.ReadKey().KeyChar);
                    if (ans == 'Y') { hero.heal(); }
                    Console.WriteLine();
                }
            } while (hero.IsAlive() && enemy.IsAlive());
            Console.WriteLine("The fight is over!");
            string winner = hero.GetHealth() > 0 ? $"{hero.GetName()}" : $"{enemy.GetName()}";
            Console.WriteLine($"The winner is: {winner}!");
            Console.ReadKey();
        }
    }
}
