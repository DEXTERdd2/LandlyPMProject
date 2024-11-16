using System.ComponentModel.DataAnnotations;

namespace Landly.Models
{
    public class Tb_BlackHat
    {
        [Key]
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Created_At { get; set; } = DateTime.Now;
        public DateTime? Updated_At { get;set; } = DateTime.Now;
    }
}
