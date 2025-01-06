using Demo17_Event01.Models;

namespace Demo17_Event01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EtreVivant p1 = new Poisson("Némo");
            p1.onPVChanged += PvChangedNotified;
            p1.onDeath += DeathNotified;
            EtreVivant a1 = new Algue();
            a1.onPVChanged += PvChangedNotified;
            a1.onDeath += DeathNotified;

            for (int i = 0; i < 20; i++) { 
                p1.Vieillir();
                a1.Vieillir();
            }
        }

        static void PvChangedNotified(EtreVivant etreVivant, int pvEtreVivant)
        {
            if(etreVivant is Poisson p) Console.WriteLine($"Notre poisson {p.Name} a {pvEtreVivant} point(s) de vie.");
            else Console.WriteLine($"Notre algue a {pvEtreVivant} point(s) de vie.");
        }

        static void DeathNotified(EtreVivant etreVivant)
        {
            if (etreVivant is Poisson p) Console.WriteLine($"Malheureusement, le poisson {p.Name} n'a pas survécu...");
            else Console.WriteLine("C'est triste, une algue vient de fanée...");
            //etreVivant.onPVChanged -= PvChangedNotified;
        }
    }
}
