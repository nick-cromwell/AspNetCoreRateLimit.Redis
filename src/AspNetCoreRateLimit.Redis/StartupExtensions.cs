using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreRateLimit.Redis
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddStackExchangeRedisStores(this IServiceCollection services)
        {
            services.AddSingleton<IIpPolicyStore, StackExchangeRedisIpPolicyStore>();
            services.AddSingleton<IClientPolicyStore, StackExchangeRedisClientPolicyStore>();
            services.AddSingleton<IRateLimitCounterStore, StackExchangeRedisRateLimitCounterStore>();
            services.AddSingleton<IProcessingStrategy, StackExchangeRedisProcessingStrategy>();
            return services;
        }
    }
}