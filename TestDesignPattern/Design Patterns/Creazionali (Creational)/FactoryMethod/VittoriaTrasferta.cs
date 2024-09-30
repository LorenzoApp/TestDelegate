using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod
{
    public class VittoriaTrasferta : IPartita
    {
        public string ConfrontaPartita(int casa, int trasferta)
        {
            return "Vittoria Trasferta";
        }
    }
}
