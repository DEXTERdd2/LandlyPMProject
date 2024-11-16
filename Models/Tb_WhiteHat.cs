using System.ComponentModel.DataAnnotations;

namespace Landly.Models
{
    public partial class Tb_WhiteHat
    {
        [Key]
        public long? Id { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Created_At { get; set; } = DateTime.Now;
        public DateTime? Updated_At { get;set; } = DateTime.Now;
        public string? Path { get; set; }
    }
}
