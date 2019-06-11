using SIS.MvcFramework;
using System.Globalization;
using System.Threading;

namespace Panda.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todo this is for culture diffreneces -> pont, comma and so on.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            WebHost.Start(new StartUp());
        }
    }
}
