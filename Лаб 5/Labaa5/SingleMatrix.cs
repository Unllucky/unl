using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    class SingleMatrix: Matrix
    {
        public SingleMatrix(int m, int n):base(m,n)
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

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++) {
                    if (j == i)
                        data[i, j] = 1;
                    else
                        data[i, j] = 0;

            }

        }
    }
}
