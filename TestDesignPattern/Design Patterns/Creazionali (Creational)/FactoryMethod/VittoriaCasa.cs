using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod
{
    public class VittoriaCasa : IPartita
    {
        public string ConfrontaPartita(int casa, int trasferta)
        {
           return "Vittoria Casa";
        }
    }
}
