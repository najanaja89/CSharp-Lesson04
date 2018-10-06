using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mentor mentor = new Mentor("Иван Иванович Иванов", 30, 13);
            Person student = new Student("Иван Иванович Иванов", 13); //Усечение Student до класса person

            //нельзя Person person = new Person();

            student.FullName = "Иван Иванович Иванов";
            //Привидение типов
            ((Student)student).GroupName = "SEP-162";
            //равносильно
            (student as Student).AverageMark = 11.3;

            if (student is Mentor)
            {
                (student as Mentor).Stage = 12;
            }
            else if (student is Student)
            {
                (student as Student).AverageMark = 11.3;
            }
            
        }
    }
}
