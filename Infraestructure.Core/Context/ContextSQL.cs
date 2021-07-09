using Infraestructure.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.Context
{

    [ExcludeFromCodeCoverage]
    public class ContextSQL : DbContext
    {

        public ContextSQL(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        #region DBSet Entities

        DbSet<OwnerEntity> ownerEntity { get; set; }

        DbSet<PropertyEntity> propertyEntity { get; set; }

        DbSet<PropertyImageEntity> properttyImageEntity { get; set; }
        DbSet<PropertyTraceEntity> propertyTraceEntity { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
