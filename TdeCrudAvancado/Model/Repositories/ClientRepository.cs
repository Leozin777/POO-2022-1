using Microsoft.EntityFrameworkCore;
using TdeCrudAvancado.Model.Domain;

namespace TdeCrudAvancado.Model.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DataContext context;
        public ClientRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Client t)
        {
            context.Add(t);
        }

        public bool Delete(int id)
        {
            var client = context.Clients.FirstOrDefault(x => x.Id == id);

            if(client == null)
                return false;
            else
            {
                context.Clients.Remove(client);
                return true;
            }
        }

        public async Task<List<Client>> getAll()
        {
            return await context.Clients.ToListAsync();
        }

        public async Task<Client> getById(int id)
        {
            return await context.Clients.SingleOrDefaultAsync(x => x.Id == id);
        }

        public void Update(Client t)
        {
            context.Entry(t).State = EntityState.Modified;
        }
    }
}