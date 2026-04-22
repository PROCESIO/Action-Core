namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public class AiCredentialsManager
{
    public AiCredentialsConfiguration CredentialConfig { get; set; }
    public IHttpClient Client { get; set; }
}
