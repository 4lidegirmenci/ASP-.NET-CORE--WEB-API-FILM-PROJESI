using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Conracts
{
    public interface IUserRepository:IRepositoryBase<User>
    {
        PagedList<User> GetAllUsers(UserParameters userParameters,bool trackChanges);

        User GetOneUserById(int id,bool trackChanges); 

        void CreateOneUser(User user);
        void UpdateOneUser(User user);
        void DeleteOneUser(User user);
    }
}
