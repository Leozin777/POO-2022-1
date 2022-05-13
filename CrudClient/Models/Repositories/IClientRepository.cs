using System.Collections.Generic;
using CrudClient.Models.Domain;

namespace CrudClient.Models.Repositories
{
    public interface IClientRepository
    {
        Client GetById(int id);
        List<Client>GetAll();
        void Create(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}