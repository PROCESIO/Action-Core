namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public class APICredentialsConfiguration
{
    public string Schema { get; set; }

    public string Host { get; set; }

    public string Path { get; set; }

    public int Port { get; set; }

    public AuthorizationConfiguration Authorization { get; set; }
}
