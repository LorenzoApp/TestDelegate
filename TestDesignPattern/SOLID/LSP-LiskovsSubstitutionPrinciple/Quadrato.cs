using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.LSP_LiskovsSubstitutionPrinciple
{
    public class Quadrato : Rettangolo
    {
        private double lato;
        public Quadrato(double lato)
        {
            this.lato = lato;
            AltezzaPrivate = this.lato;
            LarghezzaPrivate = this.lato;
        }

        public override double AltezzaPrivate
        {
            get => this.lato;
            set => this.lato = value;
        }

        public override double LarghezzaPrivate
        {
            get => this.lato;
            set => this.lato = value;
        }

    }

}
