using System.Data;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models
{
    public interface IDbClient
    {
        /// <summary>
        /// Execute a query that will return a list
        /// </summary>
        Task<DataSet> ExecuteQuery(string dbQuery);

        /// <summary>
        /// Execute a command that will return an int
        /// Examples: COUNT, INSERT, UPDATE, ...
        /// </summary>
        /// <returns></returns>
        Task<int> ExecuteCommand(string dbQuery);
    }
}