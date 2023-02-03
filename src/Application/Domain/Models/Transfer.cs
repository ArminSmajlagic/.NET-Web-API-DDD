using Domain.Models.Common;

namespace Domain.Models
{
    internal class Transfer : BaseEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int FromAccountID { get; set; }
        public int ToAccountID { get; set; }
        public double Amount { get; set; }
    }
}