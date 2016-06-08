using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    //Создание класса делегата
    delegate double MyDelegate(int var1, int var2, int var3);

    class Program
    {

        static void Main(string[] args)
        {
            //Анонимный метод
            MyDelegate myDelegate = delegate (int var1, int var2, int var3) { return (var1 + var2 + var3) / 3; };

            double avg = myDelegate(5, 5, 5);

            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}

