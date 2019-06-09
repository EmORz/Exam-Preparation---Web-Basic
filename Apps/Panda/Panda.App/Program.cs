using SIS.MvcFramework;
using System;

namespace Panda.App
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost.Start(new StartUp());
        }
    }
}
