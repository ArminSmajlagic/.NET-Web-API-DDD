using Domain.Contracts.Repositories;
using Domain.Models;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories.Banking
{
    public class LoanRepository : BaseRepository, ILoanRepository
    {
        public SqlTransaction Transaction { get; set; }

        public LoanRepository(SqlTransaction transaction) : base(transaction)
        {
            Transaction = transaction;
        }

        public IEnumerable<Loan> GetAll()
        {
            return new List<Loan>();
        }

        public Loan GetByID(int id)
        {
            return new Loan();
        }

        public int Insert(Loan entity)
        {
            SqlCommand? command = Connection.CreateCommand();
            command.Connection = Connection;
            command.Transaction = transaction;

            command.CommandText = "";
            var result = command.ExecuteNonQuery();

            //Commit of the query is being done at UOW but services have to
            //Transaction.Commit();

            return result;
        }

        public int Update(Loan entity)
        {
            SqlCommand? command = Connection.CreateCommand();
            command.Connection = Connection;
            command.Transaction = transaction;

            command.CommandText = "";
            var result = command.ExecuteNonQuery();

            //Commit of the query is being done at UOW and
            //Transaction.Commit();

            return result;
        }

        public int Delete(int id)
        {
            return 0;
        }
    }
}