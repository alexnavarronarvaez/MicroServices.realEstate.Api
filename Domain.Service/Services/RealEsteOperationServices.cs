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

namespace Domain.Service
{
    public class RealEsteOperationServices : IRealEstateOperationServices
    {


        private readonly IUnitOfWork _unitOfWork;

        public RealEsteOperationServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;

        }
        public Task<ResoponseDto<string>> AddImageProperty(ImagePropertyRequestDto requestImageProperty)
        {

            throw new NotImplementedException();
        }



        public async Task<ResoponseDto<string>> AddImageProperty(PropertyAddImageDto requestAddimageProperty)
        {
            ResoponseDto<string> result = new ResoponseDto<string>();

            PropertyImageEntity propertyAddImage = new PropertyImageEntity()
            {
                IdProperty = requestAddimageProperty.IdProperty,
                File = requestAddimageProperty.imageBase64,
                TypeFile = requestAddimageProperty.TypeFile,
                Enabled = true

            };

            await this._unitOfWork.PropertyImageRepository.InsertAsync(propertyAddImage);

            result.IsSucess = await this._unitOfWork.Save() > 0;

            result.Message = result.IsSucess ? GeneralMessage.PropertyAddImageSuccess : GeneralMessage.PropertyAddImageError;

            return result;
        }

        public async Task<ResoponseDto<string>> CreatProperty(PropertyRequestDto requestProperty)
        {
            ResoponseDto<string> result = new ResoponseDto<string>();

            PropertyEntity propertyNew = Mapper.Map<PropertyEntity>(requestProperty);

            propertyNew.CreationDate = DateTime.Now;

            await this._unitOfWork.PropertyRepository.InsertAsync(propertyNew);

            result.IsSucess = await this._unitOfWork.Save() > 0;

            result.Message = result.IsSucess ? GeneralMessage.PropertySaveSuccess : GeneralMessage.PropertySaveError;
            return result;
        }

        public async Task<ResoponseDto<string>> ChangePriceProperty(ChangePropertyRequestDto requestChangeProperty)
        {

            ResoponseDto<string> result = new ResoponseDto<string>();

            PropertyEntity propertyToUpdate = await this._unitOfWork.PropertyRepository.Find(x => x.IdProperty == requestChangeProperty.IdProperty);



            propertyToUpdate.Price = requestChangeProperty.Price;
            propertyToUpdate.ModificationDate = DateTime.Now;

            this._unitOfWork.PropertyRepository.UpdateAsync(propertyToUpdate);

            result.IsSucess = await this._unitOfWork.Save() > 0;

            result.Message = result.IsSucess ? GeneralMessage.PropertySaveSuccess : GeneralMessage.PropertySaveError;

            return result;

        }

        public async Task<ResoponseDto<string>> UpdateProperty(PropertyRequestDto requestProperty)
        {
            ResoponseDto<string> result = new ResoponseDto<string>();

            PropertyEntity propertyToUpdate = await this._unitOfWork.PropertyRepository.Find(x => x.IdProperty == requestProperty.IdProperty);


            if (propertyToUpdate != null)
            {

                propertyToUpdate = Mapper.Map<PropertyEntity>(requestProperty);

                this._unitOfWork.PropertyRepository.UpdateAsync(propertyToUpdate);

                result.IsSucess = await this._unitOfWork.Save() > 0;

                result.Message = result.IsSucess ? GeneralMessage.PropertySaveSuccess : GeneralMessage.PropertySaveError;

            }
            else
            {

                throw new GeneralExceptions(GeneralMessage.NoFoundProperty);
            }


            return result;

        }
    }
}
