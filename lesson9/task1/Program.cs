using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public delegate double MyDelegate(double var1, double var2);

    class Program
    {
        static void Main(string[] args)
        {
            //создание переменных типа MyDelegate
            MyDelegate add, sub, mul, div;

            //лямбда операторы (должны содержать в себе операторные скобки {})
            add = (var1, var2) => { return var1 + var2; };

            sub = (var1, var2) => { return var1 - var2; };

            mul = (var1, var2) => { return var1 * var2; };

            div = (var1, var2) => 
            {
                if (var2 != 0)
                {
                    return var1 / var2;
                }
                else
                {
                    return 0;
                }
            };

            Console.WriteLine("5 + 5 = " + add(5, 5));
            Console.WriteLine("10 - 5 = " + sub(10, 5));
            Console.WriteLine("10 * 5 = " + mul(10, 5));
            Console.WriteLine("10 / 5 = " + div(10, 0));
            Console.ReadKey();
        }
    }
}
