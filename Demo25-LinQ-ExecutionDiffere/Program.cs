using Demo25_LinQ_ExecutionDiffere.Models;

namespace Demo25_LinQ_ExecutionDiffere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(
                new List<Product>()
                {
                    new Product("mousse à raser", 4.99M),
                    new Product("dentifrice", 14.99M),
                    new Product("savon pour les mains", 9.99M),
                    new Product("shampoing pour cheveux colorés", 19.99M)
                });

            //List<Product> products = shop.FilterByPrice(7M, 15M);
            IEnumerable<Product> products = shop.FilterByPriceDefer(7M, 15M);
            Console.WriteLine($"Voici la liste des produits entre 7.00€ et 15.00€ :");
            foreach (Product p in products)
            {
                Console.WriteLine($"- {p.Name} : {p.Price}");
            }
        }
    }
}
