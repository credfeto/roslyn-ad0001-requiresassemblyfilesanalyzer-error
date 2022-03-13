using AD0001.Publish.Example.Database.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AD0001.Publish.Example.Database.Pgsql;

/// <summary>
///     Configures Postgresql DB
/// </summary>
public static class PostgresqlSetup
{
    /// <summary>
    ///     Configures Postgresql DB.
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddPostgresql(this IServiceCollection services)
    {
        return services.AddSingleton<IDatabase, PgsqlDatabase>();
    }
}