using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RealEstate.WebApi.Handlers;
using Application.RealEstate.WebApi.Model;
using AutoMapper;
using Domain.Service.DTO.Request;
using Domain.Service.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.RealEstate.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [TypeFilter(typeof(CustomExceptionHandlres))]
    public class RealEstateController : ControllerBase
    {

        private readonly IRealEstateOperationServices _realEstateServices;

        public RealEstateController(IRealEstateOperationServices realEstateServices)
        {
            this._realEstateServices = realEstateServices;

        }

        [HttpPost("CreateProperty")]
        public async Task<IActionResult> CreateProerty(PropertyRequestDto requestProperty)
        {
            ResponseModel<string> response = Mapper.Map<ResponseModel<string>>(await _realEstateServices.CreatProperty(requestProperty));

            return Ok(response);

        }


        [HttpPut("UpdateProperty")]
        public async Task<IActionResult> UpdateProperty(PropertyRequestDto requestProperty)
        {
            ResponseModel<string> response = Mapper.Map<ResponseModel<string>>(await _realEstateServices.UpdateProperty(requestProperty));

            return Ok(response);

        }


        [HttpPost("ChangePriceProperty")]
        public async Task<IActionResult> ChangePriceProperty(ChangePropertyRequestDto requestChangeProperty)
        {
            ResponseModel<string> response = Mapper.Map<ResponseModel<string>>(await _realEstateServices.ChangePriceProperty(requestChangeProperty));

            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> PostImage(PropertyAddImageDto request)
        {
            byte[] bytes = Convert.FromBase64String(image);
            using (MemoryStream ms = new MemoryStream(bytes))
                Image image = Image.FromStream(ms);

            return CreatedAtAction("PostImage", new { id = 123 });
        }

    }
}
