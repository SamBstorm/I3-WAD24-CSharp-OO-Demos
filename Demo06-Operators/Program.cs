using Demo06_Operators.Models;

namespace Demo06_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredient tartine = new Ingredient("Tartine", 100);
            Console.WriteLine($"Mon premier ingrédient est {tartine.Nom} avec pour valeur nutritive {tartine.ValeurNutritive}");
            Ingredient choco = new Ingredient("Pâte à tartiner chocolatée", 60);
            Console.WriteLine($"Mon second ingrédient est {choco.Nom} avec pour valeur nutritive {choco.ValeurNutritive}");
            Recette tartineAuChoco = tartine + choco;
            tartineAuChoco += choco;
            Console.WriteLine($"En mélangeant les ingrédients suivant :");
            foreach (Ingredient ingredient in tartineAuChoco.Ingredients)
            {
                Console.WriteLine($"\t- {ingredient.Nom}");
            }
            Console.WriteLine($"J'obtiens la recette de : {tartineAuChoco.Nom} !");
            Console.WriteLine($"Qui a un totale de valeur nutritive de {tartineAuChoco.ValeurNutritiveTotale} !");

            Console.WriteLine($"Si je prends une quantité de 3 de {tartine.Nom}, j'obtiens une valeur nutritive de {tartine * 3}.");

            if(tartine == choco)
            {
                Console.WriteLine("Alors tartine vaut choco");
            }

            Ingredient tartine2 = tartine;

            if (tartine2 == tartine)
            {
                Console.WriteLine("Alors tartine2 vaut tartine");
            }

            Ingredient tartine3 = new Ingredient("Tartine", 100);
            if (tartine3 == tartine)
            {
                Console.WriteLine("Alors tartine3 vaut tartine");
            }
        }
    }
}
