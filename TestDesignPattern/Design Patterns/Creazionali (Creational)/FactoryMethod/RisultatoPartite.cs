using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod
{
    public class RisultatoPartite
    {
        public IPartita? FactoryMethodPartite(string nomeClass)
        {
            //prendi dall'assembly tutti i tipi dosponibili collegati all'interfaccia IPartita
            var tipi = Assembly.GetAssembly(typeof(RisultatoPartite)).GetTypes()
                        .Where(x => typeof(IPartita).IsAssignableFrom(x));

            //prendi solo quello che contiene la parola presa da input (da fuori)
            var productType = tipi.FirstOrDefault(x => x.Name.Contains(nomeClass));

            return Activator.CreateInstance(productType) as IPartita;
        }
    }
}
