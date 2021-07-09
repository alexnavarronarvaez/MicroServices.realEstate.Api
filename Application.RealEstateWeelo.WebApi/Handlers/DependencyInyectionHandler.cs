using Domain.Service;
using Domain.Service.Services.Interface;
using Infraestructure.Core.Repository;
using Infraestructure.Core.Repository.Interface;
using Infraestructure.Core.UnitOfWork;
using Infraestructure.Core.UnitOfWork.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.RealEstate.WebApi.Handlers
{
    public class DependencyInyectionHandler
    {

        public static void DependencyInyectionConfig(IServiceCollection services)
        {

            //Repository
            services.AddScoped<UnitOfWork, UnitOfWork>();


            //Infraestructure
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));


            //Services- Domain
            services.AddTransient<IRealEstateOperationServices, RealEsteOperationServices>();


        }
    }
}
