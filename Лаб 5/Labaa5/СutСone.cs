using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    class СutCone:Cone
    {

        private double SmallRadius { get; set; }


        public СutCone(double rad, double hieght, double gen, double srad):base(rad, rad, gen)
        {
            (BigRadius, SmallRadius, Hieght, Generetix) = (rad, srad, hieght, gen);
        }

        public override double GetVol() =>
            (Math.Pow(SmallRadius, 2)+SmallRadius * BigRadius+Math.Pow(BigRadius,2))*Hieght / 3;
        public override double GetSquare() =>
            Math.Pow(SmallRadius, 2)+ (SmallRadius+BigRadius) * Generetix + Math.Pow(BigRadius,2);
       public override double GetBigRad() => BigRadius;
       public double GetSmallRad() => SmallRadius;
        public override double  GetHieght() => Hieght;
               
        public override double Getgen() => Generetix;
       
    }
}
