using Domain.Models;
using Domain.Models.Common;
using Domain.Repositories;
using System.Data;

namespace Infrastructure.Repositories.Banking
{
    public class BillingRepository : IBillingRepository
    {
        //TODO implement stadnard methodes with mongoclient
        private readonly IDbTransaction transaction;

        public BillingRepository(IDbTransaction transaction)
        {
            this.transaction = transaction;
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
