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

            _products.Add(new Product { ProductId = 1, Name = "Laptop", Price = 999.99m, Image = "laptop.png", IsActive = true, CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "Smartphone", Price = 499.99m, Image = "smartphone.png", IsActive = true, CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "Novel", Price = 19.99m, Image = "novel.png", IsActive = true, CategoryId = 2 });
            _products.Add(new Product { ProductId = 4, Name = "T-Shirt", Price = 14.99m, Image = "tshirt.png", IsActive = true, CategoryId = 3 });
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