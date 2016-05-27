using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyMatrix
    {
        //поля
        int lenghtX = 0;
        int lenghtY = 0;
        int[,] Matrix;

        //свойства
        public int LenghtY
        {
            get
            {
                return Matrix.GetLength(0);
            }
        }
        public int LenghtX
        {
            get
            {
                return Matrix.GetLength(1);
            }
        }

        //индексатор
        public int this [int indexX, int indexY]
        {
            set
            {
                Matrix [indexY, indexX] = value;
            }

            get
            {
                return Matrix[indexY, indexX];
            }
        } 
        //конструктор
        public MyMatrix(int lenghtX, int lenghtY)
        {
            this.lenghtX = lenghtX;
            this.lenghtY = lenghtY;
            Matrix = new int[lenghtY, lenghtX];
        }
        
        //метод
        public void Show ()
        {
            Random oRandom = new Random();
            for (int i  = 0; i  < Matrix.GetLength(0); i ++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    //Matrix[i, j] = oRandom.Next(0, 10);
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
