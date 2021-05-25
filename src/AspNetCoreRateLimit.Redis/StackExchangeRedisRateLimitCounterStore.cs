using StackExchange.Redis;

namespace AspNetCoreRateLimit.Redis
{
    public class StackExchangeRedisRateLimitCounterStore : StackExchangeRedisRateLimitStore<RateLimitCounter?>, IRateLimitCounterStore
    {
        public StackExchangeRedisRateLimitCounterStore(IConnectionMultiplexer connectionMultiplexer)
            : base(connectionMultiplexer)
        {
        }
    }
}