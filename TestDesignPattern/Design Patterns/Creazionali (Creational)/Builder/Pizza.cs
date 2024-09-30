using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Builder
{
    /// <summary>
    /// Il nostro prodotto (Product) con le proprie caratteristiche
    /// </summary>
    public class Pizza
    {
        public TipoImpasto Impasto { get; set; }
        public TipoSalsa Salsa { get; set; }
        public Mozzarella Mozzarella { get; set; }
        public List<Condimento> Condimenti { get; set; }

        public Pizza()
        {
            Condimenti = new List<Condimento>();
        }

        //override del metodo tostring normale, in modo da fare ritornare a "video" quella stringa personalizzata
        public override string ToString()
        {
            string strCondimenti = "";

            foreach (Condimento condimento in Condimenti)
            {
                strCondimenti += condimento.ToString() + ", ";
            }

            return "Ingredienti: " + Impasto.ToString() + ", " + Salsa.ToString() + ", " + Mozzarella + ", " + strCondimenti;
        }
    }

    //invece di creare un classe abbiamo create questi ingredienti comuni per personalizzare la pizza
    public enum TipoImpasto { Classico, Integrale, Kamut }
    public enum TipoSalsa { Pomodoro, PomodoroPiccante, Pesto }
    public enum Mozzarella { FiorDiLatte, Bufala }
    public enum Condimento { Prosciutto, Funghi, Salame, Olive, Carciofi, Wrustel, Patatine }
}
