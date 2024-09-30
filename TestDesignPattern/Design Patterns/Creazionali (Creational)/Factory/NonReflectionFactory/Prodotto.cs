using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NonReflectionFactory
{
    public abstract class Prodotto
    {
        public abstract Prodotto CreaProdotto();
        public abstract void CheProdotto();
    }
}
