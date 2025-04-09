using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_32
{
    internal class Teacher : Person //Учитель
    {
        private string faculty; //Факультет
        private string post; //Должность
        private int experience; //Стаж

        public string Faculty //Свойство для доступа к факультету
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Post //Свойство для доступа к должности
        {
            get { return post; }
            set { post = value; }
        }
        public int Experience //Свойство для доступа к стажу
        {
            get { return experience; }
            set { experience = value; }
        }
        public Teacher(string name, string surname, DateTime birthdate, string faculty, string post, int experience) : base(name, surname, birthdate) //Конструктор
        {
            this.faculty = faculty;
            this.post = post;
            this.experience = experience;
        }

        public override void Information()
        {
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Возраст: {GetAge()} лет, Факультет: {Faculty}, Должность: {Post}, Стаж: {Experience} лет");
            Console.WriteLine();
        }
    }
}
