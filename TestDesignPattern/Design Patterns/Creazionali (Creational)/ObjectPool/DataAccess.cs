using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.ObjectPool
{
    /// <summary>
    /// Classe facoltativa per connettersi, puoi farlo tranquillamente nel main
    /// </summary>
    public class DataAccess
    {
        public void PrendiDatiDalDb()
        {
            var connection = ConnectionPool.Instance.PrendiConnessione();

            if (connection != null)
            {
                connection.Connect();

                Console.WriteLine("Data retrieved successfully!");
            }
            else
            {
                Console.WriteLine("Failed to acquire connection from pool!");
            }

        }
    }
}
