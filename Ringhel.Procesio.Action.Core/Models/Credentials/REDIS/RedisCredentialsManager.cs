namespace Ringhel.Procesio.Action.Core.Models.Credentials.REDIS;

public class RedisCredentialsManager
{
    public RedisCredentialsConfiguration CredentialsConfiguration { get; set; }

    public IRedisClient Client { get; set; }
}
