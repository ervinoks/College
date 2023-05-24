using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myAnimals = new List<Animal>();
            Animal animal1 = new Animal();
            myAnimals.Add(animal1);
            Cat kitty = new Cat();
            myAnimals.Add(kitty);
            Human myself = new Human("Matt");
            myAnimals.Add(myself);
            Student stud = new Student("Jane", "Computer Science");
            myAnimals.Add(stud);

            foreach (Animal animal in myAnimals)
            {
                animal.talk();
                animal.sit();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
