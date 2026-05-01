using Domain.Abstractions.Repositories;
using Domain.Abstractions.Repositories.Members;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.Repositories.Members;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Extensions.Persistence;

public static class RepositoryRegistrationExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
    {
        services.AddScoped<IMemberRepository, MemberRepository>();
        
        services.AddScoped<IMembershipRepository, MembershipRepository>();

        return services;
    }

}
