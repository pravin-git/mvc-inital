using Acme.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Service.Implementation
{
    public class FakeUserService : IUserService
    {
        public bool IsUserValid(Common.DataContract.UserLogin login)
        {
            return true;
        }

        public Common.DataContract.UserContext GetUserContext(string userName)
        {
            throw new NotImplementedException();
        }

        public List<Common.DataContract.UserViewModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Common.DataContract.UserViewModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
