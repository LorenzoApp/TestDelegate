using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class Latte : Prodotto, ICalcolatorePrezzo
    {
        public Latte()
        {
            this.IvaPublic = 0.15;
        }

        public double CalcolaPrezzo()
        {
            return this.prezzoPublic * this.quantitaPublic * this.IvaPublic;
        }
    }
}
