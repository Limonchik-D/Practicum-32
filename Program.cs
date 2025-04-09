using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>(); //Создание списка для хранения объектов Person

            persons.Add(new Enrollee("Иван", "Иванов", new DateTime(2005, 5, 15), "Факультет информационных технологий"));
            persons.Add(new Student("Петр", "Петров", new DateTime(2003, 3, 20), "Факультет математики", 2));
            persons.Add(new Teacher("Сидор", "Сидоров", new DateTime(1980, 1, 10), "Факультет физики", "Профессор", 15));
            persons.Add(new Student("Алексей", "Алексеев", new DateTime(2002, 7, 25), "Факультет химии", 3));

            Console.WriteLine("Список персон:");
            Console.WriteLine("---------");
            foreach (var person in persons)
            {
                person.Information();
            }

            Console.WriteLine();

            //Поиск персон по заданому вощрастному диапазону
            Console.WriteLine("Введите минимальынй возраст: ");
            int minAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальный возраст: ");
            int maxAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nПерсоны в возрасте от {minAge} до {maxAge} лет:");

            foreach (var person in persons)
            {
                int age = person.GetAge();
                if (age >= minAge && age <= maxAge)
                {
                    person.Information();
                }
            }

            Console.ReadLine();

        }
    }
}
