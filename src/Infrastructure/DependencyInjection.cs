using System;
using Infrastructure.Interface;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
    {
        services.AddSingleton<IContractClientRepository, ContractClienteRepository>();

        return services;
    }
}
