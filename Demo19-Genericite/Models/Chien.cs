using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Genericite.Models
{
    internal class Chien
    {
        public string Nom { get; private set; }
        public Chien(string nom)
        {
            Nom = nom;
        }
    }
}
