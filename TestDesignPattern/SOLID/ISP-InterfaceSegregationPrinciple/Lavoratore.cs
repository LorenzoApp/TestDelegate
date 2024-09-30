using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.ISP_InterfaceSegregationPrinciple
{
    public class Lavoratore : IWork, IEater
    {
        public void mangia()
        {
            Console.WriteLine("Sto mangiandoooo!");
        }

        public void lavora()
        {
            Console.WriteLine("Sono un lavoratore, sto Lavorandooo!");
        }
    }
}
