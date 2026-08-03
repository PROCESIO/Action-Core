namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// Selects between plain sets (SADD/SMEMBERS/SREM) and sorted sets (ZADD/ZRANGE/ZREM).
/// </summary>
public enum RedisCollectionType
{
    Set,
    SortedSet
}
