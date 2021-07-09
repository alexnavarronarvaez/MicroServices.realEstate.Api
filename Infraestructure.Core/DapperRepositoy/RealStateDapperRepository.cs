using Infraestructure.Core.DapperManager.Interface;
using Infraestructure.Core.DapperRepositoy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.DapperRepositoy
{
    public class RealStateDapperRepository : IRealStateDapperRepository
    {
        private readonly IDapperManagerRepository<dynamic> dapperManager;


        public RealStateDapperRepository(IDapperManagerRepository<dynamic> dapperManager)
        {
            this.dapperManager = dapperManager;

        }

        public async Task<List<dynamic>> ListWithFilter(dynamic FilterDto)
        {
            string query = QueryResources.QueryDapper.Query1;
            var filter = new { listTypeId = 1 };
            var result = await this.dapperManager.ExecuteQuerySelectAsync(query, filter);
            return result.ToList();
        }
    }
}
