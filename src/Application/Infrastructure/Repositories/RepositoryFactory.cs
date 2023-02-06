using Domain.Contracts.Common;
using Domain.Contracts.Repositories;
using Infrastructure.Repositories.Banking;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories
{
    //Example of Factory design pattern for repository creation
    public class RepositoryFactory : IFactory
    {
        public IBaseRepository GetRepository(SqlTransaction transaction, string? repository)
        {
            switch (repository)
            {
                case "account":
                    return new AccountRepository(transaction);

                case "billing":
                    return new BillingRepository(transaction);

                case "loan":
                    return new LoanRepository(transaction);

                case "transfer":
                    return new TransferRepository(transaction);

                default:
                    throw new ArgumentException("Invalid repository name.");
            }
        }

    }
}