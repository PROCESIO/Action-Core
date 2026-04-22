namespace Ringhel.Procesio.Action.Core.Models.Credentials.AI_API;

public enum StructuredOutputMode
{
    ToolsStrictForced = 0,
    ToolsForcedNoStrict = 1,
    ToolsAllowedNotForced = 2,
    NoToolsJsonInText = 3
}
