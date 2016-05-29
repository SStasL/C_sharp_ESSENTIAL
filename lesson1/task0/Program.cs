using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress oAdress = new Adress();
            oAdress.Index = "61177";

            Console.WriteLine(oAdress.Index);

            Console.ReadKey();
        }
    }
}
