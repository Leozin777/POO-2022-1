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
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            return context.Client.ToList();
        }

        public Client GetById(int id)
        {
            return context.Client.SingleOrDefault(i => i.Id == id);
        }

        public void Update(Client t)
        {
            throw new NotImplementedException();
        }
    }
}