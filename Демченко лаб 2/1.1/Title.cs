using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
   class Title
    {
        public string tit;
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tit);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
