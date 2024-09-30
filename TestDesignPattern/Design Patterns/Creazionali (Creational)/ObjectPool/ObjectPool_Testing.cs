using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.ObjectPool
{
    /// <summary>
    /// Preparati perchè è uno dei pattern creazionali più "complessi", ma credo anche più "belli".
    /// L'object pool viene utilizzato principalmente per migliorare le performance, infatti questo pattern offre un meccanismo per riutilizzare gli oggetti "costosi" da creare
    /// (Mentre il prototype clona l'oggetto) invece di creare continuamente più e più volte nuovi oggetti.
    /// 
    /// Chi utilizza l'oggetto in questione si sente come se fosse l'unico utilizzatore, tuttavia l'oggetto in realtà, è condiviso.
    /// 
    /// Come funziona?
    /// C'è un classe "Reusable" che verrà utilizzata da 1 o più client.
    /// C'è una classe "ReusablePool" che gestice i client che utilizzano l'object pool
    /// C'è il "Client" che richiede la risorsa "Reusable" e che infine la rilascia notificandolo al ReusablePool.
    /// 
    /// Cosa succede quando il "Client" richiede la risorsa?
    /// Il ReusablePool controlla se è disponibile l'oggetto riutilizzabile disponibile, se lo trova lo consegna al client. Se non trova nulla invece,
    /// prova a creare un nuovo oggetto riutilizzabile, se ciò riesce restituisce il nuovo oggetto al client, se non riesce invece,
    /// il Pool "prende tempo" e aspetta finchè non "torna disponibile" un oggetto Reusable.
    /// L'unica accortezza è che, essendo che il client non sa di condividere l'oggetto, bisogna strutturare il codice in modo che finite le operazioni fatte da un client,
    /// il client stesso rilasci la risorsa, altrimenti il ReusablePool non vedrà mai "spazi" disponibili e si rischia di mandare in blocco il programma.
    /// 
    /// Quando utilizzarlo?
    /// Utilizzeremo questo pattern quando diversi client hanno bisogno della stessa identica risorsa, la cui creazione è costosa.
    /// 
    /// Un esempio?
    /// L'esempio più semplice è il database.
    /// Creare una connessione nuova ogni volta è costosa, utilizzarne troppe contemporaneamente si sovraccarica il server. 
    /// Per evitare ciò si potrebbe utilizzare un pool di oggetti, defininendo eventualmente anche un numero massimo di oggetto che possono essere creati contemporaneamente.
    /// 
    /// Considerazioni:
    /// L'oggetto ReusablePool dovrà essere Singleton.
    /// Bisogna limitare le risorse condivisibili (quindi un numero max di oggetti utilizzabili).
    /// Quando non ci sono risorse disponibili, il Client deve essere avvertito di ciò.
    /// Alcuni metodi devono essere sincronizzati, soprattutto in visione di applicazioni multithreading *
    /// Gestire le risorse inutilizzate (unused and expired) **
    /// 
    /// *Metodi sincronizzati:
    /// In ambito multi-threading solo 3 metodi devono essere sincronizzati in ReusablePool:
    /// Il metodo GetInstance() sync utilizzato per il singleton multithreading (cambia l'implementazione, approfondire) 
    /// Il metodo AcquireConnectionImpl sync per non restituire la stessa risorsa a due client diversi che eseguono thread diversi
    /// In alcune porzioni di codice (lock) del metodo ReleaseConnectionImpl potrebbero necessitare di essere sincronizzati, ricordo che questo metodo rilascia la risorsa.
    /// 
    /// **Risorse expired:
    /// Il problema delle risorse NON rilasciate dal client è molto importante, prendendo l'esempio del db:
    /// possono esserci connessioni al database ancora aperte ma inutilizzate, come evitare ciò?
    /// Si utilizza un timeout, ovvero viene misurato un tempo nel quale le risorse che non vengono utilizzate vengono rilasciate automaticamente.
    /// 
    /// </summary>
    public class ObjectPool_Testing
    {
#warning scommentare per il test
        //public static void Main(string[] args)
        //{
        //    var dataAccess1 = new DataAccess();
        //    dataAccess1.PrendiDatiDalDb();

        //    var dataAccess2 = new DataAccess();
        //    dataAccess2.PrendiDatiDalDb(); // Reuse connections from pool

        //    // Simulate some time passing
        //    Thread.Sleep(5000); // 5 seconds

        //    // Check and release idle connections
        //    ConnectionPool.Instance.ControllaRilascioConnessione();
        //}
    }
}
