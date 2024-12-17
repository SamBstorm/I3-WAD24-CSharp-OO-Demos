using Demo16_Delegate03.Models;

namespace Demo16_Delegate03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Shop shopping = new Shop(
                new Dictionary<Product, int>(){
                    { new Product("Snuggie", 39.99M, ["Vêtement","Hiver","Home"]), 4 },
                    { new Product("Pastelles secs", 24.99M, ["Art","Home","Work"]), 10},
                    { new Product("Bloc de feuilles 150mg", 12.99M, ["Art","Home","Work"]), 12},
                    { new Product("Casquette à hélices", 4.99M, ["Vêtement","Fashion","Fun"]), 0},
                    { new Product("Super dinosaure (peluche de 2.5m)", 199.99M, ["Home","Fun"]), 1},
                    { new Product("Monopoly Interface3", 19.99M, ["Home","Fun","Jeu"]), 1},
                    { new Product("Mastermind", 12.99M, ["Home","Fun","Jeu"]), 15}
                });

            foreach (Product p in shopping.Products)
            {
                Console.WriteLine($"- {p.Name} ({p.InventoryCode.ToString().Substring(0,8)}) {p.Price}€");
            }

            Console.WriteLine($"Quels produits voulez-vous garder?");
            string productName = Console.ReadLine();
            FilterCondition nameCondition = delegate (KeyValuePair<Product, int> stock)
            {
                return stock.Key.Name.ToLower().Contains( productName.ToLower() );
            };

            FilterCondition nameAndAvailableProductCondition = delegate (KeyValuePair<Product, int> stock)
            {
                return stock.Key.Name.ToLower().Contains(productName.ToLower()) && stock.Value > 0;
            };

            decimal minPrice = 0;
            decimal maxPrice = 10;

            FilterCondition priceCondition = delegate (KeyValuePair<Product, int> stock)
            {
                return stock.Key.Price >= minPrice && stock.Key.Price <= maxPrice;
            };

            Product[] filteredProducts = shopping.FilterProduct(nameAndAvailableProductCondition);
            foreach (Product p in filteredProducts)
            {
                Console.WriteLine($"- {p.Name} ({p.InventoryCode.ToString().Substring(0, 8)}) {p.Price}€");
            }

        }
    }
}
