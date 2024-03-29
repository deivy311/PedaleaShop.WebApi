﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using PedaleaShop.WebApi.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public readonly DbSet<T> dbSet;
        public readonly string _sqlConnectionString;

        public async Task<DataTable> SqlConnectionManager(string Query, bool IdStoredPRocedure)
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString))
            {
                await sqlConnection.OpenAsync();
                SqlDataAdapter sqlDa = new SqlDataAdapter(Query, sqlConnection);
                if (IdStoredPRocedure)
                {
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //sqlDa.SelectCommand.Parameters.AddRange = CommandType.StoredProcedure;

                }
                sqlDa.Fill(dtbl);
                await sqlConnection.CloseAsync();
            }
            return dtbl;
        }
        public async Task<DataTable> SqlConnectionManager(string Query, List<SqlParameter> sqlParameters)
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString))
            {
                await sqlConnection.OpenAsync();
                SqlDataAdapter sqlDa = new SqlDataAdapter(Query, sqlConnection);
  
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddRange(sqlParameters.ToArray());

                sqlDa.Fill(dtbl);
                await sqlConnection.CloseAsync();
            }
            return dtbl;
        }
        public Repository(IConfiguration configuration)
        {
            //_dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //_sqlConnection = new SqlConnection(configuration.GetConnectionString("DefaultDBConnection"))
            _sqlConnectionString = configuration.GetConnectionString("DefaultDBConnection");
            
        }

        public void Add(T entity)
        {
            _dbContext.Add(entity);
            Commit();
        }

        public void Add(IEnumerable<T> entities)
            => _dbContext.AddRange(entities);
        public void Add(List<T> entities)
            => _dbContext.AddRange(entities);

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }
        public void Delete(List<T> entities)
            => _dbContext.RemoveRange(entities);
        public void Delete(IEnumerable<T> entities)
            => _dbContext.RemoveRange(entities);

        public void Delete(int Id)
        {
            T entidad = GetById(Id);
            _dbContext.Remove(entidad);
        }
        public void DeleteWhereD(Expression<Func<T, bool>> where)
        {
            T entity = _dbContext.Set<T>().Where(where).FirstOrDefault<T>();
            _dbContext.Remove(entity);
            Commit();
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression);
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public virtual IEnumerable<T> Get(
           Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
        public async Task<DataTable> GetAllAsync(string table,CancellationToken cancellationToken = default)
        {
            return await this.SqlConnectionManager($"SELECT * FROM {table}", false);
  
        }
        public async Task<DataTable> GetByIdAsync(string table, int Id)
        {
            DataTable dtbl = new DataTable();
            return await this.SqlConnectionManager($"SELECT * FROM {table} WHERE Id={Id}", false);
        }
        public async Task<DataTable> GetByIdAsync(string table, string varToCompare, int Id)
        {
            return await this.SqlConnectionManager($"SELECT * FROM {table} WHERE {varToCompare}={Id}", false);
        }
        public async Task<DataTable> GetByIdAsync(string table, string varToCompare, string Id)
        {
            return await this.SqlConnectionManager($"SELECT * FROM {table} WHERE {varToCompare}='{Id}'", false);
        }
        public async Task<IEnumerable<T>> GetAllAsync(int q,CancellationToken cancellationToken = default)
        => await dbSet.Take(q).ToListAsync(cancellationToken);
        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
            => await _dbContext.AddAsync(entity);
        public T GetById(int Id)
        {
            return _dbContext.Set<T>().Find(Id);
        }

        public T GetCondition(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().Where(where).FirstOrDefault<T>();
        }

        public void Update(T entity)
            => _dbContext.Update(entity);
        public void Update(List<T> entities)
            => _dbContext.UpdateRange(entities);
        public void Update(IEnumerable<T> entities)
            => _dbContext.UpdateRange(entities);


    }
}
