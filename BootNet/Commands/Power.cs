using Sys = Cosmos.System;

namespace BootNet.Commands
{
    internal class Power
    {
        public static void Shutdown()
        {
            Sys.Power.Shutdown();
        }
        public static void Reboot()
        {
            Sys.Power.Reboot();
        }
    }
}
