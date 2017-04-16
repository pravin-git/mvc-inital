using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.DataContract
{
    [Serializable]
    public class UserRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
