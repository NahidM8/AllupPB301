using System.ComponentModel.DataAnnotations;

namespace AllupPB301.Models
{
    public class Setting:BaseEntity
    {
        [Required]
        public string Key { get; set; }
        [MaxLength(1000)]
        public string Value { get; set; }
    }
}
