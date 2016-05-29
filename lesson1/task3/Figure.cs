using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Figure
    {
        //поля
        Point p1 = null;
        Point p2 = null;
        Point p3 = null;
        Point p4 = null;
        Point p5 = null;
        string figureName = null;

       

        //свойства
        public string FigureName
        {
            get
            {
                return figureName;
            }
        }

        //конструкторы
        public Figure()
        {
            OpredFigureName();
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            OpredFigureName();
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            OpredFigureName();
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            OpredFigureName();
        }



        //методы
        //метод определения фигуры
        void OpredFigureName()
        {
            if ((p1 != null) && (p2 != null) && (p3 != null) && (p4 == null) && (p5 == null))
            {
                figureName = "triangle";
            }
            if ((p1 != null) && (p2 != null) && (p3 != null) && (p4 != null) && (p5 == null))
            {
                figureName = "quadrangle";
            }
            if ((p1 != null) && (p2 != null) && (p3 != null) && (p4 != null) && (p5 != null))
            {
                figureName = "pentagon";
            }
        }

        //расчет длины стороны многоугольника
        double LenghtSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        //расчет периметра
        public void PerimeterCalculator()
        {
            if (Equals("triangle", figureName))
            {
                //вычисление периметра треугольника
                double @l1 = LenghtSide(p1, p2);
                double @l2 = LenghtSide(p2, p3);
                double @l3 = LenghtSide(p3, p1);
                double @sum = @l1 + @l2 + @l3;
                Console.WriteLine("perimeter " + figureName + " =" + @sum);
            }
            
        }
    }
}
