using System;
using System.Globalization;
using System.Threading;
using SIS.MvcFramework;

namespace Panda.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            WebHost.Start(new StartUp());

        }
    }
}
