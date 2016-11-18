namespace ProductApi.Models
{
    using System.Linq;

    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product {
                    ProductId = 1,
                    Name = "Unicorn",
                    Type = "Toy",
                    Description = "The Unicorn with the Horn",
                    Manufacturer = "Deadpool Toys Ltd.",
                    Model = "Pinkie",
                    NetPrice = 0.12,
                    GrossPrice = 39.99 ,
                    ImageUrl = "images/unicorn.jpg"
                },
                new Product {
                    ProductId = 2,
                    Name = "Soup",
                    Type = "Food",
                    Description = "String Soup",
                    Manufacturer = "Soup Dragon Foods.",
                    Model = "",
                    NetPrice = 1.00,
                    GrossPrice = 1.20 ,
                    ImageUrl = "images/soup.jpg"
                },
                new Product {
                    ProductId = 3,
                    Name = "Light Sabre",
                    Type = "Food",
                    Description = "Laser Sword",
                    Manufacturer = "Jedi Manufacturing Ltd.",
                    Model = "Blue",
                    NetPrice = 100.00,
                    GrossPrice = 250.00 ,
                    ImageUrl = "images/lightsabre.jpg"
                }
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }
    }
}
