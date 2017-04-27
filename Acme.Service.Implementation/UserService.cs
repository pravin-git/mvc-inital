using Acme.Business;
using Acme.Common.DataContract;
using Acme.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Service.Implementation
{
    public class UserService : IUserService
    {
        public bool IsUserValid(UserLogin login)
        {
            using (UserBO userBO = new UserBO())
            {
                return userBO.IsValidUser(login);
            }
        }

        public UserContext GetUserContext(string userName)
        {
            using (UserBO userBO = new UserBO())
            {
                return userBO.GetUserContext(userName);
            }
        }


        public List<UserViewModel> GetAllUsers()
        {
            using (UserBO userBO = new UserBO())
            {
                return userBO.GetUsers();
            }
        }
        
        public UserViewModel GetUserById(int id)
        {
            using (UserBO userBO = new UserBO())
            {
                return userBO.GetUserById(id);
            }
        }
    }
}
