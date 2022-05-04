using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brieven
{
    class AangetekendeBrief
    {
        private double reisafstand;
        private double kostprijs; /*15 start, after +10 per 100km*/
        private byte reistijd; /*tijd = afstand / 100 round UP*/

        public double Reisafstand { get => reisafstand; set => reisafstand = value; }
        public double Kostprijs { get => kostprijs; set => kostprijs = value; }
        public byte Reistijd { get => reistijd; set => reistijd = value; }

        public virtual void Berekenen(double reisafstand, double kostprijs, byte reistijd)
        {
            Kostprijs = 15 + 10 * (reisafstand / 100 - (reisafstand % 100));
            Reistijd = Convert.ToByte(Math.Round(reisafstand / 100));
        }
    }
}
