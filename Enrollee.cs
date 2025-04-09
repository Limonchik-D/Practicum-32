using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_32
{
    internal class Enrollee : Person //Абитуриент
    {
        private string faculty; //Факультет

        public string Faculty //Свойство для доступа к факультету
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Enrollee (string name, string surname, DateTime birthDate, string faculty) : base(name, surname, birthDate) //Конструктор 
        {
            this.Faculty = faculty;
        }

        public override void Information()
        {
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Возраст: {GetAge()} лет, Факультет: {Faculty}");
            Console.WriteLine();
        }
    }
}
