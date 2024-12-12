using Demo09_Interfaces.Models;

namespace Demo09_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateau b = new Bateau("La toison d'or");

            Canoe c = new Canoe();

            IBateau monBateau = b;

            IBateau monSecondBateau = c;

            List<IBateau> monPort = new List<IBateau>();

            monPort.Add(b);
            monPort.Add(c);

            Random rnd = new Random();

            IBateau choixBateau = monPort[rnd.Next(monPort.Count)];

            choixBateau.Naviguer();
            if(choixBateau is Bateau bateau)
            {
                Console.WriteLine($"Le nom du bateau est {bateau.Matricule}");
            }

            choixBateau.Couler();

            Voiture v = new Voiture("ma Ferrari");
            VehiculeAmphibie va = new VehiculeAmphibie("Crocodile rouge");

            List<IVoiture> parking = new List<IVoiture>();
            parking.Add(v);
            parking.Add(va);

            parking[1].Rouler();

            monPort.Add((VehiculeAmphibie)parking[1]);
            monPort[2].Naviguer();
        }
    }
}
