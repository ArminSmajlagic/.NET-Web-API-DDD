using Domain.Contracts.Common;
using Infrastructure.Database;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories
{
    public abstract class BaseRepository : IBaseRepository
    {
        private readonly IDatabaseContext? databaseContext;

        public SqlTransaction transaction { get; set; }
        protected SqlConnection Connection
        { get { return transaction.Connection; } }

        public BaseRepository(SqlTransaction transaction)
        {
            this.transaction = transaction;
        }
    }
}