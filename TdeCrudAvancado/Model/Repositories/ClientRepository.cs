using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client t)
        {
            throw new NotImplementedException();
        }
    }
}