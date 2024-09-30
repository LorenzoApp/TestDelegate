using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.AbstractFactory
{
    public abstract class AbstractFactory
    {
        protected abstract Type? GetTipo(string oggetto);

        public IFactory Create(string oggetto)
        {
            var tipo = GetTipo(oggetto);

            return FactoryMethod(tipo);
        }

        private IFactory FactoryMethod(Type? tipo)
        {
            if (tipo == null)
            {
                throw new ArgumentNullException(nameof(tipo));
            }

            return Activator.CreateInstance(tipo) as IFactory;
        }
    }
}
