using Domain.Models;
using Domain.Models.Common;
using Domain.Repositories;
using Domain.Repositories.Common;
using Domain.Services.Contracts;
using Infrastructure.RepoFactory;

namespace Domain.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IFactory factory;

        public AccountService(IFactory factory) {
            this.factory = factory;
            _accountRepository = factory.GetRepository("account");
        }
        public int Delete(int id)
        {
            var result = _accountRepository.Delete(id);
            return result;
        }

        public IEnumerable<Account> GetAll()
        {
            var result = _accountRepository.GetAll();
            return result;
        }

        public Account GetByID(int id)
        {
            var result = _accountRepository.GetByID(id);
            return result;
        }

        public int Insert(Account entity)
        {
            var result = _accountRepository.Insert(entity);
            return result;
        }

        public int Update(Account entity)
        {
            var result = _accountRepository.Update(entity);
            return result;
        }
    }
}