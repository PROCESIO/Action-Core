#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

public class AzureStorageContainerDetails
{
    public string Name { get; init; } = string.Empty;
    public string ETag { get; init; } = string.Empty;
    public DateTimeOffset LastModified { get; init; }
    public IDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    /// <summary>Anonymous read level of the container (blob or container), or null when the container is private.</summary>
    public string? PublicAccess { get; init; }
}
