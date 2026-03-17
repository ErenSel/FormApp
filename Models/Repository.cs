namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Electronics" });
            _categories.Add(new Category { CategoryId = 2, Name = "Books" });
            _categories.Add(new Category { CategoryId = 3, Name = "Clothing" });

            _products.Add(new Product { ProductId = 1, Name = "Macbook Air", Price = 999.99m, Image = "laptop.png", IsActive = true, CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "Iphone 17 Pro Max", Price = 899.99m, Image = "smartphone.png", IsActive = true, CategoryId = 1 });

            _products.Add(new Product { ProductId = 3, Name = "Novel", Price = 19.99m, Image = "novel.png", IsActive = true, CategoryId = 2 });
            _products.Add(new Product { ProductId = 4, Name = "T-Shirt", Price = 14.99m, Image = "tshirt.png", IsActive = true, CategoryId = 3 });
            _products.Add(new Product { ProductId = 5, Name = "Iphone 14 Pro", Price = 699.99m, Image = "1.jpg", IsActive = true, CategoryId = 1 });
            _products.Add(new Product { ProductId = 6, Name = "Iphone 13 Pro", Price = 599.99m, Image = "2.jpg", IsActive = true, CategoryId = 1 });


        }
        public static List<Product> Products
        {
            get
            {

                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {

                return _categories;
            }
        }

    }
}