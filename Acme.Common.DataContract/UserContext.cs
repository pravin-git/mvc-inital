using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.DataContract
{
    [Serializable]
    public class UserContext
    {
        public int UserId { get; set; }
        public IList<UserRole> UserRoles { get; set; }
    }
}
