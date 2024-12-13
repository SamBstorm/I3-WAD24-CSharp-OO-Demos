using Demo13_Exceptions.Exceptions;
using Demo13_Exceptions.Models;

namespace Demo13_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            /*Console.WriteLine("Veuillez introduire un premier nombre :");
            int nombre1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez introduire un second nombre :");
            int nombre2 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"Le quotient de {nombre1} par {nombre2} vaut {Mathematique.Division(nombre1, nombre2)}");
            }
            catch
            {
                Console.WriteLine($"Le quotient de {nombre1} par {nombre2} vaut l'infini!");
            }*/


            Console.WriteLine("Calculons une moyenne des valeurs");
            int[] nbs =  new int[1];//null ;//
            try
            {
                Console.WriteLine($"La moyenne est de {Mathematique.Moyenne(nbs)}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Il n'y a pas de valeur à traiter...");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Aucune valeur n'est présent dans le tableau de données...");
            }
            catch (ArgumentArrayNeedValueException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Parameter name : {ex.ParamName}");
                Console.WriteLine($"Nombre de valeurs nécessaire : {ex.MinValueRequired}");
                Console.WriteLine($"Nombre de valeurs actuel : {ex.CurrentQuantityValues}");
                if (ex.CurrentQuantityValues == 0) Console.WriteLine("Pas de chiffre, pas de moyenne...");
                else if (ex.CurrentQuantityValues == 1) Console.WriteLine("Faire la moyenne d'un seul chiffre est inutile...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"La classe Exception étant la classe de base, elle coupe la file!");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Merci d'avoir utilisé Moyenne2000!");
        }
    }
}
