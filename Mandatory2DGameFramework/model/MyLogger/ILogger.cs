using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
    public interface ILogger
    {
        void AddListener(TraceListener listener);
        void RemoveListener(TraceListener listener);
        void Log(string message);
    }
}

