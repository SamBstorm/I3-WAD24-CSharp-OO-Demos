using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo16_Delegate03.Models
{
    public delegate bool FilterCondition(KeyValuePair<Product, int> stock);
    public class Shop
    {
        private Dictionary<Product, int> _products = new Dictionary<Product, int>();
        public Product[] Products
        {
            get { return _products.Keys.ToArray(); }
        }

        public Shop(Dictionary<Product, int> products)
        {
            _products = products;
        }

        public decimal Buy(Product product, int quantity)
        {
            if (!_products.ContainsKey(product)) throw new ArgumentOutOfRangeException(nameof(product), $"Ce produit n'est pas en vente.");
            if(_products[product] < quantity) throw new InvalidOperationException("Il n'y a plus assez en stock...");
            decimal total = product.Price * quantity;
            _products[product] -= quantity;
            return total;
        }

        public Product[] FilterProduct(string name)
        {
            List<Product> products = new List<Product>();
            foreach (Product product in Products) {
                if(product.Name.ToLower().Contains(name.ToLower())) 
                { 
                    products.Add(product); 
                }
            }
            return products.ToArray();
        }

        public Product[] FilterProductAvailable()
        {
            List<Product> products = new List<Product>();
            foreach (KeyValuePair<Product,int> stock in _products)
            {
                if (stock.Value > 0)
                {
                    products.Add(stock.Key);
                }
            }
            return products.ToArray();
        }

        public Product[] FilterProductByCategories(string category) {
            List<Product> products = new List<Product>();
            foreach (KeyValuePair<Product, int> stock in _products)
            {
                if (stock.Key.Categories.Contains(category))
                {
                    products.Add(stock.Key);
                }
            }
            return products.ToArray();
        }

        public Product[] FilterProductByPrice(decimal minPrice, decimal maxPrice)
        {
            List<Product> products = new List<Product>();
            foreach (KeyValuePair<Product, int> stock in _products)
            {
                if (stock.Key.Price >= minPrice && stock.Key.Price <= maxPrice)
                {
                    products.Add(stock.Key);
                }
            }
            return products.ToArray();
        }

        public Product[] FilterProduct(FilterCondition filter)
        {
            List<Product> products = new List<Product>();
            foreach (KeyValuePair<Product, int> stock in _products)
            {
                if (filter(stock))
                {
                    products.Add(stock.Key);
                }
            }
            return products.ToArray();
        }
    }
}
