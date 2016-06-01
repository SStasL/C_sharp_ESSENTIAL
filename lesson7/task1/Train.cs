using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct Train
    {
        //поля
        string endPoint;
        string nTrain;
        string time;

        //конструктор


        //свойства
        public string EndPoint
        {
            set
            {
                endPoint = value;
            }

            get
            {
                return endPoint;
            }
        }
        public string NTrain
        {
            set
            {
                nTrain = value;
            }

            get
            {
                return nTrain;
            }
        }
        public string Time
        {
            set
            {
                time = value;
            }

            get
            {
                return time;
            }
        }


        //метод
        public void Show()
        {
            Console.WriteLine("end point is {0} nTrain is {1} time is {2}", endPoint, nTrain, time);
        }

    }
}
