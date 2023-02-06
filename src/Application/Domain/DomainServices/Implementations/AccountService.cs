using Domain.Contracts.Repositories;
using Domain.Contracts.UnitOfWork;
using Domain.DomainServices.Contracts;
using Domain.Models;

namespace Domain.DomainServices.Implementations
{
    public class AccountService : IAccountService
    {
        //One option is to use IFactory & create repositories directly

        //private readonly IAccountRepository _accountRepository;
        //private readonly IFactory factory;

        //public AccountService(IFactory factory)
        //{
        //    this.factory = factory;
        //    _accountRepository = (IAccountRepository)factory.GetRepository("account");
        //}

        //Other option is to use UnitOfWork with UnitOfWorkFactory
        public readonly IUnitOfWorkFactory unitOfWorkFactory;

        public IFactory repositoryFactory { get; }

        public AccountService(IUnitOfWorkFactory unitOfWorkFactory, IFactory repositoryFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
            this.repositoryFactory = repositoryFactory;
        }

        public IEnumerable<Account> GetAll()
        {
            using (var uow = unitOfWorkFactory.Create("", repositoryFactory))
            {
                return uow.AccountRepository.GetAll();
            }
        }

        public Account GetByID(int id)
        {
            using (var uow = unitOfWorkFactory.Create("", repositoryFactory))
            {
                return uow.AccountRepository.GetByID(id);
            }
        }

        public int Delete(int id)
        {
            using (var uow = unitOfWorkFactory.Create("", repositoryFactory))
            {
                uow.AccountRepository.Delete(id);

                return uow.Commit();
            }
        }

        public int Insert(Account entity)
        {
            using (var uow = unitOfWorkFactory.Create("", repositoryFactory))
            {
                uow.AccountRepository.Insert(entity);

                return uow.Commit();
            }
        }

        public int Update(Account entity)
        {
            using (var uow = unitOfWorkFactory.Create("", repositoryFactory))
            {
                uow.AccountRepository.Update(entity);

                return uow.Commit();
            }
        }
    }
}