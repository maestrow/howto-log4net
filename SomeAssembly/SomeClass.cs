using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace SomeAssembly
{
    public class SomeClass
    {
        private static ILog logger = LogManager.GetLogger(typeof (SomeClass));

        public void DoSomething()
        {
            logger.Debug("DoSomething method called");
        }
    }
}
