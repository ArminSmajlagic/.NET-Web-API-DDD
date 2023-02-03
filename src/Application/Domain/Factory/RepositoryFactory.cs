using Domain.Repositories.Common;
using Infrastructure.Repositories.Banking;

namespace Infrastructure.RepoFactory
{
    public class RepositoryFactory
    {
        public static IBaseRepository GetRepository(string repository) {
            switch (repository)
            {
                case "account":
                    return new AccountRepository();
                case "billing":
                    return new BillingRepository();
                case "loan":
                    return new LoanRepository();
                case "transfer":
                    return new TransferRepository();
                default:
                    throw new ArgumentException("Invalid repository name.");
            }
        }
    }
}
