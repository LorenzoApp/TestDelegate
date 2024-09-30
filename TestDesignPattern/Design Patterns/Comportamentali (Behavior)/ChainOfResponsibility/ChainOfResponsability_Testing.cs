using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.ChainOfResponsibility
{
    /// <summary>
    /// Immaginiamo di creare un'oggetto che dovrà essere gestito da un altro oggetto.
    /// Se siamo pigri rendiamo tutto public e siamo "delle pippe", altrimenti utilizziamo questo pattern.
    /// 
    /// Chain Of Responsability consente a un oggetto di inviare un comando senza sapere quale oggetto lo riceverà e lo gestirà.
    /// 
    /// L'esempio più classico è il distributore automatico, dove invece di avere una fessura per ogni tipo di moneta, ne ha una per tutte.
    /// Una volta inserita poi, la moneta verrà indirizzata al deposito giusto.
    /// In questo modo il mittente che fa una richiesta non è necessariamente collegata a un singolo destinatario, ma da la possibilità a tutti i destinatari 
    /// eventualmente di gestire la richiesta, come se fosse una vera e propria catena.
    /// 
    /// Come funziona?
    /// Una classe client "Request" 
    /// Una classe astratta "Handler" che definisce un metodo che setta il successore e un metodo astratto per gestire la richiesta handleRequest
    /// N classi figlie "ConcreteHandler" che implementano handleRequest
    /// 
    /// Quando utilizzare:
    /// Più di un oggetto può gestire un comando
    /// Il gestore non è noto in anticipo
    /// Il gestore dovrebbe essere determinato automaticamente
    /// È auspicabile che la richiesta sia indirizzata ad un gruppo di oggetti senza specificare esplicitamente il destinatario
    /// Il gruppo di oggetti che possono gestire il comando deve essere specificato in modo dinamico
    /// 
    /// Attenzione al problema della catena "rotta", quando dimentichiamo di inserire nell'implementazione del metodo handle request la chiamata al successore,
    /// </summary>
    public class ChainOfResponsability_Testing
    {
#warning scommentare per il test
        //public static void Main(string[] args)
        //{
        //    #region Setup Chain
        //    DistributoreBibite distributoreBibite = new DistributoreBibite();
        //    DistributoreCaramelle distributoreCaramelle = new DistributoreCaramelle();
        //    DistributorePanini distributorePanini = new DistributorePanini();

        //    //set distributore 1 (successivo distributore 2) e così via 
        //    distributoreBibite.setDistributoreSuccessivo(distributoreCaramelle);
        //    distributoreCaramelle.setDistributoreSuccessivo(distributorePanini);
        //    #endregion

        //    //Passo i clienti partendo dalla catena 1
        //    distributoreBibite.GestisciCliente(new Cliente("Bibita"));
        //    distributoreBibite.GestisciCliente(new Cliente("Panino"));
        //    distributoreBibite.GestisciCliente(new Cliente("Caramella"));

        //    //non c'è nessuna catena qui, sicuramente non scrive nulla
        //    distributoreBibite.GestisciCliente(new Cliente("Pizza"));

        //}
    }
}
