using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.DapperManager.Interface
{
    public interface IDapperManagerRepository<T> where T : class
    {
        Task<IEnumerable<T>> ExecuteQuerySelectAsync(string query, object filter = null);

        Task<T> ExecuteFirstOrDefaultAsync(string query, object filter = null);

        Task<IEnumerable<T>> ExecuteStoreProcedureAsync(string storeProcedure, object filter = null);

        Task<int> ExecuteQueryScalarAsync(string query, object filter = null);


    }
}
