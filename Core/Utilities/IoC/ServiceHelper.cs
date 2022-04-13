using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    public static class ServiceHelper
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection CreateInstance(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}