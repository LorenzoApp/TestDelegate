using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.ReflectionFactory
{
    internal class PayPal_Reflection : IMetodiPagamento
    {
        public void Paga()
        {
            Console.WriteLine("Paypal");
        }
    }
}
