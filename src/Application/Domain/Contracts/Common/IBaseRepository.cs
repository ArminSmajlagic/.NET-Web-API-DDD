using Microsoft.Data.SqlClient;

namespace Domain.Contracts.Common
{
    public interface IBaseRepository
    {
        public SqlTransaction transaction { get; set; }
    }
}