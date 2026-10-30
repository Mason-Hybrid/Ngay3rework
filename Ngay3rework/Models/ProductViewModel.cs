namespace Ngay3rework.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }
        public string? name { get; set; } = string.Empty;
        public decimal price { get; set; }
        public string Description { get; set; } = string.Empty;
        
        public string CategoryName { get; set; } 
    }
}
