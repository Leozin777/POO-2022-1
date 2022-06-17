using Microsoft.EntityFrameworkCore;
using TdeCrudAvancado.Model.Domain;
using TdeCrudAvancado.Types;

namespace TdeCrudAvancado.Model.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
                :base(opts)
            {}

        public DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
        }
    }
}