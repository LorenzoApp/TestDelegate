using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.ChainOfResponsibility
{
    public class DistributorePanini : Distributore
    {
        protected override bool GestisciClienteImpl(Cliente cliente)
        {
            bool res = false;

            if (cliente.desiderio is "Panino")
            {
                Console.WriteLine("Ho comprato un Panino");

                res = true;
            }

            return res;
        }
    }
}
