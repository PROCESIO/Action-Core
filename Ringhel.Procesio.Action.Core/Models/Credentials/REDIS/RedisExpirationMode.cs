namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// Selects between relative (EXPIRE) and absolute (EXPIREAT) key expiration.
/// </summary>
public enum RedisExpirationMode
{
    InSeconds,
    AtTimestamp
}
