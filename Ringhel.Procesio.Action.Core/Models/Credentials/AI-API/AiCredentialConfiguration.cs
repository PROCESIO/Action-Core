namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

/// <summary>
/// Holds the configuration required to connect to and interact with an AI API provider.
/// </summary>
public class AiCredentialConfiguration
{
    /// <summary>
    /// The base URL of the AI API provider (e.g., <c>https://api.openai.com</c>).
    /// </summary>
    public string BaseUrl { get; init; } = string.Empty;

    /// <summary>
    /// The API key used to authenticate requests to the AI provider.
    /// </summary>
    public string ApiKey { get; init; } = string.Empty;

    /// <summary>
    /// The name of the HTTP header used to transmit the authentication token.
    /// Defaults to <c>Authorization</c>.
    /// </summary>
    public string AuthHeaderName { get; init; } = "Authorization";

    /// <summary>
    /// The prefix prepended to the API key value in the authentication header (e.g., <c>Bearer </c>).
    /// Defaults to <c>Bearer </c>.
    /// </summary>
    public string AuthHeaderPrefix { get; init; } = "Bearer ";

    /// <summary>
    /// A set of additional HTTP headers to include with every request to the AI provider.
    /// </summary>
    public Dictionary<string, string> DefaultHeaders { get; init; } = [];

    /// <summary>
    /// A set of default query parameters to append to every request URL sent to the AI provider.
    /// </summary>
    public Dictionary<string, string> DefaultQueryParams { get; init; } = [];

    /// <summary>
    /// Defines how structured output (JSON schema enforcement) is handled for this AI provider.
    /// Defaults to <see cref="StructuredOutputMode.ToolsStrictForced"/>.
    /// </summary>
    public StructuredOutputMode StructuredOutputMode { get; init; } = StructuredOutputMode.ToolsStrictForced;

    /// <summary>
    /// Indicates whether the AI provider supports specifying a tool choice in requests.
    /// </summary>
    public bool SupportsToolChoice { get; init; } = true;

    /// <summary>
    /// Indicates whether the AI provider supports strict JSON schema validation for structured outputs.
    /// </summary>
    public bool SupportsStrictSchema { get; init; } = true;

    /// <summary>
    /// The name of the request parameter used to specify the maximum number of tokens in the response.
    /// Defaults to <c>max_completion_tokens</c>.
    /// </summary>
    public string MaxTokensParamName { get; init; } = "max_completion_tokens";

    /// <summary>
    /// The total context window size (in tokens) supported by the AI model, if known.
    /// </summary>
    public int? ContextWindowTokens { get; init; }

    /// <summary>
    /// The maximum recommended number of input tokens to send to the model, if known.
    /// Useful for guarding against context overflow.
    /// </summary>
    public int? MaxRecommendedInputTokens { get; init; }

    /// <summary>
    /// The relative endpoint path used to test connectivity to the AI provider.
    /// Defaults to <c>/v1/models</c>.
    /// </summary>
    public string TestEndpoint { get; init; } = "/v1/models";

    /// <summary>
    /// The HTTP method used when calling the <see cref="TestEndpoint"/>.
    /// Defaults to <c>GET</c>.
    /// </summary>
    public string HttpMethod { get; init; } = "GET";
}
