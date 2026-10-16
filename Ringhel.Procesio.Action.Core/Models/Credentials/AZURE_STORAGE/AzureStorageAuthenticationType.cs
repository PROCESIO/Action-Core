namespace Ringhel.Procesio.Action.Core.Models.Credentials.AZURE_STORAGE;

/// <summary>
/// Selects how the storage account is authenticated: with its account key, or with a Microsoft Entra
/// service principal (tenant, client id and client secret).
/// </summary>
public enum AzureStorageAuthenticationType
{
    SharedKey = 0,
    ServicePrincipal = 1
}
