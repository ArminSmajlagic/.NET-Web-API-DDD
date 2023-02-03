using Domain.Services.Contracts;
using Domain.Services.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Domain.Extension
{
    public static class Domain
    {
        public static IServiceCollection AddDomainDepndencies(this IServiceCollection services, IConfiguration configuration)
        {
            //Registering repositoires
            services.AddSingleton<IAccountService, AccountService>();
            services.AddTransient<IBillingService, BillingService>();
            services.AddScoped<ITransferService, TransferService>();
            services.AddSingleton<ILoanService, LoanService>();
            return services;
        }
    }
}
