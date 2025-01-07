using Demo19_Genericite.Models;

namespace Demo19_Genericite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayListGeneric<int> arrayListInt = new ArrayListGeneric<int>();
            arrayListInt.Add(1);
            arrayListInt.Add(2);
            arrayListInt.Add(3);
            arrayListInt.Add(4);

            Console.WriteLine($"Le nombre entier en indice 2 est {arrayListInt[2]}.");

            ArrayListGeneric<string> arrayListString = new ArrayListGeneric<string>();
            arrayListString.Add("Bonjour");
            arrayListString.Add("Hello");
            arrayListString.Add("Hi");
            arrayListString.Add("Ciao");

            Console.WriteLine($"Le texte en indice 3 est {arrayListString[3]}");

            ArrayListGeneric<Chien> arrayListChien = new ArrayListGeneric<Chien>();
            arrayListChien.Add(new Chien("Médor"));
            arrayListChien.Add(new Chien("Rex"));
            arrayListChien.Add(new Chien("Rufus"));
            arrayListChien.Add(new Chien("Sultan"));

            Console.WriteLine($"Le chien en indice 0 se nomme {arrayListChien[0].Nom}");

            ArrayListGeneric<ConsoleColor> arrayListColor = new ArrayListGeneric<ConsoleColor>();
            arrayListColor.Add(ConsoleColor.Green);
            arrayListColor.Add(ConsoleColor.Red);
            arrayListColor.Add(ConsoleColor.Blue);
            arrayListColor.Add(ConsoleColor.Black);

            Console.WriteLine($"La couleur en indice 1 se nomme {arrayListColor[1]}");


        }
    }
}
