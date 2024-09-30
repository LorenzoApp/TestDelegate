using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.LSP_LiskovsSubstitutionPrinciple
{
    /// <summary>
    /// LSP Liskov's Substitution Principle dice che una classe figlia può modificare (override) delle proprietà o dei metodi della classe padre
    /// 
    /// Viene utilizzato quando non vuoi cambiare il codice di base, però vuoi cambiare il tipo di risultato, che significa?
    /// Che utilizzando sempre lo stesso codice puoi fare tornare dentro al tipo dell'oggetto padre un oggetto figlio (factory), nel quale alcune proprietà
    /// o funzioni sono state ovverridate, quindi con lo stesso codice produci risultati diversi.
    /// 
    /// Creando una classe figlia che utilizza le stesse proprietà della classe padre (in alcuni casi) non rispetta il risultato atteso.
    /// 
    /// Nello specifico, creando una classe Rectangle (Padre) che ha 2 properties altezza e larghezza,
    /// 2 property che si occupano del get e set e un metodo per calcolare l'area,
    /// successivamente creando una classe Quadrato (figlia) che eredita tutte questa proprietà, avremo che il risultato atteso 
    /// per calcolare l'area del quadrato utilizzando il metodo della classe padre potrebbe essere errato in alcuni casi specifici.
    /// 
    /// Quando?
    /// Nel metodo A inseriamo come altezza 5 e larghezza 7 alla classe rettangolo, l'area sarà 35 (va bene).
    /// Nel metodo A Creiamo un Quadrato e gli assegniamo l'altezza 7 e larghezza 2, essendo un quadrato l'area dovrebbe essere 4 (2*2) invece
    /// il risultato in questo caso è 14 perchè non prende l'ultimo valore assegnato ma bensì utilizza la formula del rettangolo
    /// 
    /// Nel metodo B invece, modifichiamo (override) come ottenere le proprietà e come vengono settate con un valore,
    /// ovvero tutti i lati sono uguali, quando modifichiamo l'altezza (o larghezza) proprietà della classe padre,
    /// assegna lo stesso valore anche all'altra proprietà (in questo caso funziona così).
    /// 
    /// Metodo A (ERRATO)
    /// Una classe padre rettangolo che ha 2 properties altezza e larghezza, 2 property che si occupano del get e set e un metodo per calcolare l'area
    /// Una classe figlia quadrato che eredità tutte le proprieta dalla classe padre rettangolo
    /// 
    /// Metodo B (CORRETTO)
    /// Una classe padre rettangolo che ha 2 properties altezza e larghezza, 2 property che si occupano del get e set e un metodo per calcolare l'area
    /// Una classe figlia quadrato che eredità tutte le proprieta dalla classe padre rettangolo e che overrida le proprietà che gli interessano
    /// 
    /// </summary>
    public class LSP_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    Rettangolo rettangolo = new Rettangolo();
        //    rettangolo.AltezzaPrivate = 7;
        //    rettangolo.LarghezzaPrivate = 8;

        //    rettangolo.CalcolaArea();

        //    Quadrato quadrato = new Quadrato(5);
        //    quadrato.AltezzaPrivate = 7;
        //    quadrato.LarghezzaPrivate = 8;

        //    quadrato.CalcolaArea();
        //}
    }
}
