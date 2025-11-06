using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Marks a method to be executed at design time at action level.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ActionEventHandlerAttribute : Attribute
{
    /// <summary>
    /// The type of event associated with this method execution.
    /// </summary>
    public ActionEventType EventType { get; set; } = ActionEventType.OnReady;

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
    /// Recommended when multiple methods are to be executed in a specific order.
    /// </summary>
    public int Order { get; set; } = 0;
}
