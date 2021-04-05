using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Core;

namespace TestTaskFromNikita.LogService
{
    public class Log4NetService : ILogService
    {
        private readonly ILog _logger;

        public Log4NetService()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        }
        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }


        public void Info(string info, object parametrs = null)
        {
            _logger.Info(info);
        }

        public void Warning(string warning, object parametrs = null)
        {
            _logger.Warn(warning);
        }

        public void Error(string error, object parametrs = null)
        {
            _logger.Error(error);
        }
    }
}
