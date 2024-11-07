using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
        public class LoggerConfig
        {
            public static void ConfigureLogger(ILogger logger)
            {
                var listeners = new List<TraceListener>
            {
                new ConsoleTraceListener(),
                // Tilføj flere lyttere her, hvis nødvendigt
            };

                listeners.ForEach(listener => logger.AddListener(listener));

                // Brug factory-mønsteret til at oprette en logningsstrategi
                var loggingStrategy = LoggingStrategyFactory.CreateLoggingStrategy("console");
                MyLogger.Instance.SetLoggingStrategy(loggingStrategy);
            }
        }
}
