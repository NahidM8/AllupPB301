using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace AllupPB301.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public bool IsMain { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
    }
}
