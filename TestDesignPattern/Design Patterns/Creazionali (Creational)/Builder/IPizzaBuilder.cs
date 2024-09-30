using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Builder
{
    /// <summary>
    /// L'interfaccia (Builder) che fornisce tutti metodi che servono per "costruire" pezzo per pezzo una Pizza (Product)
    /// </summary>
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetImpasto(TipoImpasto impasto);
        IPizzaBuilder SetSalsa(TipoSalsa salsa);
        IPizzaBuilder SetMozzarella(Mozzarella mozzarella);
        IPizzaBuilder AggiungiCondimento(Condimento condimento);
        Pizza Build();
    }
}
