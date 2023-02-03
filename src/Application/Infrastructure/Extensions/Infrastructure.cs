using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace Infrastructure.Extensions
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(opts => { 
                opts.Configuration = configuration.GetSection("RedisCaching:ConnectionString").ToString();
                opts.InstanceName = "Banking";
            });

            services.AddMemoryCache();

            services.AddSingleton<IQueueClient>(opts => new QueueClient("",""));
            services.AddSingleton<ISubscriptionClient>(opts => new SubscriptionClient("",""));

            //Register repositories

            return services;
        }

        public static async Task SetRecordAsync<T>(this IDistributedCache cache, 
            string recordID, 
            T data, 
            TimeSpan? expireTime = null, 
            TimeSpan? unusedExpireTime = null) {
            var options = new DistributedCacheEntryOptions();

            options.AbsoluteExpirationRelativeToNow = expireTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExpireTime?? TimeSpan.FromSeconds(60);

            var jsonData = JsonSerializer.Serialize(data);

            await cache.SetStringAsync(recordID, jsonData);
        }

        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cache,string recordID)
        {
            var result = await cache.GetStringAsync(recordID);

            if(result == null)
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(result)!;
        }
    }
}
