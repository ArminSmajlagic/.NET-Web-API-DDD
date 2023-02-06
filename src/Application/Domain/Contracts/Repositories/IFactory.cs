using Domain.Contracts.Common;
using Microsoft.Data.SqlClient;

namespace Domain.Contracts.Repositories
{
    public interface IFactory
    {
        IBaseRepository GetRepository(SqlTransaction transaction, string? repository = null);
    }
}