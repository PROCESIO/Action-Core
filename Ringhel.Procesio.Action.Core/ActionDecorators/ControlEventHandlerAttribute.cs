using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Marks a method to be executed at design time when a specific control's value changes.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ControlEventHandlerAttribute : Attribute
{
    /// <summary>
    /// The type of event associated with this method execution.
    /// </summary>
    public ControlEventType EventType { get; set; } = ControlEventType.OnChange;

    /// <summary>
    /// The property name whose value change triggers this method.
    /// </summary>
    public string TriggerControl { get; set; } = string.Empty;

    /// <summary>
    /// Array of input property names that the method depends on.
    /// Their values will be populated before execution.
    /// </summary>
    public string[] InputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Array of output property names that will receive results produced by the method.
    /// </summary>
    public string[] OutputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Declares the semantic type of UI update produced.
    /// This guides the front end in choosing the correct refresh strategy.
    /// </summary>
    public OutputTarget OutputTarget { get; set; } = OutputTarget.None;

    /// <summary>
    /// Optional description of the handler's purpose.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Optional execution ordering. Lower values run earlier. Defaults to 0.
    /// Recommended when multiple handlers share the same <see cref="TriggerControl"/>.
    /// </summary>
    public int Order { get; set; } = 0;
}
