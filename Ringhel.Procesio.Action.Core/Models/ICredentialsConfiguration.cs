namespace Ringhel.Procesio.Action.Core.Models
{
    public interface ICredentialsConfiguration
    {
        string Schema { get; set; }

        string Path { get; set; }

        int PortNumber { get; set; }

        IAuthorizationConfiguration Authorization { get; set; }
    }
}
