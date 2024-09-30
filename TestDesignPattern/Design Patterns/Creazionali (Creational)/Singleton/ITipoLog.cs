using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    public interface ITipoLog
    {
        string? messaggio { get; set; }
        public void ScriviLog();

    }
}
