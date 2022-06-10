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
        String path;
        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully!");
            Filesystem.InitFilesystem();
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("root@bootnet ");
            path = @"0:\";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(path);
            Console.ForegroundColor = ConsoleColor.White;
            var input = Console.ReadLine().ToLowerInvariant();
            switch (input)
            {
                default: Messages.ErrorMessage(); break;
                case "help": Messages.HelpMessage(); break;
                case "": break;
                case "clear": Commands.Messages.Clear(); break;
                case "net": Network.Connect(); break; 
                case "cat": Filesystem.CatCommand(); break;
                
            }
        }
        
    }
}
