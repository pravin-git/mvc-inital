using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Logger()
        {
            XmlConfigurator.Configure();
        }

        public void Log(string message)
        {
            logger.Info(message);
        }
    }
}
