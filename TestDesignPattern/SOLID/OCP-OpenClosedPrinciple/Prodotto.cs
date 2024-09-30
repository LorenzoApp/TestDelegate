using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{
    public class Prodotto
    {

        private double prezzoPrivate;
        public double prezzoPublic
        {
            get { return prezzoPrivate; }
            set { prezzoPrivate = value; }
        }

        private double quantitaPrivate;
        public double quantitaPublic
        {
            get { return quantitaPrivate; }
            set { quantitaPrivate = value; }
        }

        private double ivaPrivate;
        protected double IvaPublic
        {
            get { return ivaPrivate; }
            set { ivaPrivate = value; }
        }

    }
}
