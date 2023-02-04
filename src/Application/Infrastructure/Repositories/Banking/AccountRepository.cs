using Domain.Models;
using Domain.Models.Common;
using Domain.Repositories;
using Domain.Repositories.Common;
using System.Data;

namespace Infrastructure.Repositories.Banking
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IDbTransaction transaction;

        public AccountRepository(IDbTransaction transaction)
        {
            this.transaction = transaction;
        }
        //TODO implement stadnard methodes
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            List<Account> accounts = new List<Account>();
            return accounts;
        }

        public Account GetByID(int id)
        {
            return new Account();
        }

        public int Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
