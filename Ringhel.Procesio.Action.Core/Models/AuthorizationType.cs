namespace Ringhel.Procesio.Action.Core.Models
{
    public enum AuthorizationType
    {
        NoAuth = 1,
        ApiKey = 2,
        BearerToken = 3,
        BasicAuth = 4,
        OAuth10 = 5,
        OAuth20 = 6,
    }
}
