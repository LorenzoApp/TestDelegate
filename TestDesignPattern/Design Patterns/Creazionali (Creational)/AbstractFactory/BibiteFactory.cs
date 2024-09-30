using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.AbstractFactory
{
    public class BibiteFactory : AbstractFactory
    {
        //un altro modo per scriverlo senza controllare se == null nella get (grazie a readonly che una volta istanziato non cambia)
        //private static readonly Logger Instance = new Logger();

        private static BibiteFactory? bibiteFactory;

        private BibiteFactory() { }

        public static BibiteFactory Instance
        {
            get
            {
                if (bibiteFactory == null)
                {
                    bibiteFactory = new BibiteFactory();
                }
                return bibiteFactory;
            }
        }

        protected override Type? GetTipo(string oggetto)
        {
            //prendi dall'assembly tutti i tipi dosponibili collegati all'interfaccia IProdotto
            var tipi = Assembly.GetAssembly(typeof(BibiteFactory)).GetTypes()
                        .Where(x => typeof(IBibita).IsAssignableFrom(x));

            //prendi solo quello che contiene la parola presa da input (da fuori)
            var productType = tipi.FirstOrDefault(x => x.Name.Contains(oggetto));

            return productType;
        }
    }
}
