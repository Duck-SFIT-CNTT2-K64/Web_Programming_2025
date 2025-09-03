namespace BHD_BTTL.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Name = "GoldSun GRC5000 Electric Rice Cooker",
                    Image = "/images/products/noi_com.webp",
                },
                new Product()
                {
                    Name = "GoldSun GRC5000 Electric Rice Cooker",
                    Image = "/images/products/noi_com.webp",
                },
                new Product()
                {
                    Name = "GoldSun GRC5000 Electric Rice Cooker",
                    Image = "/images/products/noi_com.webp",
                },
            };
            return products;
        }
    }
}
