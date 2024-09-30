using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.ReflectionFactory;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NonReflectionFactory
{
    //
    public sealed class NonReflectionFactory
    {
        private static readonly NonReflectionFactory _instance = new NonReflectionFactory();
        private readonly Dictionary<string, Func<Prodotto>> _products = new Dictionary<string, Func<Prodotto>>();

        private NonReflectionFactory() { }

        public static NonReflectionFactory Instance
        {
            get { return _instance; }
        }

        public void RegisterProduct(string productId, Func<Prodotto> productCreator)
        {
            if (_products.ContainsKey(productId))
            {
                throw new ArgumentException($"Product with ID '{productId}' already registered");
            }
            _products.Add(productId, productCreator);
        }

        public Prodotto CreaProdotto(string productId)
        {
            if (!_products.TryGetValue(productId, out Func<Prodotto> productCreator))
            {
                throw new ArgumentException($"Product with ID '{productId}' not found");
            }
            return productCreator();
        }

    }
}
