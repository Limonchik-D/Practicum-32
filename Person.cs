using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_32
{
    abstract class Person //Инофрмация о персоне
    {
        private string name; //Имя
        private string surname; //Фамилия
        private DateTime birthdate; //Возраст

        public string Name //Свойстводля доступа к имени
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname //Свойство для доступа к Фамилии
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime Birthdate //Свойство для доступа к Возрасту
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Person(string name, string surname, DateTime birthdate)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
        }

        public int GetAge() //Метод для получения возраста
        {
            DateTime now = DateTime.Now; //Текущая дата
            int age = now.Year - birthdate.Year;
            if (now < birthdate.AddYears(age))
            {
                age--;
            }
            return age;
        }

       public abstract void Information(); //Абстрактный метод для получения информации о персоне

    }
}
