using Microsoft.EntityFrameworkCore;
using TdeCrudAvancado.Model.Domain;

namespace TdeCrudAvancado.Model.Repositories
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

    public DbSet<Client> Client { get; set; }
    }
}