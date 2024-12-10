using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Abstract.Models
{
    public abstract class Animal
    {
        public string Nom { get; set; }

        public abstract void Crier();
    }
}
