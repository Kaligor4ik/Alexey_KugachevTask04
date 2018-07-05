using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем через конструктор с полями по умолчанию: User u = new User('Петров');");
            User u = new User("Петров");
            UserPrinter.Print(u);

            Console.WriteLine("Создаем через конструктор с заданными полями: User u = new User('Петров', 'Игорь','Петрович')");
            User u2 = new User("Петров", "Игорь", "Петрович");
            UserPrinter.Print(u2);

            Console.WriteLine("Создаем через конструктор по умолчанию и устанавливаем значения полей через свойства: User u = new User()");
            User u3 = new User
            {
                LastName = "Петров",
                FirstName = "Игорь",
                MiddleName = "Петрович",
                BirthDate = "21.02.2011",
                Age = "7"
            };
            UserPrinter.Print(u3);
            Console.ReadKey();
        }
    }
}
