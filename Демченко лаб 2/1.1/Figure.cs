using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1._1
{
    class Figure
    {
        Point a;
        Point b;
        Point c;
        Point d;
        Point e;


        public Figure(Point A, Point B, Point C) {

            a = A;
            b = B;
            c = C;
        }
        public Figure(Point A, Point B, Point C,Point D)
        {

            a = A;
            b = B;
            c = C;
            d = D;
        }
        public Figure(Point A, Point B, Point C, Point D,Point E)
        {

            a = A;
            b = B;
            c = C;
            d = D;
            e = E;
        }

        public void LengthSide(Point A, Point B) =>
           Console.WriteLine( Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
      public  void PerimeterCalculator(Point A, Point B, Point C)
        {

            double ab= Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double bc = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            double ac = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            Console.WriteLine(ab+bc+ac);
        }
public void PerimeterCalculator(Point A, Point B, Point C,Point D)
        {

            double ab = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double bc = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            double cd = Math.Sqrt(Math.Pow(D.X - C.X, 2) + Math.Pow(D.Y - C.Y, 2));
            double ad= Math.Sqrt(Math.Pow(A.X - D.X, 2) + Math.Pow(A.Y - D.Y, 2));
            Console.WriteLine(ab + bc + cd+ ad);
        }
        public void PerimeterCalculator(Point A, Point B, Point C, Point D,Point E)
        {

            double ab = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double bc = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            double cd = Math.Sqrt(Math.Pow(D.X - C.X, 2) + Math.Pow(D.Y - C.Y, 2));
            double de = Math.Sqrt(Math.Pow(E.X - D.X, 2) + Math.Pow(E.Y - D.Y, 2));
            double ae= Math.Sqrt(Math.Pow(A.X - E.X, 2) + Math.Pow(A.Y - E.Y, 2));
            Console.WriteLine(ab + bc + cd + de +ae);
        }


    }
}
