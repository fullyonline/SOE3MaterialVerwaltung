using SOE3MaterialVerwaltung.Models;
using System.Data.Entity;

namespace SOE3MaterialVerwaltung.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Materialgroup> Materialgroups { get; set; }
    }
}
