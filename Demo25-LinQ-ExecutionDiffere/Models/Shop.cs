using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo25_LinQ_ExecutionDiffere.Models
{
    internal class Shop
    {
        private List<Product> _products;

        public Shop(List<Product> products)
        {
            _products = products;
        }

        public List<Product> FilterByPrice(decimal minPrice, decimal maxPrice)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in _products) { 
                if(product.Price >= minPrice && product.Price <= maxPrice) result.Add(product);
            }
            return result;
        }

        public IEnumerable<Product> FilterByPriceDefer(decimal minPrice, decimal maxPrice)
        {
            foreach (Product product in _products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice) yield return product;
            }
        }
    }
}
