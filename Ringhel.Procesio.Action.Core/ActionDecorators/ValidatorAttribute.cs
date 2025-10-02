using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute that defines a validation
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ValidatorAttribute : Attribute
{
    /// <summary>
    /// Describes whether the validation is mandatory or not
    /// </summary>
    public bool IsRequired { get; set; } = false;

    /// <summary>
    /// Describes the type of validation that will be used
    /// </summary>
    public ExpectedType Expects { get; set; }
}
