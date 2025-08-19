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
    /// The target output control property name that will receive the result
    /// </summary>
    public string OutputControl { get; set; } = string.Empty;

    /// <summary>
    /// Optional tab identifier for better organization
    /// </summary>
    public string Tab { get; set; } = string.Empty;

    /// <summary>
    /// Optional description of what this handler does
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
