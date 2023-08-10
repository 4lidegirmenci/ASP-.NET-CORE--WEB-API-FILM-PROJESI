using Entities.DataTransferObject;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IUserServices
    {
        (IEnumerable<UserDto> users,MetaData metaData)GetAllUsers(UserParameters userParameters,bool trackChanges);

        UserDto GetUserById(int id,bool trackChanges);

        UserDto CreateOneUser(UserDtoForInsertion user);

        void UpdateOneUser(int id,UserDtoForUpdate userdto,bool trackChanges);

        void DeleteOneUser(int id,bool trackChanges);
    }
}
