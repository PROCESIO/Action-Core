namespace Ringhel.Procesio.Action.Core.Models
{
    /// <summary>
    /// Model representing a connector operation
    /// </summary>
    public class ConnectorOperationModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public bool RequiresAuthentication { get; set; } = true;
    }
}
