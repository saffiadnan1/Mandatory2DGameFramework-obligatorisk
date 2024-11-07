using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
        public class FileLoggingStrategy : ILoggingStrategy
        {
            private string _filePath;

            public FileLoggingStrategy(string filePath)
            {
                _filePath = filePath;
            }

            public void Log(string message)
            {
                File.AppendAllText(_filePath, message + Environment.NewLine);
            }
        }
}
