using Demo21_ActionFunc.Models;

namespace Demo21_ActionFunc
{
    public delegate bool Condition(Product p);
    public delegate List<Product> Filtre(Condition condition);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> shop = new List<Product>() { 
                new Product("Pull de Noël",29.99M),
                new Product("Casque gaming", 149.99M),
                new Product("Jeux de société", 24.99M),
                new Product("Cartes à jouer", 49.99M),
                new Product("Cartes de tarot", 12.50M)
            };

            Func<Func<Product,bool>,List<Product>> fonctionFiltre = delegate (Func<Product,bool> conditionFiltre)
            {
                List<Product> result = new List<Product>();
                foreach (Product p in shop)
                {
                    if(conditionFiltre(p)) result.Add(p);
                }
                return result;
            };

            Func<Product, bool> conditionPrix = delegate (Product p)
            {
                return p.Price < 50M;
            };

            foreach (Product p in fonctionFiltre(conditionPrix))
            {
                Console.WriteLine($"{p.Name} : {p.Price} Euro(s)");
            }
        }
    }
}
