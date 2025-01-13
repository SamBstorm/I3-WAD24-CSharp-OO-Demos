namespace Demo27_LinQ_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personne> personnes = new List<Personne>();
            personnes.Add(new Personne("Willis", "Bruce", DateTime.Now));
            personnes.Add(new Personne("Bassinger", "Kim", DateTime.Now));
            personnes.Add(new Personne("Cruise", "Tom", DateTime.Now));
            personnes.Add(new Personne("Hanks", "Tom", DateTime.Now));
            personnes.Add(new Personne("Lucas", "Georges", DateTime.Now));

            var personnesNomPrenom = personnes.Select((p) => new { p.Nom, p.Prenom });
            //var personnesNomPrenom = from p in personnes
            //                         select new {p.Nom, p.Prenom};
            IEnumerable<string> noms = personnes.Select(p => p.Nom);
            //IEnumerable<string> noms = from p in personnes
            //                           select p.Nom;
            IEnumerable<int> anneesDeNaissances = personnes.Select(p => p.DateNaissance.Year);
            //IEnumerable<int> anneesDeNaissances = from p in personnes
            //                                      select p.DateNaissance.Year;
        }
    }
}
