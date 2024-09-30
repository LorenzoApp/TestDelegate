using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.SRP_SingleResponsibilityPrinciple
{
    /// <summary>
    /// Il Principio di Responsabilità Singola dice che ogni classe deve evere un solo "motivo" (responsibility) per cambiare.
    /// Se una classe dovesse avere più di una responsabilità, la classe va suddivisa in più classi, una per ogni responsabilità (manutibilità e flessibilità).
    /// 
    /// Il motivo?
    /// Perchè c'è il rischio che il cambiamento portato da un "metodo" possa influenzare anche gli altri (responsability), cosa significa nello specifico?
    /// Immaginiamo di avere una classe user che ha all'interno i dettagli dell'utente, e 4 metodi che si occupano di generare un report, gestire le autenticazioni e le autorizzazioni.
    /// 
    /// Inizialmente va tutto bene giusto? Bene, immaginiamo di modificare il metodo che gestosce il report, cosa succede?
    /// Che il cambiamento di un singolo metodo potrebbe compromettere il funzionamento anche degli altri 2... e questo non va bene! (ESEMPIO A)
    /// 
    /// Per NON compromettere tuttociò e rendere il codice più manutenibile, dobbiamo applicare l'esempio B
    /// 
    /// I progetti in genere crescono, gli utenti potrebbe avere sempre più funzionalità, l'applicazione corretta di questo principio permette di
    /// NON sminchiare tutto con una nuova funzionalità, inoltre facilità l'analisi del codice durante il debugging, perchè se scoppia il report, sicuramente non devi controllare le autenticazioni.
    /// 
    /// ESEMPIO A (ERRATO):
    /// Unica classe Utente con all'interno i dettagli e metodi tutti insieme.
    /// 
    /// ESEMPIO B (CORRETTO) SRP:
    /// Una classe Utente con i dettagli dell'utente come nome,cognome,email etc etc
    /// Una classe UserReport che si occupa di gestire i Report generati dall'utente
    /// Una classe USerAuthenticator che si occupa di gestire le autenticazioni dell'utente
    /// Una classse Authorizer che si occupa di gestire le autorizzazioni dell'utente
    /// 
    /// </summary>
    public class SRP_Testing
    {

#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    //creo un report
        //    UtenteReport utenteReport = new UtenteReport();
        //    utenteReport.GeneraReport();

        //    //creo una gestione delle autorizzazioni
        //    UtenteAutorizzazioni utenteAutorizzazioni = new UtenteAutorizzazioni();
        //    utenteAutorizzazioni.GestisciAutorizzazioni();

        //    //creo un'autenticazione
        //    UtenteAutenticazioni utenteAutenticazioni = new UtenteAutenticazioni();
        //    utenteAutenticazioni.GestisciAutenticazioni();
        //}
    }
}
