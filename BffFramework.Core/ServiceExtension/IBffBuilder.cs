using Microsoft.Extensions.DependencyInjection;

namespace BffFramework.Core.ServiceExtension;

/// <summary>
/// Provides a mechanism for configuring BFF services.
/// </summary>
public interface IBffBuilder
{
    /// <summary>
    /// Gets the <see cref="IServiceCollection"/> where BFF services are configured.
    /// </summary>
    IServiceCollection Services {get;}
}