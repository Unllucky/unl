using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Bla1 : Bla0
    { 
        public override void bla(params int[]b){
            for(int i =0;i<b.Length;i++)
            Console.WriteLine(b[i].GetType().ToString());
            }
    }
}
