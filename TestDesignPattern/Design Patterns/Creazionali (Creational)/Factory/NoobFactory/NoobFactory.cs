using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NoobFactory
{
    public sealed class NoobFactory
    {
        private static readonly NoobFactory instance = new NoobFactory();
        private NoobFactory() { }

        public static NoobFactory GetInstance
        {
            get
            {
                return instance;
            }
        }

        internal IForma? GetForma(string tipoForma)
        {
            switch (tipoForma)
            {
                case "cerchio":
                    return new Cerchio_Noob();
                case "quadrato":
                    return new Quadrato_Noob();
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}
