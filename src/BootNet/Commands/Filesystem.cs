using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace BootNet.Commands
{
    public class Filesystem
    {
        static readonly Sys.FileSystem.CosmosVFS fs = new();
        public static void InitFilesystem()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }
        public static void CatCommand()
        {
            Console.Write("Filename: ");
            var fn = Console.ReadLine();
            Console.Write("Text to write: ");
            var text = Console.ReadLine();
            try
            {
                File.WriteAllText(@"0:\"+fn, text);
            }
            catch (Exception e)
            {
                Drivers.ErrorScreen.ErrorText = e;
                Drivers.ErrorScreen.Panic();
            }
        }
    }
}
