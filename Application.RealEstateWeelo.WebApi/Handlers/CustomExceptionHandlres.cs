using Application.RealEstate.WebApi.Model;
using Common.Utils.Exceptions;
using Common.Utils.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.RealEstate.WebApi.Handlers
{
    public class CustomExceptionHandlres : ExceptionFilterAttribute
    {

        public CustomExceptionHandlres()
        {


        }

        public override void OnException(ExceptionContext context)
        {
            HttpResponseException oResponseException = new HttpResponseException();

            ResponseModel<string> oResponse = new ResponseModel<string>()
            {
                IsSucess = false,
                Result = JsonConvert.SerializeObject(context.Exception)

            };


            if (context.Exception is GeneralExceptions)
            {
                oResponseException.Status = StatusCodes.Status400BadRequest;
                oResponse.Message = context.Exception.Message;
                context.ExceptionHandled = true;


            }
            else
            {

                if (context.Exception != null)
                {
                    oResponseException.Status = StatusCodes.Status500InternalServerError;
                    oResponse.Message = GeneralMessage.Error500;
                    context.ExceptionHandled = true;

                }
            }


            context.Result = new ObjectResult(oResponseException.Value)
            {
                StatusCode = oResponseException.Status,
                Value = oResponse

            };



        }


    }
}
