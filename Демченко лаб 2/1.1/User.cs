using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public DateTime DateTime {get;}

        public User(string login, string name, string lastname, byte age, DateTime dateTime) =>
            (Login, Name, LastName, Age, DateTime) = (login, name, lastname, age, dateTime);

        public override string ToString()=>
                $"Login: {Login}\nName: {Name}\nLast Name: {LastName}\nAge: {Age}\nDate-Time: {DateTime}";
        




    }
}
