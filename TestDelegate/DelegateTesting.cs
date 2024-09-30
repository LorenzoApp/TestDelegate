using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.Remoting;
using NLog;

namespace TestDelegate
{


    public delegate void TestDelegate(int x, int y);

    public delegate void MyDelegateAsync(int x, int y);

    public class DelegateTesting
    {

        static void Main(string[] args)
        {
            Logger Log = LogManager.GetLogger("Ciao");

            string? classe = System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.FullName;

            Log.Info("Dentro " + classe);

            Log.Error("errore grave");

            //#region Test dei delegates
            ////// I Delegates sono utilizzati per puntare a dei metodi, possiamo associare per lo stesso delegates a più di un metodo o allo stesso tempo
            ////// creare una classe statica che prenda come parametro un Delegates per svolegere più operazioni annidate

            //////creare un delegate che punta a una funzione
            ////TestDelegate delegatoInt = Somma;
            //////tratta la funzione come se fosse un oggetto
            ////Somma(5, 8);

            //////ora il delegate punta alla seconda funzione
            ////delegatoInt = Differenza;
            ////Differenza(5, 8);

            //////passa il delegato nella funzione statica per fare delle funzioni annidate
            ////MoltiplicaPiuDelegate(5, 8, delegatoInt);
            //#endregion

            //#region Test dei Func
            ////le func sono dei delegate generici che hanno sempre un valore di ritorno (no void),
            ////va specificato il tipo di valore di ritorno e accetta fino a 16 valori di input
            ////inoltre possono essere utilizzati con gli anonymous method e con le lambda expression

            //////return di un valore bool (dx) e come input abbiamo una string (sx), func punta alla funzione isNumeric
            ////Func<string, bool> func1 = IsNumeric;
            ////Console.WriteLine($"Il valore inserito è numerico: {func1("12154")}"); //stampo se il valore inserito è numero o no (con la funzione regex)

            //////altro esempio
            ////Func<int, int, int> func2 = SommaConReturn;
            ////Console.WriteLine($"La somma è = {func2(5, 7)}");

            ////// è possibile creare una function di tipo anonymous
            ////Func<int, int, int> func3 = delegate (int x, int y) { return x - y; };
            ////Console.WriteLine($"La sottrazione (anonymous) è = {func3(5, 7)}");

            ////oppure utilizzando le lambda expression
            ////Func<int, int, int> func4 = (x, y) => x * y;
            ////Console.WriteLine($"La moltiplicazione (lamba expression) è = {func4(5, 7)}");


            //#endregion

            //#region Test delle Action
            ////Action è uguale alle func con l'unica differenza che non torna alcun valore (va bene void)
            //// puoi passare parameters ma se non hai bisogno di alcun parametro puoi tranquillamente non passare nulla

            //////Action void
            ////Action<int, int> action1 = Somma;
            ////action1(5, 2);

            //////Action anonymous
            ////Action action2 = delegate () { Console.WriteLine("Action 2"); };
            ////action2();

            ////Action lambda expression
            ////Action<int> action3 = x => Console.WriteLine($"Action 3: {x + 1}");
            ////action3(3);

            //#endregion

            //#region Test dei Predicate
            ////I predicate sono uguali ai Func e alle Action, sono dei delegate che prendono in input 1 parametro e torna un booleano

            ////predicato 1 che prende in input una stringa e ritorna bool
            ////Predicate<string> predicato1 = IsNumeric;
            ////Console.WriteLine(predicato1("fafafa"));

            //////Predicate con Anonymous
            ////Predicate<int> predicato2 = delegate (int x) { return x == 1; };
            ////Console.WriteLine(predicato2(2));

            //////Predicato con lambda expression
            ////Predicate<string> predicate3 = y => y.Equals("lorenzo");
            ////Console.WriteLine(predicate3("lorenzo"));

            //#endregion

            //#region Test delle Extension Methods
            ////Serve per estendere (aggiungere) metodi a delle classi già esistenti, ha bisogno di una classe e n metodi statici e l'operatore "this" nei parametri (dei motodi)
            ////guarda region Extension String Class (esempio)

            //////Immaginiamo di voler estendere la classe string (vedi classe estendi String)
            ////string nome = "Lorenzo";
            //////abbiamo creato questo metodo che conta il numero di caratteri e lo utilizziamo direttamente dal tipo string
            ////nome.ContaCaratteri();

            //////come vedi anche con una lista funziona, senza mandargli in input un parametro!
            ////List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            ////Console.WriteLine($"La media è = {list.MediaNumeri()}");
            //#endregion

            //#region Test degli Events
            //////gli events funzionano solo se esiste un delegates, altrimenti siamo "fritti"... in questo caso il nostro intEvent è il nostro delegate.

            //////creo il mio evento (classe)
            ////TestEvent ilMioNumero = new TestEvent();
            ////// aggiungo al mio oggetto ilmionumero, metto il .intevent (il mio delegato della classe)
            ////// e tramite += aggiungo (puntatore al metodo) l'evento dividi event
            ////ilMioNumero.intEvent += DividiEvent;

            ////int numeroInput;

            ////do
            ////{
            ////    //prendo in input da tastiera un qualsiasi numero o testo
            ////    Console.WriteLine("\nInserisci un numero:");
            ////    string? testoNUmero = Console.ReadLine();

            ////    //controllo che non sia null e soprattutto sia un numero senno non va bene
            ////    if (testoNUmero != null && IsNumeric(testoNUmero))
            ////    {
            ////        //visto che è un numero trasformo la stringa in int
            ////        numeroInput = Int32.Parse(testoNUmero);

            ////        //ho fissato -1 per uscire quindi controllo che non sia = -1
            ////        if (numeroInput != -1)
            ////        {
            ////            //se non è -1 allora assegno all'oggetto che ho creato . numero int (properties) uguale al numero preso in input
            ////            ilMioNumero.NumeroInt = numeroInput;
            ////        }
            ////    }
            ////    else
            ////    {
            ////        numeroInput = -1;
            ////    }
            ////}
            ////while (!numeroInput.Equals(-1));

            //#endregion
        }

