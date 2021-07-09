using Common.Utils.DTO;
using Infraestructure.Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _entities;



        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<TEntity>();

        }

        public IQueryable<TEntity> AsQueryable()
        {
            return _entities.AsQueryable<TEntity>();
        }


        public async Task InsertAsync(TEntity entity)
        {

            await _entities.AddAsync(entity);

        }

        public async Task InsertAsync(IEnumerable<TEntity> entity)
        {

            await _entities.AddRangeAsync(entity);

        }

        public void UpdateAsync(TEntity entity)
        {

            _entities.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }


        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }


        private IQueryable<TEntity> PerfomInclusions(IEnumerable<Expression<Func<TEntity, object>>> ingludeProperties, IQueryable<TEntity> query)
        {

            return ingludeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }


        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> filterExpression)
        {
            // IQueryable<TEntity> query = AsQueryable();

            return await _entities.FirstOrDefaultAsync(filterExpression);

        }

        public Task<PaginationDto<TEntity>> PaginationBy(Expression<Func<TEntity, bool>> filterExpression, PaginationDto<TEntity> pagination)
        {



            throw new NotImplementedException();
        }

        public Task<PaginationDto<TEntity>> PaginationByFilter(PaginationDto<TEntity> pagination)
        {
            throw new NotImplementedException();
        }

        public async Task<int> ExcecuteProcedure(string sp, params object[] parameters)
        {

            return _dbContext.Database.ExecuteSqlRaw(sp, parameters);
        }
    }
}
