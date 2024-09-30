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
    public class Personale : IPrototype
    {
        public string Nome { get; set; } = "Personale";
        public string Descrizione { get; set; } = "Classe per gestire le tue attività personali";
        public Color Colore { get; set; } = Color.Blue;

        public IPrototype Clona()
        {
            return new Personale
            {
                Nome = this.Nome,
                Descrizione = this.Descrizione,
                Colore = this.Colore
            };
        }
    }
}
