using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.Extension
{
    public static class Application
    {
        public static IServiceCollection AddApplicationDepndencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}