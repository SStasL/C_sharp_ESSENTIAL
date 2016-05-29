using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Converter
    {
        //поля
        readonly double kusd;
        readonly double keur;
        readonly double krur;
        double inValue;
        double outUsd;

        //свойства
        public double InValue
        {
            set
            {
                inValue = value;
            }
        }
        public double OutValue
        {
            get
            {
                outUsd = Convertusd();
                return outUsd;
            }
        }

        //конструктор
        public Converter(double kusd, double keur, double krur)
        {
            this.kusd = kusd;
            this.keur = keur;
            this.krur = krur;
        }

        //метод
        private double Convertusd()
        {
            return inValue / kusd;
        }
    }
}
