using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.SRP_SingleResponsibilityPrinciple
{
    public class UtenteAutorizzazioni : Utente
    {
        public void GestisciAutorizzazioni()
        {
            //fai qualcosa
            System.Console.WriteLine("Sto gestendo le autorizzazioni");
        }
    }
}
