using System;

namespace AD0001.Publish.Example.Database.Dapper;

/// <summary>
///     Calculates delay retries.
/// </summary>
internal static class RetryDelayCalculator
{
    /// <summary>
    ///     Calculate the retry delay based on the current number of attempts
    /// </summary>
    /// <param name="attempts">The number of attempts</param>
    /// <returns>The time to wait before the next attempt</returns>
    public static TimeSpan Calculate(int attempts)
    {
        // do a fast first retry, then exponential backoff
        return TimeSpan.FromSeconds(attempts);
    }
}