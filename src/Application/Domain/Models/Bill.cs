using Domain.Models.Common;

namespace Domain.Models
{
    public class Bill : BaseEntity
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public DateTime date { get; set; }
        public double Amount { get; set; }
        public bool Cleared { get; set; }
        public bool Late { get; set; }

        // Observer Design pattern
        private IAccount subscribedAccount { get; set; }

        private void NotifyUsers()
        {
            subscribedAccount.BillingNotification(this);
        }
    }
}