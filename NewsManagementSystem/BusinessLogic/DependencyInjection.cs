﻿using System.Reflection;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Interface;
using Repositories.Repositories;

namespace BusinessLogic;

public static class DependencyInjection
{

    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepository();
        services.AddAutoMapper();
        services.AddServices(configuration);
    }

    public static void AddRepository(this IServiceCollection services)
    {
        services
            .AddScoped<IUOW, UOW>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

    }

    private static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }

    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISystemAccountService, SystemAccountService>();

    }
}