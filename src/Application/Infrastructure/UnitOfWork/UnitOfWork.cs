using Domain.Contracts.Repositories;
using Domain.Contracts.UnitOfWork;
using Microsoft.Data.SqlClient;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private SqlConnection? _connection;
        private SqlTransaction? _transaction;
        private readonly IFactory factory;

        private IAccountRepository? _accountRepository;
        private IBillingRepository? _billingRepository;
        private ILoanRepository? _loanRepository;
        private ITransferRepository? _transferRepository;

        public UnitOfWork(string ConnectionString, IFactory factory)
        {
            _connection = new SqlConnection() { ConnectionString = ConnectionString };
            _connection.Open();
            _transaction = _connection.BeginTransaction();
            this.factory = factory;
        }

        public IAccountRepository AccountRepository => _accountRepository ??
            (_accountRepository = (IAccountRepository)factory.GetRepository(_transaction!, "account"));

        public IBillingRepository BillingRepository => _billingRepository ??
            (_billingRepository = (IBillingRepository)factory.GetRepository(_transaction!, "bill"));

        public ILoanRepository LoanRepository => _loanRepository
            ?? (_loanRepository = (ILoanRepository)factory.GetRepository(_transaction!, "loan"));

        public ITransferRepository TransferRepository => _transferRepository ??
            (_transferRepository = (ITransferRepository)factory.GetRepository(_transaction!, "transfer"));

        public int Commit()
        {
            try
            {
                _transaction!.Commit();

                return 1;
            }
            catch
            {
                _transaction!.Rollback();
            }
            finally
            {
                _transaction!.Dispose();
                _transaction = _connection!.BeginTransaction();
            }
            return 0;
        }

        // IDisposable & Finalize with GC (garbage collector)
        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}