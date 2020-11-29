using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleMatrix matrix = new SingleMatrix(3, 4);

           // matrix.Fill();
           // matrix.Show();
            TringleMatrix tringleMatrix = new TringleMatrix(5, 5);
            tringleMatrix.Fill();
            tringleMatrix.Show();
        }
    }
}
