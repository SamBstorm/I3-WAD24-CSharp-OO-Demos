using Demo28_LinQ_SingleOrFirstOrDefault.Models;
using System.Collections;

namespace Demo28_LinQ_SingleOrFirstOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listEleve = new List<Student>(){
                new Student ("Legrain", "Samuel"),
                new Student ("Morre", "Thierry"),
                new Student ("Person", "Michael"),
                new Student ("Legrain", "Adrien") };

            Student? s_legrain;

            try
            {
                s_legrain = listEleve
                    .Where((s) => s.Nom == "Legrain" && s.Prenom == "Corentin")
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                Console.WriteLine("Attention, plus d'un étudiant correspondant!");
                s_legrain = listEleve
                    .Where((s) => s.Nom == "Legrain" && s.Prenom == "Corentin")
                    .FirstOrDefault();
            }
            if( s_legrain is null)
            {
                Console.WriteLine("Aucune correspondance à la demande...");
            }
            else
            {
                Console.WriteLine($"Voici l'étudiant : {s_legrain.Prenom} {s_legrain.Nom}.");
            }
        }
    }
}
