using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Author
    {
        //поле
        string data;

        //свойство
        public string Data
        {
            set
            {
                data = value;
            }
        }

        //метод
        public void Show()
        {
            Console.WriteLine(data);
        }
    }
}
