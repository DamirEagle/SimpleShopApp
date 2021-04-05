using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFromNikita.Services.LogService
{
    public interface ILogService
    {
        void Info(string info, object parametrs = null);
        void Warning(string warning, object parametrs = null);
        void Error(string error, object parametrs = null);
    }
}
