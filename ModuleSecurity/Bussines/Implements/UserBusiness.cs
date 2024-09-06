﻿using Bussines.Interfaces;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Implements
{
    public class UserBusiness : IUserBusiness
    {
        protected readonly IUserData data;

        public UserBusiness(IUserData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            IEnumerable<User> users = await this.data.GetAll();
            var userDtos = users.Select(user => new UserDto
            {
                Id = user.Id,
                IdPerson = user.IdPerson,
                State = user.State,
            });
            return userDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<UserDto> GetById(int id)
        {

            User user = await this.data.GetById(id);
            UserDto userDto = new UserDto();

            userDto.Id = user.Id;
            userDto.IdPerson = user.IdPerson;
            userDto.State = user.State;
            return userDto;
        }
        public User mapData(User user, UserDto entity)
        {
            user.Id = entity.Id;
            user.IdPerson = entity.IdPerson;
            user.State = entity.State;
            return user;
        }

        public async Task<User> Save(UserDto entity)
        {
            User user = new User();
            user.CreatedAt = DateTime.Now.AddHours(-5);
            user = this.mapData(user, entity);
            user.Person = null;

            return await this.data.Save(user);
        }

        public async Task Update(UserDto entity)
        {
            User user = await this.data.GetById(entity.Id);
            if (user == null)
            {
                throw new Exception("Registro NO encontrado");
            }
            user = this.mapData(user, entity);
            await this.data.Update(user);
        }
    }
}
