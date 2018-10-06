using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_Inheritance
{
    public sealed class Mentor : Person //sealed Запрет на наслеодвание от этого класса
    {
        public Mentor(string fullName, int age, int stage)
            : base(fullName, age) //Делегируем в конструктор базового тимпа
        {
            Stage = stage;
        }
        public int Stage { get; set; }

        public new void ToDo()
        {
            Console.WriteLine("Делаю дела как преподаватель");
        }

        public override string ReturnFullName()
        {
            return $"{FullName} стаж {Stage}";
        }

        public override void SaySomething()
        {

        }
    }
}
