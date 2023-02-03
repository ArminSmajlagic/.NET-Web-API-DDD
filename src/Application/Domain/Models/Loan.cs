using Domain.Models.Common;

namespace Domain.Models
{
    public class Loan : BaseEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public DateTime nextPayment { get; set; }
        public int AccountID { get; set; }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public int TotalPayments { get; set; }
        public int FinishedPayments { get; set; }

        public int LeftPayments
        {
            get { return TotalPayments - FinishedPayments; }
            set { LeftPayments = value; }
        }

        private IAccount subscribedAccount { get; set; }

        private void NotifyUsers()
        {
            subscribedAccount.LoanNotification(this);
        }
    }
}