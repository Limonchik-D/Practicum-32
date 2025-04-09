using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Practicum_32
{
    internal class Student : Person //Студент
    {
        private string faculty; //Факультет
        private int course; //Курс

        public string Faculty //Свойство для доступа к факультету   
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public int Course //Свойство для доступа к Курсу   
        {
            get { return course; }
            set { course = value; }
        }

        public Student(string name, string surname, DateTime birthdate, string faculty, int course) : base(name, surname, birthdate)
        {
            this.faculty = faculty;
            this.course = course;
        }

        public override void Information()
        {
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Возраст: {GetAge()} лет, Факультет: {Faculty}, Курс: {Course}");
            Console.WriteLine();
        }
    }
}
