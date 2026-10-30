using System.ComponentModel.DataAnnotations;

namespace Ngay3rework.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Id is required")]
        public int id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string name { get; set; } = String.Empty;

        public List<Product>? Products { get; set; } 
    }
}
