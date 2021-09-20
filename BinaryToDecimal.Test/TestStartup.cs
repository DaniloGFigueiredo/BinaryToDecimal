using BinaryToDecimal.Domain;
using BinaryToDecimal.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BinaryToDecimal.Test
{
    public sealed class TestStartup
    {
        //Forms of support:
        // ConfigureServices(IServiceCollection services)
        // ConfigureServices(IServiceCollection services, HostBuilderContext hostBuilderContext)
        // ConfigureServices(HostBuilderContext hostBuilderContext, IServiceCollection services)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBinaryToDecimalService, BinaryToDecimalService>();
        }
    }
}

