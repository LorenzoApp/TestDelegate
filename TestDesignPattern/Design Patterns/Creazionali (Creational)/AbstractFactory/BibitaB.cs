using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.AbstractFactory
{
    public class BibitaB : IBibita
    {
        public void Stampa()
        {
            Console.WriteLine("Stampa BibitaB");
        }
    }
}
