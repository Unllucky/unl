using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
   class Bla0
    {
        public virtual void bla(params int[] a)
        {
            int tot = a.Length;
            for(int i =0;i<tot;i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (i % 3 == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                
                    Console.ForegroundColor = ConsoleColor.Yellow;

                


                Console.WriteLine($"{tot}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
