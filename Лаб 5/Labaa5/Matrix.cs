using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    public partial class Matrix
    {
        protected double[,] data;

        protected int M { get; set; }
        protected int N { get; set; }

        public Matrix(int m, int n)
        {
            (M, N) = (m, n);
            data = new double[m, n];
        }
        public virtual void Show()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(data[i, j] + " ");
                Console.WriteLine();
            }
        }

        public virtual void Fill()
        {
            Random r = new Random();
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    data[i, j] = r.Next(0, 10);

        }

    }
}
