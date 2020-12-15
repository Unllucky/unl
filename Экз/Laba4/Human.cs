using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Human(string a, string b) { (Name, LastName) = (a, b); }
        public override string ToString()
        {
            return $"Name: {Name}\nLast Name: {LastName}";
        }
        public virtual void show()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
