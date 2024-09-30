using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.DIP_DependencyInversionPrinciple
{
    public class GestoreFile
    {
        public void GestisciTuttiIFile(IFile file)
        {
            file.LeggiFile();
            file.ScriviFile();
        }
    }
}
