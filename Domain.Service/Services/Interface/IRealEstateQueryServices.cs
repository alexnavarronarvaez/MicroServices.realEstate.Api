using Common.Utils.DTO;
using Domain.Service.DTO.Request;
using Domain.Service.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Services.Interface
{
    public interface IRealEstateQueryServices
    {

        Task<List<ListPropertyPaginate>> QueryListPropertyFilter(PropertyFilterDto requestFiter)

    }
}
