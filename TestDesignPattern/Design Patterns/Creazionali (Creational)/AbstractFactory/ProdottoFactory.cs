using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton;
using TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.AbstractFactory
{
    public class ProdottoFactory : AbstractFactory
    {
        private static ProdottoFactory? prodottoFactory;

        private ProdottoFactory() { }

        public static ProdottoFactory Instance
        {
            get
            {
                if (prodottoFactory == null)
                {
                    prodottoFactory = new ProdottoFactory();
                }
                return prodottoFactory;
            }
        }

        protected override Type? GetTipo(string oggetto)
        {
            //prendi dall'assembly tutti i tipi dosponibili collegati all'interfaccia IProdotto
            var tipi = Assembly.GetAssembly(typeof(ProdottoFactory)).GetTypes()
                        .Where(x => typeof(IProdotto).IsAssignableFrom(x));

            //prendi solo quello che contiene la parola presa da input (da fuori)
            var productType = tipi.FirstOrDefault(x => x.Name.Contains(oggetto));

            return productType;
        }
    }
}
