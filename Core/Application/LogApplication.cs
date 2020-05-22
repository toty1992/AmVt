using Core.Application.Base;
using Core.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class LogApplication : BaseApplication
    {
        public void Log(string logText)
        {
            var log = new Logger() { LogText = logText };
            Context.Loggers.Add(log);
            Context.SaveChanges();
        }
    }
}
