using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Data.Contract
{
    public interface IAcmeUnitofWork
    {
        void Commit();
        IUserRepository UserRepository { get; }
    }
}
