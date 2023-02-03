using Domain.Models;
using Domain.Models.Common;

namespace Domain.Repositories.Common
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        int Insert(T entity);

        int Update(T entity);

        int Delete(int id);
    }
}