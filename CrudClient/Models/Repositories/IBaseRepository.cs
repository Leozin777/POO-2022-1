namespace CrudClient.Models.Repositories
{
    public interface IBaseRepository<T>
    where T : class
    {
        T GetById(int id);
        List<T>GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}