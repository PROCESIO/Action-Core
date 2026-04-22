namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public class AiCredentialManager
{
    public AiCredentialConfiguration CredentialConfig { get; set; }
    public IHttpClient Client { get; set; }
}
