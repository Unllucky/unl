using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    class TringleMatrix : Matrix
    {
        public TringleMatrix(int m, int n) : base(m, n)
        {
            (M, N) = (m, n);
            data = new double[m, n];
        }

        public override void Show()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(data[i, j] + " ");
                Console.WriteLine();
            }
        }

        public override void Fill()
        {
            Random r = new Random();
            
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    if(i<=j)
                        data[i, j] = r.Next(0,10);
                    else
                    {
                        data[i, j] = 0;
                    }


                }

        }
    }
}
