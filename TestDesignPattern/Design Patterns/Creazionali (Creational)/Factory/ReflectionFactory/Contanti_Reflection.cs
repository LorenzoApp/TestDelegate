using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.ReflectionFactory
{
    public class Contanti_Reflection : IMetodiPagamento
    {
        public void Paga()
        {
            Console.WriteLine("Contanti");
        }
    }
}
