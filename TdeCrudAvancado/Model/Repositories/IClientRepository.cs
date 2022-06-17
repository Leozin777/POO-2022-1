using TdeCrudAvancado.Model.Domain;

namespace TdeCrudAvancado.Model.Repositories
{
    public interface IClientRepository
    {
        Task<Client> getById(int id);
        Task<List<Client>> getAll();
        void Create(Client t);
        bool Delete(int t);
        void Update(Client t);
    }
}