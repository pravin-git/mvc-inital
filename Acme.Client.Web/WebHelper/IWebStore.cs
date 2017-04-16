using Acme.Common.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Client.Web.WebHelper
{
    public interface IWebStore
    {
        UserContext UserContext { get; set; }
    }
}
