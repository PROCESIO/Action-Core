namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

/// <summary>
/// Connection details of an "Azure Storage Account" credential, mapped from the credential template properties.
/// Held by <see cref="AzureStorageCredentialsManager"/> alongside the connected <see cref="IAzureStorageClient"/>.
/// </summary>
public class AzureStorageCredentialsConfiguration
{
    public AzureStorageAuthenticationType AuthenticationType { get; set; }
    public string AccountName { get; set; } = string.Empty;
    public string AccountKey { get; set; } = string.Empty;
    public string TenantId { get; set; } = string.Empty;
    public string ClientId { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
    public string BlobEndpoint { get; set; } = string.Empty;

    /// <summary>
    /// The blob service URL the client connects to: the public endpoint derived from the account name, unless a
    /// private or sovereign-cloud endpoint is configured. The only credential value meant for log and error
    /// messages; it never includes the account key or the client secret.
    /// </summary>
    public string Endpoint => string.IsNullOrWhiteSpace(BlobEndpoint)
        ? $"https://{AccountName}.blob.core.windows.net"
        : BlobEndpoint;
}
