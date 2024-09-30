using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    public class LoggerTxt : ITipoLog
    {

        public string? messaggio { get; set; }

        public LoggerTxt(string messaggio)
        {
            this.messaggio = messaggio;
        }

        public void ScriviLog()
        {
            Console.WriteLine("Txt: " + messaggio);
        }
    }
}
