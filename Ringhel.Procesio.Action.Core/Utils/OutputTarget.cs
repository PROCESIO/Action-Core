namespace Ringhel.Procesio.Action.Core.Utils;

/// <summary>
/// Describes the kind of front-end update produced by a control change trigger method.
/// The platform uses this to decide how to refresh the UI for the controls listed in OutputControls.
/// </summary>
public enum OutputTarget
{
    /// <summary>
    /// No special front-end refresh semantic. The platform will treat outputs generically.
    /// </summary>
    None = 0,

    /// <summary>
    /// The method produces or mutates one or more control values (e.g. auto-calculated value, dependent field update).
    /// The front end will read and display updated values for the affected OutputControls after method execution.
    /// </summary>
    Value = 1,

    /// <summary>
    /// The method produces a new dynamic option list (e.g. dropdown / multi-select choices) for one or more OutputControls.
    /// The front end will bind the refreshed option items for those controls after method execution.
    /// </summary>
    Options = 2,
}
