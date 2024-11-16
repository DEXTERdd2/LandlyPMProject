using System.ComponentModel.DataAnnotations;

namespace Landly.Models
{
    public class Tb_Users
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
    }
}
