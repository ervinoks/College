using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L159
{
    public class SharedClass : SchoolClass
    {
        private string teacher2;
        public SharedClass(string t1, string t2) : base(t1)
        {
            teacher2 = t2;
        }
        public string GetSharedRegister() => $"{teacher} and {teacher2}: {String.Join(", ", students)}";
        public void ChangePrimaryTeacher()
        {
            (teacher, teacher2) = (teacher2, teacher);
        }
    }
}
