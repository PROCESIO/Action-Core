#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

public class AzureStorageBlobDetails
{
    public string Name { get; init; } = string.Empty;
    public string ContentType { get; init; } = string.Empty;
    public string ETag { get; init; } = string.Empty;
    public long Size { get; init; }
    public DateTimeOffset LastModified { get; init; }
    public IDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();
}
