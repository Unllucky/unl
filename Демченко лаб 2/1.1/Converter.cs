using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Converter
    {
        public double Usd { get; set; }
        public double Rub { get; set; }
        public double Eu { get; set; }

        public Converter(double usd, double rub, double eu) =>
            (Usd, Rub, Eu) = (usd, rub, eu);


        public void convertToUsd(double grn)=>
                     Console.WriteLine(grn / Usd);

        public void convertToRub(double grn) =>
            Console.WriteLine(grn / Rub);

        public void convertToUa(double grn) =>
                     Console.WriteLine(grn / Eu);

        public void convertUsdToGrn(double usd) =>
             Console.WriteLine(Usd*28.2);

        public void convertRubToGrn(double rub) =>
            Console.WriteLine(Rub*0.37);

        public void convertUaTogrn(double Ua) =>
                     Console.WriteLine( Eu*33.2);



    }
}
