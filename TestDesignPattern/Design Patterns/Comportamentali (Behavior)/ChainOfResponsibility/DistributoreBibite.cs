using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.ChainOfResponsibility
{
    public class DistributoreBibite : Distributore
    {
        protected override bool GestisciClienteImpl(Cliente cliente)
        {
            bool res = false;

            if (cliente.desiderio is "Bibita")
            {
                Console.WriteLine("Ho comprato una bibita");

                res = true;
            }

            return res;
        }
    }
}
