using Demo08_Abstract.Models;

namespace Demo08_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> foyer = new List<Animal>();
            foyer.Add(new Souris() { Nom = "Jerry" });
            foyer.Add(new Chat() { Nom = "Tom" });
            foyer.Add(new Tigre() { Nom = "Tonny" });

            foreach (Animal a in foyer)
            {
                a.Crier();
            }
        }
    }
}
