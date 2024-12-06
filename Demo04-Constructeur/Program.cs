namespace Demo04_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animalDeCompagnie = new Animal("Bugs");

            Console.WriteLine($"Voici les propriété de notre animal :");
            Console.WriteLine($"Nom : {((animalDeCompagnie.Nom is null)? "NULL" : animalDeCompagnie.Nom)}");
            Console.WriteLine($"Point de Vie : { animalDeCompagnie.PointDeVie }");
            Console.WriteLine($"Point de Bonheur : { animalDeCompagnie.PointDeBonheur }");
            Console.WriteLine($"Liste de jouets :");
            foreach (string jouet in animalDeCompagnie.Jouets)
            {
                Console.WriteLine($"\t- {jouet}");
            }

            Animal animalDeSauvegarde = new Animal("Bugs", 5, 0, ["balle","carotte kuin-kuin","grelot géant"]);

            Console.WriteLine($"Voici les propriété de notre animal :");
            Console.WriteLine($"Nom : {((animalDeSauvegarde.Nom is null) ? "NULL" : animalDeSauvegarde.Nom)}");
            Console.WriteLine($"Point de Vie : {animalDeSauvegarde.PointDeVie}");
            Console.WriteLine($"Point de Bonheur : {animalDeSauvegarde.PointDeBonheur}");
            Console.WriteLine($"Liste de jouets :");
            foreach (string jouet in animalDeSauvegarde.Jouets)
            {
                Console.WriteLine($"\t- {jouet}");
            }
        }
    }
}
