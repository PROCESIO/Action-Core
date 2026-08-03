#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// The simplified Redis operations exposed to the Redis connector. Each operation opens, uses and
/// releases its Redis connection internally, so the action never manages the connection lifecycle.
/// Arbitrary Redis command execution is intentionally not supported: every key, field, member and
/// value is sent as a typed argument so user input can never be reinterpreted as a Redis command.
/// </summary>
public interface IRedisClient
{
    #region Key / String

    Task<RedisOperationResult> GetKey(string key);
    Task<RedisOperationResult> SetKey(string key, string? value, RedisSetMode mode, int? timeToLiveSeconds);
    Task<RedisOperationResult> DeleteKey(string key);
    Task<RedisOperationResult> KeyExists(string key);
    Task<RedisOperationResult> ScanKeys(string? pattern, int? pageSize, int? maxKeys, string? cursor);
    Task<RedisOperationResult> IncrementKey(string key, long amount);

    #endregion

    #region Expiration

    Task<RedisOperationResult> SetExpiration(string key, RedisExpirationMode mode, int? seconds, DateTime? expiresAt);
    Task<RedisOperationResult> GetTimeToLive(string key);
    Task<RedisOperationResult> PersistKey(string key);

    #endregion

    #region Hash

    Task<RedisOperationResult> HashSetFields(string key, string? fieldsJson);
    Task<RedisOperationResult> HashGet(string key, string? field);
    Task<RedisOperationResult> HashDeleteFields(string key, IList<string>? fields);

    #endregion

    #region List

    Task<RedisOperationResult> ListPush(string key, IList<string>? values, RedisListSide side);
    Task<RedisOperationResult> ListPop(string key, RedisListSide side, int? count);
    Task<RedisOperationResult> ListRange(string key, long start, long stop);

    #endregion

    #region Set / Sorted set

    Task<RedisOperationResult> CollectionAdd(string key, RedisCollectionType type, IList<string>? members, string? scoredMembersJson);
    Task<RedisOperationResult> CollectionMembers(string key, RedisCollectionType type, long start, long stop, RedisSortOrder order);
    Task<RedisOperationResult> CollectionRemove(string key, RedisCollectionType type, IList<string>? members);

    #endregion

    #region Pub/Sub

    Task<RedisOperationResult> Publish(string? channel, string? message);

    #endregion
}
