using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_Event01.Models
{
    public class Poisson : EtreVivant
    {
        public string Name { get; private set; }

        public Poisson(string name)
        {
            Name = name;
        }

        public override void Vieillir()
        {
            if (PV > 0) PV--;
        }
    }
}
