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
            {
            //    Dice sixsideddie = new Dice();
            //    Dice tensideddie = new Dice(10);
            //    Console.WriteLine("Six sided die: ");
            //    for (int i = 0; i < 10; i++) { Console.WriteLine(sixsideddie.Roll()); }
            //    Console.WriteLine("\nTen sided die: ");
            //    for (int i = 0; i < 10; i++) { Console.WriteLine(tensideddie.Roll()); }
            //    Console.ReadKey();
            }
            {
                Console.Write("Input the amount of sides on your dice: ");
                Dice mydice = new Dice(int.Parse(Console.ReadLine()));
                Warrior hero = new Warrior("Sub-Zero"), enemy = new Warrior("Scorpion");
                Console.WriteLine($"{hero.GetName()} has {hero.GetHealth()}HP" +
                    $"\nAnd {enemy.GetName()} has {enemy.GetHealth()}HP");
                Console.WriteLine("\nThe fight begins!");
                do
                {
                    hero.Attack(enemy, mydice.Roll());
                    Console.WriteLine($"{hero.GetName()} now has {hero.GetHealth()}HP");
                    enemy.Attack(hero, mydice.Roll());
                    Console.WriteLine($"{enemy.GetName()} now has {enemy.GetHealth()}HP");
                } while (hero.IsAlive() && enemy.IsAlive());
                Console.WriteLine("The fight is over!");
                string winner = hero.GetHealth() > 0 ? $"{hero.GetName()}" : $"{enemy.GetName()}";
                Console.WriteLine($"The winner is: {winner}!");
                Console.ReadKey();
            }
            }
        }
}
