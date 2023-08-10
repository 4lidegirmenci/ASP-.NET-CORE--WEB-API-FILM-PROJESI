using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Conracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class userRepository : RepositoryBase<User>, IUserRepository
    {
        public userRepository(RepsitoryContext.RepositoryContext context) : base(context)
        {

        }

        public void CreateOneUser(User user) => Create(user);


        public void DeleteOneUser(User user) => Delete(user);



        public PagedList<User> GetAllUsers(UserParameters userParameters
            , bool trackChanges) 
        {
           var users= FindAll(trackChanges).OrderBy(b => b.UserId).ToList();

            return PagedList<User>.ToPagedList(users, userParameters.PageNumber, userParameters.PageSize);
        } 


        public User GetOneUserById(int id, bool trackChanges) => FindByCondition(b => b.UserId.Equals(id), trackChanges).SingleOrDefault();



        public void UpdateOneUser(User user) => Update(user);

        
    }
}
