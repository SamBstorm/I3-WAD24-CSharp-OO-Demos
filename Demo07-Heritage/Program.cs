using Demo07_Heritage.Models;

namespace Demo07_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne(
                firstName : "Jhon", 
                lastName : "Doe", 
                birthDate : new DateTime(1987,1,1));

            Console.WriteLine(p.SePresenter());

            Employe e = new Employe("Henry","Verne",new DateTime(1991,1,1),"Développement");

            Console.WriteLine(e.SePresenter());
            e.Travailler();

            if (e.EstOccupe)
            {
                Console.WriteLine("Désoloé, je travaille, je n'ai pas le temps...");
            }
            else
            {
                Console.WriteLine("Oui, que puis-je faire pour toi?");
            }
        }
    }
}
