using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Prototype
{
    /// <summary>
    /// Questo pattern è utilizzato quando per esempio dobbiamo creare degli oggetti con le stesse caratteristiche con molta frequenza, come fare in questo caso?
    /// Utilizziamo il prototype!
    /// 
    /// Perchè è molto più comodo copiare sempre le stesse proprietà rispetto a ridefinirle ogni volta nell'oggetto X
    /// 
    /// Come?
    /// Abbiamo bisogno di:
    /// Un'interfaccia che definisca un metodo "Clona" 
    /// Uno o più classi prototipi che implementano l'interfaccia e che personalizzino il metodo clone
    /// (Facoltativa) Una classe PrototypeManager che gestisce la clonazione 
    /// 
    /// Buono perchè aumenta le performance, in quanto è MENO dispendioso clonare un oggetto che crearlo da zero.
    /// Buono perchè si istanziano le classi durante il runtime e NON in fase di compilazione e perchè permette di evitare una gerarchia di Factory per creare gli oggetti.
    /// 
    /// In scenari complessi dove si gestisce un gran numero di prototipi o si necessita di un controllo più approfondito sulla loro creazione e gestione è il caso di inserire
    /// una classe (non obbligatoria) PrototypeManager
    /// Quando questo avviene il pattern sarà molto simile al factory, con l'unica differenza che è più performante in quanto clona l'oggetto.
    ///
    /// </summary>
    public class Prototype_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
            ////come prima cosa creiamo il nostro prototype manager
            //PrototypeManager manager = new PrototypeManager();

            //IPrototype persona = manager.GetPrototype("Personale");

            //IPrototype lavoratore = manager.GetPrototype("Lavoro");

            //IPrototype acquisto = manager.GetPrototype("Acquisti");

            //Console.WriteLine($"Categoria personale: Nome - {persona.Nome}, Descrizione - {persona.Descrizione}, Colore - {persona.Colore}");
            //Console.WriteLine($"Categoria personale: Nome - {lavoratore.Nome}, Descrizione - {lavoratore.Descrizione}, Colore - {lavoratore.Colore}");
            //Console.WriteLine($"Categoria personale: Nome - {acquisto.Nome}, Descrizione - {acquisto.Descrizione}, Colore - {acquisto.Colore}");

            ////oppure secondo lsv principle (SOLID)
            ////ci aspettiamo che sia un lavoratore ma visto che facciamo un "ovveride del tipo" cambia in lavoratore
            //lavoratore = lavoratore.Clona();

            //Console.WriteLine($"Categoria personale: Nome - {lavoratore.Nome}, Descrizione - {lavoratore.Descrizione}, Colore - {lavoratore.Colore}");

            //lavoratore.Colore = Color.OrangeRed;
            //lavoratore.Descrizione = "Ciao sono un nuovo lavoratore";
            //lavoratore.Nome = "So lollo";
            //Console.WriteLine($"Categoria personale: Nome - {lavoratore.Nome}, Descrizione - {lavoratore.Descrizione}, Colore - {lavoratore.Colore}");

        //}
    }
}
