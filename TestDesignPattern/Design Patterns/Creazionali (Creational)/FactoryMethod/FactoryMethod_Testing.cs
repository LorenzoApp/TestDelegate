using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.FactoryMethod
{
    /// <summary>
    /// Questo pattern essendo un Factory, si occupa della creazione degli oggetti, in questo caso attraverso un metodo.
    /// 
    /// Come funziona?
    /// Abbiamo bisogno di un'interfaccia "Padre" che venga implementata da X classi figlie e di una classe astratta che fornisca un metodo per creare gli oggetti con il return type dell'interfaccia.
    /// Successivamente ogni oggetto figlio della classe astratta farà un override del metodo della classse astratta facendo ritornare il tipo di oggetto corretto.
    /// 
    /// Questo è il ragionamento di base, esiste però un modo "più veloce da scrivere ma meno potente a livello di prestazioni" che può essere utilizzato in c# e java perchè permettono la reflection. 
    /// Quindi nel nostro caso, la classe astratta non ci sarà, ma il factory method sarà istanziato dentro una classe normale
    /// con all'interno la classe activator che si occupa della creazione di oggetti tramite typeof etc etc
    /// 
    /// Ovviamente questo pattern è buono per future implementazioni senza toccare il codice esistente, manutenzione e leggibilità.
    /// 
    /// Quando implementarlo?
    /// Se hai molti oggetti dello stesso tipo e li manipoli principalmente come oggetti astratti, allora hai bisogno di una fabbrica.
    /// 
    /// </summary>
    public class FactoryMethod_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    //ecco i risultati della partita
        //    int casa = 5, trasferta = 2;

        //    //creo la nostra classe con all'interno il factory method
        //    RisultatoPartite risultato = new RisultatoPartite();

        //    //la squadra casa ha vinto
        //    Console.WriteLine(risultato.FactoryMethodPartite("Casa")?.ConfrontaPartita(casa, trasferta));

        //    //la squadra in trasferta ha vinto
        //    Console.WriteLine(risultato.FactoryMethodPartite("Trasferta")?.ConfrontaPartita(casa, trasferta));
        //}
    }
}
