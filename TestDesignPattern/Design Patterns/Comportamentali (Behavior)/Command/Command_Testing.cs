using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Command
{
    /// <summary>
    /// Le Macro, proprio come l'idea del pattern Command, vengono costruite riunendo un insieme di comandi in un preciso ordine.
    /// 
    /// Questo pattern fornisce le opzioni per accodare comandi, annullare/ripristinare azioni e altre manipolazioni.
    /// 
    /// Come costruirlo?
    /// Un'interfaccia "Command" che definisce un'operazione Execute.
    /// Una o più classi "ConcreteCommand" che estendono l'interfaccia "Command" e implementano il metodo Execute, invocando le operazioni corrispondenti del Receiver. Collega il Receiver con l'operazione da svolgere.
    /// Una classe "Client" che si occupa di istanziare la classe "ConcreteCommand" e gli imposta il Receiver.
    /// Una classe "Invoker" che si occupa di "chiedere" il comando da utilizzare per soddisfare la richiesta.
    /// Una classe "Receiver" che conosce come effettuare le operazioni.
    /// 
    /// Come funziona?
    /// Il client richiede l'esecuzione di un comando.
    /// L'Invoker prende il comando, lo incapsula e lo mette in coda, nel caso ci sia qualcos'altro da fare prima,
    /// e il ConcreteCommand che si occupa del comando richiesto, invia il suo risultato al Receiver.
    /// 
    /// Esempio:
    /// Immaginiamo di avere un telecomando che deve accendere la luce (e forse altri comandi in futuro)
    /// 
    /// Alcune implementazioni del modello di progettazione Command permettono di supportare l'annullamento e il ripristino delle azioni
    /// Per farciò possiamo procedere in 2 modi:
    /// 1) A basso effort di codice: Prima di eseguire ciascun comando, viene archiviata in memoria un'istantanea dello stato del ricevitore (non applicabili per le immagini)
    /// 
    /// 2) Ad alto effort di codice: Invece di archiviare gli stati degli oggetti riceventi, l'insieme delle operazioni eseguite viene archiviato in memoria.
    ///    In questo caso le classi Command e Receiver dovrebbero implementare degli algoritmi inversi per annullare ogni azione.
    ///    Ciò richiederà uno sforzo di programmazione aggiuntivo, ma sarà necessaria meno memoria rispetto al primo approccio (e quindi applicabile)
    /// 
    /// Quando bisogna memorizzare più informazioni sui Receiver forse un buon approccio è il Memento Pattern
    /// </summary>
    public class Command_Testing
    {

#warning scommentare per il test
        //public static void Main(string[] args)
        //{

        //}
    }
}
