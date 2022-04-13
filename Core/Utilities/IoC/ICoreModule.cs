using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection services);
    }
}