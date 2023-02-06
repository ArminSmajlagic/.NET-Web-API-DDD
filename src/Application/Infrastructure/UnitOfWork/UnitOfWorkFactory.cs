using Domain.Contracts.Repositories;
using Domain.Contracts.UnitOfWork;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create(string connectionString, IFactory factory)
        {
            return new UnitOfWork(connectionString, factory);
        }
    }
}