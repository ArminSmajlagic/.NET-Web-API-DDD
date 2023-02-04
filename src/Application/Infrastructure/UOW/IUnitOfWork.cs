using Domain.Repositories;

namespace Domain.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository AccountRepository { get; }
        IBillingRepository BillingRepository { get; }
        ILoanRepository LoanRepository { get; }
        ITransferRepository TransferRepository { get; }

        void Commit();

    }
}