namespace Ringhel.Procesio.Action.Core.Models.AiDecisional;

/// <summary>
/// Selects which OpenAI-compatible endpoint the AI Decisional action targets.
/// </summary>
public enum EndpointMode
{
    /// <summary>
    /// <c>POST {base_url}/chat/completions</c> — uses <c>messages[]</c> input shape and
    /// <c>max_completion_tokens</c> for the token cap parameter.
    /// </summary>
    ChatCompletions = 0,

    /// <summary>
    /// <c>POST {base_url}/responses</c> — uses <c>input[]</c> shape and
    /// <c>max_output_tokens</c> for the token cap parameter.
    /// </summary>
    Responses = 1
}
