using Domain.Models.Common;

namespace Domain.Models
{
    public class Account : BaseEntity, IAccount, IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        private void Billing(Bill bill)
        {
            // Send email notification to the user.
            // ...
        }
    }
}