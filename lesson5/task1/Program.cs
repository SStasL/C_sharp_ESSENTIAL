using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random oRandom = new Random();
            //создание массива
            int[] MyArray = new int[10];

            //цикл для заполнения массива
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = oRandom.Next(0, 11);
            }

            //цикл вывод элементов массива на єкран
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write((MyArray[i]) + " ");
                if (i == (MyArray.Length - 1))
                {
                    Console.WriteLine();
                }
            }


            //наибольшее значение массива
            Console.WriteLine("наибольшее значение в массиве {0}", MyArray.Max());

            //наименьшее значение массива
            Console.WriteLine("наименьшее значение в массиве {0}", MyArray.Min());

            //общая сумма элеметов массива
            Console.WriteLine("общая сумма в массиве {0}", MyArray.Sum());

            //AVG
            Console.WriteLine("среднеарифметическое значение в массиве {0}", MyArray.Average());


            //цикл вывода нечетных элементов массива на єкран
            for (int i = 0; i < MyArray.Length; i++)
            {
                if ((MyArray[i])%2 == 0)
                {
                    Console.Write((MyArray[i]) + " ");
                    if (i == (MyArray.Length - 1))
                    {
                        Console.WriteLine();
                    }
                }
            }

            //пауза
            Console.ReadKey();
        }
    }
}
