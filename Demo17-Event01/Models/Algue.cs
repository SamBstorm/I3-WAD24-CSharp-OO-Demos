using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_Event01.Models
{
    public class Algue : EtreVivant
    {
        public override void Vieillir()
        {
            PV++;
        }
    }
}
