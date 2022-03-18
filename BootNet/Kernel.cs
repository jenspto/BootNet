using Cosmos.HAL.Drivers.PCI.Video;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully.");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" ___            _    _  _       _   ");
            Console.WriteLine(@"| _ ) ___  ___ | |_ | \| | ___ | |_ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"| _ \/ _ \/ _ \|  _|| .  |/ -_)|  _|");
            Console.WriteLine(@"|___/\___/\___/ \__||_|\_|\___| \__|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("If you want to donate to the BootNet project, you can donate at http://ko-fi.com/ptobuon. 50% of my earnings will go to charity for Ukraine.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(c) 2022 Pto Buon. All rights reserved.");
            Console.WriteLine("Documentation: http://pto-buon.github.io/BootNet");
            Console.WriteLine("Source: http://github.com/pto-buon/BootNet");
        }
        String currentPath = @"0:\";
        
        protected override void Run()
        {
            Console.Write(currentPath + ">");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                default: Console.WriteLine("Bad command or file name."); break;
                case "shutdown": Commands.Power.Shutdown(); break;
                case "reboot": Commands.Power.Reboot(); break;
                case "ip": Commands.Network.IP(); break;
                case "dns": Commands.Network.DNS(); break;
                case "dhcp": Commands.Network.DHCP(); break;
                case "setip": Commands.Network.IPv4(); break;
                case "ftp": Commands.Network.FTP(); break;
                case "tpc": Commands.Network.TCP(); break;
                case "udp": Commands.Network.UDP(); break;
            }
        }
    }
}

