using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        struct Notebook
        {
            //поля
            string model;
            string manufactory;
            double price;

            //конструктор
            public Notebook(string model, string manufactory, double price)
            {
                this.model = model;
                this.manufactory = manufactory;
                this.price = price;
            }

            //метод
            public void Show()
            {
                Console.WriteLine("model is {0} manufactory is {1} price is {2}", model, manufactory, price);
            }
        }
        static void Main(string[] args)
        {
            Notebook oNotebook = new Notebook("d620", "Dell", 100.0);

            oNotebook.Show();

            Console.ReadKey();
        }
    }
}
