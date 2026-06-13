using Microsoft.Extensions.DependencyInjection;

namespace BffFramework.Core.ServiceExtension;

public static class BffServiceCollectionExtension
{
    public static IBffBuilder AddBff(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        return new BffBuilder(services);
    }

    public static IBffBuilder AddMockFeature(this IBffBuilder builder)
    {
        return builder;
    }
}