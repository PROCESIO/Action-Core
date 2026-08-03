namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// Controls the conditional behaviour of the Set key operation (SET, SET NX, SET XX).
/// </summary>
public enum RedisSetMode
{
    Always,
    OnlyIfNotExists,
    OnlyIfExists
}
