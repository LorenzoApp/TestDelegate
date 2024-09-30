using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    internal class LoggerPdf : ITipoLog
    {
        public string? messaggio { get; set; }

        public LoggerPdf(string messaggio)
        {
            this.messaggio = messaggio;
        }

        public void ScriviLog()
        {
            Console.WriteLine("Pdf: " + messaggio);
        }
    }
}
