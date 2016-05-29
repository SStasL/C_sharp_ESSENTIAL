using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book oBook = new Book("лис микита","Франко","its cool book");
            oBook.Show();

            Console.ReadKey();
        }
    }
}
