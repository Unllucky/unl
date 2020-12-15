using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Manager:Human
    {
        public string Firm { get; set; }
        public Manager(string a,string b, string c) : base(a, b)
        {
            
            Firm = c;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nLast Name: {LastName}\nFirm - {Firm}";
        }
        public override void show()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
