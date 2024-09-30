using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class Assorbenti : Prodotto, ICalcolatorePrezzo
    {
        public Assorbenti()
        {
            this.IvaPublic = 0.5;
        }

        public double CalcolaPrezzo()
        {
            return this.prezzoPublic * this.quantitaPublic * this.IvaPublic;
        }
    }
}
