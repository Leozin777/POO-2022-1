using CrudClient.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudClient.Models.Repositories
{
     public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

    public DbSet<Client> Client { get; set; }
        
    }
}