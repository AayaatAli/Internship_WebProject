using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Second
{
    public class Logs
    {
        static ILog _logs;

        Logs()
        {
            //log4net.Config.XmlConfigurator.Configure();
        }


        static void config()
        {
            _logs = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log4net.Config.XmlConfigurator.Configure();
        }
        public static ILog getInstance()
        {
            if (_logs == null)
            {
                config();
                //_logs =new 
            }
            return _logs;
        }

        public static void printLogs(String msg)
        {
            getInstance();
            _logs.Debug(msg);
        }
    }
}