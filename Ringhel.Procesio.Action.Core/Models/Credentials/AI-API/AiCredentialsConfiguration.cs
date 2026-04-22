namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

/// <summary>
/// Holds the configuration required to connect to and interact with an AI API provider.
/// </summary>
public class AiCredentialsConfiguration
{
    /// <summary>
    /// The base URL of the AI API provider (e.g., <c>https://api.openai.com</c>).
    /// </summary>
    public string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    /// The API key used to authenticate requests to the AI provider.
    /// </summary>
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// The name of the HTTP header used to transmit the authentication token.
    /// Defaults to <c>Authorization</c>.
    /// </summary>
    public string AuthHeaderName { get; set; } = "Authorization";

    /// <summary>
    /// The prefix prepended to the API key value in the authentication header (e.g., <c>Bearer </c>).
    /// Defaults to <c>Bearer </c>.
    /// </summary>
    public string AuthHeaderPrefix { get; set; } = "Bearer ";

    /// <summary>
    /// A set of additional HTTP headers to include with every request to the AI provider.
    /// </summary>
    public Dictionary<string, string> DefaultHeaders { get; set; } = [];

    /// <summary>
    /// A set of default query parameters to append to every request URL sent to the AI provider.
    /// </summary>
    public Dictionary<string, string> DefaultQueryParams { get; set; } = [];

    /// <summary>
    /// Defines how structured output (JSON schema enforcement) is handled for this AI provider.
    /// Defaults to <see cref="StructuredOutputMode.ToolsStrictForced"/>.
    /// </summary>
    public StructuredOutputMode StructuredOutputMode { get; set; } = StructuredOutputMode.ToolsStrictForced;

    /// <summary>
    /// Indicates whether the AI provider supports specifying a tool choice in requests.
    /// </summary>
    public bool SupportsToolChoice { get; set; } = true;

    /// <summary>
    /// Indicates whether the AI provider supports strict JSON schema validation for structured outputs.
    /// </summary>
    public bool SupportsStrictSchema { get; set; } = true;

    /// <summary>
    /// The name of the request parameter used to specify the maximum number of tokens in the response.
    /// Defaults to <c>max_completion_tokens</c>.
    /// </summary>
    public string MaxTokensParamName { get; set; } = "max_completion_tokens";

    /// <summary>
    /// The total context window size (in tokens) supported by the AI model, if known.
    /// </summary>
    public int? ContextWindowTokens { get; set; }

    /// <summary>
    /// The maximum recommended number of input tokens to send to the model, if known.
    /// Useful for guarding against context overflow.
    /// </summary>
    public int? MaxRecommendedInputTokens { get; set; }

    /// <summary>
    /// The relative endpoint path used to test connectivity to the AI provider.
    /// Defaults to <c>/v1/models</c>.
    /// </summary>
    public string TestEndpoint { get; set; } = "/v1/models";

    /// <summary>
    /// The HTTP method used when calling the <see cref="TestEndpoint"/>.
    /// Defaults to <c>GET</c>.
    /// </summary>
    public string HttpMethod { get; set; } = "GET";
}
