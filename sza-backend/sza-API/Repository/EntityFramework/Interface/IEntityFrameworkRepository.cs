using Microsoft.EntityFrameworkCore;
using Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityFramework.Interface
{
    public interface IEntityRepository<T>
    where T :
    BaseEntity,
    new()
    {
        public Task<T?> Add(T entity);
        public Task<T?> Get(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>?> GetList(Expression<Func<T, bool>> filter);
        public Task<EntityState> Update(T entity);
    }
}
