namespace AMST4.Carousel.MVC.Models
{
    public class Product
    {
        internal readonly object Category;

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
