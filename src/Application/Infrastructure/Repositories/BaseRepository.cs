using Microsoft.Data.SqlClient;
using System.Data;


namespace Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected SqlTransaction Transaction { get; private set; }
        protected SqlConnection Connection { get { return Transaction.Connection; } }
        public BaseRepository(SqlTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
