using Core.Application;
using Core.Factory;

namespace AVService.Helper
{
    public class Logger
    {
        private static Logger instance = null;

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                    instance = new Logger();

                return instance;
            }
        }

        public void LogString(string logStrng)
        {
            var fac = new ApplicationFactory();
            var lApp = fac.GetApplication<LogApplication>();
            lApp.Log(logStrng);
        }

    }
}