using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Prototype
{
    /// <summary>
    /// La nostra classe ConcretePrototype
    /// </summary>
    public class Lavoro : IPrototype
    {
        public string Nome { get; set; } = "Lavoro";
        public string Descrizione { get; set; } = "Classe per tenere traccia dei lavori svolti";
        public Color Colore { get; set; } = Color.Yellow;

        public IPrototype Clona()
        {
            return new Lavoro()
            {
                Nome = this.Nome,
                Descrizione = this.Descrizione,
                Colore = this.Colore
            };
        }
    }
}
