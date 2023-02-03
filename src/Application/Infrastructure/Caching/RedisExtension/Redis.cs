
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Infrastructure.Caching.RedisExtension
{
    public static class Redis
    {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache,
           string recordID,
           T data,
           TimeSpan? expireTime = null,
           TimeSpan? unusedExpireTime = null)
        {
            var options = new DistributedCacheEntryOptions();

            options.AbsoluteExpirationRelativeToNow = expireTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExpireTime ?? TimeSpan.FromSeconds(60);

            var jsonData = JsonSerializer.Serialize(data);

            await cache.SetStringAsync(recordID, jsonData);
        }

        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cache, string recordID)
        {
            var result = await cache.GetStringAsync(recordID);

            if (result == null)
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(result)!;
        }
    }
}
