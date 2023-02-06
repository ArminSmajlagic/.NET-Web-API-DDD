using Domain.Contracts.Common;
using Domain.Models;

namespace Domain.Contracts.Repositories
{
    public interface IAccountRepository : IBaseRepository
    {
        IEnumerable<Account> GetAll();

        Account GetByID(int id);

        int Insert(Account entity);

        int Update(Account entity);

        int Delete(int id);
    }
}