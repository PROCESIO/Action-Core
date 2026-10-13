#nullable enable
namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

/// <summary>
/// The blob and container operations exposed to the Azure Storage connector. Every container and blob name
/// is sent as a typed argument and every operation returns the same <see cref="AzureStorageOperationResult"/>,
/// so the action never builds URLs or handles the storage SDK itself.
/// </summary>
public interface IAzureStorageClient
{
    #region Blob

    Task<AzureStorageOperationResult> UploadBlob(string container, string? prefix, FileModel file);
    Task<AzureStorageOperationResult> DownloadBlob(string container, string blobName);
    Task<AzureStorageOperationResult> BlobExists(string container, string blobName);
    Task<AzureStorageOperationResult> GetBlobProperties(string container, string blobName);
    Task<AzureStorageOperationResult> ListBlobs(string container, string? prefix, int maxResults);
    Task<AzureStorageOperationResult> DeleteBlob(string container, string blobName);
    Task<AzureStorageOperationResult> DeleteBlobsByNames(string container, IList<string> blobNames);
    Task<AzureStorageOperationResult> DeleteBlobsByPrefix(string container, string prefix);
    Task<AzureStorageOperationResult> CopyBlob(string container, string blobName, string destinationContainer, string destinationBlobName);
    Task<AzureStorageOperationResult> MoveBlob(string container, string blobName, string destinationContainer, string destinationBlobName);

    #endregion

    #region Container

    Task<AzureStorageOperationResult> CreateContainer(string container);
    Task<AzureStorageOperationResult> DeleteContainer(string container);
    Task<AzureStorageOperationResult> GetContainer(string container);
    Task<AzureStorageOperationResult> ListContainers(string? prefix, int maxResults);

    #endregion
}
