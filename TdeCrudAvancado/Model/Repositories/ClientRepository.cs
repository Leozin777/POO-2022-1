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
            var client = context.Client.FirstOrDefault(x => x.Id == id);

            if(client == null)
                return false;
            else
            {
                context.Client.Remove(client);
                return true;
            }
        }

        public async Task<List<Client>> getAll()
        {
            return await context.Client.ToListAsync();
        }

        public async Task<Client> getById(int id)
        {
            return await context.Client.SingleOrDefaultAsync(x => x.Id == id);
        }

        public void Update(Client t)
        {
            context.Entry(t).State = EntityState.Modified;
        }
    }
}