using System.Threading.Tasks;
namespace TdeCrudAvancado.Model.Repositories
{
    public interface IUnityOfWork
    {
        Task commit();

        IClientRepository clientRepository{get;}
    }
}