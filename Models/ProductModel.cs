namespace NPLubricants.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } 
        public string? PhotoUrl {  get; set; }
        public bool IsFeaturedProduct { get; set; }
        public bool IsPremiumProduct { get; set; }


    }
    public class ProductList
    {
        public List<ProductModel> GetProducts()
        {
            return new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Laptop", Description = "High performance laptop", PhotoUrl = "LAPTOP.jpg", IsFeaturedProduct = false,IsPremiumProduct = true },
            new ProductModel { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", PhotoUrl = "PHONE.jpg",IsFeaturedProduct = true },
            new ProductModel { Id = 3, Name = "Tablet", Description = "Portable tablet device", PhotoUrl = "TABLET.jpg",IsFeaturedProduct = true },
            new ProductModel { Id = 4, Name = "Headphones", Description = "Noise-cancelling headphones", PhotoUrl = "HEADPHONES.jpg",IsFeaturedProduct = false,IsPremiumProduct = true },
            new ProductModel { Id = 5, Name = "Smartwatch", Description = "Feature-packed smartwatch", PhotoUrl = "SMARTWATCH.jpg",IsFeaturedProduct = true },
            new ProductModel { Id = 6, Name = "Camera", Description = "DSLR camera with lens", PhotoUrl = "CAMERA.jpg" , IsFeaturedProduct = false},
            new ProductModel { Id = 7, Name = "Monitor", Description = "4K Ultra HD monitor", PhotoUrl = "MONITOR.jpg" , IsFeaturedProduct = false},
            new ProductModel { Id = 8, Name = "Keyboard", Description = "Mechanical keyboard", PhotoUrl = "KEYBOARD.jpg" , IsFeaturedProduct = true},
            new ProductModel { Id = 9, Name = "Mouse", Description = "Wireless ergonomic mouse", PhotoUrl = "MOUSE.jpg" , IsFeaturedProduct = false,IsPremiumProduct = true}
        };
        }
    }
}
