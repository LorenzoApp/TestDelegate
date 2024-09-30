using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.ObjectPool
{
    /// <summary>
    /// Questa è la nostra classe "Reusable", ovvero la classe che sarà utilizzata da N client e gestita dalla classe "ReusablePool"
    /// </summary>
    public class DatabaseConnection : IPoolableConnection
    {
        //stringa di connessione
        private string connectionString;

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            //simulazione della connessione al database
            Console.WriteLine("Mi connetto al database");
        }

        public void Disconnect()
        {
            //simulazione della disconnessione al database
            Console.WriteLine("Mi Disconnetto dal database");
        }
    }
}
