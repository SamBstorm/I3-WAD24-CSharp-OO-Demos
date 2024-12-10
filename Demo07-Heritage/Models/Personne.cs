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
        protected DateTime BirthDate { get; private set; }

        public Personne(string firstName, string lastName, DateTime birthDate) {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public virtual string SePresenter()
        {
            return $"Voici {FirstName} {LastName}, il est né le {BirthDate.ToShortDateString()}";
        }

        public string SePresenter2()
        {
            return $"Voici {FirstName} {LastName}, il est né le {BirthDate.ToShortDateString()}";
        }

        public override string ToString()
        {
            return SePresenter();
        }
    }
}
