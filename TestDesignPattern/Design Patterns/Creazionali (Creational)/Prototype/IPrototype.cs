using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Prototype
{
    public interface IPrototype
    {
        string Nome { get; set; }
        string Descrizione { get; set; }
        Color Colore { get; set; }
        IPrototype Clona();
    }
}
