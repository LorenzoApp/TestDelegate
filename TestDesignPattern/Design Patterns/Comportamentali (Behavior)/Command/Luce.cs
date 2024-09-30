using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Command
{
    /// <summary>
    /// Questa classe è la nostra classe Receiver
    /// </summary>
    public class Luce
    {
        private bool statoLuce;

        public void Accendi()
        {
            statoLuce = true;
        }

        public void Spegni()
        {
            statoLuce = false;
        }
    }
}
