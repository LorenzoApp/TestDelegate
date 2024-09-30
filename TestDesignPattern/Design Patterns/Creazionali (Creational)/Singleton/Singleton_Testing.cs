using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.Singleton
{
    /// <summary>
    /// Il pattern Singleton serve per garantire che una classe una volta creata, anche se istanziata più volte, restituisca sempre e solo se stessa.
    /// 
    /// Prendiamo ad esempio una classe Logger, che viene utilizzata per tenere traccia delle attività del programma in un file txt.
    /// Se NON utilizzassimo il Singleton rischiamo di creare per ogni classe chiamante una nuova classe Logger, che in programmi semplici non 
    /// potrebbe inficiare sulle performance, ma in programmi di dimensioni più elevate potrebbe gravare sulle performance.
    /// 
    /// Come scriverlo correttamente?
    /// Creo una classe Logger (il nostro Singleton) e opzionalmente "sealed" (in modo che non possa essere ereditata).
    /// Una variabile istanza privata e statica dello stesso tipo della classe, 
    /// un costruttore privato, in questo caso Logger(),
    /// una property statica dello stesso tipo della classe chiamata Instance dove nella get controlliamo se esiste la facciamo ritornare altrimente ne creiamo una nuova.
    /// 
    /// </summary>
    public class Singleton_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    LoggerTxt loggerTxt = new LoggerTxt("Biagio amico delle guardie");
        //    LoggerPdf loggerPdf = new LoggerPdf("Biagio amico degli sbirri");
        //    LoggerImm loggerImm = new LoggerImm("Biagio amico della finanza");

        //    Logger logger = Logger.Instance;

        //    logger.ScriviLogLorenzo(loggerTxt);
        //    logger.ScriviLogLorenzo(loggerPdf);
        //    logger.ScriviLogLorenzo(loggerImm);
        //}
    }
}
