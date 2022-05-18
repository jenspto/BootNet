using BootNet.Commands;
using BootNet.Drivers;
using Cosmos.HAL;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using Sys = Cosmos.System;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        String Path;
        public readonly Sys.FileSystem.CosmosVFS fs = new();

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("SUCCESS: ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Boot");
            Console.WriteLine("");

            try
            {
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("SUCCESS: ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Filesystem initialization.");
            } catch (Exception)

            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("FAILED: ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Filesystem initialization.");
            }
            Console.WriteLine();
            try
            {
                BootNet.Commands.Network.DHCP();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("SUCCESS: ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Network connection. Your ip is "+ NetworkConfig.CurrentConfig.Value.IPAddress.ToString());
            } catch (Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("FAILED: ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Network connection.");
            }
            Console.WriteLine();
        }

        protected override void Run()
        { 

            try 
            {
                Path=@"0:\";
                Console.Write(Path + ">");
                var input = Console.ReadLine();
                switch (input)
                {
                    default: { Console.WriteLine("Bad command or file name."); } break;
                    case "": { Console.WriteLine(); } break;
                    case "echo": Basic.Echo(); break;
                    case "shutdown": Basic.Shutdown(); break;
                    case "reboot": Basic.Reboot(); break;
                    case "network setup": Network.DHCP(); break;
                    case "clear": Basic.Clear(); break;
                    case "info": Basic.Info(); break;
                    

                }
            }
            catch(Exception e)
            {
                ErrorScreen.ErrorText = e;
                ErrorScreen.Panic();
            }
        }
    }
}
