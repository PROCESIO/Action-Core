namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public class APICredentialsManager
{
    public APICredentialsConfiguration CredentialConfig { get; set; }

    public IHttpClient Client { get; set; }

    /// <summary>
    /// Point this credential at another host before issuing requests. Updates <see cref="CredentialConfig"/>
    /// (scheme, host, port and base path) and the <see cref="Client"/> together so the two never disagree.
    /// The authorization follows the credential to the new host: the token, API key or basic authentication
    /// is sent to whatever host is set here, so only point a credential at hosts that may see it.
    /// A trailing slash on the URL is dropped. Call it again to switch host; the stored credential is not changed.
    /// When the manager was built without a credential, a configuration is created from the URL.
    /// </summary>
    /// <param name="baseUrl">An absolute http or https URL.</param>
    /// <exception cref="ArgumentException">The URL is null, empty, relative or not http or https.</exception>
    public void SetBaseUrl(string baseUrl)
    {
        var trimmedBaseUrl = TrimTrailingSlash(baseUrl);
        if (!Uri.TryCreate(trimmedBaseUrl, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            throw new ArgumentException("The base URL must be an absolute http or https URL.", nameof(baseUrl));
        }

        CredentialConfig ??= new APICredentialsConfiguration
        {
            Authorization = new AuthorizationConfiguration { Type = AuthorizationType.NoAuth }
        };

        CredentialConfig.Schema = uri.Scheme;
        CredentialConfig.Host = uri.Host;
        CredentialConfig.Port = uri.Port;
        CredentialConfig.Path = uri.AbsolutePath;

        Client?.SetBaseUrl(trimmedBaseUrl);
    }

    private static string TrimTrailingSlash(string url)
    {
        var trimmed = url?.Trim();
        return trimmed is { Length: > 1 } && trimmed.EndsWith('/')
            ? trimmed.Substring(0, trimmed.Length - 1)
            : trimmed;
    }
}
