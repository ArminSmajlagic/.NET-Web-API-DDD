using Domain.Repositories;
using Infrastructure.Caching.InMemory;
using Infrastructure.Repositories.Banking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //Redis Caching
            services.AddStackExchangeRedisCache(opts => { 
                opts.Configuration = configuration.GetSection("RedisCaching:ConnectionString").ToString();
                opts.InstanceName = "Banking";
            });

            // .NET Caching
            services.AddMemoryCache();

            // My primitive In-Memory data store for Caching
            services.AddTransient<AnotherInMemoryStore>();

            //Registering repositoires - use directly in DI or use UOW(transaction pattern) repository members 
            services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddTransient<IBillingRepository, BillingRepository>();
            services.AddScoped<ITransferRepository, TransferRepository>();
            services.AddSingleton<ILoanRepository, LoanRepository>();

            //Optional creation of repositories with Factory
            //services.AddSingleton<IFactory,RepositoryFactory>();

            // Azure MQ - TODO specify connection string

            //services.AddSingleton<IQueueClient>(opts => new QueueClient("",""));
            //services.AddSingleton<ISubscriptionClient>(opts => new SubscriptionClient("",""));

            return services;
        }
    }
}
