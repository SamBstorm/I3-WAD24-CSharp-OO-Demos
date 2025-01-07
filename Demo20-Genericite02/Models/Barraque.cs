using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo20_Genericite02.Models
{
    public class Barraque : Usine<Soldat>
    {
        public Soldat CreerSoldat()
        {
            return Produire<Soldat>();
        }

        public Officier CreerOfficier()
        {
            return Produire<Officier>();
        }
    }
}
