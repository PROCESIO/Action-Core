#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

/// <summary>
/// Uniform shape returned by every <see cref="IAzureStorageClient"/> operation so that the five action
/// outputs (Result, UploadedBlobName, OutputFile, Names, Details) can be populated the same way for all operations.
/// </summary>
public sealed class AzureStorageOperationResult
{
    /// <summary>True when the operation applied, or when the targeted blob or container exists.</summary>
    public bool Result { get; init; }

    /// <summary>Full name of the blob written by the upload operation, including the prefix.</summary>
    public string? UploadedBlobName { get; init; }

    /// <summary>Content of the downloaded blob.</summary>
    public FileModel? OutputFile { get; init; }

    /// <summary>Blob or container names returned by the list and bulk delete operations.</summary>
    public IList<string>? Names { get; init; }

    /// <summary>Structured, operation-specific payload such as <see cref="AzureStorageBlobDetails"/> or <see cref="AzureStorageContainerDetails"/>.</summary>
    public object? Details { get; init; }
}
