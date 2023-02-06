using Domain.Contracts.Repositories;
using Domain.Models;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories.Banking
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public SqlTransaction Transaction { get; set; }

        public AccountRepository(SqlTransaction transaction) : base(transaction)
        {
            this.Transaction = transaction;
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