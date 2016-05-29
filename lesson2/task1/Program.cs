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
            Converter oConverter = new Converter(25, 30, 0.25);
            oConverter.InValue = 100;
            Console.WriteLine(oConverter.OutValue);

            Console.ReadKey();
        }
    }
}
