using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class Proteine : Prodotto, ICalcolatorePrezzo
    {

        public Proteine()
        {
            this.IvaPublic = 0.30;
        }

        public double CalcolaPrezzo()
        {
            return this.prezzoPublic * this.quantitaPublic * this.IvaPublic;
        }
    }
}
