using Demo22_LinQ_TypeAnonyme.Models;

namespace Demo22_LinQ_TypeAnonyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez indiquer votre nom :");
            string nom = Console.ReadLine() ?? "";
            Console.WriteLine("Veuillez indiquer votre prénom :");
            string prenom = Console.ReadLine() ?? "";
            Console.WriteLine("Veuillez indiquer votre date de naissance (au format yyyy-mm-dd) :");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            //Personne user = new Personne() { Nom = nom, Prenom = prenom, DateNaissance = birthdate};
            var user = new { nom, prenom, birthdate };

            List<Personne> personnes = new List<Personne>() { 
                new Personne(){Nom="Legrain", Prenom="Samuel", DateNaissance= new DateTime(1987,9,27)},
                new Personne(){Nom="Legrain", Prenom="Adrien", DateNaissance= new DateTime(1989,6,21)},
                new Personne(){Nom="Legrain", Prenom="Corentin", DateNaissance= new DateTime(1991,12,15)}
            };

            var personnesModifiees = personnes.Select(p => new { p.Prenom, p.DateNaissance });
            /* //Si nous utilisions les fonctions anonyme au lieu des expressions fléchées (lambda expression)
            var personnesModifiees = personnes.Select(delegate (Personne p) { return new { p.Prenom, p.DateNaissance }; });
            var maFonctionFelchee = delegate (Personne p) { return new { p.Prenom, p.DateNaissance }; };
            */
        }
    }
}
