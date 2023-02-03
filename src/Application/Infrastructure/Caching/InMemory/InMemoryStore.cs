﻿using Domain.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Infrastructure.Caching.InMemory
{
    public class InMemoryStore
    {
        private readonly IMemoryCache cache;

        public InMemoryStore(IMemoryCache cache) {
            this.cache = cache;
        }

        public async Task<List<Account>> GetAccountsCached() {
            List<Account> result;

            result = cache.Get<List<Account>>("Accounts");

            return result;
        }

        public async void AddAccounts(List<Account> accounts)
        {
            cache.Set("Accounts", accounts, TimeSpan.FromMinutes(5));
        }
    }
}
