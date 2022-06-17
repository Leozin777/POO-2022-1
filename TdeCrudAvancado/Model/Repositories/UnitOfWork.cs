using System;
using System.Threading.Tasks;

namespace TdeCrudAvancado.Model.Repositories
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }

        public async Task commit()
        {
            await _context.SaveChangesAsync();
        }

        private IClientRepository _clientRepository;
        public IClientRepository clientRepository
        {
            get{return _clientRepository ??= new ClientRepository(_context);}
        }
    }
}