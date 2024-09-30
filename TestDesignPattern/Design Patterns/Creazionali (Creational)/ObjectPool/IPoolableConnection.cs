using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.ObjectPool
{
    public interface IPoolableConnection
    {
        void Connect();
        void Disconnect();
    }
}
