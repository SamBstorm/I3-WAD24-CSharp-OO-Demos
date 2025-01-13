using Demo07_Heritage.Models;

namespace Demo24_LinQ_MethodeExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Samuel","Legrain", new DateTime(1987,9,27));

            //p1 = PersonneExtensions.SeFaireEmbaucher(p1, "dotnet");
            p1 = p1.SeFaireEmbaucher("dotnet");

            Console.WriteLine(((Employe)p1).SePresenter());
        }
    }
}
