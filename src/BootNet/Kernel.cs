using BootNet.Drivers;
using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using BootNet.Commands;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully!");
            Filesystem.InitFilesystem();
        }

        protected override void Run()
        {
            var input = Console.ReadLine().ToLowerInvariant();
            switch (input)
            {
                default: Messages.ErrorMessage(); break;
                case "help": Messages.HelpMessage(); break;
                case "cat": Filesystem.CatCommand(); break;
                
            }
        }
        
    }
}
