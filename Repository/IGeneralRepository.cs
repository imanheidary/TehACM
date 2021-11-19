using Repository.VM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IGeneralRepository<T> where T : class
    {
        Task<ResultMessageVM> Add(T entity);
        Task<ResultMessageVM> Update(T entity);
        Task<ResultMessageVM> Delete(T entity);
        Task<T> GetSingle(int Id);
        Task<List<T>> GetAll();
    }
}
