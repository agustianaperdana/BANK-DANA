using Microsoft.EntityFrameworkCore;

namespace testapi.Models
{
    public class ContextNasabah:DbContext
    {
        public ContextNasabah(DbContextOptions<ContextNasabah> context) : base(context)
        {
        }
        public DbSet<MNasabah> Nasabahs { get; set; }
        public DbSet<MTest01> test01s { get; set; }
    }
}
