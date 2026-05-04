using Newtonsoft.Json;

namespace Ringhel.Procesio.Action.Core.Models.AiDecisional;

/// <summary>
/// Output of the AI Decisional action. Wire shape matches the PROCESIO DataModel
/// registered for this action, hence the snake_case JSON property names.
/// </summary>
public class LLMResponse
{
    /// <summary>
    /// Parsed, normalized structured output extracted from the provider response —
    /// either the tool/function call arguments or the JSON parsed from the assistant text.
    /// Shape follows the <c>ai_decisional_evaluate</c> tool schema:
    /// <c>{ results: [{ case_id, is_true, confidence?, explanation? }] }</c>.
    /// </summary>
    [JsonProperty("structured_output")]
    public object StructuredOutput { get; set; }

    /// <summary>
    /// Full provider response payload (verbatim) for debugging or advanced extraction
    /// (e.g. token usage, model echo, finish reason).
    /// </summary>
    [JsonProperty("raw_provider_response")]
    public object RawProviderResponse { get; set; }
}
