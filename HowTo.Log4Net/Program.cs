using System;
using System.Reflection;
using log4net;
using SomeAssembly;

namespace HowTo.Log4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ok");
            Method1();
            Method2();
            new SomeClass().DoSomething();
            Console.ReadKey();
        }

        static void Method1()
        {
            ILog log = LogManager.GetLogger("functional.1");
            log.Debug(MethodBase.GetCurrentMethod().Name);
        }

        static void Method2()
        {
            ILog log = LogManager.GetLogger("functional.2");
            log.Debug(MethodBase.GetCurrentMethod().Name);
        }
    }
}
