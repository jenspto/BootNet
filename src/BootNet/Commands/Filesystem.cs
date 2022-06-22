using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
namespace BootNet.Commands
{
    public class Filesystem
    {
        public static Sys.FileSystem.CosmosVFS fs = new();
        public static void Start()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }
    }
}
