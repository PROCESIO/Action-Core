namespace Ringhel.Procesio.Action.Core.Models
{
    public class AuthorizationConfiguration : IAuthorizationConfiguration
    {
        public AuthorizationType Type { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ApiKey { get; set; }

        public string ApiValue { get; set; }

        public ClientApiKeyLocation ApiKeyLocation { get; set; }
    }
}
