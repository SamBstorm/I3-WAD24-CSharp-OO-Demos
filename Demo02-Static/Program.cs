using Demo02_Static.Enums;

namespace Demo02_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture();
            v1.color = EnumColor.Rouge;
            v1.nbSeats = 4;

            Voiture v2 = new Voiture() { 
                color = EnumColor.Bleu,
                nbSeats = 5
            };

            Voiture.nbWheels = 4;

            Console.WriteLine($"Ma voiture est de couleur {v1.color} et a {v1.nbSeats} place(s). Toutes les voitures ont {Voiture.nbWheels} roue(s).");


            Console.WriteLine($"La voiture de Dorothée est de couleur {v2.color} et a {v2.nbSeats} place(s). Toutes les voitures ont {Voiture.nbWheels} roue(s).");

            Console.WriteLine($"Je roule trop vite, je me crashe... Je perds une roue...");
            Voiture.nbWheels -= 1;


            Console.WriteLine($"Ma voiture est de couleur {v1.color} et a {v1.nbSeats} place(s). Toutes les voitures ont {Voiture.nbWheels} roue(s).");


            Console.WriteLine($"La voiture de Dorothée est de couleur {v2.color} et a {v2.nbSeats} place(s). Toutes les voitures ont {Voiture.nbWheels} roue(s).");


            Console.WriteLine(Mathematics.Addition(3.14, 2.5, 7.2));
        }
    }
}
