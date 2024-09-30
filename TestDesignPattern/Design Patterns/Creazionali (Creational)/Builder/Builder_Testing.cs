using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Builder
{
    /// <summary>
    /// Questo pattern viene utilizzato per crare un oggetto con diversi tipi di configurazione, può essere considerato un "dinamico" parametrizzato.
    /// 
    /// Questa classe prevede un singolo costruttore con diversi metodi per la configurazione dell'oggetto.
    /// 
    /// Di cosa abbiamo bisogno?
    /// Un'interfaccia (o classe astratta) Builder comune che definisce le differenti parti dell'oggetto (prodotto) da creare
    /// Una classe ConcreteBuilder che implementa l'interfaccia, il Prodotto private, un unico costruttore e l'implementazione di tutti i metodi definiti dall'interfaccia
    /// Una classe Director che si occupa della costruzione dell'oggetto complesso tramite l'interfaccia Builder (DI)
    /// Una classe Product che rappresenta l'oggetto che verrà creato
    /// 
    /// E' un po' complesso, però molto utile quando vogliamo rendere indipendenti diverse parti che compongono un'oggetto, in modo che il sistema possa crostruire
    /// oggetti diversi in base a quello di cui ha bisogno
    /// 
    /// Questo pattern è molto simile all'Abstract Factory, dove il client usa i vari Factory Method per creare gli oggetti.
    /// Nel caso del builder invece, c'è il ConcreteBuilder che si occupa di creare l'oggetto (che poi gli verrà chiesto), ma c'è la classe Builder che si occupa "raggrupparli".
    /// 
    /// In poche parole in genere l'abstract factory crea oggetti da classe derivate di un tipo comune, mentre il builder tramite i concretebuilder si occupa delle creazioni di oggetti
    /// totalmente diversi, che poi saranno "messi insieme" dalla classe builder (quindi più tipi diversi)
    /// 
    /// Esempio:
    /// Immaginiamo di volere costruire una pizza, per ogni pizza esistono più tipi di pizza (quindi più implementazioni) come la margherita, la capricciosa etc etc
    /// 
    /// Creiamo
    /// Un'interfaccia (Builder) IPizzaBuilder che dia un "modello" da seguire per costruire la pizza (come il set degli ingredienti, impasto etc etc)
    /// Una classe (ConcreteBuilder) BuilderPizza che implementi questi metodi
    /// Una classe (Product) Pizza che abbia delle caratteristiche all'interno (e degli enum in questo caso per definire degli ingredienti)
    /// Una classe (Director) DirectorPizza che si occupi di fornire delle classi per creare le pizze "pronte" come la margherita e Custom (facoltativa)
    ///
    /// 
    /// /// </summary>
    public class Builder_Testing
    {
#warning scommentare per il test
        static void Main(string[] args)
        {
            //Creo il mio Builder
            var builder = new BuilderPizza();

            //Creo il mio direttore
            var direttore = new DirectorPizza();

            //creo una margherita
            Pizza margherita = direttore.CreaMargherita(builder);

            //creo una capricciosa89
            Pizza capricciosa = direttore.CreaCapricciosa(builder);

            //creo pizza personalizzata
            Pizza americana = direttore.CreaPizzaPersonalizzata(new Pizza
            {
                Impasto = TipoImpasto.Classico,
                Salsa = TipoSalsa.Pomodoro,
                Mozzarella = Mozzarella.FiorDiLatte,
                Condimenti = { Condimento.Wrustel, Condimento.Patatine }
            });

            Console.WriteLine(margherita.ToString());
            Console.WriteLine(capricciosa.ToString());
            Console.WriteLine(americana.ToString());
        }
    }
}
