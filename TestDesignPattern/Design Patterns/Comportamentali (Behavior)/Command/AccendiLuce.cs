using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Command
{
    /// <summary>
    /// Il nostro ConcreteCommand
    /// </summary>
    public class AccendiLuce : ICommand
    {
        private Luce luce;

        public AccendiLuce(Luce luce)
        {
            this.luce = luce;
        }

        public void Execute()
        {
            luce.Accendi();
            Console.WriteLine("Light turned on");
        }
    }
}
