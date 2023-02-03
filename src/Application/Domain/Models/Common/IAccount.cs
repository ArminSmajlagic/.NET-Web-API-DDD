namespace Domain.Models.Common
{
    public interface IAccount
    {
        //default interface
        void BillingNotification(Bill bill)
        {
            Console.WriteLine("Not implemented BillingNotification");
            throw new NotImplementedException();
        }

        void LoanNotification(Loan bill)
        {
            Console.WriteLine("Not implemented LoanNotification");
            throw new NotImplementedException();
        }
    }
}