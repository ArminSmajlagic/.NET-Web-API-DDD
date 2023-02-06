using Domain.Contracts.Repositories;
using Domain.Models;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories.Banking
{
    public class BillingRepository : BaseRepository, IBillingRepository
    {
        //TODO implement stadnard methodes with mongoclient
        public SqlTransaction Transaction { get; set; }

        public BillingRepository(SqlTransaction transaction) : base(transaction)
        {
            Transaction = transaction;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bill> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bill GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Bill entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Bill entity)
        {
            throw new NotImplementedException();
        }
    }
}