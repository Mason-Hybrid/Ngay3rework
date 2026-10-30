namespace Ngay3rework.Models
{
    public class Product
    {
        
        public int id { get; set; }
        
        public string? name { get; set; } = string.Empty;
        public decimal price { get; set; }

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
