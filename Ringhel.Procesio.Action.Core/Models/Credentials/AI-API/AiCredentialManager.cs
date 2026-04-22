using Ringhel.Procesio.Action.Core.Models.Credentials.API;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

public class AiCredentialManager
{
    public AiCredentialConfiguration CredentialConfig { get; set; }
    public IHttpClient Client { get; set; }
}
