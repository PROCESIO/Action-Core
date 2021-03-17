using System.Data.Common;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.DB
{
    public class DBCredentialsManager
    {
        public DBCredentialsConfiguration CredentialsConfiguration { get; set; }

        public DbConnection Client { get; set; }
    }
}
