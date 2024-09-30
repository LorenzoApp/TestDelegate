using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    internal class LoggerImm : ITipoLog
    {
        public string? messaggio { get; set; }

        public LoggerImm(string messaggio)
        {
            this.messaggio = messaggio;
        }

        public void ScriviLog()
        {
            Console.WriteLine("Immagine: " + messaggio);
        }

    }
}
