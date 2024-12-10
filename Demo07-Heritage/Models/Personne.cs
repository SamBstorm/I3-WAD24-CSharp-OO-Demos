using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_Heritage.Models
{
    public class Personne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime BirthDate { get; set; }

        public Personne(string firstName, string lastName, DateTime birthDate) {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string SePresenter()
        {
            return $"Voici {FirstName} {LastName}, il est né le {BirthDate.ToShortDateString()}";
        }
    }
}
