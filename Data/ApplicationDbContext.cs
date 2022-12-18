using SOE3MaterialVerwaltung.Models;
using System.Data.Entity;
using System.Reflection.Emit;

namespace SOE3MaterialVerwaltung.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
            this.Database.Connection.ConnectionString = @"Data Source=DESKTOP-VUM307Q\SQLEXPRESS;Initial Catalog=SOE3MaterialVerwaltung;Integrated Security=True";
        }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Materialgroup> Materialgroups { get; set; }
    }
}
