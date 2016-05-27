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
            Random oRandom = new Random();
            MyMatrix oMyMatrix = new MyMatrix(10, 10);

            for (int i = 0; i < oMyMatrix.LenghtY; i++)
            {
                for (int j = 0; j < oMyMatrix.LenghtX; j++)
                {
                    oMyMatrix[i, j] = oRandom.Next(0, 10);
                }
            }

            oMyMatrix.Show();

            Console.ReadKey();
            
        }
    }
}
