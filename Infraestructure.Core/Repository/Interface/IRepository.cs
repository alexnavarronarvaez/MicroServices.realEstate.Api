using Common.Utils.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> AsQueryable();
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties);


        Task<PaginationDto<TEntity>> PaginationBy(Expression<Func<TEntity, bool>> filterExpression, PaginationDto<TEntity> pagination);
        Task<PaginationDto<TEntity>> PaginationByFilter(PaginationDto<TEntity> pagination);

        Task<int> ExcecuteProcedure(string sp, params object[] parameters);
    }
}
