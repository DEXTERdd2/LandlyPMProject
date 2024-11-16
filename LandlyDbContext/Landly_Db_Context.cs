using Landly.Models;
using Microsoft.EntityFrameworkCore;

namespace Landly.LandlyDbContext
{
    public partial class Landly_Db_Context : DbContext
    {
        public Landly_Db_Context()
        {
        }

        public Landly_Db_Context(DbContextOptions<Landly_Db_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Tb_Users> Tb_Users { get; set; } = null!;
        public virtual DbSet<Tb_BlackHat> Tb_BlackHat { get; set; } = null!;
        public virtual DbSet<Tb_WhiteHat> Tb_WhiteHat { get; set; } = null!;
        public virtual DbSet<Tb_Domains> Tb_Domains { get; set; } = null!;
        public virtual DbSet<Tb_SubDomains> Tb_SubDomains { get; set; } = null!;
    }
}
