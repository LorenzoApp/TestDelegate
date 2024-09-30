using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPattern.SOLID.DIP_DependencyInversionPrinciple
{
    public interface IFile
    {
        string Name { get; set; }
        string Description { get; set; }
        string Version { get; set; }

        public void ScriviFile();
        public void LeggiFile();

    }
}
