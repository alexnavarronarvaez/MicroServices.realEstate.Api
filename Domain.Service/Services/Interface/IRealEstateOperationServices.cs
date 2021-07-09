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
    public interface IRealEstateOperationServices
    {

        Task<ResoponseDto<string>> CreatProperty(PropertyRequestDto requestProperty);
        Task<ResoponseDto<string>> AddImageProperty(PropertyAddImageDto requestAddimageProperty);


        Task<ResoponseDto<string>> AddImageProperty(ImagePropertyRequestDto requestImageProperty);

        Task<ResoponseDto<string>> ChangePriceProperty(ChangePropertyRequestDto requestChangeProperty);

        Task<ResoponseDto<string>> UpdateProperty(PropertyRequestDto requestProperty);

        // Task<List<>> UpdateProperty(PropertyRequestDto requestProperty);


    }
}
