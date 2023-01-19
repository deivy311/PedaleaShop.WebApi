using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;


namespace PedaleaShop.WebApi.Domain.Services
{
    public class UsersServices: IUsersServices
    {
        public IUnitRepository _repository;

        //public UsersServices(IUnitRepository repository)
        //{
        //    _repository = repository;
        //}
        //public async Task AddEntity(User entity)
        //{
        //    _repository.UsersRepository.Add(entity);
        //    await _repository.CommitAsync();
        //}
        //public async Task AddEntities(IEnumerable<User> entities)
        //{
        //    _repository.UsersRepository.Add(entities);
        //    await _repository.CommitAsync();
        //}

        //public User GetEntity(int Id) => _repository.UsersRepository.GetById(Id);

        //public User GetByName(string Name) => _repository.GetByName(Name);
        //public async Task<IEnumerable<User>> GetEntities()=> await _repository.UsersRepository.GetAllAsync();

        //public async Task UpdateEntity(User entity)
        //{
        //    _repository.UsersRepository.Update(entity);
        //    await _repository.CommitAsync();
        //}
        //public async Task UpdateEntity(IEnumerable<User> entities)
        //{
        //    _repository.UsersRepository.Update(entities);
        //    await _repository.CommitAsync();
        //}
        //public async Task DeleteEntity(User entity)
        //{
        //    _repository.UsersRepository.Delete(entity);
        //    await _repository.CommitAsync();
        //}

        //public async Task DeleteEntity(IEnumerable<User> entities)
        //{
        //    _repository.UsersRepository.Delete(entities);
        //    await _repository.CommitAsync();
        //}
    }
}
