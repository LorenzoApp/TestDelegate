using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NonReflectionFactory
{
    public class AlimentariNonReflection : Prodotto
    {
        public override AlimentariNonReflection CreaProdotto()
        {
            return new AlimentariNonReflection();
        }

        public override void CheProdotto()
        {
            Console.WriteLine("Alimentari");
        }

        public static void Register()
        {
            NonReflectionFactory.Instance.RegisterProduct("Prodotto1ID", () => new AlimentariNonReflection());
        }
    }
}
