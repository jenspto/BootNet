using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using BootNet.Drivers;
using BootNet.Commands;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        String Path;

        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BootNet booted successfully.");
            Console.ForegroundColor = ConsoleColor.White;
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
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
