using Infraestructure.Core.Context;
using Infraestructure.Core.Repository;
using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        #region Attributes
        private readonly ContextSQL _contextSQL;
        #endregion Attributes


        #region Constructor
        public UnitOfWork(ContextSQL contextSQL)
        {
            _contextSQL = contextSQL;

        }
        #endregion Constructor


        #region Repository


        #region Owner
        Repository<OwnerEntity> ownerRepository;


        public Repository<OwnerEntity> OwnerRepository
        {
            get
            {

                if (this.ownerRepository == null)
                {

                    this.ownerRepository = new Repository<OwnerEntity>(_contextSQL);
                }

                return ownerRepository;
            }

        }

        #endregion Project


        #region Property
        Repository<PropertyEntity> propertyRepository;


        public Repository<PropertyEntity> PropertyRepository
        {
            get
            {

                if (this.propertyRepository == null)
                {

                    this.propertyRepository = new Repository<PropertyEntity>(_contextSQL);
                }

                return this.propertyRepository;
            }

        }

        #endregion Property

        #region Property Image
        Repository<PropertyImageEntity> propertyImageRepository;


        public Repository<PropertyImageEntity> PropertyImageRepository
        {
            get
            {

                if (this.propertyImageRepository == null)
                {

                    this.propertyImageRepository = new Repository<PropertyImageEntity>(_contextSQL);
                }

                return this.propertyImageRepository;
            }

        }

        #endregion Property Trace



        #region Property Trace
        Repository<PropertyTraceEntity> propertyTraceRepository;


        public Repository<PropertyTraceEntity> PropertyTraceRepository
        {
            get
            {

                if (this.propertyTraceRepository == null)
                {

                    this.propertyTraceRepository = new Repository<PropertyTraceEntity>(_contextSQL);
                }

                return this.propertyTraceRepository;
            }

        }



        #endregion Property Trace





        public async Task<int> Save()
        {
            int result = 0;
            EntityState state = EntityState.Unchanged;
            Dictionary<string, List<object>> changes = GetChanged(ref state);
            result = await _contextSQL.SaveChangesAsync();

            return result;
        }

        #endregion Repository


        public Dictionary<string, List<object>> GetChanged(ref EntityState state)
        {

            Dictionary<string, List<object>> keyValues = new Dictionary<string, List<object>>();
            IEnumerable<EntityEntry> changes = (from x in _contextSQL.ChangeTracker.Entries().AsEnumerable()
                                                where x.State != EntityState.Unchanged
                                                select x);

            foreach (var item in changes)
            {
                var entity = item.Entity;
                state = item.State;

                Assembly assembly = Assembly.Load(entity.GetType().Assembly.FullName);
                Type type = assembly.GetType(entity.GetType().FullName);
                object _entity = Convert.ChangeType(entity, type);
                if (keyValues.ContainsKey(entity.GetType().Name))
                {

                    keyValues[entity.GetType().Name].Add(_entity);
                }
                else
                {

                    keyValues.Add(entity.GetType().Name, new List<object>() { _entity });

                }
            }

            return keyValues;
        }

    }
}
