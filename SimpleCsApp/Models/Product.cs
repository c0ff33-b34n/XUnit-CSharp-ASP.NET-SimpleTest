using System.Collections.Generic;

namespace SimpleCsApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }

    public class ProductDataSource : IDataSource {
        public IEnumerable<Product> Products =>
        new Product[] {
            new Product { Name = "Running Shoes", Price = 80M },
            new Product { Name = "Dumbell Weight Set", Price = 38M }
        };
    }
    
}