using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class Merendine : Prodotto, ICalcolatorePrezzo
    {
        public Merendine()
        {
            this.IvaPublic = 0.20;
        }

        public double CalcolaPrezzo()
        {
            return this.prezzoPublic * this.quantitaPublic * this.IvaPublic;
        }
        
    }
}
