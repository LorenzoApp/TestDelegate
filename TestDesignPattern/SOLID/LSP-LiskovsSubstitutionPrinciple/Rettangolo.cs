using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.LSP_LiskovsSubstitutionPrinciple
{
    public class Rettangolo
    {
        public virtual double AltezzaPrivate { get; set; }
        

        public virtual double LarghezzaPrivate { get; set; }


        public void CalcolaArea()
        {
            System.Console.WriteLine(LarghezzaPrivate * AltezzaPrivate);
        }
    }
}
