using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Point
    {
        //поля
        int x;
        int y;
        string pointName;

        //свойства
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string PointName
        {
            get
            {
                return pointName;
            }
        }

        //конструктор
        public Point (int x, int y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }
    }
}
