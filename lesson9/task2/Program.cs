using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //создание делегата который возвращает double, а в качестве входных параметров принимает массив типа MyDelegate
    public delegate double MyDelegate(MyDel[] array);

    //создание делегата который возвращает int (будет возвращать random) без входных параметров
    public delegate int MyDel();

    class Program
    {

        static void Main(string[] args)
        {

            //создание массыва делегатов
            MyDel[] delArray = new MyDel[3];

            //Random
            Random rnd = new Random();

            //методы сообщенные с делегатом MyDel для массива
            delArray[0] = delegate { return rnd.Next(1, 100); };
            delArray[1] = delegate { return rnd.Next(1, 100); };
            delArray[2] = delegate { return rnd.Next(1, 100); };

            
            //метод сообщенный с делегатом MyDelegate
            MyDelegate myDelegate = delegate (MyDel[] array) 
            {
                int count = 0;
                int maxCount = array.Length;
                for (int i = 0; i < maxCount; i++)
                {
                    count += array[i].Invoke();
                    Console.WriteLine(count);
                }
                return count / maxCount;

            };


            Console.WriteLine("MyDelegate = " + myDelegate(delArray));

            Console.ReadKey();
        }
    }
}