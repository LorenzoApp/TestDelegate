using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.Design_Patterns.Creazionali__Creational_.Factory.ReflectionFactory
{
    public sealed class ReflectionFactory
    {
        //singleton
        private static readonly ReflectionFactory instance = new ReflectionFactory();
        
        //lista di tipi
        private readonly IEnumerable<Type?> types;
        
        //costruttore privato per il singleton
        private ReflectionFactory()
        {
            //tramite la reflection prendo tutti i tipi 
            var tipi = Assembly.GetAssembly(typeof(ReflectionFactory)).GetTypes()
                       .Where(x => typeof(IMetodiPagamento).IsAssignableFrom(x));

            types = tipi ?? new List<Type>();
        }

        //getinstance pubblico per il singleton
        public static ReflectionFactory GetInstance { get => instance; }

        //metodo che tramite la reflection crea un oggetto FACTORY REFLECTION in base al tipo di testo passato
        public IMetodiPagamento? GetMetodoPagamentoReflection(string metodoPagamento)
        {
            var productTypes = types.FirstOrDefault(x => x.Name.Contains(metodoPagamento));

            //createInstance serve per creare un'istanza se il tipo passato esiste
            return Activator.CreateInstance(productTypes) as IMetodiPagamento;
        }
    }
}
