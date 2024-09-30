using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.OCP_OpenClosedPrinciple
{

    /// <summary>
    /// Questo principio afferma che il codice scritto una volta collaudato NON dovrebbe essere modificato, ma bensì implementato.
    /// Ciò implica che il codice esistente non dovrebbe cambiare, al massimo ci possono essere delle modifiche MINIME.
    ///
    /// Le nuove funzionalità andranno scritte quindi in nuove classi.
    /// 
    /// La regola è: classi, moduli e funzioni sono aperte alle estensioni ma chiuse alle modifiche.
    /// 
    /// Supponiamo di avere una classe Prodotto con all'intero un metodo che in base al tipo di oggetto 
    /// Calcola il prezzo in base all'iva in uno switch case: inizialmente i prodotti sono 3 (merendine, latte e proteine)
    /// 
    /// Classe prodotto{
    /// string tipo = "";
    /// double prezzo = null;
    /// 
    /// Metodo calcola prezzo(int quantità)
    /// {
    /// double prezzo = tipo * prezzo base
    /// else if(tipo == "merendine")
    /// {}
    /// else if(tipo == "latte")
    /// {}
    /// else if(tipo == "proteine")
    /// {}
    /// 
    /// return prezzo;
    /// }
    /// 
    /// Una volta testato il tutto, il negozio decide che venderà per esempio anche gli assorbenti.
    /// 
    /// Nell'esempio A (Sbagliato) andiamo a modificare il codice già scritto (preesistente) rischiando di dover capire prima come funziona se non l'abbiamo scritto noi,
    /// rischiamo di compromettere tutte le altre funzionalità se dovesse capitare di scrivere qualcosa di sbagliato.
    /// 
    /// Nell'esempio B (Corretto) Esistondo un'unica interfaccia che calcola il prezzo di ogni oggetto, nel caso in cui dovessimo aggiungere la classe assorbente (o più),
    /// non andremo a modificare le altre funzionalità ma bensì ad aggiungere una classe a parte dedicata senza compromettere il codice già esistente.
    /// 
    /// ESEMPIO A (ERRATO):
    /// STIAMO MODIFICANDO IL METODO GIA' ESISTENTE AGGIUNGENDO L'ASSORBENTE - NON VA BENE, VA CONTRO IL L'OCP
    /// Classe prodotto{
    /// string tipo = "";
    /// double prezzo = null;
    /// 
    /// Metodo calcola prezzo(int quantità)
    /// {
    /// double prezzo = quantita * prezzo base;
    /// 
    /// if(tipo == "merendine")
    /// {prezzo += prezzo * 0.3}
    /// else if(tipo == "latte")
    /// {prezzo += prezzo * 0.5}
    /// else if(tipo == "proteine")
    /// {prezzo += prezzo * 0.7}
    /// else if(tipo == "assorbente")
    /// {prezzo += prezzo * 0.2}
    /// }
    /// return prezzo;
    /// }
    /// 
    /// 
    /// ESEMPIO B (CORRETTO):
    /// Una interfaccia ICalcolaPrezzo con all'interno CalcolaPrezzo(prodotto * quantità)
    /// Una classe CalcolatriceDeiPrezzi che ha all'interno un metodo calcola prezzo che ha come input un ICalcolatore prezzo e che calcola in base a che tipo di prodotto gli passi in automatico il prezzo
    /// Una classe Merendine che implementa l'interfaccia ICalcolaPrezzo con il relativo metodo che calcola il prezzo secondo il proprio tasso
    /// Una classe latte che implementa l'interfaccia ICalcolaPrezzo con il relativo metodo che calcola il prezzo secondo il proprio tasso
    /// Una classe proteine che implementa l'interfaccia ICalcolaPrezzo con il relativo metodo che calcola il prezzo secondo il proprio tasso
    /// Una classe assorbente che implementa l'interfaccia ICalcolaPrezzo con il relativo metodo che calcola il prezzo secondo il proprio tasso
    /// 
    /// NB: questo principio va applicato SOLO nelle aree che capita spesso o si presume che cambieranno.
    ///
    /// </summary>
    public class OCP_Testing
    {
#warning scommentare per il test

        //static void Main(string[] args)
        //{
        //    //esempio: calcolo del prezzo di prodotti diversi con prezzo e quantità uguale ma con iva diversa
        //    Merendine merendine = new Merendine { prezzoPublic = 5.15, quantitaPublic = 5 };
        //    Latte latte = new Latte { prezzoPublic = 5.15, quantitaPublic = 5 };
        //    Proteine proteine = new Proteine { prezzoPublic = 5.15, quantitaPublic = 5 };
        //    Assorbenti assorbenti = new Assorbenti { prezzoPublic = 5.15, quantitaPublic = 5 };

        //    //classe che si occupa di calcolare il prezzo per tutti i tipi di prodotti
        //    CalcolatoreDeiPrezzi calcola = new CalcolatoreDeiPrezzi();

        //    //passo tramite Dependency Injection l'oggetto che implementa l'interfaccia e che in automatico prenderà il metodo corretto all'interno
        //    Console.WriteLine(calcola.CalcolaIlPrezzo(merendine));
        //    Console.WriteLine(calcola.CalcolaIlPrezzo(latte));
        //    Console.WriteLine(calcola.CalcolaIlPrezzo(proteine));
        //    Console.WriteLine(calcola.CalcolaIlPrezzo(assorbenti));
        //}

    }
}
