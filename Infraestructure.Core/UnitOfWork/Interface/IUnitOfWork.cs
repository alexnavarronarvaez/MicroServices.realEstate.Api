using Infraestructure.Core.Repository;
using Infraestructure.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {


        #region Repository

        Repository<OwnerEntity> OwnerRepository { get; }


        Repository<PropertyEntity> PropertyRepository { get; }

        Repository<PropertyImageEntity> PropertyImageRepository { get; }

        Repository<PropertyTraceEntity> PropertyTraceRepository { get; }

        Task<int> Save();

        #endregion
    }
}
