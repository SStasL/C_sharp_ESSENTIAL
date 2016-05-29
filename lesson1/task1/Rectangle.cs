using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Rectangle
    {
        //поля
        double side1;
        double side2;
        double p;
        double a;

        //пользовательский конструктор
        public Rectangle (double side1, double side2 )
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        //методы
        public double GetPerimeter()
        {
            return ((side1 * 2) + (side2 * 2));
        }
        public double GetArea()
        {
            return side1 * side2;
        }

        //свойства
        public double P
        {
            get
            {
                return GetPerimeter();
            }
        }
        public double A
        {
            get
            {
                return GetArea();
            }
        }
    }
}
