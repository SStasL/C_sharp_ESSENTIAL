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
            Train[] aTrain = new Train[3];

            for (int i = 0; i < aTrain.Length; i++)
            {
                Console.WriteLine("enter end point");
                aTrain[i].EndPoint = Console.ReadLine();
                Console.WriteLine("enter ntrain");
                aTrain[i].NTrain = Console.ReadLine();
                Console.WriteLine("enter time");
                aTrain[i].Time = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("enter number of train");
            string numberOfTrain = Console.ReadLine();
            for (int i = 0; i < aTrain.Length; i++)
            {
                if (aTrain[i].NTrain.Equals(numberOfTrain))
                {
                    aTrain[i].Show();
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            
            Console.WriteLine("not possible number");
            Console.ReadKey();
            
        }
    }
}
