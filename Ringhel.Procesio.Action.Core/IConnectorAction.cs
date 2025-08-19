using Ringhel.Procesio.Action.Core.Models;

namespace Ringhel.Procesio.Action.Core;

/// <summary>
/// Interface for connector actions that support design-time execution
/// and incremental step functionality
/// </summary>
public interface IConnectorAction : IAction
{
    /// <summary>
    /// Executes a specific connector method at design time
    /// This is called when control values change and need to trigger 
    /// dynamic behavior like populating dropdowns
    /// </summary>
    /// <param name="methodName">Name of the method to execute</param>
    /// <param name="inputs">Input parameters for the method</param>
    /// <returns>Result that will be used to update target controls</returns>
    Task<object> ExecuteConnectorMethod(string methodName, Dictionary<string, object> inputs);

    /// <summary>
    /// Gets the available operations for this connector
    /// This is typically called to populate operation dropdowns
    /// </summary>
    /// <returns>List of available operations</returns>
    Task<IEnumerable<ConnectorOperationModel>> GetAvailableOperations();

    /// <summary>
    /// Validates the connector configuration
    /// </summary>
    /// <returns>True if configuration is valid</returns>
    Task<bool> ValidateConfiguration();
}
