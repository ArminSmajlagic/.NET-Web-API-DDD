using Domain.Models;
using Domain.Models.Common;
using Domain.Repositories;
using System.Data;

namespace Infrastructure.Repositories.Banking
{
    public class TransferRepository : ITransferRepository
    {
        private readonly IDbTransaction transaction;

        public TransferRepository(IDbTransaction transaction)
        {
            this.transaction = transaction;
        }
        //TODO implement stadnard methodes
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transfer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transfer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Transfer entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Transfer entity)
        {
            throw new NotImplementedException();
        }
    }
}
