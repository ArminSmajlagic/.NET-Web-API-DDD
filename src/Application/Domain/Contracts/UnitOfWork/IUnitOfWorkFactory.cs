using Domain.Contracts.Repositories;

namespace Domain.Contracts.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create(string connectionString, IFactory factory);
    }
}