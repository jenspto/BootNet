using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