        #region Metodi

        //funzione che utilizzo per testare i delegate
        static void Somma(int x, int y) => Console.WriteLine($"Il risultato è = {x + y}");

        //funzione che utilizzo con le Func
        static int SommaConReturn(int x, int y) => x + y;

        //funzione che utilizzo per testare i delegate
        static void Differenza(int x, int y) => Console.WriteLine($"Il risultato è = {x - y}");

        //metodo che prende come parametro un delegate
        static void MoltiplicaPiuDelegate(int x, int y, TestDelegate delegato)
        {
            Console.WriteLine($"Il risultato è = {x * y}");
            delegato(x, y);

            delegato = Somma;
            delegato(8, 9);

        }

        //metodo che utilizzo per l'aggiunta di un evento (in realtà è un metodo static normale)
        static void DividiEvent(int x, int y) => Console.WriteLine($"(evento) Hai diviso {x} per {y} e il risultato è = {x / y}");

        #endregion

        #region Regex
        //regex che controlla se l'input è un numero numerico oppure no (bool)
        public static bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }
        #endregion

    }

    #region Classe test per Extension String

    public static class EstendiString
    {
        //metodo 1 che conta e che stampa il numero di caratteri 
        public static void ContaCaratteri(this string testo) => Console.WriteLine($"I caratteri sono:{testo.Length}");

        public static double MediaNumeri(this IEnumerable<int> numeri) => (double)numeri.Sum() / (double)numeri.Count();

    }

    #endregion

    #region Classe test per gli Events
    public class TestEvent
    {
        
        private int numeroPrivate1;
        private int numeroPrivate2;

        //l'importante è che ci sia il delegate interno per far funzionare l'evento
        public event TestDelegate intEvent;

        //properties che accetta solo il set e non il get (soggettiva come cosa, in questo caso andava bene così)
        public int NumeroInt
        {
            set
            {
                this.numeroPrivate1 = value * value;
                this.numeroPrivate2 = value - 3;
                this.intEvent(this.numeroPrivate1, this.numeroPrivate2);
            }
        }
    }
    #endregion

}


