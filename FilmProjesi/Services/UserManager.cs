using AutoMapper;
using Entities.DataTransferObject;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Conracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public class UserManager : IUserServices
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public UserManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public UserDto CreateOneUser(UserDtoForInsertion userDto)
        {
            var entity = _mapper.Map<User>(userDto);
            _manager.User.CreateOneUser(entity);
            _manager.Save();
            return _mapper.Map<UserDto>(entity);

        }

        public void DeleteOneUser(int id, bool trackChanges)
        {
            //check entity

            var entity = _manager.User.GetOneUserById(id, trackChanges);
            if (entity is null)
            {
                throw new UserNotFoundException(id);
            }
            _manager.User.DeleteOneUser(entity);
            _manager.Save();
        }

        public (IEnumerable<UserDto> users, MetaData metaData) GetAllUsers(UserParameters userParameters,bool trackChanges)
        {
            
            var usersWithMetaData = _manager.User.GetAllUsers(userParameters,trackChanges);
            var usersDto= _mapper.Map<IEnumerable<UserDto>>(usersWithMetaData);
            return (usersDto, usersWithMetaData.MetaData);
        }

        public UserDto GetUserById(int id, bool trackChanges)
        {
            var user = _manager.User.GetOneUserById(id, trackChanges);
            if (user is null)
            {
                throw new UserNotFoundException(id);
            }
            return _mapper.Map<UserDto>(user);
        }

        public void UpdateOneUser(int id, UserDtoForUpdate userdto, bool trackChanges)
        {
            //check entity
            var entity = _manager.User.GetOneUserById(id, false);
            if (entity is null)
            {
                throw new UserNotFoundException(id);
            }
            //check params


            //entity.UserName = user.UserName;
            //entity.Password = user.Password;
            //entity.Email = user.Email;
            //entity.Phone = user.Phone;

            //mapping

            entity = _mapper.Map<User>(userdto);

            _manager.User.Update(entity);
            _manager.Save();


        }
    }
}
