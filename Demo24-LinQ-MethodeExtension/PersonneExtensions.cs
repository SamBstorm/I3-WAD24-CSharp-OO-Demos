using Demo07_Heritage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo24_LinQ_MethodeExtension
{
    internal static class PersonneExtensions
    {
        public static Employe SeFaireEmbaucher(this Personne futurEmploye, string departement)
        {
            return new Employe(futurEmploye.FirstName, futurEmploye.LastName, DateTime.Now, departement);
        }
    }
}
