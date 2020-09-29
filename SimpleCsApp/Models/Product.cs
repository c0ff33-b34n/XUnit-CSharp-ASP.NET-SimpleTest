namespace SimpleCsApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts() {

            Product runningShoes = new Product {
                Name = "Running Shoes", Price = 80M
            };
            
            Product dumbellSet = new Product {
                Name = "Dumbell Weight Set", Price = 38M
            };

            return new Product[] { runningShoes, dumbellSet };
        }
    }
}