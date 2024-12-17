using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_Delegate03.Models
{
    public class Product
    {
        public Guid InventoryCode { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string[] Categories { get; private set; }

        public Product(string name, decimal price, string[] categories) {
            Name = name;
            Price = price;
            Categories = categories;
            InventoryCode = Guid.NewGuid();
        }
    }
}
