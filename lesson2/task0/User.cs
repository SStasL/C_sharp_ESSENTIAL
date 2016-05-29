using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class User
    {
        //поля
        readonly string login;
        readonly string firstName;
        readonly string lastName;
        readonly int age;
        readonly string date;

        //конструктор
        public User(string login, string firstName, string lastName, int age, string date)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.date = date;
        }

        //метод
        public void Show()
        {
            Console.WriteLine(login);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(date);
        }
    }
}
