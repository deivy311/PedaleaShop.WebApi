using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace PedaleaShop.WebApi.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Add(List<T> entity);
        void Update(T entity);
        void Update(List<T> entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(int Id);
        void Delete(List<T> entity);
        void Delete(IEnumerable<T> entities);
        void DeleteWhereD(Expression<Func<T, bool>> where);
        T GetById(int Id);
        T GetCondition(Expression<Func<T, bool>> where);
        IEnumerable<T> Get(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        void Commit();

        Task CommitAsync();
        IQueryable<T> Filter(Expression<Func<T, bool>> expression);
        Task<DataTable> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync(int q, CancellationToken cancellationToken = default);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string propierties = "");
    }
}
