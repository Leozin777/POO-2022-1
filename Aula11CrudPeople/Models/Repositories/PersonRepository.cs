using System.Collections.Generic;
using System.Linq;
using Aula11CrudPeople.Models.Domains;

namespace Aula11CrudPeople.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Person person)
        {
            context.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return context.People.ToList();
        }

        public Person GetById(int id)
        {
            return context.People.SingleOrDefault(i=>i.Id == id);
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}