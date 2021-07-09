using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.DapperRepositoy.Interface
{
    public interface IRealStateDapperRepository
    {

        Task<List<dynamic>> ListWithFilter(dynamic FilterDto);
    }
}
