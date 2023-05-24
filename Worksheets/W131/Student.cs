using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W131
{
    internal class Student : Human
    {
        private string faveSubject;
        public Student(string name, string faveSubject) : base(name)
        {
            this.faveSubject = faveSubject;
        }
        public override void talk()
        {
            base.talk();
            Console.WriteLine($"And my favourite subject is {faveSubject}");
        }
    }
}
