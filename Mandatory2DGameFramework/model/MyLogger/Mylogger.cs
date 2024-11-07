using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
    
        public class MyLogger : ILogger
        {
            private static MyLogger _instance;
            private TraceSource _traceSource;
            private List<ILogObserver> _observers;
            private ILoggingStrategy _loggingStrategy;

            private MyLogger()
            {
                _traceSource = new TraceSource("MyLoggerSource");
                _observers = new List<ILogObserver>();
            }

            public static MyLogger Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new MyLogger();
                    }
                    return _instance;
                }
            }

            public void SetLoggingStrategy(ILoggingStrategy loggingStrategy)
            {
                _loggingStrategy = loggingStrategy;
            }

            public void AddListener(TraceListener listener)
            {
                _traceSource.Listeners.Add(listener);
            }

            public void RemoveListener(TraceListener listener)
            {
                _traceSource.Listeners.Remove(listener);
            }

            public void Log(string message)
            {
                _traceSource.TraceEvent(TraceEventType.Information, 0, message);
                _traceSource.Flush();
                NotifyObservers(message);
                _loggingStrategy?.Log(message);
            }

            public void Attach(ILogObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(ILogObserver observer)
            {
                _observers.Remove(observer);
            }

            private void NotifyObservers(string message)
            {
                foreach (var observer in _observers)
                {
                    observer.Update(message);
                }
            }
        }
}



