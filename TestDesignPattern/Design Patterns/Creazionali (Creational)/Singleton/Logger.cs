using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    public sealed class Logger
    {
        //un altro modo per scriverlo senza controllare se == null nella get (grazie a readonly che una volta istanziato non cambia)
        //private static readonly Logger Instance = new Logger();

        private static Logger? logger;

        private Logger() { }

        public static Logger Instance 
        { 
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                }
                return logger;
            }
                
         }
        public void ScriviLogLorenzo(ITipoLog tipoLog) 
        {
            tipoLog.ScriviLog();
        }
    }
}
