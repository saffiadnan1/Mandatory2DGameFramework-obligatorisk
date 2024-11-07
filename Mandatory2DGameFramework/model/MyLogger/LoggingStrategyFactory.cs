using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
    
        public static class LoggingStrategyFactory
        {
            public static ILoggingStrategy CreateLoggingStrategy(string type, string parameter = null)
            {
                switch (type.ToLower())
                {
                    case "console":
                        return new ConsoleLoggingStrategy();
                    case "file":
                        return new FileLoggingStrategy(parameter);
                    default:
                        throw new ArgumentException("Invalid logging strategy type");
                }
            }
        }
}
