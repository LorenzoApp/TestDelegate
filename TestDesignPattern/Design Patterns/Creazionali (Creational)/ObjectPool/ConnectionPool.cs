using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.ObjectPool
{
    /// <summary>
    /// Questa è la classe "ReusablePool" ovvero colei che gestira client e l'oggetto "Reusable" che nel nostro caso è DatabaseConnection
    /// </summary>
    public class ConnectionPool
    {
        private readonly Queue<DatabaseConnection> connessioniDisponibili;
        private readonly int massimoNumeroDiConnessioni;

        //utilizzato per il lock
        private readonly object sincronizzaRoot = new object();

        //mappa l'oggetto con l'ultimo utilizzo
        private readonly Dictionary<DatabaseConnection, DateTime> oraUltimoUtilizzo = new Dictionary<DatabaseConnection, DateTime>();

        //costruttore privato per pattern singleton che definisce il numero massimo di connessioni
        private ConnectionPool(int size)
        {
            connessioniDisponibili = new Queue<DatabaseConnection>();
            massimoNumeroDiConnessioni = size;
        }

        // Singleton instance with maximum pool size of 5
        private static readonly ConnectionPool istanzaPrivate = new ConnectionPool(5);

        //istanza pubblica che verrà utilizzata al di fuori
        public static ConnectionPool Instance
        {
            get
            {
                return istanzaPrivate;
            }
        }

        /// <summary>
        /// Metodo PrendiConnessione che contralla in caso di multithreading con il lock che sia sync
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IPoolableConnection? PrendiConnessione()
        {
            DatabaseConnection? connection = null;

            //controllo che in caso di multithreading solo uno alla volta entri dentro con il lock
            lock (sincronizzaRoot)
            {
                //se il numero di connessioni disponibili è maggiore di zero
                if (connessioniDisponibili.Count > 0)
                {
                    connection = connessioniDisponibili.Dequeue();
                    oraUltimoUtilizzo[connection] = DateTime.Now; // Update last usage time
                }
                //oppure se il numero di connessioni disponibili è minore del numero massimo di connessioni
                else if (connessioniDisponibili.Count < massimoNumeroDiConnessioni)
                {
                    connection = new DatabaseConnection("YourConnectionString");
                    oraUltimoUtilizzo[connection] = DateTime.Now; // Update last usage time
                }
                //il pool è pieno, l'utente deve attendere
                else
                {
                    Console.WriteLine("Il pool di connessioni è pieno. Impossibile connettersi");
                }
            }

            return connection;
        }

        public void RilascioConnessione(IPoolableConnection connection)
        {
            //is corrisponde a ==
            if (connection is DatabaseConnection)
            {
                lock (sincronizzaRoot)
                {
                    var dbConnection = (DatabaseConnection)connection;
                    dbConnection.Disconnect();

                    // Check if the connection has been idle for too long
                    var idleTime = DateTime.Now - oraUltimoUtilizzo[dbConnection];
                    
                    if (idleTime.TotalSeconds > 30) // 30 seconds idle timeout in this example
                    {
                        Console.WriteLine("Rilascio della connessione...");
                        oraUltimoUtilizzo.Remove(dbConnection); // Remove from usage map
                    }
                    else
                    {
                        // Connection is not idle, put it back in the pool
                        connessioniDisponibili.Enqueue(dbConnection);
                    }
                }
            }
        }

        public void ControllaRilascioConnessione() // Method to check and release idle connections
        {
            lock (sincronizzaRoot)
            {
                var now = DateTime.Now;

                foreach (var connection in oraUltimoUtilizzo.Keys)
                {
                    var idleTime = now - oraUltimoUtilizzo[connection];
                    if (idleTime.TotalSeconds > 30) // Check idle time against timeout
                    {
                        Console.WriteLine("Tempo scaduto, rilascio della connessione...");
                        connection.Disconnect(); // Disconnect the idle connection
                        oraUltimoUtilizzo.Remove(connection); // Remove from usage map
                    }
                }
            }
        }

    }
}
