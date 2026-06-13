using Microsoft.Extensions.DependencyInjection;

namespace BffFramework.Core.ServiceExtension;

internal class BffBuilder: IBffBuilder
{
    public IServiceCollection Services {get;}

    public BffBuilder(IServiceCollection services)
    {
        Services = services ?? throw new ArgumentNullException(nameof(services));
    }
} 