using System.Diagnostics;

namespace AD0001.Publish.Example.Database.Pgsql;

/// <summary>
///     Configuration for creating Postgresql connections.
/// </summary>
[DebuggerDisplay("{ConnectionString}")]
public sealed class PgsqlServerConfiguration
{
    /// <summary>
    ///     Gets the connection string.
    /// </summary>
    public string ConnectionString { get; init; } = default!;
}