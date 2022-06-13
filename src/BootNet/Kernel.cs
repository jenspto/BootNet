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
        public static String path { get; set; }
        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully!");
            path = @"0:\";
            Filesystem.InitFilesystem();
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("root@bootnet ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(path + " ");
            Console.ForegroundColor = ConsoleColor.White;
            var input = Console.ReadLine().ToLowerInvariant();
            switch (input)
            {
                    //Messages
                default: Messages.ErrorMessage(); break;
                case "help": Messages.HelpMessage(); break;
                case "": break;
                case "clear": Commands.Messages.Clear(); break;
                    //Filesystem
                case "cd": Filesystem.CdCommand(); break;
                case "fs --new --folder": Filesystem.NewFolderCommand(); break;
                case "fs --new --file": Filesystem.NewFileCommand(); break;
                case "dir": Filesystem.DirCommand(); break;
                case "fs --edit": Filesystem.EditCommand(); break;
                    //Network
                case "net --connect": Network.Connect(); break;                 
            }
        }
        
    }
}
