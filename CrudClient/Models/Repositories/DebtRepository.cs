using CrudClient.Models.Domain;

namespace CrudClient.Models.Repositories
{
    public class DebtRepository : IDebtRepository
    {
        private DataContext context;

        public void Create(Debt t)
        {
            t.Client = context.Client.SingleOrDefault(x=>x.Id == t.Client.Id);
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Debt> GetAll()
        {
            return context.Debts.Include(c=>c.Client).Include(p=>p.Client.Debt).ToList();
            
        }

        public Debt GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Debt t)
        {
            throw new NotImplementedException();
        }
    }
}