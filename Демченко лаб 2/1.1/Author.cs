using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Author
    {

        public string aut;
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(aut);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
