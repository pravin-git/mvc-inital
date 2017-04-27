using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common.DataContract;

namespace Acme.Data.Contract
{
    public interface IUserRepository
    {
        bool IsValidUser(UserLogin userLogin);
        List<UserViewModel> GetUsers();
        UserViewModel GetUserById(int id);
    }
}
