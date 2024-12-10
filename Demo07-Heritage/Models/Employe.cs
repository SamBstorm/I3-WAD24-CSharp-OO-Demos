using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_Heritage.Models
{
    public class Employe : Personne
    {
        public string Departement { get; set; }
        public bool EstOccupe { get; set; }

        public Employe(string firstName, string lastName, DateTime birthDate, string departement) : base(firstName, lastName, birthDate)
        {
            Departement = departement;
            EstOccupe = false;
        }

        public void Travailler()
        {
            EstOccupe = true;
        }
    }
}
