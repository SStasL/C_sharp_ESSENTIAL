using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        //метод
        static void BD()
        {
            Console.WriteLine("ввдедите год месяц и день Вашего рождения в виде XXXX/XX/XX год месяц день");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            //перевод введенной даты в строку и извлечение из строки месяца и дня
            string nextBirthDM = '.' + birthDay.ToString().Substring(3, 2) + '.' + birthDay.ToString().Substring(0, 2);
            Console.WriteLine("день и месяц рождения " + nextBirthDM);
            Console.WriteLine("МЕСЯЦ РОЖДЕНИЯ " + birthDay.Month);

            Console.WriteLine("дата Вашего рождения {0}", birthDay);        // введенный др

            DateTime now = DateTime.Now;
            Console.WriteLine("текщая дата {0}", now);
            Console.WriteLine("текущий год {0:yyyy}", now);

            //добавить + 1 год и добавть к нему месяц и день рождения
            if (birthDay.Month < now.Month)
            {
                //добавить + 1 год и добавть к нему месяц и день рождения
                DateTime nextYear = now.AddYears(1);
                Console.WriteLine("следующий год {0:yyyy}", nextYear);
                string sNextBirthDay = nextYear.ToString().Substring(6, 4) + nextBirthDM;
                Console.WriteLine("строка следующий ДР " + sNextBirthDay);
                //DateTime вычисление сколько дней осталось до ДР
                DateTime nextBirthDay = DateTime.Parse(sNextBirthDay);
                TimeSpan left = nextBirthDay.AddDays(1) - now;
                Console.WriteLine("до Вашего ДР осталось {0} дней", left.Days);
            }
            else
            {
                //не добавлять 1 год и добавть к нему месяц и день рождения
                //DateTime nextYear = now.AddYears(1);
                Console.WriteLine("следующий год {0:yyyy}", now);
                string sNextBirthDay = now.ToString().Substring(6, 4) + nextBirthDM;
                Console.WriteLine("строка следующий ДР " + sNextBirthDay);
                //DateTime вычисление сколько дней осталось до ДР
                DateTime nextBirthDay = DateTime.Parse(sNextBirthDay);
                TimeSpan left = nextBirthDay.AddDays(1) - now;
                Console.WriteLine("до Вашего ДР осталось {0} дней", left.Days);
            }

            
        }
        static void Main(string[] args)
        {
            BD();

            Console.ReadKey();
        }
    }
}
