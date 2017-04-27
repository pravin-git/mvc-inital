using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Data.Contract;
using Acme.Common.DataContract;

namespace Acme.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private AcmeEntities objContext;

        public UserRepository(AcmeEntities context)
        {
            this.objContext = context;
        }

        public bool IsValidUser(UserLogin userLogin)
        {
            return objContext.User.Where(p => p.UserName == userLogin.UserName).Any();
        }


        public List<UserViewModel> GetUsers()
        {
            var query = objContext.User.Select(u => new UserViewModel()
            {
                UserId = u.UserId,
                UserName = u.UserName,
                Email = u.Email
            });
            return query.ToList();
        }


        public UserViewModel GetUserById(int id)
        {
            return objContext.User.Where(u => u.UserId == id).Select(u => new UserViewModel()
            {
                UserId = u.UserId,
                UserName = u.UserName,
                Email = u.Email

            }).SingleOrDefault();
        }
    }
}
