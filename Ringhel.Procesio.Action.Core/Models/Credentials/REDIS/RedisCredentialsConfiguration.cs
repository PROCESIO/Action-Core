namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

/// <summary>
/// Connection details of a "Redis" credential, mapped from the credential template properties.
/// Held by <see cref="RedisCredentialsManager"/> alongside the connected <see cref="IRedisClient"/>.
/// </summary>
public class RedisCredentialsConfiguration
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Database { get; set; }
    public bool UseTls { get; set; }
    public bool ValidateCertificate { get; set; }
    public int ConnectTimeoutSeconds { get; set; }
    public int CommandTimeoutSeconds { get; set; }

    /// <summary>Safe host:port label for log and error messages. Never includes the password.</summary>
    public string Endpoint => $"{Host}:{Port}";
}
