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
            try
            {
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            }catch(Exception e)
            {
                Drivers.ErrorScreen.ErrorText = e;
                Drivers.ErrorScreen.Panic();
            }
        }
        public static void EditCommand()
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
        public static void CdCommand()
        {
            Console.Write("Go to: ");
            var cd = Console.ReadLine().ToLowerInvariant();
            if (Directory.Exists(cd))
            {
                Kernel.path = cd;
            }
            else
            {
                Console.WriteLine("Directory not found.");
            }
        }
        public static void DirCommand()
        {
            var directory_list = Directory.GetDirectories(Kernel.path);
            var files_list = Directory.GetFiles(Kernel.path);
            foreach (var file in files_list)
            {
                Console.WriteLine(file);
            }
            foreach (var dir in directory_list)
            {
                Console.WriteLine(dir);
            }
        }
    }
}
