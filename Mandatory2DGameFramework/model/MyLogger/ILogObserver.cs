using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.MyLogger
{
        public interface ILogObserver
        {
            void Update(string message);
        }
}
