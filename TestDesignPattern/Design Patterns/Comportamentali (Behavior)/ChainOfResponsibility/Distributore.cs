using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Comportamentali__Behavior_.ChainOfResponsibility
{
    /// <summary>
    /// La nostra classe astratta "Handler"
    /// </summary>
    public abstract class Distributore
    {
        //handler successivo
        private Distributore? distributoreSuccessivo;

        /// <summary>
        /// metodo per settare il distributore successivo
        /// </summary>
        /// <param name="successivo"></param>
        public void setDistributoreSuccessivo(Distributore successivo)
        {
            distributoreSuccessivo = successivo;
        }

        /// <summary>
        /// metodo da implementare per gestire la richiesta
        /// </summary>
        /// <param name="distributore"></param>
        protected abstract bool GestisciClienteImpl(Cliente cliente);

        /// <summary>
        /// Metodo che viene utilizzato per gestire la richiesta, chiamare il metodo implementanto della classe figlio e successivamente se
        /// la classe figlio NON gestisce la richiesta, chiamare il distributore successivo (chain) che gestirà la richiesta (metodo ricorsivo) 
        /// </summary>
        /// <param name="cliente"></param>
        public void GestisciCliente(Cliente cliente)
        {
            //chiama il metodo della classe figlio per gestire il cliente
            bool gestCliente = GestisciClienteImpl(cliente);

            //se il distributore successivo è != null e la classe figlia non è riuscita a gestire la richiesta
            if (distributoreSuccessivo != null && !gestCliente)
            {
                //chiama l'implementazione della classe figlia successiva
                distributoreSuccessivo.GestisciCliente(cliente);
            }
        }

    }
}
