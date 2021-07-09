
using Dapper;
using Infraestructure.Core.DapperManager.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.DapperManager
{
    public class DapperManagerRepository<T> : IDapperManagerRepository<T> where T : class
    {

        private readonly IConfiguration configuration;
        private readonly string connString;

    
    

        public DapperManagerRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.connString = this.configuration.GetConnectionString("ConnectionStringSQLServer");
        }

        #region Métodos Públicos

        /// <summary>
        /// Ejecutar sentencia sql
        /// </summary>
        /// <typeparam name="T">Entidad para realizar el Mapeo</typeparam>
        /// <param name="cnx">The Connection String.</param>
        /// <param name="query">Quesry SQL a ejecutar.</param>
        /// <param name="filter">Condición que se debe mapear a la sentencia sql server.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="Exception">Manejo de errores</exception>
        public async Task<IEnumerable<T>> ExecuteQuerySelectAsync(string query, object filter = null)
        {
            using var conn = new SqlConnection(this.connString);
            conn.Open();
            var result = await conn.QueryAsync<T>(query, filter).ConfigureAwait(false);
            conn.Close();
            return result;
        }

        /// <summary>
        /// Ejecutar sentencia sql y devuelve un primer registro
        /// </summary>
        /// <typeparam name="T">Entidad para realizar el Mapeo</typeparam>
        /// <param name="cnx">The Connection String.</param>
        /// <param name="query">Quesry SQL a ejecutar.</param>
        /// <param name="filter">Condición que se debe mapear a la sentencia sql server.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="Exception">Manejo de errores</exception>
        public async Task<T> ExecuteFirstOrDefaultAsync(string query, object filter = null)
        {
            using var conn = new SqlConnection(this.connString);
            conn.Open();
            var result = await conn.QueryFirstOrDefaultAsync<T>(query, filter).ConfigureAwait(false);
            conn.Close();
            return result;
        }

        /// <summary>
        ///     s the store procedure.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cnx">The Connection String.</param>
        /// <param name="storeProcedure">The store procedure.</param>
        /// <param name="filter">The filter.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        public async Task<IEnumerable<T>> ExecuteStoreProcedureAsync(string storeProcedure, object filter = null)
        {
            using var conn = new SqlConnection(this.connString);
            conn.Open();
            var result = await conn.QueryAsync<T>(storeProcedure, filter, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            conn.Close();
            return result;
        }

        /// <summary>
        ///     s the query scalar.
        /// </summary>
        /// <param name="cnx">The Connection String.</param>
        /// <param name="query">The query.</param>
        /// <param name="filter">The filter.</param>
        /// <returns>System.Int32.</returns>
        /// <summary>

        public async Task<int> ExecuteQueryScalarAsync(string query, object filter = null)
        {
            using var conn = new SqlConnection(this.connString);
            conn.Open();
            var result = await conn.ExecuteScalarAsync<int>(query, filter).ConfigureAwait(false);
            conn.Close();
            return result;
        }

        #endregion Métodos Públicos
    }
}
}
