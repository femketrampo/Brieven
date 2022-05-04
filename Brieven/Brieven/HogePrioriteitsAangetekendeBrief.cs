using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brieven
{
    class HogePrioriteitsAangetekendeBrief : AangetekendeBrief
    {
        //tijd = afstand / 200 round UP
        //30 euro per 100km
        public override void Berekenen(double reisafstand, double kostprijs, byte reistijd)
        {
            Kostprijs = 30 * (reisafstand / 100 - (reisafstand % 100));
            Reistijd = Convert.ToByte(Math.Round(reisafstand / 100));
        }
    }
}
