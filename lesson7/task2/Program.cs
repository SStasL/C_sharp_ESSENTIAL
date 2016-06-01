using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        //метод для MyClass
        static void ClassTaker(MyClass oMyClass)    //должен присвоить полю change экземпляра oMyClass значение "изменено"
        {
            oMyClass.change = "changed";
        }

        //метод для MyStruct
        static void StructTaker(MyStruct oMyStruct)    //должен присвоить полю change экземпляра oMyStruct значение "изменено"
        {
            oMyStruct.change = "changed";
        }
        static void StructTaker(ref MyStruct oMyStruct)
        {
            oMyStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            MyClass oMyClass = new MyClass();
            Console.WriteLine("после создания объекта " + oMyClass.change);
            oMyClass.change = "not changed";
            Console.WriteLine("после прямого обращения к полю объекта " + oMyClass.change);
            ClassTaker(oMyClass);
            Console.WriteLine("после вызова статического метода " + oMyClass.change);


            MyStruct oMyStruct = new MyStruct();
            Console.WriteLine("после создания объекта " + oMyStruct.change);
            oMyStruct.change = "not changed";
            Console.WriteLine("после прямого обращения к полю объекта " + oMyStruct.change);
            StructTaker(oMyStruct);
            Console.WriteLine("после вызова статического метода " + oMyStruct.change);

            StructTaker(ref oMyStruct);
            Console.WriteLine("после вызова статического метода ref " + oMyStruct.change);

            Console.ReadKey();
        }
    }
}
