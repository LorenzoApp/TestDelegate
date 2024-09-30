using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.AbstractFactory
{
    /// <summary>
    /// Questo è in assoluto il factory più complicato, un factory di più factory... un casino!
    /// 
    /// Da cosa è formato?
    /// Una classe astratta AbstractFactory dove vengono definite le varie interfacce implementabili A,B,C
    /// Le classi astratte figlie Factory1, Factory2 che estendono la classe astratta padre AbstractFactory
    /// Una o più interfacce AbstractProduct A,B,C etc etc
    /// Le classi A1,A2,B1,B2,C1,C2 che implementano le interfacce A,B,C etc etc
    /// 
    /// Attenzione a non fare questo "errore"
    /// Quando aggiungiamo una nuova famiglia di prodotti, dobbiamo per forza di cose aggiungere nel AbstractFactory la creazione della nuova interfaccia,
    /// creando così un'infinità di implementazioni nelle sottoclassi.
    /// E' importantissimo per evitare ciò, di creare i Factory 1,2,3 etc etc come Factory Method con Reflection, inoltre dovranno essere tutti Singleton.
    /// 
    /// Un'altra soluzione è quella di utilizzare il pattern Prototype al posto del Factory Method, l'implementazione per quest'ultimo la vedremo in seguito.
    /// Anticipo però che, questo approccio elimina la necessità di una nuova factory per ogni nuova famiglia di prodotti.
    /// 
    /// Quando utilizzarlo?
    /// il sistema deve essere indipendente dal modo in cui vengono creati i prodotti con cui funziona.
    /// il sistema è o dovrebbe essere configurato per funzionare con più famiglie di prodotti.
    /// una famiglia di prodotti è progettata per funzionare solo tutti insieme.
    /// è necessaria la creazione di una libreria di prodotti, per la quale è rilevante solo l'interfaccia, non anche l'implementazione.
    /// 
    /// </summary>
    public class AbstractFactory_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    //factory del prodotto
        //    ProdottoFactory prodottoFactory = ProdottoFactory.Instance;

        //    //factory delle bibite
        //    BibiteFactory bibiteFactory = BibiteFactory.Instance;

        //    //creo il prodotto corretto
        //    var prodotto = prodottoFactory.Create("ProdottoA");
        //    prodotto.Stampa();

        //    prodotto = prodottoFactory.Create("ProdottoB");
        //    prodotto.Stampa();

        //    var bibite = bibiteFactory.Create("BibitaA");
        //    bibite.Stampa();

        //    bibite = bibiteFactory.Create("BibitaB");
        //    bibite.Stampa();
        //}
    }
}
