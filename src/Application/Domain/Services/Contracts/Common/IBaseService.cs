using Domain.Models.Common;

namespace Domain.Services.Contracts.Common
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        int Insert(T entity);

        int Update(T entity);

        int Delete(int id);
    }
}