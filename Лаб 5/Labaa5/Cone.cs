using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa5
{
    class Cone
    {
        protected double BigRadius { get; set; }
        protected double Hieght { get; set; }
        protected double Generetix { get; set; }

        public Cone(double rad, double hieght,double gen) => (BigRadius, Hieght,Generetix) = (rad, hieght,gen);
        public virtual double GetVol()=>
            (Math.Pow(BigRadius, 2) * Hieght) / 3;
        public virtual double GetSquare() =>
            Math.Pow(BigRadius, 2) * BigRadius*Generetix;
        public virtual double GetBigRad() => BigRadius;
        public virtual double GetHieght() => Hieght;
        public virtual double Getgen() => Generetix;



    }
}
