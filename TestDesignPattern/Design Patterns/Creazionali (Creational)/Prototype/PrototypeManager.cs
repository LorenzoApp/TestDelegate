using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Prototype
{
    /// <summary>
    /// Classe che si occupa di gestire tutte le classe prototipi (Facoltativa)
    /// </summary>
    public class PrototypeManager
    {
        private Dictionary<string, IPrototype> prototipi;

        /// <summary>
        /// Nel costruttore definiamo già i nostri 3 oggetti prototipi
        /// </summary>
        public PrototypeManager()
        {
            prototipi = new Dictionary<string, IPrototype>();
            AddPrototype("Personale", new Personale());
            AddPrototype("Lavoro", new Lavoro());
            AddPrototype("Acquisti", new Shopping());
        }

        /// <summary>
        /// metodo per aggiungere un nuovo prototipi
        /// </summary>
        /// <param name="chiave"></param>
        /// <param name="prototipo"></param>
        public void AddPrototype(string chiave, IPrototype prototipo)
        {
            prototipi[chiave] = prototipo;
        }

        /// <summary>
        /// Metodo che in base alle chiave passata clona (e fa un return) dell'oggetto chiamato
        /// </summary>
        /// <param name="chiave"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IPrototype GetPrototype(string chiave)
        {
            if (prototipi.ContainsKey(chiave))
            {
                return prototipi[chiave].Clona();
            }
            else
            {
                throw new Exception($"Prototype '{chiave}' non trovato");
            }
        }
    }

}
