namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

/// <summary>
/// Defines the strategy used by an AI provider to enforce structured (JSON schema) output.
/// </summary>
public enum StructuredOutputMode
{
    /// <summary>
    /// The model is forced to use tools with strict JSON schema validation enabled.
    /// This is the most constrained mode and ensures the output fully conforms to the defined schema.
    /// </summary>
    ToolsStrictForced = 0,

    /// <summary>
    /// The model is forced to use tools, but strict JSON schema validation is disabled.
    /// Use this for providers that support tool forcing but do not support strict schema enforcement.
    /// </summary>
    ToolsForcedNoStrict = 1,

    /// <summary>
    /// Tools are available and the model may use them, but it is not forced to do so.
    /// Structured output is not guaranteed.
    /// </summary>
    ToolsAllowedNotForced = 2,

    /// <summary>
    /// No tools are used. The model is instructed to return JSON directly in the response text.
    /// Use this for providers that do not support tool/function calling at all.
    /// </summary>
    NoToolsJsonInText = 3
}
