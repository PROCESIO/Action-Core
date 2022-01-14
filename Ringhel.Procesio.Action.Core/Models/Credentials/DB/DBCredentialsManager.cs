using System.Data.Common;

namespace Ringhel.Procesio.Action.Core.Models
{
    public class DbCredentialsManager
    {
        public DbCredentialsConfiguration CredentialsConfiguration { get; set; }

        public IDbClient Client { get; set; }
    }
}
