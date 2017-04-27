using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Data.Contract;

namespace Acme.Data.Repository
{
    public class AcmeUnitofWork : IAcmeUnitofWork, IDisposable
    {
        readonly AcmeEntities context;

        private IUserRepository userRepository;

        public AcmeUnitofWork()
        {
            this.context = new AcmeEntities();
        }


        public void Commit()
        {
            context.SaveChanges();
        }

        public IUserRepository UserRepository
        {
            get { return userRepository ?? (userRepository = new UserRepository(context)); }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}
