#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// Uniform shape returned by every <see cref="IRedisClient"/> operation so that the three action
/// outputs (Response, Found, AffectedCount) can be populated the same way for all operations.
/// </summary>
public sealed class RedisOperationResult
{
    /// <summary>Structured, operation-specific payload mapped to the Response output.</summary>
    public object? Response { get; init; }

    /// <summary>True when the targeted key, field or member existed, or when the operation applied.</summary>
    public bool Found { get; init; }

    /// <summary>Operation-specific count: deleted keys, new list length, increment result, TTL, subscriber count.</summary>
    public long? AffectedCount { get; init; }
}
