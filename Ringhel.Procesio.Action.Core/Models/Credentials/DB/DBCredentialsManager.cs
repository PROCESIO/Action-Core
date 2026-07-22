namespace Ringhel.Procesio.Action.Core.Models.Credentials.DB;

public class DbCredentialsManager
{
    public DbCredentialsConfiguration CredentialsConfiguration { get; set; }

    public IDbClient Client { get; set; }
}
