using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.DIP_DependencyInversionPrinciple
{
    /// <summary>
    /// /// Questo principio si basa sull'inversione delle dipendenze, ovvero mira a distaccare le dipendenze dalle classi "superiori" (complesse) a quelle inferiori (più semplici)
    /// aggiungendo un "layer" che fa da tramite... per aumentare la flessibilità e la manutenibilità.
    /// 
    /// Che significa?
    /// Il tutto si basa sulla DI (Dependence Injection) ovvero il passare la dipendenza tramite costruttore, metodi, o proprietà.
    /// 
    /// Come funziona?
    /// Immaginiamo di avere un'applicazione che gestisce file. Inizialmente gestisce solo immagini, successivamente con le nuove implementazioni
    /// dovrà gestire anche testi e video.
    /// 
    /// Esempio:
    /// Classe Gestisci File
    /// {
    ///     metodo scriviFile(Immagine) {fai qualcosa con le immagini}
    ///     metodo leggi file(Immagine) {fai qualcosa con le immagini}
    /// }
    /// 
    /// Se decidessimo di leggere un testo, con il metodo A andremo a modificare nuovamente alcune proprietà della classe gestisci file,
    /// rischioso perchè teoricamente potresti andare a toccare qualcosa che non dovresti oltre a dover ritestare tutte le funzionalità passate (oltre alle nuove).
    /// 
    /// Attraverso il metodo B invece, implementando questo tipo di astrazione, possiamo aggiungere N tipi di file senza dover toccare e/o inficiare su quelle già esistenti.
    /// 
    /// Metodo A (ERRATO):
    /// Classe Gestisci File
    /// {
    ///     metodo scriviFile(Immagine) {fai qualcosa con le immagini}
    ///     metodo leggi file(Immagine) {fai qualcosa con le immagini}
    ///     metodo leggi file(Testo) {fai qualcosa con il testo}
    /// }
    /// 
    /// Metodo B (CORRETTO)
    /// Creare un'interfaccia IFile con i metodi scrivi e leggi file
    /// Creare N classi che implementano l'interfaccia 
    /// Creare un layer (una classe) GestoreFile che si occupa di fare da tramite tra il main(dove si chiama e si utilizza il codice)
    /// e le varie classi attraverso la DI 
    /// 
    /// NB: Non sempre è possibile applicare questo prinicipio, si consiglia di applicarlo quando è necessario e si "prevede" che quella parte del codice
    /// possa cambiare con il tempo, altrimenti possiamo omettere e scrivere codice pulito nelle classi più semplici.
    /// Un astrazione ancora più di alto livello si potrebbe fare attraverso il Design Pattern Factory, tuttavia non lo vedremo in questo esempio.
    /// 
    /// </summary>
    public class DIP_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    FilePdf filePdf = new FilePdf();
        //    FileTxt fileTxt = new FileTxt();

        //    //layer
        //    GestoreFile gestoreFile = new GestoreFile();
        //    gestoreFile.GestisciTuttiIFile(fileTxt);
        //    gestoreFile.GestisciTuttiIFile(filePdf);

        //}
    }
}
