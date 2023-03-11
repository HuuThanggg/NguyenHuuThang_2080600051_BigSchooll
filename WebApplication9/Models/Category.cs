using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}