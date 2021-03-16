namespace Ringhel.Procesio.Action.Core.Models
{
    public interface IAuthorizationConfiguration
    {
        AuthorizationType Type { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        string ApiKey { get; set; }

        string ApiValue { get; set; }

        ClientApiKeyLocation ApiKeyLocation { get; set; }
    }
}
