using Acme.Common.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Service.Contract
{
    public interface IUserService
    {
        bool IsUserValid(UserLogin login);
        UserContext GetUserContext(string userName);
        List<UserViewModel> GetAllUsers();
        UserViewModel GetUserById(int id);
    }
}
