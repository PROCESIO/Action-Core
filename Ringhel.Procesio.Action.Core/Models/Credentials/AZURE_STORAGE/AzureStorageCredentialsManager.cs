namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

public class AzureStorageCredentialsManager
{
    public AzureStorageCredentialsConfiguration CredentialsConfiguration { get; set; }

    public IAzureStorageClient Client { get; set; }
}
