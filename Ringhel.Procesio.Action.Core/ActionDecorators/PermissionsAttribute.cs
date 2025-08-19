namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute that is used to define the action's permissions
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class PermissionsAttribute : Attribute
{
    public bool CanDelete { get; set; }
    public bool CanAddFromToolbar { get; set; }
    public bool CanDuplicate { get; set; }
}
