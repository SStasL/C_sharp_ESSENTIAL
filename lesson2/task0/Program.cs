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
            new User("login", "ivan", "ivanoff", 25, "25.03.2015").Show();
            Console.ReadKey();
        }
    }
}
