using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Adress
    {
        //поля
        string index;
        string country;
        string city;
        string street;
        string house;
        string apartment;

        //свойства
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
    }
}
