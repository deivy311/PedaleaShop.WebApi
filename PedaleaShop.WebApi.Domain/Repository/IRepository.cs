﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PedaleaShop.WebApi.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<DataTable> SqlConnectionManager(string Query, bool IdStoredPRocedure);
        Task<DataTable> SqlConnectionManager(string Query, List<SqlParameter> sqlParameters);
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
        Task<DataTable> GetByIdAsync(string table,int Id);
        Task<DataTable> GetByIdAsync(string table, string varToCompare, int Id);
        Task<DataTable> GetByIdAsync(string table, string varToCompare, string Id);
        T GetCondition(Expression<Func<T, bool>> where);
        IEnumerable<T> Get(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        void Commit();

        Task CommitAsync();
        IQueryable<T> Filter(Expression<Func<T, bool>> expression);
        Task<DataTable> GetAllAsync(string table, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync(int q, CancellationToken cancellationToken = default);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string propierties = "");
    }
}
