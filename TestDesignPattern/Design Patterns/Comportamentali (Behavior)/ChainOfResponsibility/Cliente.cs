using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.ChainOfResponsibility
{
    /// <summary>
    /// La nostra classe "Request"
    /// </summary>
    public class Cliente
    {
        public string desiderio;
        public string? nome { get; set; }

        public Cliente(string desiderio)
        {
            this.desiderio = desiderio;
        }
    }
}
