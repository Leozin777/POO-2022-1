using System.Collections.Generic;
using Aula11CrudPeople.Models.Domains;

namespace Aula11CrudPeople.Models.Repositories
{
    public interface IPersonRepository
    {
         Person GetById(int id);
         List<Person>GetAll();
         void Create(Person person);
         void Update(Person person);
         void Delete(int id);
    }
}