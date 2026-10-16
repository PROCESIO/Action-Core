using Ringhel.Procesio.Action.Core.Models.Credentials.API;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

public class AiCredentialsManager
{
    public AiCredentialsConfiguration CredentialConfig { get; set; }
    public IHttpClient Client { get; set; }
}
