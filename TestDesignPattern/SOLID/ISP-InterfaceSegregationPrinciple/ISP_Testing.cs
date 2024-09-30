using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.ISP_InterfaceSegregationPrinciple
{
    /// <summary>
    /// Il principio dell'ISP (Interface Principle Segregation) è quello di suddividere un'interfaccia "grande" in più "mini" interfacce in modo che se in un futuro ci dovessero essere una o più modifiche
    /// non c'è bisogno di implementare metodi non necessari (quindi vuoti) nella nuova classe (il tutto più flessibile).
    /// 
    /// Ecco un esempio pratico:
    /// 
    /// Ipotizziamo di avere una classe manageriale che deve gestire dei lavoratori, i lavoratori devono quindi lavorare e fare una pausa pranzo.
    /// Cosa succede quando subentra una nuova classe  Robot? I robot devono solo lavorare, non hanno bisogno di pause ne tanto meno di mangiare.
    /// 
    /// Nell'esempio "A" (ERRORE) la nuova classe Robot per lavorare dovra implementare sia i metodi work che il metodo eat (che non gli serve).
    /// 
    /// Nell'esempio "B" (CORRETTO) la nuova classe robot dovrà implementare solo l'interfaccia iworker mentre la classe dei lavoratori dovrà implementare entrambe le interfacce.
    /// 
    /// Tutto questo mira ad avere più flessibilità, anche se richiede un'impegno computazionale decisamente più grande.
    /// 
    /// ESEMPIO A (ERRORE):
    /// Interfaccia IWorker con dentro i metodi eat e work
    /// 
    /// ESEMPIO B (CORRETTO):
    /// Un'interfaccia IEater con all'interno il metodo eat e un'altra interfaccia IWorker con all'interno il metodo work
    /// 
    /// </summary>
    public class ISP_Testing
    {
#warning scommentare per il test
        //static void Main(string[] args)
        //{
        //    Robot robottone = new Robot();
        //    robottone.lavora();

        //    Lavoratore lavoratore = new Lavoratore();
        //    lavoratore.mangia();
        //    lavoratore.lavora();
        //}
    }
}
