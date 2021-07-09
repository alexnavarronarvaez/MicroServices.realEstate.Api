using AutoMapper;
using Common.Utils.DTO;
using Domain.Service.DTO.Request;
using Common.Utils.Resources;
using Domain.Service.Services.Interface;
using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Entities;
using System;
using System.Threading.Tasks;
using Common.Utils.Exceptions;
using Infraestructure.Core.DapperRepositoy.Interface;
using System.Collections.Generic;
using Domain.Service.DTO.Response;

namespace Domain.Service
{
    public class RealEsteQueryServices : IRealEstateQueryServices
    {


        private readonly IRealStateDapperRepository _realStateDapperRepository;

        public RealEsteQueryServices(IRealStateDapperRepository realStateDapperRepository)
        {
            this._realStateDapperRepository = realStateDapperRepository;

        }

        public Task<List<ListPropertyPaginate>> QueryListPropertyFilter(PropertyFilterDto requestFiter)
        {
            throw new NotImplementedException();
        }
    }
}
