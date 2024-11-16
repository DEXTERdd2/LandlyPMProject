using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Landly.Models
{
    public class Tb_SubDomains
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("DomainsId")]
        public long? DomainId { get; set; }
        [ForeignKey("WhiteHat")]
        public long? WhiteHatId { get; set; }
        [ForeignKey("BlackHat")]
        public long? BlackHatId { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime Updated_At { get; set; } = DateTime.Now;
        //foreignkeys
        public virtual Tb_WhiteHat? WhiteHat { get; set; }
        public virtual Tb_BlackHat? BlackHat { get; set; }
        public virtual Tb_Domains? DomainsId { get; set; }
    }
}
