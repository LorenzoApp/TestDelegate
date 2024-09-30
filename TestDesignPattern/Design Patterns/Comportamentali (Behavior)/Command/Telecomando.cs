using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Command
{
    /// <summary>
    /// La nostra classe Invoker 
    /// </summary>
    public class Telecomando
    {
        private ICommand comando;

        public void SetComando(ICommand comando)
        {
            this.comando = comando;
        }

        public void PremiBottone()
        {
            if (comando != null)
            {
                comando.Execute();
            }
        }

    }
}
