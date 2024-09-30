using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestDelegate
{
    #region Ciclo di vita di un Thread
    //dotNET Framework switcha in automatico i thread da Running e Sleeping.
    //Un processo si può dividere in più thread, un Thread è un processo diviso in più parti
    //il ciclo di vita di un thread va da:
    //READY è lo stato iniziale (appena creato) , con start() va in stato -> running
    //RUNNING sleep() e va in stato -> SLEEPING oppure con abord() va in stato DEAD
    //SLEEPING da sleeping può tornare in stato running oppure con Suspend() va in stato SUSPENDED
    //SUSPENDED resume() e torna in stato Sleeping
    //DEAD entra qui se è stato concluso correttamente o è stato cancellato. 
    #endregion

    #region Properties della classe Thread
    //properties:
    //current: thread restituisce il nome del thread
    //IsAlive: serve per capire lo stato del thread, return true se è in esecuzione altrimenti return false
    //Name: per assegnare un nome al thread
    //Priority: (per lo scheduler) in genere è assegnato a normal, però si può cambiare come abovenormal, lowest etc etc 
    #endregion

    #region Metodi della classe Thread
    //methods:
    //Interrupt: per interrompere il thread che sta aspettando o dormendo o Join (stato)
    //Join: per bloccare il thread finchè un altro thread non è terminato
    //Resume: per recuperare un thread che è stato sospeso da poco
    //Sleep: per bloccare il thread per un certo periodo di tempo
    //SpinWait: per bloccare un thread un numero di volte per un numero specifico di tempo per iterazione (non ho capito)
    //Start: per iniziare un thread
    //suspend: per sospendere un thread 
    #endregion

    // delegate utilizzato nel test 4
    public delegate void SommaDeiNumeriDelegate(int sommaDeiNumeri);

    public class ThreadTesting
    {
        //variabile statica utilizzata nel test 7
        private static int Somma = 0;

        //lock object
        public static object _lock = new(); // è uguale a scrivere new object()

        //variabile statica per il reset di un evento manuale
        public static ManualResetEvent ManualResetEvent = new ManualResetEvent(false);

        //main è un sistema single Thread(application)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
            
        //    //#region Cambiare il nome al Thread
        //    //////I Thread di base non hanno un nome,
        //    ////Thread t = Thread.CurrentThread; //current thread restituisce il nome del thread
        //    ////// possiamo assegnarglielo noi però con Name
        //    ////t.Name = "Main Thread";
        //    ////Console.WriteLine($"Thread name {t.Name}");
        //    ////Console.WriteLine($"My current Thread : {Thread.CurrentThread.Name}");
        //    //#endregion

        //    //Console.WriteLine("Main Thread started");

        //    //#region Single thread
        //    ////Metodo1();
        //    ////Console.WriteLine($"------COMPLETATO------");
        //    ////Metodo2();
        //    ////Console.WriteLine($"------COMPLETATO------");
        //    ////Metodo3();
        //    ////Console.WriteLine($"------COMPLETATO------"); 
        //    //#endregion

        //    //#region MultiThreading: Thread - ThreadStart(delegate) - ParameterizedThreadStart(delegate con object)

        //    //#region Test 1 - Thread di un metodo utilizzando Thread() -> delegate istanziato in automatica da CLR
        //    ////CLR in automatico instanzia un delegate e fa le operazioni del test 3
        //    ////creo i Threads
        //    ////Thread t1 = new Thread(Metodo1)
        //    ////{
        //    ////    Name = "Thread 1"
        //    ////};

        //    ////Thread t2 = new Thread(Metodo2)
        //    ////{
        //    ////    Name = "Thread 2"
        //    ////};

        //    //////oppure scrivere così è la stessa cosa
        //    ////Thread t3 = new Thread(Metodo3);
        //    ////t3.Name = "Thread 3";

        //    //////esegui i metodi
        //    ////t1.Start();
        //    ////t2.Start();
        //    ////t3.Start();
        //    //#endregion

        //    //#region Test 3 - ThreadStart (delegate void senza parametri)
        //    ////ThreadStart è un delegate e come tale essendo void puo essere assegnato a metodi che hanno type void e 0 parametri in ingresso
        //    ////ThreadStart oggetto = new ThreadStart(MetodoStampaNumeri);

        //    ////**essendo un delegate possiamo applicare anche gli anonymous e i lambda expression**
        //    ////ThreadStart oggettoAnonymous = delegate () { MetodoStampaNumeri(); }; // anonymous
        //    ////ThreadStart oggettoLambdaExpression = () =>  MetodoStampaNumeri(); //lambda

        //    ////// oppure questo (vanno bene entrambi)
        //    ////ThreadStart oggetto = MetodoStampaNumeri;

        //    //////Al posto di assegnare il metodo direttamente al task utilizziamo il delegate appena creato "oggetto"
        //    ////Thread thread1 = new Thread(oggetto);
        //    ////thread1.Start();
        //    //#endregion

        //    //#region Test 4 - Passsare i parametri ai Thread in modo sicuro (con e senza doppio delegate)
        //    ////DA QUI ---> faccio la stessa cosa però in maniera sicura, utilizzando la classe Gestisci numeri
        //    ////GestisciNumeri gestisciNumeri = new GestisciNumeri(10);

        //    ////ThreadStart oggetto = new ThreadStart(gestisciNumeri.MetodoStampaNumeriSicuro);

        //    ////Thread thread = new Thread(oggetto);
        //    ////thread.Start();

        //    ////Creo il mio delegate che punta al metodo (callback method) somma numeri
        //    ////SommaDeiNumeriDelegate sommaDeiNumeriDelegate = MetodoSommaNumeri;

        //    //////creo il mio oggetto in modo da passargli le proprietà in modo sicuro
        //    ////GestisciNumeri gestisciNumeri = new GestisciNumeri(10, sommaDeiNumeriDelegate);

        //    //////creo il delegate oggetto che ha all'interno il delegate che punta al metodo somma 
        //    ////ThreadStart oggetto = new ThreadStart(gestisciNumeri.MetodoSommaNumeriSicuro);

        //    //////passo al thread oggetto che sarebbe il delegate di tipo void con dentro un altro delegate che punta al metodo somma
        //    ////Thread thread = new Thread(oggetto);
        //    ////thread.Start();

        //    //#endregion

        //    //#region Test 5 - ParameterizedThreadStart (delegate void con 1 parametro di tipo object in ingresso)
        //    //// delegate void che accetta solo 1 parametro object in ingresso
        //    ////ParameterizedThreadStart oggetto2 = new ParameterizedThreadStart(MetodoStampaNumeriInIngresso);
        //    //////ParameterizedThreadStart oggetto2 = delegate (object? x) { MetodoStampaNumeriInIngresso(x); }; //anonymous
        //    //////ParameterizedThreadStart oggetto2 =  (object? x) => MetodoStampaNumeriInIngresso(x); ; //lambda

        //    ////Thread threadParameterized = new Thread(oggetto2);
        //    //////threadParameterized.Start("b"); //test con il testo
        //    ////threadParameterized.Start(5);
        //    //#endregion

        //    //#region Test 6 - IsAlive e JOIN (blocca il thread per un tempo indefinito/finito[se specificato] finchè il metodo join interno non è terminato)
        //    //////creo il primo nuovo thread
        //    ////Thread thread1 = new Thread(Metodo1);
        //    ////thread1.Start();

        //    //////creo il secondo nuovo thread
        //    ////Thread thread2 = new Thread(Metodo2);
        //    ////thread2.Start();

        //    //////forzo gli altri thread con Join, finchè Thread1 non ha finito la sua esecuzione, gli altri thread non possono andare avanti
        //    //////thread1.Join();
        //    //////Console.WriteLine("Thread1 completato");

        //    //////oppure join specificando i millisecondi, in questo modo specifichi un timeout prima che gli altri thread continuino la loro esecuzione
        //    ////if (thread1.Join(10000))
        //    ////{
        //    ////    Console.WriteLine("Thread1 completato");
        //    ////}

        //    //////forzo gli altri thread con Join, finchè Thread2 non ha finito la sua esecuzione, gli altri thread non possono andare avanti
        //    ////thread2.Join();
        //    ////Console.WriteLine("Thread2 completato");

        //    //////is alive torna boolean true se è in esecuzione, false se non lo è
        //    ////if (thread1.IsAlive)
        //    ////{
        //    ////    Console.WriteLine("Thread 1 ancora in esecuzione");
        //    ////}
        //    ////else
        //    ////{
        //    ////    Console.WriteLine("Thread 1 ha finito al 100%");
        //    ////}
        //    //#endregion
        //    //#endregion

        //    //#region MultiThreading: Interlocked - Lock - Monitor (per proteggere le risorse che utilizziamo nel multithreading)
        //    ////Interlocked: (più veloce rispetto a lock) fornisce dei metodi come somma, divisione, confronto che non possono essere interroti da altri processi (atomic operation)
        //    ////Lock: permette a una porzione di codice di "proteggerla", ovvero un unico Thread per volta può accedervi
        //    ////Monitor: è un lock ma fornisce più controlli sui thread, a differenza del lock permette di utillizare try, catch, finally
        //    ////Monitor: quindi abbiamo maggiore controllo di quel che sta avvenendo nel nostro codice

        //    //#region Interlocked
        //    ////misura il tempo tra due punti specifici dell'applicazione
        //    ////Stopwatch stopwatch = Stopwatch.StartNew();

        //    //////creo nuovo thread, all'interno la CLR crea un delegate in automatico e lo faccio partire con start
        //    ////Thread t1 = new Thread(MetodoAddizionaInterlocked);
        //    ////t1.Start();

        //    //////come vediamo dal risultato sommiamo con il metodo interlocked
        //    ////Thread t2 = new Thread(MetodoAddizionaInterlocked);
        //    ////t2.Start();

        //    //////dico che finchè non finisce t1 e t2 gli altri thread non posso terminare
        //    ////t1.Join();
        //    ////t2.Join();

        //    ////Console.WriteLine($"La somma è = {Somma}");

        //    ////stopwatch.Stop();

        //    ////Console.WriteLine($"Il tempo trascorso è di = {stopwatch.ElapsedTicks}");

        //    ////più veloce rispetto a lock
        //    //#endregion

        //    //#region Lock
        //    //////misura il tempo tra due punti specifici dell'applicazione
        //    ////Stopwatch stopwatch = Stopwatch.StartNew();


        //    ////Thread thread1 = new Thread(MetodoAddizionaLock);
        //    ////Thread thread2 = new Thread(MetodoAddizionaLock);

        //    ////thread1.Start();
        //    ////thread2.Start();

        //    ////thread1.Join();
        //    ////thread2.Join();


        //    ////Console.WriteLine($"La somma è = {Somma}");

        //    ////stopwatch.Stop();

        //    ////Console.WriteLine($"Il tempo trascorso è di = {stopwatch.ElapsedTicks}");
        //    //////più lento rispetto a Interlocked
        //    //#endregion

        //    //#region Monitor

        //    //#region Enter (riservare il codice a quel solo Thread) (esempio 1 e 2 - vedi MetodoAddizionaMonitor) e Exit (rilasciare il Thread - ATTENZIONE: se non fai Exit si rischia deadlock)
        //    //////Enter serve per bloccare quella parte di codice (come il lock normale)
        //    //////Exit invece rilascia la risorsa permettendo anche ad altri thread di accedervi

        //    //////misura il tempo tra due punti specifici dell'applicazione
        //    ////Stopwatch stopwatch = Stopwatch.StartNew();

        //    ////Thread thread1 = new Thread(MetodoAddizionaMonitor);
        //    ////Thread thread2 = new Thread(MetodoAddizionaMonitor);

        //    ////thread1.Start();
        //    ////thread2.Start();

        //    ////thread1.Join();
        //    ////thread2.Join();

        //    ////Console.WriteLine($"La somma è = {Somma}");

        //    ////stopwatch.Stop();

        //    ////Console.WriteLine($"Il tempo trascorso è di = {stopwatch.ElapsedTicks}");
        //    //////più lento rispetto a Interlocked 
        //    //#endregion

        //    //#region Wait - Pulse - PulseAll
        //    //// Pulse: serve per mandare una "notifica" al Thread che è in Wait (attesa) che può andare avanti
        //    //// Pulse: se ci fossero più di un Thread in attesa allora la scelta varia in base allo scheduling (non da noi)
        //    //// Wait: serve per rilasciare la risorsa e mettere il thread in attesa finchè non riceve una notifica (pulse, pulseAll)
        //    //// PulseAll: manda una notifica a tutti i Thread in modo che competano tra loro per l'uso della risorsa

        //    //Thread thread1 = new Thread(MetodoLeggiMonitor);
        //    //Thread thread2 = new Thread(MetodoScriviMonitor);

        //    //thread1.Start();
        //    //thread2.Start();

        //    //thread1.Join();
        //    //thread2.Join();

        //    //#endregion

        //    //#endregion

        //    //#region ManualResetEvent (True .Set evento sbloccato | False .Reset = inizialmente bloccato)
        //    //// Manual Reset/set event serve per ...
        //    //Thread thread = new Thread(MetodoLeggiMonitor);



        //    //#endregion



        //    //#endregion

        //    //Console.WriteLine("Main Thread ended");

        //    //Console.ReadLine();

        //}

        #region Metodi della classe ThreadTesting
        //metodo di test 1 per verificare il single thread/multithread
        static void Metodo1()
        {
            Console.WriteLine("Metodo 1 iniziato usando il thread " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Metodo uno ciclo: {i}");
            }
            Console.WriteLine("Metodo 1 finito usando il thread " + Thread.CurrentThread.Name);

            Thread.Sleep(10000);
            Console.WriteLine("Metodo 1 awake");
        }

        //metodo di test 1 per verificare il single thread
        static void Metodo2()
        {
            Console.WriteLine("Metodo 2 iniziato usando il thread " + Thread.CurrentThread.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Metodo due ciclo: {i}");
                if (i == 2)
                {
                    Console.WriteLine($"Partono i 5 secondi");

                    //il processo dorme per 5 secondi
                    Thread.Sleep(5000);

                    Console.WriteLine($"Finiti i 5 secondi");
                }
            }
            Console.WriteLine("Metodo 2 finito usando il thread " + Thread.CurrentThread.Name);

        }

        //metodo di test 1 per verificare il single thread/multithread
        static void Metodo3()
        {
            Console.WriteLine("Metodo 3 iniziato usando il thread " + Thread.CurrentThread.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Metodo tre ciclo: {i}");
            }
            Console.WriteLine("Metodo 3 finito usando il thread " + Thread.CurrentThread.Name);

        }

        //metodo utilizzato dal delegate void ThreadStart
        static void MetodoStampaNumeri()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Stampo numero: {i}");
            }
        }

        //metodo utilizzato per il delegate ParameterizedThreadStart
        static void MetodoStampaNumeriInIngresso(object? massimoNumeri)
        {
            int stop = massimoNumeri != null && DelegateTesting.IsNumeric(massimoNumeri.ToString()) ? Convert.ToInt32(massimoNumeri) : 0;

            if (stop > 0)
            {
                for (int i = 0; i < stop; i++)
                {
                    Console.WriteLine($"Stampo numero: {i}");
                }
            }
            else
            {
                Console.WriteLine($"Niente numeri");
            }
        }

        //metodo utilizzato per il delegate SommaDeiNumeriDelegate che viene chiamato da un delegate interno alla classe Gestisci numeri in modo sicuro
        static void MetodoSommaNumeri(int somma)
        {
            Console.WriteLine("La somma è: " + somma);
        }

        public static void MetodoAddizionaInterlocked()
        {
            for (int i = 0; i < 4000; i++)
            {
                //invece di 
                //Somma++;
                Interlocked.Increment(ref Somma); //referenza (ref) alla variabile che deve essere incrementata
            }
        }

        public static void MetodoAddizionaLock()
        {
            for (int i = 0; i < 4000; i++)
            {
                //invece di 
                //Somma++;
                lock (_lock)
                {
                    Somma++;
                }
            }
        }

        public static void MetodoAddizionaMonitor()
        {
            #region Costruttore 1 - LockEnter && LockExit
            //for (int i = 0; i < 4000; i++)
            //{
            //    Monitor.Enter(_lock);

            //    try
            //    {
            //        Somma++;

            //    }
            //    finally
            //    {
            //        //nel nostro caso non ci serve catch, utilizzeremo finally

            //        Monitor.Exit(_lock);

            //    }
            //} 
            #endregion

            #region Costruttore 2 - LockEnter, LockExit e ref LockTaken
            //Locktaken serve per tenere traccia dello stato, ovvero se effettivamente è stato preso in causa il thread con l'enter
            //LockTaken è true se la richiesta è stata presa in considerazione, altrimenti è false

            for (int i = 0; i < 4000; i++)
            {
                bool lockTaken = false;

                //passiamo il lock e il locktaken nel metodo enter, che visto che c'è il ref, dovrebbe (se va tutto a buon fine) passare lockTaken = true
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Somma++;

                }
                finally
                {
                    //nel nostro caso non ci serve catch, utilizzeremo finally

                    //se è andato tutto a buon fine, lockTaken è true... se è così facciamo exit
                    if (lockTaken)
                    {
                        Console.WriteLine("");
                        Monitor.Exit(_lock);
                    }
                }
            }
            #endregion
        }

        public static void MetodoLeggiMonitor()
        {
            //riserva la risorsa
            Monitor.Enter(_lock);

            for (int i = 0; i < 5; i++)
            {
                //manda una notifica al prossimo Thread che può andare avanti
                Monitor.Pulse(_lock); //oppure PulseAll in caso ci fosse la necessità
                Console.WriteLine($"Leggi - Monitor Thread working: {i}");

                Console.WriteLine($"Leggi - Monitor Thread Completed: {i}");

                //rilascia la risorsa e mette in wait in attesa della notifica pulse
                Monitor.Wait(_lock);

            }

            //Monitor.Exit(_lock);

        }

        public static void MetodoScriviMonitor()
        {
            Monitor.Enter(_lock);

            for (int i = 0; i < 5; i++)
            {
                //manda una notifica al prossimo Thread che può andare avanti
                Monitor.Pulse(_lock); //oppure PulseAll in caso ci fosse la necessità
                Console.WriteLine($"Scrivi - Monitor Thread working: {i}");

                Console.WriteLine($"Scrivi - Monitor Thread Completed: {i}");

                //rilascia la risorsa e mette in wait in attesa della notifica pulse
                Monitor.Wait(_lock);
            }

            //Monitor.Exit(_lock);
        }

        #endregion

    }

    //classe per gestire in modo SICURO i numeri o in generale i dati (NumberHelper)
    public class GestisciNumeri
    {
        //variabile privata accessibile solo tramite costruttore o metodo
        private int numero;

        //delegate interno alla classe - callback Delegate
        SommaDeiNumeriDelegate sommaDeiNumeriDelegate;

        //costruttore usato solo per un test, non eliminare anche se da sottolineato
        public GestisciNumeri(int numero)
        {
            this.numero = numero;
        }

        //costruttore della classe con delegate
        public GestisciNumeri(int numero, SommaDeiNumeriDelegate sommaDeiNumeriDelegate)
        {
            this.numero = numero;
            this.sommaDeiNumeriDelegate = sommaDeiNumeriDelegate;
        }

        //metodo per stampare 
        public void MetodoStampaNumeriSicuro()
        {
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"Stampo numero sicuro: {i}");
            }
        }

        public void MetodoSommaNumeriSicuro()
        {
            int somma = 0;

            for (int i = 0; i < numero; i++)
            {
                somma += i;
            }

            if (sommaDeiNumeriDelegate != null)
            {
                this.sommaDeiNumeriDelegate(somma);
            }

        }

    }
}







