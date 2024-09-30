using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Builder
{
    public class DirectorPizza
    {
        public DirectorPizza() { }

        public Pizza CreaMargherita(IPizzaBuilder builder)
        {
            return builder.SetImpasto(TipoImpasto.Classico)
                      .SetSalsa(TipoSalsa.Pomodoro)
                      .SetMozzarella(Mozzarella.FiorDiLatte)
                      .Build();
        }

        public Pizza CreaCapricciosa(IPizzaBuilder builder)
        {
            return builder.SetImpasto(TipoImpasto.Classico)
                          .SetSalsa(TipoSalsa.Pomodoro)
                          .SetMozzarella(Mozzarella.FiorDiLatte)
                          .AggiungiCondimento(Condimento.Prosciutto)
                          .AggiungiCondimento(Condimento.Funghi)
                          .AggiungiCondimento(Condimento.Carciofi)
                          .AggiungiCondimento(Condimento.Olive)
                          .Build();
        }

        /// <summary>
        /// Da studiare come fare una pizza Custom
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        public Pizza CreaPizzaPersonalizzata(Pizza pizza)
        {
            return pizza;
        }
    }
}
