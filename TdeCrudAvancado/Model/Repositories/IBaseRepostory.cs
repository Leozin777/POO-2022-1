using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeCrudAvancado.Model.Repositories
{
    public interface IBaseRepostory<T>
    where T:class
    {
        T GetById(int id);
        List<T>GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}