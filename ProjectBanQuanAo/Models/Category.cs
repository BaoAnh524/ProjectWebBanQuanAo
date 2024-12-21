using System.ComponentModel.DataAnnotations;

namespace ProjectBanQuanAo.Models
{
    public class Category 
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        public string slug { get; set; }
        [Required]
        public string description { get; set; }
        public string status { get; set; }


    }
}
