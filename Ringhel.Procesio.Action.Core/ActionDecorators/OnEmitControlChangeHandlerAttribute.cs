namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute used to mark methods that should be executed at design time
/// when specific control values change
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class OnEmitControlChangeHandlerAttribute : Attribute
{
    /// <summary>
    /// The control property name that triggers this method when its value changes
    /// </summary>
    public string TriggerControl { get; set; } = string.Empty;

    /// <summary>
    /// Array of input control property names that are used inside the method
    /// These values will be passed to the method when it's executed
    /// </summary>
    public string[] InputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Array of target output control property names that will receive results
    /// </summary>
    public string[] OutputControls { get; set; } = Array.Empty<string>();

    /// <summary>
    /// The control property name that will be triggered when this method finishes execution
    /// </summary>
    public string OutputTarget { get; set; } = string.Empty;

    /// <summary>
    /// Optional description of what this handler does
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
