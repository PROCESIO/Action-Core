using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute used to define control dependencies for showing/hiding controls based on other control values
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class DependencyDecoratorAttribute : Attribute
{
    /// <summary>
    /// The tab name where the dependency control resides
    /// </summary>
    public string Tab { get; set; }

    /// <summary>
    /// The name of the dependency control
    /// </summary>
    public string Control { get; set; }

    /// <summary>
    /// The type of comparison to be executed
    /// </summary>
    public Operator Operator { get; set; }

    /// <summary>
    /// The logical operator to be used in the comparison
    /// If missing, defaults to 'And'
    /// </summary>
    public LogicalOperator LogicalOperator { get; set; }

    /// <summary>
    /// The value(s) to be compared with the dependency control value
    /// Can be a single value or an array of values
    /// </summary>
    public object[] Value { get; set; }
}
