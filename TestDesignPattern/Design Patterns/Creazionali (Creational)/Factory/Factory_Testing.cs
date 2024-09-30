using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.NonReflectionFactory;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory
{
    /// <summary>
    /// Il pattern Factory serve principalmente a "nascondere" la creazione degli oggetti senza esporre COME al client, creando i nuovi oggetti sfruttando le inferfacce/classi astratte.
    /// 
    /// Se hai molti oggetti dello stesso tipo e li manipoli per lo più trasformandoli in tipi astratti, allora hai bisogno di una fabbrica (factory).
    /// 
    /// Ovviamente il suo obiettivo principale è quello di aumentare la flessibilità del codice, permettendo di aggiungere nuove implementazioni senza modificare la classe principale factory.
    /// E' importante ricordare che il factory utilizza il pattern Singleton.
    /// 
    /// Esiste un'implementazione "noob" ovvero applicare il factory (o parameterized factory) inserendo all'interno della classe factory uno switch case
    /// GOOD: perchè è molto semplice
    /// BAD: perchè non rispetta l'OCP (Open Closed Principle), ovvero che "Il codice esistente non va modificato, ma bensì esteso".
    ///      Si potrebbe optare per creare delle sottoclassi, tuttavia essendoci all'interno del Factory anche il pattern Singleton tuttociò non è applicabile.
    /// 
    /// Esiste un'implementazione "good" che utilizza la reflection (Register), nello specifico utilizza un costruttore HashMap che mappa i parametri per esempio l'ID di un prodotto e il tipo di classe.
    /// GOOD: perchè in caso di nuove implementazioni non modifichiamo il codice esistente.
    /// BAD: perchè utilizzando la reflection perdiamo il 10% delle performance, inoltre non tutti i linguaggi di programmazione forniscono il meccanismo della reflaction.
    /// 
    /// Esiste un'implementazione "good" che NON utilizza la reflection (Register), nello specifico creiamo una classe esterna che si occupa di creare l'oggetto specifico.
    /// GOOD: perchè in caso di nuove implementazioni non modifichiamo il codice esistente.
    /// BAD: codice ancora più complesso
    /// 
    /// </summary>
    public class Factory_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    #region NoobFactory

        //    var formaGenerica = NoobFactory.NoobFactory.GetInstance.GetForma("quadrato");
        //    formaGenerica?.Stampa();

        //    formaGenerica = NoobFactory.NoobFactory.GetInstance.GetForma("cerchio");
        //    formaGenerica?.Stampa();

        //    #endregion

        //    #region ReflectionFactory

        //    var metodiPagamento = ReflectionFactory.ReflectionFactory.GetInstance.GetMetodoPagamentoReflection("Contanti_Reflection");
        //    metodiPagamento?.Paga();

        //    metodiPagamento = ReflectionFactory.ReflectionFactory.GetInstance.GetMetodoPagamentoReflection("PayPal_Reflection");
        //    metodiPagamento?.Paga();

        //    #endregion

        //    #region NonReflectionFactory -- NON HO CAPITO L'UTILITA'
        //    AlimentariNonReflection.Register();
        //    Infantili_NonReflection.Register();

        //    Prodotto product1 = NonReflectionFactory.NonReflectionFactory.Instance.CreaProdotto("Prodotto1ID");
        //    Prodotto product2 = NonReflectionFactory.NonReflectionFactory.Instance.CreaProdotto("Prodotto2ID");

        //    product1.CheProdotto(); // Output: Creating Prodotto1
        //    product2.CheProdotto(); // Output: Creating Prodotto2 
        //    #endregion
        //}
    }
}
