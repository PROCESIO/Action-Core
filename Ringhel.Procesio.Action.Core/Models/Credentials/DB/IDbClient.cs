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
        /// Execute a query that will return a list in a specified amount of time
        /// </summary>
        Task<DataSet> ExecuteQuery(string dbQuery, int timeout);

        /// <summary>
        /// Execute a command that will return an int
        /// Examples: COUNT, INSERT, UPDATE, ...
        /// </summary>
        /// <returns></returns>
        Task<int> ExecuteCommand(string dbQuery);
        /// <summary>
        /// Execute a command that will return an int in a specified amount of time
        /// Examples: COUNT, INSERT, UPDATE, ...
        /// </summary>
        /// <returns></returns>
        Task<int> ExecuteCommand(string dbQuery, int timeout);
    }
}