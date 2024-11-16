using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Landly.Models
{
    public class Tb_Domains
    {
        [Key]
        public long? Id { get; set; }
        [DefaultValue(null)]
        public string? Name { get; set; } = null;
        public bool? IsActive { get; set; } = true;
    }
}
