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
    public class Shopping : IPrototype
    {
        public string Nome { get; set; } = "Shopping";
        public string Descrizione { get; set; } = "Classe per tenere traccia dei tuoi acquisti";
        public Color Colore { get; set; } = Color.Green;

        public IPrototype Clona()
        {
            return new Shopping()
            {
                Nome = this.Nome,
                Descrizione = this.Descrizione,
                Colore = this.Colore
            };
        }
    }
}
