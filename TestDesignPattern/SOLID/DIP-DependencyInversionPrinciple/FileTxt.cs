using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.DIP_DependencyInversionPrinciple
{
    public class FileTxt : IFile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }

        public void LeggiFile()
        {
            Console.WriteLine("Sto leggendo un file TXT");
        }

        public void ScriviFile()
        {
            Console.WriteLine("Sto scrivendo un file TXT");
        }
    }
}
