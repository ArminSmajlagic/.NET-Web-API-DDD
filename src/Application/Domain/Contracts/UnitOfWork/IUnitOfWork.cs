using Domain.Contracts.Repositories;

namespace Domain.Contracts.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository AccountRepository { get; }
        IBillingRepository BillingRepository { get; }
        ILoanRepository LoanRepository { get; }
        ITransferRepository TransferRepository { get; }

        int Commit();
    }
}