using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute that is used to define some basic information about the action
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ClassDecoratorAttribute : Attribute
{
    /// <summary>
    /// Display name of the class
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Action Shape
    /// </summary>
    public ActionShape Shape { get; set; } = ActionShape.Circle;

    /// <summary>
    /// Action description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Action category
    /// </summary>
    public Classification Classification { get; set; }

    /// <summary>
    /// Action can be tested with test values.
    /// </summary>
    public bool IsTestable { get; set; } = false;

    /// <summary>
    /// Tooltip property. 
    /// </summary>
    public string Tooltip { get; set; }
}