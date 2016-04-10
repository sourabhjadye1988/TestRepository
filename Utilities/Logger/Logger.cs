using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utilities
{
    //Log levels
    public enum Level
    {
        INFO = 0,
        DEBUG = 1,
        ERROR = 2,
        FATAL = 3,
        WARN = 4
    }

    public class Logger
    {
        //Init
        private static readonly ILog logger =
            LogManager.GetLogger(typeof(Logger));

        //Constructor
        static Logger()
        {
            GlobalContext.Properties["formattedDate"] = DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year;
            XmlConfigurator.Configure();
            //DOMConfigurator.Configure();            
        }
        
        //Loggin Function
        public static void Log(string message, Level level = Level.ERROR)
        {
            switch (level)
            {
                case Level.INFO:
                    logger.Info(message);
                    break;
                case Level.DEBUG:
                    logger.Debug(message);
                    break;
                case Level.ERROR:
                    logger.Error(message);
                    break;
                case Level.FATAL:
                    logger.Fatal(message);
                    break;
                case Level.WARN:
                    logger.Warn(message);
                    break;
                default:
                    
                    break;
            }
        }

        
    }
}
