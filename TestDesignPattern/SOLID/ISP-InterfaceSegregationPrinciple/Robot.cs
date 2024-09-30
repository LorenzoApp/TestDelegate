using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.ISP_InterfaceSegregationPrinciple
{
    public class Robot : IWork
    {
        public void lavora()
        {
            Console.WriteLine("Sono un Robot, sto lavorando!");
        }
    }
}
