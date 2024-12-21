using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanQuanAo.Models
{
    public class Product 
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string slug { get; set; }

        [Required]
        public string description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public Brand brand { get; set; }

        public string? fileNameImg { get; set; }

        [NotMapped]
        [FileExtensions]
        public IFormFile ImageUpload { get; set; }

    }
}
