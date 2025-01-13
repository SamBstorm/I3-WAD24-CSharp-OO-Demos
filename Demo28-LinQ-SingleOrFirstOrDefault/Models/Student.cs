using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo28_LinQ_SingleOrFirstOrDefault.Models
{
    internal class Student
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Student(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}
