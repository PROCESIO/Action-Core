namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

public class AiCredentialConfiguration
{
    public string BaseUrl { get; init; } = string.Empty;
    public string ApiKey { get; init; } = string.Empty;
    public string AuthHeaderName { get; init; } = "Authorization";
    public string AuthHeaderPrefix { get; init; } = "Bearer ";
    public Dictionary<string, string> DefaultHeaders { get; init; } = [];
    public Dictionary<string, string> DefaultQueryParams { get; init; } = [];
    public StructuredOutputMode StructuredOutputMode { get; init; } = StructuredOutputMode.ToolsStrictForced;
    public bool SupportsToolChoice { get; init; } = true;
    public bool SupportsStrictSchema { get; init; } = true;
    public string MaxTokensParamName { get; init; } = "max_completion_tokens";
    public int? ContextWindowTokens { get; init; }
    public int? MaxRecommendedInputTokens { get; init; }
    public string TestEndpoint { get; init; } = "/v1/models";
    public string HttpMethod { get; init; } = "GET";
}
