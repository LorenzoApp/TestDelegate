using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Builder
{
    //BuilderPizza è la nostra ConcreteBuilder, che si occuperà di fornire l'effettiva implementazione per la creazione della pizza
    //infatti avremo tutti i metodi per creare la pizza desiderata (non è detto che vanno usati tutti)
    public class BuilderPizza : IPizzaBuilder
    {
        private Pizza pizza;

        public BuilderPizza()
        {
            this.Reset();
        }

        public Pizza Build()
        {
            Pizza lapizza = this.pizza;

            this.Reset();

            return lapizza;
        }

        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public IPizzaBuilder AggiungiCondimento(Condimento condimento)
        {
            pizza.Condimenti.Add(condimento);
            return this;
        }

        public IPizzaBuilder SetImpasto(TipoImpasto impasto)
        {
            pizza.Impasto = impasto;
            return this;
        }

        public IPizzaBuilder SetMozzarella(Mozzarella mozzarella)
        {
            pizza.Mozzarella = mozzarella;
            return this;
        }

        public IPizzaBuilder SetSalsa(TipoSalsa salsa)
        {
            pizza.Salsa = salsa;
            return this;
        }
    }
}
