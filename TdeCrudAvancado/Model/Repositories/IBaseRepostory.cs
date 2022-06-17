namespace TdeCrudAvancado.Model.Repositories
{
    public interface IBaseRepostory<T>
    where T:class
    {
        T GetById(int id);
        Task<T>GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}