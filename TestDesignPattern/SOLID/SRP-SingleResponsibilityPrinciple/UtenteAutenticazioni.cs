using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.SRP_SingleResponsibilityPrinciple
{
    internal class UtenteAutenticazioni : Utente

    {
       public void GestisciAutenticazioni()
        {
            //fai qualcosa
            System.Console.WriteLine("Sto gestendo le autenticazioni");
        }

    }
}

