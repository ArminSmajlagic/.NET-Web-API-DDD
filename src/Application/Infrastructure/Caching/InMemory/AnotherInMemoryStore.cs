using Domain.Models;

namespace Infrastructure.Caching.InMemory
{
    public class AnotherInMemoryStore
    {
        private List<Account>? accounts;

        public AnotherInMemoryStore(List<Account>? accounts = null)
        {
            if (accounts == null)
                accounts = new List<Account>();
            else
                this.accounts = accounts;
        }

        public void Add(Account account)
        {
            accounts!.Add(account);
        }

        public void Remove(int id)
        {
            accounts!.Remove(accounts!.Where(x => x.Id == id).First());
        }
    }
}