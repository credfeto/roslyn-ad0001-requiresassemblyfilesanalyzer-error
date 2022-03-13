using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AD0001.Publish.Example.Database.Interfaces.Builders;

namespace AD0001.Publish.Example.Database.Interfaces;

/// <summary>
///     SQL Server Database.
/// </summary>
public interface IDatabase
{
    /// <summary>
    ///     Execute a sql statement with parameters and return a single <typeparamref name="TResult" />,
    /// </summary>
    /// <typeparam name="TResult">The type to return</typeparam>
    /// <typeparam name="TSourceObject">The first type to map</typeparam>
    /// <param name="builder">The object builder that will convert from a <typeparamref name="TSourceObject" /> to a <typeparamref name="TResult" />.</param>
    /// <param name="storedProcedure">The sql to execute</param>
    /// <returns>The <typeparamref name="TResult" />.</returns>
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    Task<TResult> QuerySingleAsync<TSourceObject, TResult>(IObjectBuilder<TSourceObject, TResult> builder, string storedProcedure)
        where TSourceObject : class, new() where TResult : class;
}