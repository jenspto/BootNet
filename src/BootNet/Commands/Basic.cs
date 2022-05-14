using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootNet.Drivers;

namespace BootNet.Commands
{
    public static class Basic
    {
        public static void Echo()
        {
            Console.Write("Text to echo: ");
            var input = Console.ReadLine();
            try
            {
                Console.WriteLine(input);
            }
            catch(Exception e)
            {
                ErrorScreen.ErrorText = e;
                ErrorScreen.Panic();
            }
        }
        public static void Shutdown()
        {
            Cosmos.System.Power.Shutdown();
            Cosmos.System.Power.QemuShutdown();
        }
        public static void Reboot()
        {
            Cosmos.System.Power.Reboot();
            Cosmos.System.Power.QemuReboot();
        }
    }
}
