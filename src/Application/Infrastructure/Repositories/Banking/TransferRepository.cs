using Domain.Contracts.Repositories;
using Domain.Models;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories.Banking
{
    public class TransferRepository : BaseRepository, ITransferRepository
    {
        public SqlTransaction Transaction { get; set; }

        public TransferRepository(SqlTransaction transaction) : base(transaction)
        {
            this.Transaction = transaction;
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