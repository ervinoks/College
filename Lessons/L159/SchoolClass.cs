using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L159
{
    public class SchoolClass
    {
        protected string teacher;
        protected List<string> students;
        public SchoolClass(string t)
        {
            teacher = t;
        }
        public void AddStudent(string s)
        {
            students.Add(s);
        }
        public string GetRegister() => $"{teacher}: {String.Join(", ", students)}";
    }
}
