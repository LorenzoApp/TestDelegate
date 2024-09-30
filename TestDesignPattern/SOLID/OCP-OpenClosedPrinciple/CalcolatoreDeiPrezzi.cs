using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class CalcolatoreDeiPrezzi
    {
        public double CalcolaIlPrezzo(ICalcolatorePrezzo calcolatorePrezzo)
        {
            return calcolatorePrezzo.CalcolaPrezzo();
        }
    }
}
