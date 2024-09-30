using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.SRP_SingleResponsibilityPrinciple
{
    internal class UtenteReport : Utente
    {
        public void GeneraReport()
        {
            //fai qualcosa
            System.Console.WriteLine("Sto generando il report");

        }
    }
}
