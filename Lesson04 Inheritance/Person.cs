using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_Inheritance
{
    public abstract class Person
    {
        public Person(string fullname, int age)
        {
            FullName = FullName;
            Age = age;
        }
        public string FullName { get; set; } = "";
        public int Age { get; set; }

        public void ToDo()
        {
            Console.WriteLine("Делаю дела");
        }
        public virtual string ReturnFullName()
        {
            return $"{FullName}";
        }
    }
}
