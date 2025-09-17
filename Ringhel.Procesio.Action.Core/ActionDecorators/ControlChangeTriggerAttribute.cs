namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute used to mark methods that should be executed at design time
/// when specific control values change
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ControlChangeTriggerAttribute : Attribute
{
    /// <summary>
    /// The property name that triggers this method when its value changes.
    /// </summary>
    public string TriggerControl { get; set; } = string.Empty;

    /// <summary>
    /// Array of input property names that are used inside the method.
    /// The input values will be passed for these properties before method execution.
    /// </summary>
    public string[] InputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Array of output property names that will receive results from method execution.
    /// </summary>
    public string[] OutputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// The output property name that will be triggered when this method finishes execution.
    /// </summary>
    public string NextControl { get; set; } = string.Empty;

    /// <summary>
    /// Optional description of what this handler does.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Optional execution order (lower runs earlier). Defaults to 0.
    /// When multiple methods share the same TriggerControl, execution considers Order value.
    /// </summary>
    public int Order { get; set; } = 0;
}
