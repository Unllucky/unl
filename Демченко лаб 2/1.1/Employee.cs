using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Employee
    {
        enum positoins
        {
            manager, director, courier
        }
    
        
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public Employee(string name, string lastname,string position) =>
            (Name, LastName,Position) = (name, lastname,position);

        public override string ToString()
        {
            return $"Name: {Name}\nLast Name: {LastName}";
        }

        public void EmployeeInfo()
        {
            int salary=0;
            string sbor = "5%";
            positoins p = positoins.courier;
            positoins p1 = positoins.manager;
            positoins p2 = positoins.director;


            if(Position == (p.ToString()))
                salary = 4000;

            if (Position == (p1.ToString()))
                salary = 8000;
            if (Position == (p2.ToString()))
                salary = 10000;
            Console.WriteLine(this);
            Console.WriteLine(salary+ "\n" + sbor);
        }

    }
}
