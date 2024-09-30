using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NonReflectionFactory
{
    public class Infantili_NonReflection : Prodotto
    {
        public override Infantili_NonReflection CreaProdotto()
        {
            return new Infantili_NonReflection();
        }

        public override void CheProdotto()
        {
            Console.WriteLine("Infantili");
        }

        public static void Register()
        {
            NonReflectionFactory.Instance.RegisterProduct("Prodotto2ID", () => new Infantili_NonReflection());
        }
    }
}
