using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Adress
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public uint Apartment { get; set; }
        public Adress(int index, string country, string city, string street, string house, uint apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    

        public override string ToString()
        {
            return $"Country: {Country}\nCity: {City}\nStreet: {Street}\nHouse: {House}\nApartment: {Apartment}";
        }











    }
}
