using Domain.Repositories;
using Infrastructure.Repositories.Banking;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;

        private SqlConnection _connection;
        private SqlTransaction _transaction;

        private IAccountRepository accountRepository;
        private IBillingRepository billingRepository;
        private ILoanRepository loanRepository;
        private ITransferRepository transferRepository;

        public UnitOfWork(string ConnectionString)
        {
            _connection = new SqlConnection() { ConnectionString = ConnectionString };
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IAccountRepository AccountRepository
        {
            get { return accountRepository ?? (accountRepository = new AccountRepository(_transaction)); }
        }

        public IBillingRepository BillingRepository
        {
            get { return billingRepository ?? (billingRepository = new BillingRepository(_transaction)); }
        }

        public ILoanRepository LoanRepository
        {
            get { return loanRepository ?? (loanRepository = new LoanRepository(_transaction)); }
        }

        public ITransferRepository TransferRepository
        {
            get { return transferRepository ?? (transferRepository = new TransferRepository(_transaction)); }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
            }
        }

        // IDisposable & Finalize with garbage cleaner
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
