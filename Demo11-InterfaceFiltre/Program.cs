using Demo11_InterfaceFiltre.Models;

namespace Demo11_InterfaceFiltre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu au touché-coulé!");

            List<IPlacable> myShips = new List<IPlacable>();
            myShips.Add(new Bateau(2));
            myShips.Add(new Bateau(4));

            Console.WriteLine($"Veuillez positionner vos bateaux :");
            foreach (IPlacable ship in myShips)
            {
                Console.WriteLine("Veuillez indiquer la position sur l'axe X :");
                int posX = int.Parse(Console.ReadLine());
                Console.WriteLine("Veuillez indiquer la position sur l'axe Y :");
                int posY = int.Parse(Console.ReadLine());
                Console.WriteLine("Votre bateau est-il à l'horizontal ? (O)ui - (N)on");
                bool isHorizontal = Console.ReadKey(true).Key == ConsoleKey.O;
                ship.SetPosition(posX, posY, isHorizontal);
                Console.WriteLine($"Votre bateau est positionné en {posX} - {posY} {(isHorizontal ? "à l'horizontal" : "à la vertical")}.");
            }

            List<IAttackable> opponentShips = new List<IAttackable>();
            for (int i = 0; i < myShips.Count; i++)
            {
                opponentShips.Add((Bateau)myShips[i]);
            }
            Console.WriteLine("Quel position envoyez-vous votre missile?");
            Console.WriteLine("Veuillez indiquer la position sur l'axe X :");
            int posMissileX = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer la position sur l'axe Y :");
            int posMissileY = int.Parse(Console.ReadLine());
            bool hit = false;
            for (int i = 0; i < opponentShips.Count && !hit; i++)
            {
                if(opponentShips[i].FireOn(posMissileX, posMissileY))
                {
                    hit = true;
                }
            }
            if (hit)
            {
                Console.WriteLine("Touché!");
            }
            else
            {
                Console.WriteLine("Plouf!");
            }
        }
    }
}
