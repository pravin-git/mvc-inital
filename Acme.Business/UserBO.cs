using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Data.Contract;
using Acme.Data.Repository;
using Acme.Common.DataContract;

namespace Acme.Business
{
    public class UserBO : IDisposable
    {
        private AcmeUnitofWork uom;

        public UserBO(IAcmeUnitofWork unitOfWork)
        {
            this.uom = unitOfWork as AcmeUnitofWork;
        }

        public UserBO() : this(new AcmeUnitofWork())
        {

        }

        public UserViewModel GetUserById(int id)
        {
            return this.uom.UserRepository.GetUserById(id);
        }

        public List<UserViewModel> GetUsers()
        { 
            return this.uom.UserRepository.GetUsers();
        }

        public bool IsValidUser(UserLogin userLogin)
        {
            return this.uom.UserRepository.IsValidUser(userLogin);
        }

        public void Dispose()
        {
            if (uom != null)
            {
                uom.Dispose();
            }
        }
    }
}
