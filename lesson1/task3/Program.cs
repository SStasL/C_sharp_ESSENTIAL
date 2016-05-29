using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point oPoint1 = new Point(10, 10, "point1");
            Point oPoint2 = new Point(30, 30, "point2");
            Point oPoint3 = new Point(40, 40, "point2");
            Point oPoint4 = new Point(50, 40, "point2");
            Point oPoint5 = new Point(50, 40, "point2");

            Figure oFigure = new Figure(oPoint1, oPoint2, oPoint3);

            oFigure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
