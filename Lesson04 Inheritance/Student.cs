using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_Inheritance
{
    public class Student : Person
    {   //быстрый конструктор ctrl+.
        public Student(string fullname, int age) : base(fullname, age)
        {
       
        }
        public string GroupName { get; set; }
        public double AverageMark { get; set; }

        public override void SaySomething()
        {
            throw new NotImplementedException();
        }
    }
}
